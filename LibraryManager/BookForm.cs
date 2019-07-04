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
    public partial class BookForm : Form
    {

        public string bookPanelPurpose;
        public string bookIdForEditMode;
        private int available_copies;
        private int copies;

        public AdminPanelForm adminPanel;

        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=library;";
        MySqlConnection databaseConnection;

        public BookForm(List<string[]> CategoriesList)
        {
            InitializeComponent();
            databaseConnection = new MySqlConnection(connectionString);

            categories.Items.Clear();
            CategoriesList.ForEach(category => categories.Items.Add(category[1]));

        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void bookPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void editBook(string bookID)
        {
            bookPanel.Visible = true;
            bookPanelPurpose = "edit";
            bookPanel.BringToFront();
            

            bookIdForEditMode = bookID;

            string selectQuery = "SELECT * from library.books WHERE id=" + bookID + ";";
            MySqlCommand command = new MySqlCommand(selectQuery, databaseConnection);

            MySqlDataReader reader;

            try
            {
                databaseConnection.Open(); 

                reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetString(4), reader.GetString(5), reader.GetString(6)};

                        available_copies = Int32.Parse(reader.GetString(7));
                        copies = Int32.Parse(reader.GetString(6));

                        displayInfo(row, reader["cover"].ToString() == "" ? null : (byte[])reader["cover"]);

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

        private void displayInfo(string[] row, byte[] img)
        {
            bookTitleTb.Text = row[1];
            bookAuthorTb.Text = row[2];
            categories.SelectedItem = row[3];
            bookDescriptionTb.Text = row[4];
            bookPagesTb.Text = row[5];
            bookCopiesTb.Text = row[6];
            
            if (img == null)
                return;
            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void chooseImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void saveBookBtn_Click(object sender, EventArgs e)
        {
            byte[] img;
            if (pictureBox1.Image == null) // handle no cover selected
                img = null;
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                img = ms.ToArray();
            }

            string query;
            if (bookPanelPurpose == "new")
            {
                query = "INSERT INTO library.books(name, author, category, description, pages, copies, available_copies, cover) VALUES(@title, @author, " +
                    "@category, @description, @pages, @copies, @available_copies, @cover);";

                MySqlCommand command = new MySqlCommand(query, databaseConnection);

                command.Parameters.Add("@title", MySqlDbType.VarChar, 255);
                command.Parameters.Add("@author", MySqlDbType.VarChar, 255);
                command.Parameters.Add("@category", MySqlDbType.VarChar, 255);
                command.Parameters.Add("@description", MySqlDbType.VarChar, 2550);
                command.Parameters.Add("@pages", MySqlDbType.Int32, 255);
                command.Parameters.Add("@available_copies", MySqlDbType.Int32, 100);
                command.Parameters.Add("@copies", MySqlDbType.Int32);
                command.Parameters.Add("@cover", MySqlDbType.Blob);


                command.Parameters["@title"].Value = bookTitleTb.Text.Length > 0 ? bookTitleTb.Text : "N/A";
                command.Parameters["@author"].Value = bookAuthorTb.Text.Length > 0 ? bookAuthorTb.Text : "N/A";
                command.Parameters["@category"].Value = categories.SelectedItem;
                command.Parameters["@description"].Value = bookDescriptionTb.Text.Length > 0 ? bookDescriptionTb.Text : "N/A";
                command.Parameters["@pages"].Value = bookPagesTb.Text.Length > 0 ? Int32.Parse(bookPagesTb.Text) : 0;
                command.Parameters["@available_copies"].Value = bookCopiesTb.Text.Length > 0 ? Int32.Parse(bookCopiesTb.Text) : 0;
                command.Parameters["@copies"].Value = bookCopiesTb.Text.Length > 0 ? Int32.Parse(bookCopiesTb.Text) : 0;
                command.Parameters["@cover"].Value = img;

                try
                {
                    databaseConnection.Open();


                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Book Added Successfully");
                        adminPanel.getBooks();
                        clearTextboxes();

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
            else
            {

                int newCopies = Int32.Parse(bookCopiesTb.Text);

                if(newCopies >= copies - available_copies) // handle new available copies. New Total > Old Total - availalbe_copies = Total Rented
                {
                    available_copies += newCopies - copies;
                    copies = newCopies;
                } else
                {
                    MessageBox.Show("New Total Copies has to be greater or equal to Old Total - available_copies");
                    return;
                }

                query = $"UPDATE library.books SET name=@name, author=@author, category=@category," +
                    $"pages=@pages, description=@description, copies=@copies, cover=@cover, available_copies=@a_copies" +
                    $" WHERE id=@id";

                MySqlCommand command = new MySqlCommand(query, databaseConnection);

                command.Parameters.AddWithValue("@name", bookTitleTb.Text);
                command.Parameters.AddWithValue("@author", bookAuthorTb.Text);
                command.Parameters.AddWithValue("@category", categories.SelectedItem);
                command.Parameters.AddWithValue("@description", bookDescriptionTb.Text);
                command.Parameters.AddWithValue("@pages", bookPagesTb.Text);
                command.Parameters.AddWithValue("@copies", copies);
                command.Parameters.AddWithValue("@a_copies", available_copies);
                command.Parameters.AddWithValue("@cover", img);
                command.Parameters.AddWithValue("@id", bookIdForEditMode);
                // TODO: validate inputs; update available_copies when updating copies
                try
                {
                    if (!(databaseConnection != null && databaseConnection.State == ConnectionState.Open))
                        databaseConnection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Book Updated Successfully");
                        adminPanel.getBooks();
                        clearTextboxes();

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
            this.Close();

        }

        private void clearTextboxes()
        {
            bookTitleTb.Text = "";
            bookAuthorTb.Text = "";
            bookCopiesTb.Text = "";
            bookDescriptionTb.Text = "";
            bookPagesTb.Text = "";
            pictureBox1.Image = null;
        }
        
    }
}
