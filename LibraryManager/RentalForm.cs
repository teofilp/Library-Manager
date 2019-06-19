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
    public partial class RentalForm : Form
    {
        public AdminPanelForm adminPanel;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=library;";
        MySqlConnection databaseConnection;
        string id;
        List<string> returnedBooksByNow = new List<string>();

        public RentalForm()
        {
            databaseConnection = new MySqlConnection(connectionString);
            InitializeComponent();
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {

        }
        public void getRentalInfo(string id)
        {
            string query = $"SELECT * FROM rentals WHERE id={id};";

            this.id = id;

            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            MySqlDataReader reader;

            try
            {
                if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open)) 
                    databaseConnection.Open();

                reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                        reader.GetString(5), reader.GetString(6), reader.GetDateTime(7).ToString()};
                        
                        displayInfo(row);

                        break;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine("exception is: " + ex);
            }
            finally
            {
                if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
                    databaseConnection.Close();
            }

        }

        private void displayInfo(string[] row)
        {
            borrowerNameTb.Text = row[0];
            borrowerEmailTb.Text = row[1];
            borrowerPhoneTb.Text = row[2];
            borrowerAddressTb.Text = row[3];
            borrowedBooksTb.Text = row[4];
            returnedBooksTb.Text = row[5];
            saveReturnedBooksForLaterValidation(); // we don't want to erase a book once it's been returned
            date.Value = Convert.ToDateTime(row[6]);   
        }

        private void saveReturnedBooksForLaterValidation()
        {
            returnedBooksByNow = returnedBooksTb.Text.Split(new[] { ',', ' ' },
                                StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private void updateRentalBtn_Click(object sender, EventArgs e)
        {
            string result = null;
            if (!validInputs(out result))
            {
                MessageBox.Show(result);
                return;
            }

            string query = "UPDATE rentals SET fullname=@fullname, email=@email, phone_number=@phone_number, address=@address, borrowed_books=@borrowed_books," +
                " returned_books=@returned_books, date=@date WHERE id=@id";

            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            command.Parameters.AddWithValue("@fullname", borrowerNameTb.Text);
            command.Parameters.AddWithValue("@email", borrowerEmailTb.Text);
            command.Parameters.AddWithValue("@phone_number", borrowerPhoneTb.Text);
            command.Parameters.AddWithValue("@address", borrowerAddressTb.Text);
            command.Parameters.AddWithValue("@borrowed_books", borrowedBooksTb.Text);
            command.Parameters.AddWithValue("@returned_books", returnedBooksTb.Text);
            command.Parameters.AddWithValue("@date", date.Value);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                    databaseConnection.Open();
                int affectedRows = command.ExecuteNonQuery();
                if(affectedRows == 1)
                {
                    MessageBox.Show("Info updated successfully");
                    updateBooksAvailableCopies();
                    adminPanel.getRentals();
                    this.Close();
                } else
                {
                    MessageBox.Show("Something went wrong, try again later! " + affectedRows + "id: " + id);
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

        private void updateBooksAvailableCopies()
        {
            List<string> newReturnedBooks = returnedBooksTb.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList().Where(bookId => !returnedBooksByNow.Contains(bookId)).ToList();
            
            newReturnedBooks.ForEach(bookId =>
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
                            int available_copies = reader.GetInt32(7);
                            if(!reader.IsClosed)
                                reader.Close(); // close the reader to make a new connection available for the update command

                            available_copies++;


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

                            } catch (Exception ex)
                            {
                                MessageBox.Show($"Something went wrong when trying to update the book(id={bookId}; " + ex.ToString());
                            }
                            break; // break to avoid error when attempting to reader.Read() at the next iteration with the reader closed
                            // we know there is only one record in the db with our id, so the while would have executed once anyways but the condition is checked twice ;)
                         
                        }
                    }
                    
                } catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong when trying to reach the server for book(id={bookId}) information: " + ex.ToString());
                } finally
                {
                    if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
                        databaseConnection.Close();
                    
                }
            });
        }

        private bool validInputs(out string result)
        {
            string[] borrowedBooks = borrowedBooksTb.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string[] returnedBooks = returnedBooksTb.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            bool booksOk = true;
            bool noDuplicates = true;
            bool notAlreadyReturned = true;
            result = "";

            returnedBooks.ToList().ForEach(book =>
            {
                if (!borrowedBooks.ToList().Contains(book))
                    booksOk = false;
            });

            if (!booksOk)
            {
                result += "Some of the returned books have not been borrowed, check again the inputs!\n";
            }

            if (returnedBooks.ToList().Count != returnedBooks.ToList().Distinct().Count())
            {
                result += "Some of the books appear for multiple times, which is not valid!";
                noDuplicates = false;
            }
            
            returnedBooksByNow.ForEach(book => {
                if (!returnedBooks.ToList().Contains(book))
                {
                    notAlreadyReturned = false;
 
                }
            });

            if(!notAlreadyReturned)
                result += "You cannot delete a book that has already been returned";

            //result = "Ok!";

            return booksOk && noDuplicates && notAlreadyReturned;
        }
    }
}
