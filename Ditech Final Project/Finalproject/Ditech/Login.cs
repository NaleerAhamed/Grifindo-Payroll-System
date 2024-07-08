using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ditech
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var ex = MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ex== DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Enter your username and password","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            string username = txtun.Text;
            string password = txtpw.Text;

            bool valid = false;

            switch (username)
            {
                case "Admin":
                    valid = (password =="Admin@55");
                    break;
                case "Esoft":
                    valid = (password == "Esoft@123");
                    break;
                case "Esoft123":
                    valid = (password== "Esoft@1234");
                    break;
            }
            if(valid)
            {
                MessageBox.Show("Successfully logged in", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Connecting to Registration page
                Registration reg = new Registration();
                reg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtun.Clear();
            txtpw.Clear();
            txtun.Focus();
        }

        private void chkpw_CheckedChanged(object sender, EventArgs e)
        {
            if(chkpw.Checked == true)
            {
                txtpw.UseSystemPasswordChar = true;
            }
            else
            {
                txtpw.UseSystemPasswordChar = false;
            }
        }
    }
}
