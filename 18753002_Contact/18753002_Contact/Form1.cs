using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18753002_Contact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void User_Click(object sender, EventArgs e)
        {
            User.Text = "";
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (User.Text == "admin" && Password.Text == "admin")
            {
                MessageBox.Show("Login Sukses", "Information");
                FormContact frm = new FormContact();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf username/password anda salahh!!");
                User.Text = "Username";
                Password.Text = "Password";
                User.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
