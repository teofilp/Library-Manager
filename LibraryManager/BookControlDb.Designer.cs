namespace LibraryManager
{
    partial class BookControlDb
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookCover = new System.Windows.Forms.PictureBox();
            this.bookTitleLb = new System.Windows.Forms.Label();
            this.bookAuthorLb = new System.Windows.Forms.Label();
            this.bookAvailableLb = new System.Windows.Forms.Label();
            this.bookDescriptionLb = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.Label();
            this.bookAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookAvailable = new System.Windows.Forms.Label();
            this.addBook = new System.Windows.Forms.Button();
            this.bookCategoryLb = new System.Windows.Forms.Label();
            this.bookCategory = new System.Windows.Forms.Label();
            this.bookDescription = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // bookCover
            // 
            this.bookCover.Location = new System.Drawing.Point(41, 22);
            this.bookCover.Name = "bookCover";
            this.bookCover.Size = new System.Drawing.Size(159, 213);
            this.bookCover.TabIndex = 0;
            this.bookCover.TabStop = false;
            // 
            // bookTitleLb
            // 
            this.bookTitleLb.AutoSize = true;
            this.bookTitleLb.Location = new System.Drawing.Point(256, 22);
            this.bookTitleLb.Name = "bookTitleLb";
            this.bookTitleLb.Size = new System.Drawing.Size(33, 13);
            this.bookTitleLb.TabIndex = 1;
            this.bookTitleLb.Text = "Title: ";
            // 
            // bookAuthorLb
            // 
            this.bookAuthorLb.AutoSize = true;
            this.bookAuthorLb.Location = new System.Drawing.Point(245, 50);
            this.bookAuthorLb.Name = "bookAuthorLb";
            this.bookAuthorLb.Size = new System.Drawing.Size(44, 13);
            this.bookAuthorLb.TabIndex = 2;
            this.bookAuthorLb.Text = "Author: ";
            this.bookAuthorLb.Click += new System.EventHandler(this.bookAuthorLb_Click);
            // 
            // bookAvailableLb
            // 
            this.bookAvailableLb.AutoSize = true;
            this.bookAvailableLb.Location = new System.Drawing.Point(233, 168);
            this.bookAvailableLb.Name = "bookAvailableLb";
            this.bookAvailableLb.Size = new System.Drawing.Size(56, 13);
            this.bookAvailableLb.TabIndex = 3;
            this.bookAvailableLb.Text = "Available: ";
            // 
            // bookDescriptionLb
            // 
            this.bookDescriptionLb.AutoSize = true;
            this.bookDescriptionLb.Location = new System.Drawing.Point(223, 109);
            this.bookDescriptionLb.Name = "bookDescriptionLb";
            this.bookDescriptionLb.Size = new System.Drawing.Size(66, 13);
            this.bookDescriptionLb.TabIndex = 4;
            this.bookDescriptionLb.Text = "Description: ";
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Location = new System.Drawing.Point(312, 22);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(27, 13);
            this.bookTitle.TabIndex = 5;
            this.bookTitle.Text = "N/A";
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSize = true;
            this.bookAuthor.Location = new System.Drawing.Point(312, 50);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(27, 13);
            this.bookAuthor.TabIndex = 6;
            this.bookAuthor.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author: ";
            // 
            // bookAvailable
            // 
            this.bookAvailable.AutoSize = true;
            this.bookAvailable.Location = new System.Drawing.Point(312, 168);
            this.bookAvailable.Name = "bookAvailable";
            this.bookAvailable.Size = new System.Drawing.Size(21, 13);
            this.bookAvailable.TabIndex = 8;
            this.bookAvailable.Text = "No";
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(276, 216);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(75, 23);
            this.addBook.TabIndex = 9;
            this.addBook.Text = "Add";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // bookCategoryLb
            // 
            this.bookCategoryLb.AutoSize = true;
            this.bookCategoryLb.Location = new System.Drawing.Point(233, 78);
            this.bookCategoryLb.Name = "bookCategoryLb";
            this.bookCategoryLb.Size = new System.Drawing.Size(55, 13);
            this.bookCategoryLb.TabIndex = 10;
            this.bookCategoryLb.Text = "Category: ";
            // 
            // bookCategory
            // 
            this.bookCategory.AutoSize = true;
            this.bookCategory.Location = new System.Drawing.Point(312, 78);
            this.bookCategory.Name = "bookCategory";
            this.bookCategory.Size = new System.Drawing.Size(27, 13);
            this.bookCategory.TabIndex = 11;
            this.bookCategory.Text = "N/A";
            // 
            // bookDescription
            // 
            this.bookDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bookDescription.Location = new System.Drawing.Point(315, 106);
            this.bookDescription.Multiline = true;
            this.bookDescription.Name = "bookDescription";
            this.bookDescription.ReadOnly = true;
            this.bookDescription.Size = new System.Drawing.Size(100, 52);
            this.bookDescription.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BookControlDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bookDescription);
            this.Controls.Add(this.bookCategory);
            this.Controls.Add(this.bookCategoryLb);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.bookAvailable);
            this.Controls.Add(this.bookAuthor);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.bookDescriptionLb);
            this.Controls.Add(this.bookAvailableLb);
            this.Controls.Add(this.bookAuthorLb);
            this.Controls.Add(this.bookTitleLb);
            this.Controls.Add(this.bookCover);
            this.Name = "BookControlDb";
            this.Size = new System.Drawing.Size(435, 261);
            this.Load += new System.EventHandler(this.BookControlDb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bookCover;
        private System.Windows.Forms.Label bookTitleLb;
        private System.Windows.Forms.Label bookAuthorLb;
        private System.Windows.Forms.Label bookAvailableLb;
        private System.Windows.Forms.Label bookDescriptionLb;
        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.Label bookAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bookAvailable;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Label bookCategoryLb;
        private System.Windows.Forms.Label bookCategory;
        private System.Windows.Forms.TextBox bookDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
