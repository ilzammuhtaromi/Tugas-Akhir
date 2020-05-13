using Program_TA.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_TA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formMenu obj = new formMenu();
            obj.Show();
            this.Hide();
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals(@"User Name"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"User Name";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if(txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }
    }
}
