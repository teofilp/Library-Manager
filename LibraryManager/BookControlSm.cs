using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.IO;

namespace LibraryManager
{
    public partial class BookControlSm : UserControl
    {
        private Book book;
        private ObservableCollection<Book> cartBooks;

        public BookControlSm(Book book, ObservableCollection<Book> cartBooks)
        {
            InitializeComponent();
            this.cartBooks = cartBooks;
            this.book = book;
            this.bookTitle.Text = book.title;
            this.bookCategory.Text = book.category;
            this.bookAuthor.Text = book.author;
           
            try
            {
                var ms = new MemoryStream(book.cover);
                bookCover.Image = Image.FromStream(ms);
                bookCover.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                // handle no image
            }

        }

        private void BookControlSm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
