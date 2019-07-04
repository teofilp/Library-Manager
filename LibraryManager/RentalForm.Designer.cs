namespace LibraryManager
{
    partial class RentalForm
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
            this.borrowerName = new System.Windows.Forms.Label();
            this.borrowerEmail = new System.Windows.Forms.Label();
            this.borrowerPhoneNumber = new System.Windows.Forms.Label();
            this.borrowerAddress = new System.Windows.Forms.Label();
            this.returnedBooks = new System.Windows.Forms.Label();
            this.borrowerNameTb = new System.Windows.Forms.TextBox();
            this.borrowerEmailTb = new System.Windows.Forms.TextBox();
            this.borrowerPhoneTb = new System.Windows.Forms.TextBox();
            this.borrowerAddressTb = new System.Windows.Forms.TextBox();
            this.returnedBooksTb = new System.Windows.Forms.TextBox();
            this.updateRentalBtn = new System.Windows.Forms.Button();
            this.borrowedBooksTb = new System.Windows.Forms.TextBox();
            this.borrowedBooks = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // borrowerName
            // 
            this.borrowerName.AutoSize = true;
            this.borrowerName.Location = new System.Drawing.Point(41, 37);
            this.borrowerName.Name = "borrowerName";
            this.borrowerName.Size = new System.Drawing.Size(54, 13);
            this.borrowerName.TabIndex = 0;
            this.borrowerName.Text = "Full Name";
            // 
            // borrowerEmail
            // 
            this.borrowerEmail.AutoSize = true;
            this.borrowerEmail.Location = new System.Drawing.Point(63, 84);
            this.borrowerEmail.Name = "borrowerEmail";
            this.borrowerEmail.Size = new System.Drawing.Size(32, 13);
            this.borrowerEmail.TabIndex = 1;
            this.borrowerEmail.Text = "Email";
            // 
            // borrowerPhoneNumber
            // 
            this.borrowerPhoneNumber.AutoSize = true;
            this.borrowerPhoneNumber.Location = new System.Drawing.Point(19, 125);
            this.borrowerPhoneNumber.Name = "borrowerPhoneNumber";
            this.borrowerPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.borrowerPhoneNumber.TabIndex = 2;
            this.borrowerPhoneNumber.Text = "Phone number";
            // 
            // borrowerAddress
            // 
            this.borrowerAddress.AutoSize = true;
            this.borrowerAddress.Location = new System.Drawing.Point(308, 37);
            this.borrowerAddress.Name = "borrowerAddress";
            this.borrowerAddress.Size = new System.Drawing.Size(45, 13);
            this.borrowerAddress.TabIndex = 3;
            this.borrowerAddress.Text = "Address";
            // 
            // returnedBooks
            // 
            this.returnedBooks.AutoSize = true;
            this.returnedBooks.Location = new System.Drawing.Point(269, 125);
            this.returnedBooks.Name = "returnedBooks";
            this.returnedBooks.Size = new System.Drawing.Size(84, 13);
            this.returnedBooks.TabIndex = 4;
            this.returnedBooks.Text = "Returned Books";
            // 
            // borrowerNameTb
            // 
            this.borrowerNameTb.Location = new System.Drawing.Point(121, 34);
            this.borrowerNameTb.Name = "borrowerNameTb";
            this.borrowerNameTb.Size = new System.Drawing.Size(123, 20);
            this.borrowerNameTb.TabIndex = 5;
            // 
            // borrowerEmailTb
            // 
            this.borrowerEmailTb.Location = new System.Drawing.Point(121, 81);
            this.borrowerEmailTb.Name = "borrowerEmailTb";
            this.borrowerEmailTb.Size = new System.Drawing.Size(123, 20);
            this.borrowerEmailTb.TabIndex = 6;
            // 
            // borrowerPhoneTb
            // 
            this.borrowerPhoneTb.Location = new System.Drawing.Point(121, 125);
            this.borrowerPhoneTb.Name = "borrowerPhoneTb";
            this.borrowerPhoneTb.Size = new System.Drawing.Size(123, 20);
            this.borrowerPhoneTb.TabIndex = 7;
            // 
            // borrowerAddressTb
            // 
            this.borrowerAddressTb.Location = new System.Drawing.Point(371, 34);
            this.borrowerAddressTb.Name = "borrowerAddressTb";
            this.borrowerAddressTb.Size = new System.Drawing.Size(123, 20);
            this.borrowerAddressTb.TabIndex = 8;
            // 
            // returnedBooksTb
            // 
            this.returnedBooksTb.Location = new System.Drawing.Point(371, 122);
            this.returnedBooksTb.Name = "returnedBooksTb";
            this.returnedBooksTb.Size = new System.Drawing.Size(123, 20);
            this.returnedBooksTb.TabIndex = 9;
            // 
            // updateRentalBtn
            // 
            this.updateRentalBtn.Location = new System.Drawing.Point(460, 173);
            this.updateRentalBtn.Name = "updateRentalBtn";
            this.updateRentalBtn.Size = new System.Drawing.Size(75, 23);
            this.updateRentalBtn.TabIndex = 10;
            this.updateRentalBtn.Text = "Update";
            this.updateRentalBtn.UseVisualStyleBackColor = true;
            this.updateRentalBtn.Click += new System.EventHandler(this.updateRentalBtn_Click);
            // 
            // borrowedBooksTb
            // 
            this.borrowedBooksTb.Location = new System.Drawing.Point(371, 81);
            this.borrowedBooksTb.Name = "borrowedBooksTb";
            this.borrowedBooksTb.ReadOnly = true;
            this.borrowedBooksTb.Size = new System.Drawing.Size(123, 20);
            this.borrowedBooksTb.TabIndex = 11;
            // 
            // borrowedBooks
            // 
            this.borrowedBooks.AutoSize = true;
            this.borrowedBooks.Location = new System.Drawing.Point(269, 84);
            this.borrowedBooks.Name = "borrowedBooks";
            this.borrowedBooks.Size = new System.Drawing.Size(85, 13);
            this.borrowedBooks.TabIndex = 12;
            this.borrowedBooks.Text = "Borrowed Books";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(121, 172);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(222, 20);
            this.date.TabIndex = 13;
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 226);
            this.Controls.Add(this.date);
            this.Controls.Add(this.borrowedBooks);
            this.Controls.Add(this.borrowedBooksTb);
            this.Controls.Add(this.updateRentalBtn);
            this.Controls.Add(this.returnedBooksTb);
            this.Controls.Add(this.borrowerAddressTb);
            this.Controls.Add(this.borrowerPhoneTb);
            this.Controls.Add(this.borrowerEmailTb);
            this.Controls.Add(this.borrowerNameTb);
            this.Controls.Add(this.returnedBooks);
            this.Controls.Add(this.borrowerAddress);
            this.Controls.Add(this.borrowerPhoneNumber);
            this.Controls.Add(this.borrowerEmail);
            this.Controls.Add(this.borrowerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RentalForm";
            this.Text = "RentalForm";
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label borrowerName;
        private System.Windows.Forms.Label borrowerEmail;
        private System.Windows.Forms.Label borrowerPhoneNumber;
        private System.Windows.Forms.Label borrowerAddress;
        private System.Windows.Forms.Label returnedBooks;
        private System.Windows.Forms.TextBox borrowerNameTb;
        private System.Windows.Forms.TextBox borrowerEmailTb;
        private System.Windows.Forms.TextBox borrowerPhoneTb;
        private System.Windows.Forms.TextBox borrowerAddressTb;
        private System.Windows.Forms.TextBox returnedBooksTb;
        private System.Windows.Forms.Button updateRentalBtn;
        private System.Windows.Forms.TextBox borrowedBooksTb;
        private System.Windows.Forms.Label borrowedBooks;
        private System.Windows.Forms.DateTimePicker date;
    }
}