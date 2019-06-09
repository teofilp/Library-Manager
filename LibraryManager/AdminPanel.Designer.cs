namespace LibraryManager
{
    partial class AdminPanelForm
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
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bookDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.newBook = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.categoryTb = new System.Windows.Forms.TextBox();
            this.categoriesGridView = new System.Windows.Forms.DataGridView();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateogoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteCategoryBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // booksGridView
            // 
            this.booksGridView.AccessibleName = "dataGridView2";
            this.booksGridView.AllowUserToAddRows = false;
            this.booksGridView.AllowUserToDeleteRows = false;
            this.booksGridView.AllowUserToOrderColumns = true;
            this.booksGridView.AllowUserToResizeColumns = false;
            this.booksGridView.AllowUserToResizeRows = false;
            this.booksGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookTitle,
            this.bookAuthor,
            this.bookCategory,
            this.bookDescription,
            this.bookPages,
            this.bookCopies,
            this.availableCopies,
            this.bookEdit,
            this.bookDelete});
            this.booksGridView.Location = new System.Drawing.Point(12, 58);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.ReadOnly = true;
            this.booksGridView.ShowEditingIcon = false;
            this.booksGridView.Size = new System.Drawing.Size(916, 257);
            this.booksGridView.TabIndex = 0;
            this.booksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // bookID
            // 
            this.bookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookID.HeaderText = "Id";
            this.bookID.Name = "bookID";
            this.bookID.ReadOnly = true;
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookTitle.HeaderText = "Title";
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.ReadOnly = true;
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookAuthor.HeaderText = "Author";
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.ReadOnly = true;
            // 
            // bookCategory
            // 
            this.bookCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookCategory.HeaderText = "Category";
            this.bookCategory.Name = "bookCategory";
            this.bookCategory.ReadOnly = true;
            // 
            // bookDescription
            // 
            this.bookDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookDescription.HeaderText = "Description";
            this.bookDescription.Name = "bookDescription";
            this.bookDescription.ReadOnly = true;
            // 
            // bookPages
            // 
            this.bookPages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookPages.HeaderText = "Pages";
            this.bookPages.Name = "bookPages";
            this.bookPages.ReadOnly = true;
            // 
            // bookCopies
            // 
            this.bookCopies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookCopies.HeaderText = "Copies";
            this.bookCopies.Name = "bookCopies";
            this.bookCopies.ReadOnly = true;
            // 
            // availableCopies
            // 
            this.availableCopies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.availableCopies.HeaderText = "Available Copies";
            this.availableCopies.Name = "availableCopies";
            this.availableCopies.ReadOnly = true;
            // 
            // bookEdit
            // 
            this.bookEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookEdit.HeaderText = "Edit";
            this.bookEdit.Name = "bookEdit";
            this.bookEdit.ReadOnly = true;
            this.bookEdit.Text = "Edit";
            this.bookEdit.UseColumnTextForButtonValue = true;
            // 
            // bookDelete
            // 
            this.bookDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookDelete.HeaderText = "Delete";
            this.bookDelete.Name = "bookDelete";
            this.bookDelete.ReadOnly = true;
            this.bookDelete.Text = "Delete";
            this.bookDelete.UseColumnTextForButtonValue = true;
            // 
            // newBook
            // 
            this.newBook.AccessibleName = "";
            this.newBook.Location = new System.Drawing.Point(531, 12);
            this.newBook.Name = "newBook";
            this.newBook.Size = new System.Drawing.Size(127, 34);
            this.newBook.TabIndex = 1;
            this.newBook.Text = "New Book";
            this.newBook.UseVisualStyleBackColor = true;
            this.newBook.Click += new System.EventHandler(this.newBook_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AccessibleName = "dataGridView2";
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dataGridView3.Location = new System.Drawing.Point(310, 372);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(618, 235);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Copies";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Edit";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Edit";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Delete";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Delete";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Books Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(307, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rentals Database";
            // 
            // button1
            // 
            this.button1.AccessibleName = "";
            this.button1.Location = new System.Drawing.Point(664, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reload Books";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "newBookBtn";
            this.button2.Location = new System.Drawing.Point(797, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete All Books";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "";
            this.button3.Location = new System.Drawing.Point(640, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Reload Rental Records";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AccessibleName = "";
            this.button4.Location = new System.Drawing.Point(773, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "Delete All Rental Records";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // categoryTb
            // 
            this.categoryTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.categoryTb.Location = new System.Drawing.Point(16, 324);
            this.categoryTb.Multiline = true;
            this.categoryTb.Name = "categoryTb";
            this.categoryTb.Size = new System.Drawing.Size(151, 34);
            this.categoryTb.TabIndex = 9;
            // 
            // categoriesGridView
            // 
            this.categoriesGridView.AllowUserToAddRows = false;
            this.categoriesGridView.AllowUserToDeleteRows = false;
            this.categoriesGridView.AllowUserToResizeColumns = false;
            this.categoriesGridView.AllowUserToResizeRows = false;
            this.categoriesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryId,
            this.cateogoryName,
            this.deleteCategoryBtn});
            this.categoriesGridView.Location = new System.Drawing.Point(12, 372);
            this.categoriesGridView.Name = "categoriesGridView";
            this.categoriesGridView.Size = new System.Drawing.Size(279, 235);
            this.categoriesGridView.TabIndex = 10;
            this.categoriesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesGridView_CellContentClick);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.AccessibleName = "";
            this.addCategoryBtn.Location = new System.Drawing.Point(174, 324);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(117, 34);
            this.addCategoryBtn.TabIndex = 11;
            this.addCategoryBtn.Text = "Add Category";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // categoryId
            // 
            this.categoryId.HeaderText = "Id";
            this.categoryId.Name = "categoryId";
            this.categoryId.Width = 40;
            // 
            // cateogoryName
            // 
            this.cateogoryName.HeaderText = "Name";
            this.cateogoryName.Name = "cateogoryName";
            // 
            // deleteCategoryBtn
            // 
            this.deleteCategoryBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteCategoryBtn.HeaderText = "Delete";
            this.deleteCategoryBtn.Name = "deleteCategoryBtn";
            this.deleteCategoryBtn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteCategoryBtn.Text = "Delete";
            this.deleteCategoryBtn.UseColumnTextForButtonValue = true;
            // 
            // AdminPanelForm
            // 
            this.ClientSize = new System.Drawing.Size(940, 619);
            this.Controls.Add(this.booksGridView);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.categoriesGridView);
            this.Controls.Add(this.categoryTb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.newBook);
            this.Name = "AdminPanelForm";
            this.ShowIcon = false;
            this.Text = "Library Manager";
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newBookBtn;
        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copies;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedBooks;
        private System.Windows.Forms.DataGridViewButtonColumn editRental;
        private System.Windows.Forms.DataGridViewButtonColumn deleteRental;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.Button newBook;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableCopies;
        private System.Windows.Forms.DataGridViewButtonColumn bookEdit;
        private System.Windows.Forms.DataGridViewButtonColumn bookDelete;
        private System.Windows.Forms.TextBox categoryTb;
        private System.Windows.Forms.DataGridView categoriesGridView;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateogoryName;
        private System.Windows.Forms.DataGridViewButtonColumn deleteCategoryBtn;
    }
}

