using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;


namespace LibraryManager
{
    public partial class booksCollection : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=library;";
        MySqlConnection databaseConnection;

        List<Book> books = new List<Book>();
        ObservableCollection<Book> cartBooks = new ObservableCollection<Book>();  // we use observable collection to keep track of changes in the array

        List<BookControlDb> bookUIItems = new List<BookControlDb>(); // we need to keep the references for every ui item so that we can remove them from the panel when we search for specific keys
        
        List<BookControlSm> checkoutItems = new List<BookControlSm>(); // same as above
        private bool checkoutPanelActive = false;

        public booksCollection()
        {
            InitializeComponent();
            cartBooks.CollectionChanged += cartBooks_CollectionChanged;
            databaseConnection = new MySqlConnection(connectionString);
            getBooks();
            createTest();
        }

        public async void getBooks()
        {
            books.Clear();
            string query = "SELECT * from books";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                    databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        books.Add(new Book(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetString(4), reader.GetInt32(6),Int32.Parse(reader.GetString(7)), reader.GetValue(8).GetType() == typeof(System.DBNull) ? new byte[0] : (byte[])reader.GetValue(8)));  
                    }
                    populateUI("");
                }
                else
                {
                    MessageBox.Show("no more records in db");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("exception is: " + ex);
            }
            finally
            {
                if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
                    databaseConnection.Close();
            }

        }

        private void booksCollection_Load(object sender, EventArgs e)
        {
            
        }

        private void populateUI(string searchKey)
        {

            bookUIItems.ForEach(bookControl => Controls.Remove(bookControl));
            bookUIItems.Clear();
            int top = 50;
            int left = 10;
            books.Where(book => (book.title.ToLower().Contains(searchKey) || book.author.ToLower().Contains(searchKey) || book.category.ToLower().Contains(searchKey))).ToList().ForEach(book =>
            {

                BookControlDb bookControl = new BookControlDb(book, cartBooks);
                bookControl.Location = new Point(left, top);

                if (left > 400)
                {
                    top += 275; // position books in the gallery, 2 on each row
                    left = 10;
                }
                else
                {
                    left += 445;
                }
                bookUIItems.Add(bookControl);
                Controls.Add(bookControl);
            });

        }

        private void populateCheckoutUI()
        {
            int top = 250;
            int left = 10;

            checkoutItems.ForEach(item => checkoutPnl.Controls.Remove(item));

            cartBooks.ToList().ForEach(book =>
            {
                BookControlSm checkoutItem = new BookControlSm(book, cartBooks);
                checkoutItem.Location = new Point(left, top);

                if(left > 400)
                {
                    top += 175;
                    left = 10;
                } else
                {
                    left += 299;
                }
                checkoutItems.Add(checkoutItem);
                checkoutPnl.Controls.Add(checkoutItem);
            });
        }

        private void createTest()
        {
            
        }
        
        void cartBooks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //list changed - an item was added.
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add ||
               e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove) // check for new item or deleted item
            {
                if (checkoutPanelActive)
                {
                    populateCheckoutUI();
                }
                cartItemsNumber.Text = cartBooks.Count.ToString();
            }
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            populateUI(searchTb.Text);
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            if(cartBooks.ToList().Count == 0)
            {
                MessageBox.Show("Your cart is empty, you need to choose at least one book before you can checkout");
                return;
            }
            checkoutPnl.Visible = true;
            checkoutPnl.BringToFront();
            bookUIItems.ForEach(bookControl => bookControl.Visible = false); // hide gallery elements so that the scroll won't interfere with the checkout panel
            populateCheckoutUI();
            checkoutPanelActive = true;
            
        }

        private void checkoutBackBtn_Click(object sender, EventArgs e)
        {
            bookUIItems.ForEach(bookControl => bookControl.Visible = true); // show gallery elements when checkout panel is not visible
            checkoutPnl.Visible = false;
            checkoutPnl.SendToBack();
            checkoutPanelActive = false;

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string borrowerName = renterFirstNameTb.Text + " " + renterLastNameTb.Text;
            string borrowerEmail = renterEmailTb.Text;
            string borrowerPhoneNumber = renterPhone.Text;
            string borrowerAddress = addressTb.Text;

            string booksToRent = "";
            cartBooks.ToList().ForEach(bookElement => booksToRent += bookElement.id + ", ");
            booksToRent = booksToRent.TrimEnd(new char[2] {',', ' ' });

            string query = "INSERT INTO library.rentals(fullname, email, phone_number, address, borrowed_books, returned_books, date) VALUES(@fullname, @email, " +
                    "@phone_number, @address, @borrowed_books, @returned_books, @date);";

            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            command.Parameters.Add("@fullname", MySqlDbType.VarChar, 255);
            command.Parameters.Add("@email", MySqlDbType.VarChar, 255);
            command.Parameters.Add("@phone_number", MySqlDbType.VarChar, 255);
            command.Parameters.Add("@address", MySqlDbType.VarChar, 2550);
            command.Parameters.Add("@borrowed_books", MySqlDbType.VarChar, 255);
            command.Parameters.Add("@returned_books", MySqlDbType.VarChar, 255);
            command.Parameters.Add("@date", MySqlDbType.Date, 100);
            
            command.Parameters["@fullname"].Value = borrowerName;
            command.Parameters["@email"].Value = borrowerEmail;
            command.Parameters["@phone_number"].Value = borrowerPhoneNumber;
            command.Parameters["@address"].Value = borrowerAddress;
            command.Parameters["@borrowed_books"].Value = booksToRent;
            command.Parameters["@returned_books"].Value = "";
            command.Parameters["@date"].Value = DateTime.Now;

            try
            {
                if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                    databaseConnection.Open();


                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Books Rented Successfully");
                    updateBookDetails();
                    clearUI();
                }
                else
                {
                    MessageBox.Show("Something went wrong, try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
                    databaseConnection.Close();
            }

        }

        private void clearUI()
        {
            renterFirstNameTb.Text = "";
            renterLastNameTb.Text = "";
            renterEmailTb.Text = "";
            renterPhone.Text = "";
            addressTb.Text = "";

            checkoutPanelActive = false;
            checkoutPnl.Visible = false;
            bookUIItems.ForEach(bookControl => bookControl.Visible = true); // show gallery elements when checkout panel is not visible

            getBooks();
            cartBooks.Clear();
            cartItemsNumber.Text = cartBooks.Count.ToString();

           
        }

        private void updateBookDetails()
        {
            cartBooks.ToList().ForEach(book =>
            {

                string query = $"UPDATE books SET available_copies={book.available - 1} WHERE id={book.id}";

                MySqlCommand command = new MySqlCommand(query, databaseConnection);

                try
                {
                    if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                        databaseConnection.Open();

                    command.ExecuteNonQuery();

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            });
        }
    }
    
}
