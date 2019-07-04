namespace LibraryManager
{
    partial class BookControlSm
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
            this.bookCover = new System.Windows.Forms.PictureBox();
            this.bookTitle = new System.Windows.Forms.Label();
            this.bookTitleLb = new System.Windows.Forms.Label();
            this.bookCategory = new System.Windows.Forms.Label();
            this.bookCategoryLb = new System.Windows.Forms.Label();
            this.bookAuthor = new System.Windows.Forms.Label();
            this.bookAuthorLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // bookCover
            // 
            this.bookCover.Location = new System.Drawing.Point(29, 15);
            this.bookCover.Name = "bookCover";
            this.bookCover.Size = new System.Drawing.Size(84, 119);
            this.bookCover.TabIndex = 1;
            this.bookCover.TabStop = false;
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Location = new System.Drawing.Point(198, 32);
            this.bookTitle.MaximumSize = new System.Drawing.Size(90, 0);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(27, 13);
            this.bookTitle.TabIndex = 7;
            this.bookTitle.Text = "N/A";
            // 
            // bookTitleLb
            // 
            this.bookTitleLb.AutoSize = true;
            this.bookTitleLb.Location = new System.Drawing.Point(159, 32);
            this.bookTitleLb.Name = "bookTitleLb";
            this.bookTitleLb.Size = new System.Drawing.Size(33, 13);
            this.bookTitleLb.TabIndex = 6;
            this.bookTitleLb.Text = "Title: ";
            // 
            // bookCategory
            // 
            this.bookCategory.AutoSize = true;
            this.bookCategory.Location = new System.Drawing.Point(199, 95);
            this.bookCategory.Name = "bookCategory";
            this.bookCategory.Size = new System.Drawing.Size(27, 13);
            this.bookCategory.TabIndex = 15;
            this.bookCategory.Text = "N/A";
            // 
            // bookCategoryLb
            // 
            this.bookCategoryLb.AutoSize = true;
            this.bookCategoryLb.Location = new System.Drawing.Point(137, 95);
            this.bookCategoryLb.Name = "bookCategoryLb";
            this.bookCategoryLb.Size = new System.Drawing.Size(55, 13);
            this.bookCategoryLb.TabIndex = 14;
            this.bookCategoryLb.Text = "Category: ";
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSize = true;
            this.bookAuthor.Location = new System.Drawing.Point(199, 62);
            this.bookAuthor.MaximumSize = new System.Drawing.Size(90, 0);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(27, 13);
            this.bookAuthor.TabIndex = 13;
            this.bookAuthor.Text = "N/A";
            // 
            // bookAuthorLb
            // 
            this.bookAuthorLb.AutoSize = true;
            this.bookAuthorLb.Location = new System.Drawing.Point(148, 62);
            this.bookAuthorLb.Name = "bookAuthorLb";
            this.bookAuthorLb.Size = new System.Drawing.Size(44, 13);
            this.bookAuthorLb.TabIndex = 12;
            this.bookAuthorLb.Text = "Author: ";
            // 
            // BookControlSm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bookCategory);
            this.Controls.Add(this.bookCategoryLb);
            this.Controls.Add(this.bookAuthor);
            this.Controls.Add(this.bookAuthorLb);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.bookTitleLb);
            this.Controls.Add(this.bookCover);
            this.Name = "BookControlSm";
            this.Size = new System.Drawing.Size(287, 148);
            this.Load += new System.EventHandler(this.BookControlSm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bookCover;
        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.Label bookTitleLb;
        private System.Windows.Forms.Label bookCategory;
        private System.Windows.Forms.Label bookCategoryLb;
        private System.Windows.Forms.Label bookAuthor;
        private System.Windows.Forms.Label bookAuthorLb;
    }
}
