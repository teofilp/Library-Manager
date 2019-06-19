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
            this.rentalsGridView = new System.Windows.Forms.DataGridView();
            this.rentalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterBorrowedBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returned_books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editRentalBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CompleteRental = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.categoryTb = new System.Windows.Forms.TextBox();
            this.categoriesGridView = new System.Windows.Forms.DataGridView();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateogoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteCategoryBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.lateReturnsGrid = new System.Windows.Forms.DataGridView();
            this.dueReturnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueReturnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueReturnBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LateDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lateReturns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lateReturnsGrid)).BeginInit();
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
            this.booksGridView.Size = new System.Drawing.Size(1245, 257);
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
            this.newBook.Location = new System.Drawing.Point(997, 12);
            this.newBook.Name = "newBook";
            this.newBook.Size = new System.Drawing.Size(127, 34);
            this.newBook.TabIndex = 1;
            this.newBook.Text = "New Book";
            this.newBook.UseVisualStyleBackColor = true;
            this.newBook.Click += new System.EventHandler(this.newBook_Click_1);
            // 
            // rentalsGridView
            // 
            this.rentalsGridView.AccessibleName = "dataGridView2";
            this.rentalsGridView.AllowUserToAddRows = false;
            this.rentalsGridView.AllowUserToDeleteRows = false;
            this.rentalsGridView.AllowUserToOrderColumns = true;
            this.rentalsGridView.AllowUserToResizeRows = false;
            this.rentalsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rentalsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalId,
            this.renterFullName,
            this.renterEmail,
            this.renterPhoneNumber,
            this.renterAddress,
            this.renterBorrowedBooks,
            this.returned_books,
            this.rentalDate,
            this.editRentalBtn,
            this.CompleteRental});
            this.rentalsGridView.Location = new System.Drawing.Point(310, 372);
            this.rentalsGridView.Name = "rentalsGridView";
            this.rentalsGridView.Size = new System.Drawing.Size(618, 235);
            this.rentalsGridView.TabIndex = 2;
            this.rentalsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentalsGridView_CellContentClick);
            // 
            // rentalId
            // 
            this.rentalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rentalId.HeaderText = "Id";
            this.rentalId.Name = "rentalId";
            // 
            // renterFullName
            // 
            this.renterFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.renterFullName.HeaderText = "Full Name";
            this.renterFullName.Name = "renterFullName";
            // 
            // renterEmail
            // 
            this.renterEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.renterEmail.HeaderText = "Email";
            this.renterEmail.Name = "renterEmail";
            // 
            // renterPhoneNumber
            // 
            this.renterPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.renterPhoneNumber.HeaderText = "Phone Number";
            this.renterPhoneNumber.Name = "renterPhoneNumber";
            // 
            // renterAddress
            // 
            this.renterAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.renterAddress.HeaderText = "Address";
            this.renterAddress.Name = "renterAddress";
            // 
            // renterBorrowedBooks
            // 
            this.renterBorrowedBooks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.renterBorrowedBooks.HeaderText = "Borrowed Books";
            this.renterBorrowedBooks.Name = "renterBorrowedBooks";
            // 
            // returned_books
            // 
            this.returned_books.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.returned_books.HeaderText = "Returned Books";
            this.returned_books.Name = "returned_books";
            // 
            // rentalDate
            // 
            this.rentalDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rentalDate.HeaderText = "At Date";
            this.rentalDate.Name = "rentalDate";
            // 
            // editRentalBtn
            // 
            this.editRentalBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.editRentalBtn.HeaderText = "Edit";
            this.editRentalBtn.Name = "editRentalBtn";
            this.editRentalBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editRentalBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editRentalBtn.Text = "Edit";
            this.editRentalBtn.UseColumnTextForButtonValue = true;
            // 
            // CompleteRental
            // 
            this.CompleteRental.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompleteRental.HeaderText = "Complete";
            this.CompleteRental.Name = "CompleteRental";
            this.CompleteRental.Text = "Complete";
            this.CompleteRental.UseColumnTextForButtonValue = true;
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
            this.button1.Location = new System.Drawing.Point(1130, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reload Books";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reloadBooks);
            // 
            // button3
            // 
            this.button3.AccessibleName = "";
            this.button3.Location = new System.Drawing.Point(801, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Reload Rental Records";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.reloadRentals);
            // 
            // categoryTb
            // 
            this.categoryTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.categoryTb.Location = new System.Drawing.Point(12, 334);
            this.categoryTb.Name = "categoryTb";
            this.categoryTb.Size = new System.Drawing.Size(151, 24);
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
            // addCategoryBtn
            // 
            this.addCategoryBtn.AccessibleName = "";
            this.addCategoryBtn.Location = new System.Drawing.Point(174, 334);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(117, 24);
            this.addCategoryBtn.TabIndex = 11;
            this.addCategoryBtn.Text = "Add Category";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // lateReturnsGrid
            // 
            this.lateReturnsGrid.AllowUserToAddRows = false;
            this.lateReturnsGrid.AllowUserToResizeRows = false;
            this.lateReturnsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lateReturnsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lateReturnsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dueReturnId,
            this.dueReturnName,
            this.dueReturnBooks,
            this.LateDays,
            this.notify});
            this.lateReturnsGrid.Location = new System.Drawing.Point(944, 372);
            this.lateReturnsGrid.Name = "lateReturnsGrid";
            this.lateReturnsGrid.Size = new System.Drawing.Size(313, 235);
            this.lateReturnsGrid.TabIndex = 12;
            this.lateReturnsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lateReturnsGrid_CellContentClick);
            // 
            // dueReturnId
            // 
            this.dueReturnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dueReturnId.HeaderText = "Id";
            this.dueReturnId.Name = "dueReturnId";
            // 
            // dueReturnName
            // 
            this.dueReturnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dueReturnName.HeaderText = "Name";
            this.dueReturnName.Name = "dueReturnName";
            // 
            // dueReturnBooks
            // 
            this.dueReturnBooks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dueReturnBooks.HeaderText = "Books to be returned";
            this.dueReturnBooks.Name = "dueReturnBooks";
            // 
            // LateDays
            // 
            this.LateDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LateDays.HeaderText = "Late Days";
            this.LateDays.Name = "LateDays";
            // 
            // notify
            // 
            this.notify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notify.HeaderText = "Notify";
            this.notify.Name = "notify";
            this.notify.Text = "Notify";
            this.notify.UseColumnTextForButtonValue = true;
            // 
            // lateReturns
            // 
            this.lateReturns.AutoSize = true;
            this.lateReturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lateReturns.Location = new System.Drawing.Point(941, 340);
            this.lateReturns.Name = "lateReturns";
            this.lateReturns.Size = new System.Drawing.Size(92, 18);
            this.lateReturns.TabIndex = 13;
            this.lateReturns.Text = "Late Returns";
            // 
            // AdminPanelForm
            // 
            this.ClientSize = new System.Drawing.Size(1269, 617);
            this.Controls.Add(this.lateReturns);
            this.Controls.Add(this.lateReturnsGrid);
            this.Controls.Add(this.booksGridView);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.categoriesGridView);
            this.Controls.Add(this.categoryTb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentalsGridView);
            this.Controls.Add(this.newBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminPanelForm";
            this.Text = "Library Manager";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lateReturnsGrid)).EndInit();
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
        private System.Windows.Forms.DataGridView rentalsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterBorrowedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn returned_books;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDate;
        private System.Windows.Forms.DataGridViewButtonColumn editRentalBtn;
        private System.Windows.Forms.DataGridViewButtonColumn CompleteRental;
        private System.Windows.Forms.DataGridView lateReturnsGrid;
        private System.Windows.Forms.Label lateReturns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueReturnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueReturnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueReturnBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn LateDays;
        private System.Windows.Forms.DataGridViewButtonColumn notify;
    }
}

