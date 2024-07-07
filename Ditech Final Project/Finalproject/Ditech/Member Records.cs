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

namespace Ditech
{
    public partial class Member_Records : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SIEET30\SQLEXPRESS;Initial Catalog=library_ms;Integrated Security=True");
        SqlCommand cmd;
        public Member_Records()
        {
            InitializeComponent();
        }

        
        private void btn_back_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }
        public void view()
        {
            con.Open();
            string query = "SELECT * from Reg_lb";  
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void Member_Records_Load(object sender, EventArgs e)
        {
            view();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var ex = MessageBox.Show("Would you like to exit","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(ex==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
