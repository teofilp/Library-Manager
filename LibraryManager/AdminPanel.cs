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
        List<string[]> categories = new List<string[]>();

        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=library;";
        MySqlConnection databaseConnection;

        public AdminPanelForm()
        {
            InitializeComponent();
            databaseConnection = new MySqlConnection(connectionString);
            getBooks();
            getCategories();
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
                        reader.GetString(5), reader.GetString(6)};
                        
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

        private void button1_Click(object sender, EventArgs e)
        {
            getBooks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete all books??", "Confirm delete", MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes)
            {
                // delete all books
            }
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
    }
   
}
