using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grifindo_Toys
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SIEET30\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        //SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_un.Clear();
            txt_pw.Clear();
            txt_un.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_lg_Click(object sender, EventArgs e)
        {
            if (txt_un.Text != string.Empty && txt_pw.Text != string.Empty)
            {
                con.Open();
                string query = "SELECT * from Login WHERE Username='"+txt_un.Text+"' and Password='"+txt_pw.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read()==true)
                {
                    MessageBox.Show("Successfully logged in","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Homepage Homepage = new Homepage();
                    Homepage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter value in all field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_pw.UseSystemPasswordChar = checkBox1.Checked;
        }
    }
}
