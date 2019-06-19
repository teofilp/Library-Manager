using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;

namespace LibraryManager
{
    public partial class BookControlDb : UserControl
    {
       
        private bool added = false;
        private Book book;
        private ObservableCollection<Book> cartBooks;

        public BookControlDb(Book book, ObservableCollection<Book> cartBooks)
        {
            InitializeComponent();
            this.cartBooks = cartBooks;
            this.book = book;
            this.bookTitle.Text = book.title;
            this.bookCategory.Text = book.category;
            this.bookAuthor.Text = book.author;
            this.bookDescription.Text = book.description;
            this.bookAvailable.Text = book.available > 0 ? "Yes" : "No";

            // handle search when this book is in the cart and we redraw the ui
            cartBooks.ToList().ForEach(bookItem => {
                if (bookItem == this.book)
                {
                    this.added = true;
                    this.addBook.Text = "Remove";
                }
               });
            
            if (book.available <= 0)
            {
                addBook.Click -= addBook_Click;
            }
            try
            {
                var ms = new MemoryStream(book.cover);
                bookCover.Image = Image.FromStream(ms);
                bookCover.SizeMode = PictureBoxSizeMode.StretchImage;
            } catch( Exception ex)
            {
                // handle no image
            }
           
        }

        private void bookAuthorLb_Click(object sender, EventArgs e)
        {

        }

        private void BookControlDb_Load(object sender, EventArgs e)
        {

        }

        private void addBook_Click(object sender, EventArgs e)
        {
            if (this.added)
            {
                this.addBook.Text = "Add";
                this.added = false;
                cartBooks.Remove(this.book);
            } else
            {
                this.addBook.Text = "Remove";
                this.cartBooks.Add(this.book);
                this.added = true;
            }

        }
    }
}
