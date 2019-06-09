namespace LibraryManager
{
    partial class BookForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.bookPanel = new System.Windows.Forms.Panel();
            this.categories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookPagesTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookDescriptionTb = new System.Windows.Forms.RichTextBox();
            this.saveBookBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chooseImageBtn = new System.Windows.Forms.Button();
            this.bookCopiesTb = new System.Windows.Forms.TextBox();
            this.bookAuthorTb = new System.Windows.Forms.TextBox();
            this.bookTitleTb = new System.Windows.Forms.TextBox();
            this.BookCopies = new System.Windows.Forms.Label();
            this.bookAuthor = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.Label();
            this.bookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookPanel
            // 
            this.bookPanel.Controls.Add(this.categories);
            this.bookPanel.Controls.Add(this.label3);
            this.bookPanel.Controls.Add(this.label2);
            this.bookPanel.Controls.Add(this.bookPagesTb);
            this.bookPanel.Controls.Add(this.label1);
            this.bookPanel.Controls.Add(this.bookDescriptionTb);
            this.bookPanel.Controls.Add(this.saveBookBtn);
            this.bookPanel.Controls.Add(this.pictureBox1);
            this.bookPanel.Controls.Add(this.chooseImageBtn);
            this.bookPanel.Controls.Add(this.bookCopiesTb);
            this.bookPanel.Controls.Add(this.bookAuthorTb);
            this.bookPanel.Controls.Add(this.bookTitleTb);
            this.bookPanel.Controls.Add(this.BookCopies);
            this.bookPanel.Controls.Add(this.bookAuthor);
            this.bookPanel.Controls.Add(this.bookTitle);
            this.bookPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookPanel.Location = new System.Drawing.Point(0, 0);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(777, 511);
            this.bookPanel.TabIndex = 4;
            this.bookPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bookPanel_Paint);
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(89, 129);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(205, 21);
            this.categories.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pages";
            // 
            // bookPagesTb
            // 
            this.bookPagesTb.Location = new System.Drawing.Point(89, 329);
            this.bookPagesTb.Name = "bookPagesTb";
            this.bookPagesTb.Size = new System.Drawing.Size(71, 20);
            this.bookPagesTb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Desciption";
            // 
            // bookDescriptionTb
            // 
            this.bookDescriptionTb.Location = new System.Drawing.Point(89, 173);
            this.bookDescriptionTb.Name = "bookDescriptionTb";
            this.bookDescriptionTb.Size = new System.Drawing.Size(296, 126);
            this.bookDescriptionTb.TabIndex = 2;
            this.bookDescriptionTb.Text = "";
            // 
            // saveBookBtn
            // 
            this.saveBookBtn.Location = new System.Drawing.Point(89, 429);
            this.saveBookBtn.Name = "saveBookBtn";
            this.saveBookBtn.Size = new System.Drawing.Size(191, 27);
            this.saveBookBtn.TabIndex = 6;
            this.saveBookBtn.Text = "Save Book";
            this.saveBookBtn.UseVisualStyleBackColor = true;
            this.saveBookBtn.Click += new System.EventHandler(this.saveBookBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 367);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // chooseImageBtn
            // 
            this.chooseImageBtn.Location = new System.Drawing.Point(524, 431);
            this.chooseImageBtn.Name = "chooseImageBtn";
            this.chooseImageBtn.Size = new System.Drawing.Size(109, 23);
            this.chooseImageBtn.TabIndex = 5;
            this.chooseImageBtn.Text = "Choose Image";
            this.chooseImageBtn.UseVisualStyleBackColor = true;
            this.chooseImageBtn.Click += new System.EventHandler(this.chooseImageBtn_Click);
            // 
            // bookCopiesTb
            // 
            this.bookCopiesTb.Location = new System.Drawing.Point(89, 368);
            this.bookCopiesTb.Name = "bookCopiesTb";
            this.bookCopiesTb.Size = new System.Drawing.Size(71, 20);
            this.bookCopiesTb.TabIndex = 4;
            // 
            // bookAuthorTb
            // 
            this.bookAuthorTb.Location = new System.Drawing.Point(89, 86);
            this.bookAuthorTb.Name = "bookAuthorTb";
            this.bookAuthorTb.Size = new System.Drawing.Size(296, 20);
            this.bookAuthorTb.TabIndex = 1;
            // 
            // bookTitleTb
            // 
            this.bookTitleTb.Location = new System.Drawing.Point(89, 38);
            this.bookTitleTb.Name = "bookTitleTb";
            this.bookTitleTb.Size = new System.Drawing.Size(296, 20);
            this.bookTitleTb.TabIndex = 0;
            // 
            // BookCopies
            // 
            this.BookCopies.AutoSize = true;
            this.BookCopies.Location = new System.Drawing.Point(34, 368);
            this.BookCopies.Name = "BookCopies";
            this.BookCopies.Size = new System.Drawing.Size(39, 13);
            this.BookCopies.TabIndex = 5;
            this.BookCopies.Text = "Copies";
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSize = true;
            this.bookAuthor.Location = new System.Drawing.Point(29, 86);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(38, 13);
            this.bookAuthor.TabIndex = 3;
            this.bookAuthor.Text = "Author";
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Location = new System.Drawing.Point(40, 38);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(27, 13);
            this.bookTitle.TabIndex = 2;
            this.bookTitle.Text = "Title";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 511);
            this.Controls.Add(this.bookPanel);
            this.Name = "BookForm";
            this.Text = "Add new book";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.bookPanel.ResumeLayout(false);
            this.bookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Button saveBookBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button chooseImageBtn;
        private System.Windows.Forms.TextBox bookCopiesTb;
        private System.Windows.Forms.TextBox bookAuthorTb;
        private System.Windows.Forms.TextBox bookTitleTb;
        private System.Windows.Forms.Label BookCopies;
        private System.Windows.Forms.Label bookAuthor;
        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.RichTextBox bookDescriptionTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookPagesTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categories;
        private System.Windows.Forms.Label label3;
    }
}