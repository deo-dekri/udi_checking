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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            userActionPanel.Visible = false;
        }

        private void lblChangeuser_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void mouseUpOnUserIcon(object sender, MouseEventArgs e)
        {
            if (userActionPanel.Visible)
            {
                userActionPanel.Visible = false;
            }
            else
            {
                userActionPanel.Visible = true;
            }
            
        }
    }
}
