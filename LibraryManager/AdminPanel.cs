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
using System.IO;

namespace LibraryManager
{
    public partial class AdminPanelForm : Form
    {
        List<string[]> books = new List<string[]>();
        List<string[]> categories = new List<string[]>(); // store categories to send to book form and display in combobox
        Dictionary<string, string> notifyDetails = new Dictionary<string, string>();

        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=library;";
        MySqlConnection databaseConnection;

        public AdminPanelForm()
        {
            InitializeComponent();
            databaseConnection = new MySqlConnection(connectionString);
            getBooks();
            getCategories();
            getRentals();
        }

        public void getRentals()
        {
            rentalsGridView.Rows.Clear();
            lateReturnsGrid.Rows.Clear();

            string query = "SELECT * from rentals";

            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            command.CommandTimeout = 60;
            MySqlDataReader reader = null;
            try
            {
                if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                    databaseConnection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] rentalRow = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                        reader.GetString(5), reader.GetString(6), reader.GetDateTime(7).ToShortDateString()};

                        rentalsGridView.Rows.Add(rentalRow);
                        
                        // check to see whether there are books to be returned and have already passed 14 days from borrowing
                        int daysFromRental = getDaysFromNow(reader.GetDateTime(7));
                        Console.WriteLine(daysFromRental);
                        List<String> toReturn = booksToReturn(reader.GetString(5), reader.GetString(6));

                        if (toReturn.Count > 0)
                        {
                            if (daysFromRental > 14)
                            {
                                int lateDays = daysFromRental - 14;
                                string booksToReturnString = string.Join(",", toReturn);

                                notifyDetails[reader.GetString(0)] = "Phone Number: " + reader.GetString(3) + "\nEmail: " + reader.GetString(2);

                                string[] lateReturnsRow = { reader.GetString(0), reader.GetString(1), booksToReturnString, lateDays.ToString() };
                                lateReturnsGrid.Rows.Add(lateReturnsRow); 
                                // afisam cartile care mai trebuiie returnate daca au trecut mai mult de 14 zile

                            }
                        }
                    }
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
                if(reader!=null)
                    reader.Close();
            }
        }

        private List<string> booksToReturn(string borrowed_books, string returned_books)
        {
            string[] borrowedBooks = borrowed_books.Split(new[] { ", " }, StringSplitOptions.None);
            string[] returnedBooks = returned_books.Split(new[] {", "}, StringSplitOptions.None);

            List<string> toReturn = new List<string>();

            borrowedBooks.ToList().ForEach(borrowed =>
            {
                if (!returnedBooks.Contains(borrowed))
                    toReturn.Add(borrowed);
            });
            /* same as
            for (int i = 0; i < borrowedBooks.Length; i++)
                if (!returnedBooks.Contains(borrowedBooks[i]))
                    toReturn.Add(borrowedBooks[i]);
                    */

            return toReturn;
        }

        private int getDaysFromNow(DateTime dateTime) // check to see whether the book/s should have been returned by now
        {
            return DateTime.Now.Subtract(dateTime).Days;
        }

        private void getCategories()
        {
            categoriesGridView.Rows.Clear();
            categories.Clear();
            string query = "SELECT * from categories";

            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            command.CommandTimeout = 60;

            try
            {
                if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                    databaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1) };
                        categories.Add(row);
                        categoriesGridView.Rows.Add(row);
                    }
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

        public async void getBooks()
        {
            booksGridView.Rows.Clear();

            string query = "SELECT * from books";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                if(!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                    databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                        reader.GetString(5), reader.GetString(6), reader.GetString(7)};
                        
                        booksGridView.Rows.Add(row);
                    }
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
        private void newBook_Click_1(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(categories);
            bookForm.Show();
            bookForm.Text = "Add new book";
            bookForm.bookPanelPurpose = "new";
            bookForm.adminPanel = this;
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8) // handle edit button
            {
                BookForm bookForm = new BookForm(categories);
                bookForm.Show();
                bookForm.Text = "Edit book";
                bookForm.adminPanel = this;
                bookForm.editBook(booksGridView.CurrentRow.Cells[0].Value.ToString());
            }
            else if (e.ColumnIndex == 9) // handle delete button
                deleteBook(booksGridView.CurrentRow.Cells[0].Value.ToString());
        }

        private void deleteBook(string bookID)
        {
            // delete book
            var confirmResult = MessageBox.Show("Are you sure to delete this book??", "Confirm delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                string deletionQuery = $"DELETE FROM library.books WHERE id={bookID}";

                MySqlCommand command = new MySqlCommand(deletionQuery, databaseConnection);
                try
                {
                    databaseConnection.Open();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Book deleted successful");

                    getBooks(); // reload remaining books in gridView
                } catch(Exception e)
                {
                    // handle exception
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
                        databaseConnection.Close();
                }


            }
        }

        private void reloadBooks(object sender, EventArgs e)
        {
            getBooks();
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            string category = categoryTb.Text;
            if(category.Length > 0)
            {
                string query = "INSERT INTO categories (name) VALUES(@name);";

                MySqlCommand command = new MySqlCommand(query, databaseConnection);

                command.Parameters.Add("@name", MySqlDbType.VarChar, 255);
                command.Parameters["@name"].Value = category;
                try
                {
                    if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                        databaseConnection.Open();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Category added successfully");
                        categoryTb.Text = "";
                        getCategories();
                    }
                } catch (Exception ex)
                {
                   MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
                        databaseConnection.Close();
                }
                
            }
        }

        private void categoriesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
                if(MessageBox.Show("Are you sure to delete this category??", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    deleteCategory(categoriesGridView.CurrentRow.Cells[0].Value.ToString());
        }

        private void deleteCategory(string categoryId)
        {
            string query = $"DELETE FROM categories WHERE id={categoryId}";

            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            try
            {
                if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                    databaseConnection.Open();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Category deleted successfully");
                getCategories();
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

        private void rentalsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 9)
            {
                // transform row cells into lists containing individual ids
                updateBooksAvailableCopies(rentalsGridView.CurrentRow.Cells[5].Value.ToString().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                    rentalsGridView.CurrentRow.Cells[6].Value.ToString().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList());

                returnAllBooks(rentalsGridView.CurrentRow.Cells[0].Value.ToString(), rentalsGridView.CurrentRow.Cells[5].Value.ToString());
            } else if(e.ColumnIndex == 8)
            {
                RentalForm rentalForm = new RentalForm();
                rentalForm.Show();
                rentalForm.adminPanel = this;
                rentalForm.getRentalInfo(rentalsGridView.CurrentRow.Cells[0].Value.ToString());

            }
        }

        private void returnAllBooks(string id, string returnedBooks)
        {
            string query = $"UPDATE rentals SET returned_books=@returned_books WHERE id=@id;";

            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@returned_books", returnedBooks);
            try
            {
                if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                    databaseConnection.Open();

                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Books returned successful");
                    getRentals();
                    getBooks();
                    
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.ToString());
            } finally
            {
                if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
                    databaseConnection.Close();
            }
        }

        private void lateReturnsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show(notifyDetails[lateReturnsGrid.CurrentRow.Cells[0].Value.ToString()]);
            }
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void updateBooksAvailableCopies(List<string> borrowedBooks, List<string> alreadyReturned)
        {
            List<string> newReturnedBools = borrowedBooks.Where(bookId => !alreadyReturned.Contains(bookId)).ToList();
            newReturnedBools.ForEach(bookId =>
            {
                // get available copies for each book
                string selectQuery = $"SELECT * FROM books WHERE id={bookId};";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, databaseConnection);
                selectCommand.CommandTimeout = 60;
                MySqlDataReader reader = null;
                try
                {
                    if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                        databaseConnection.Open();

                    reader = selectCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int available_copies = reader.GetInt32(7) + 1;

                            if (!reader.IsClosed)
                                reader.Close();

                            string updateQuery = $"UPDATE books SET available_copies=@available_copies WHERE id=@id;";
                            MySqlCommand updateCommand = new MySqlCommand(updateQuery, databaseConnection);

                            updateCommand.Parameters.AddWithValue("@available_copies", available_copies);
                            updateCommand.Parameters.AddWithValue("@id", bookId);

                            try
                            {
                                if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                                    databaseConnection.Open();

                                if (updateCommand.ExecuteNonQuery() != 1)
                                    throw new Exception();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Something went wrong when trying to update the book(id={bookId}; " + ex.ToString());
                            }
                            break;

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong when trying to reach the server for book(id={bookId}) information: " + ex.ToString());
                }
                finally
                {
                    if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
                        databaseConnection.Close();

                }
            });
        }

        private void reloadRentals(object sender, EventArgs e)
        {
            // reload all rentals
            getRentals();
        }
    }
   
}
