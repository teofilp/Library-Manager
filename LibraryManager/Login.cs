using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class Login : Form
    {
        public bool adminLogin = false;
        public bool loginSuccessful = false;
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (checkBox1.Checked)
            {
                if (username == "admin" && password == "admin")
                {
                    adminLogin = true;
                    loginSuccessful = true;
                    this.Close();
                }

                else
                    MessageBox.Show("Admin credentials are wrong!");
            }
            else if (username.Length > 0 && password.Length > 0)
            {
                loginSuccessful = true;
                MessageBox.Show("Hello guest!"); // redirect to guest panel
                this.Close();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
