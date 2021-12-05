using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xarvis
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            if (btnId.Text == "ID")
            {
                btnId.Text = "";
            }
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            if (btnId.Text == "")
            {
                btnId.Text = "ID";
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Enter(object sender, EventArgs e)
        {
            if(btnPassword.Text== "Password")
            {
                btnPassword.Text = "";

            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (btnPassword.Text == "")
            {
                btnPassword.Text = "Password";

            }
        }

        private void btncross_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = "Admin", password = "Admin";
            if (this.btnId.Text == user && this.btnPassword.Text == password)
            {
                Index index = new Index();
                index.Show();
            }
            else MessageBox.Show("Authentication Failed");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
