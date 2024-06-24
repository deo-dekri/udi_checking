using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GS1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string set_username = "Admin";
        public string set_password = "admin123";

        public string input_username;
        public string input_password;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            input_username = txtUserName.Text;
            input_password = txtPassword.Text;

            if (input_username == "" && txtPassword.Focus())
            {
                txtUserName.Text = "Please input username";
                txtUserName.ForeColor = Color.Red;
            }


            if (input_username == set_username && input_password == set_password)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your username or password is wrong","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void lblClearField_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if( result == DialogResult.Yes )
            {
                Application.Exit();
            }
        } 
    }
}
