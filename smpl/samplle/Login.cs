using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samplle
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username=="Ahamed" && password=="123456")
            {
                MessageBox.Show("Successfully logged in","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Client Clt = new Client();
                Clt.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Invaild Username or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

               
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked ==true) 
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
