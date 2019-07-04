namespace LibraryManager
{
    partial class booksCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booksCollection));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cartItemsNumber = new System.Windows.Forms.Label();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.checkoutPnl = new System.Windows.Forms.Panel();
            this.disclaimer = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.renterPhoneNumber = new System.Windows.Forms.Label();
            this.renterEmailLb = new System.Windows.Forms.Label();
            this.renterLastNameLb = new System.Windows.Forms.Label();
            this.renterFirstNameLb = new System.Windows.Forms.Label();
            this.renterPhone = new System.Windows.Forms.TextBox();
            this.renterEmailTb = new System.Windows.Forms.TextBox();
            this.renterLastNameTb = new System.Windows.Forms.TextBox();
            this.renterFirstNameTb = new System.Windows.Forms.TextBox();
            this.checkoutBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.checkoutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(736, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cartItemsNumber
            // 
            this.cartItemsNumber.AutoSize = true;
            this.cartItemsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cartItemsNumber.Location = new System.Drawing.Point(786, 9);
            this.cartItemsNumber.Name = "cartItemsNumber";
            this.cartItemsNumber.Size = new System.Drawing.Size(24, 25);
            this.cartItemsNumber.TabIndex = 1;
            this.cartItemsNumber.Text = "0";
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Location = new System.Drawing.Point(812, 11);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(75, 23);
            this.checkoutBtn.TabIndex = 2;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(13, 9);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(153, 20);
            this.searchTb.TabIndex = 3;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(172, 9);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 21);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutPnl
            // 
            this.checkoutPnl.AutoScroll = true;
            this.checkoutPnl.Controls.Add(this.disclaimer);
            this.checkoutPnl.Controls.Add(this.Address);
            this.checkoutPnl.Controls.Add(this.addressTb);
            this.checkoutPnl.Controls.Add(this.confirmBtn);
            this.checkoutPnl.Controls.Add(this.renterPhoneNumber);
            this.checkoutPnl.Controls.Add(this.renterEmailLb);
            this.checkoutPnl.Controls.Add(this.renterLastNameLb);
            this.checkoutPnl.Controls.Add(this.renterFirstNameLb);
            this.checkoutPnl.Controls.Add(this.renterPhone);
            this.checkoutPnl.Controls.Add(this.renterEmailTb);
            this.checkoutPnl.Controls.Add(this.renterLastNameTb);
            this.checkoutPnl.Controls.Add(this.renterFirstNameTb);
            this.checkoutPnl.Controls.Add(this.checkoutBackBtn);
            this.checkoutPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutPnl.Location = new System.Drawing.Point(0, 0);
            this.checkoutPnl.Name = "checkoutPnl";
            this.checkoutPnl.Size = new System.Drawing.Size(899, 487);
            this.checkoutPnl.TabIndex = 5;
            this.checkoutPnl.Visible = false;
            // 
            // disclaimer
            // 
            this.disclaimer.AutoSize = true;
            this.disclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.disclaimer.Location = new System.Drawing.Point(262, 36);
            this.disclaimer.Name = "disclaimer";
            this.disclaimer.Size = new System.Drawing.Size(316, 20);
            this.disclaimer.TabIndex = 7;
            this.disclaimer.Text = "Books have to be returned within 14 days";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(591, 106);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 11;
            this.Address.Text = "Address";
            // 
            // addressTb
            // 
            this.addressTb.Location = new System.Drawing.Point(653, 103);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(145, 20);
            this.addressTb.TabIndex = 10;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(723, 155);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 9;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // renterPhoneNumber
            // 
            this.renterPhoneNumber.AutoSize = true;
            this.renterPhoneNumber.Location = new System.Drawing.Point(277, 160);
            this.renterPhoneNumber.Name = "renterPhoneNumber";
            this.renterPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.renterPhoneNumber.TabIndex = 8;
            this.renterPhoneNumber.Text = "Phone Number";
            // 
            // renterEmailLb
            // 
            this.renterEmailLb.AutoSize = true;
            this.renterEmailLb.Location = new System.Drawing.Point(323, 106);
            this.renterEmailLb.Name = "renterEmailLb";
            this.renterEmailLb.Size = new System.Drawing.Size(32, 13);
            this.renterEmailLb.TabIndex = 7;
            this.renterEmailLb.Text = "Email";
            // 
            // renterLastNameLb
            // 
            this.renterLastNameLb.AutoSize = true;
            this.renterLastNameLb.Location = new System.Drawing.Point(32, 160);
            this.renterLastNameLb.Name = "renterLastNameLb";
            this.renterLastNameLb.Size = new System.Drawing.Size(56, 13);
            this.renterLastNameLb.TabIndex = 6;
            this.renterLastNameLb.Text = "Last name";
            // 
            // renterFirstNameLb
            // 
            this.renterFirstNameLb.AutoSize = true;
            this.renterFirstNameLb.Location = new System.Drawing.Point(32, 106);
            this.renterFirstNameLb.Name = "renterFirstNameLb";
            this.renterFirstNameLb.Size = new System.Drawing.Size(55, 13);
            this.renterFirstNameLb.TabIndex = 5;
            this.renterFirstNameLb.Text = "First name";
            // 
            // renterPhone
            // 
            this.renterPhone.Location = new System.Drawing.Point(381, 157);
            this.renterPhone.Name = "renterPhone";
            this.renterPhone.Size = new System.Drawing.Size(145, 20);
            this.renterPhone.TabIndex = 4;
            // 
            // renterEmailTb
            // 
            this.renterEmailTb.Location = new System.Drawing.Point(381, 103);
            this.renterEmailTb.Name = "renterEmailTb";
            this.renterEmailTb.Size = new System.Drawing.Size(145, 20);
            this.renterEmailTb.TabIndex = 3;
            // 
            // renterLastNameTb
            // 
            this.renterLastNameTb.Location = new System.Drawing.Point(102, 157);
            this.renterLastNameTb.Name = "renterLastNameTb";
            this.renterLastNameTb.Size = new System.Drawing.Size(145, 20);
            this.renterLastNameTb.TabIndex = 2;
            // 
            // renterFirstNameTb
            // 
            this.renterFirstNameTb.Location = new System.Drawing.Point(102, 103);
            this.renterFirstNameTb.Name = "renterFirstNameTb";
            this.renterFirstNameTb.Size = new System.Drawing.Size(145, 20);
            this.renterFirstNameTb.TabIndex = 1;
            // 
            // checkoutBackBtn
            // 
            this.checkoutBackBtn.Location = new System.Drawing.Point(13, 13);
            this.checkoutBackBtn.Name = "checkoutBackBtn";
            this.checkoutBackBtn.Size = new System.Drawing.Size(75, 23);
            this.checkoutBackBtn.TabIndex = 0;
            this.checkoutBackBtn.Text = "< Back";
            this.checkoutBackBtn.UseVisualStyleBackColor = true;
            this.checkoutBackBtn.Click += new System.EventHandler(this.checkoutBackBtn_Click);
            // 
            // booksCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(899, 487);
            this.Controls.Add(this.checkoutPnl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.cartItemsNumber);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "booksCollection";
            this.Text = "Gallery";
            this.Load += new System.EventHandler(this.booksCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.checkoutPnl.ResumeLayout(false);
            this.checkoutPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label cartItemsNumber;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel checkoutPnl;
        private System.Windows.Forms.Button checkoutBackBtn;
        private System.Windows.Forms.TextBox renterEmailTb;
        private System.Windows.Forms.TextBox renterLastNameTb;
        private System.Windows.Forms.TextBox renterFirstNameTb;
        private System.Windows.Forms.Label renterPhoneNumber;
        private System.Windows.Forms.Label renterEmailLb;
        private System.Windows.Forms.Label renterLastNameLb;
        private System.Windows.Forms.Label renterFirstNameLb;
        private System.Windows.Forms.TextBox renterPhone;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.Label disclaimer;
    }
}