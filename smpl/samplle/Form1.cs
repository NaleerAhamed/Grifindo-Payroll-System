using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // step 1

namespace samplle
{
    public partial class Client : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SIEET30\SQLEXPRESS;Initial Catalog=quiet_attic_flims;Integrated Security=True;TrustServerCertificate=True");
        SqlCommand cmd;
        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            {
                con.Open();
                string query = "Insert into client values('" + comboBox1.Text + "','" + txtnm.Text + "','" + txtadd.Text + "','" + txtage.Text + "','" + txtphn.Text + "','" + txteml.Text + "')";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
                     
            {
                con.Open();
                string query = "update client set client_name = '"+txtnm.Text+"',client_age='"+txtage.Text+"',client_phone_number='"+txtphn.Text+"',client_email='"+txteml.Text+"',Address='"+txtadd.Text+"' WHERE client_id='"+comboBox1.Text+"'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.ResetText();
                txtnm.Clear();
                txtnm.Clear();
                txtadd.Clear();
                txtage.Clear();
                txtphn.Clear();
                txteml.Clear();
                comboBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Delete from client WHERE client_id='" + comboBox1.Text + "'";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            var ask = MessageBox.Show("Are you sure want to delete", "Delete Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (ask == DialogResult.Yes) 
            {
                MessageBox.Show("Record deleted successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                comboBox1.ResetText();
                txtnm.Clear();
                txtnm.Clear();
                txtadd.Clear();
                txtage.Clear();
                txtphn.Clear();
                txteml.Clear();
                comboBox1.Focus();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from client WHERE client_id ='"+comboBox1.Text+"'";
            cmd = new SqlCommand(query, con);
            SqlDataReader dr =cmd.ExecuteReader();
            while(dr.Read())
            {
                MessageBox.Show("Records found!","Found",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtnm.Text = dr["client_name"].ToString();
                txtage.Text = dr["client_age"].ToString();
                txtphn.Text = dr["client_phone_number"].ToString();
                txteml.Text = dr["client_email"].ToString();
                txtadd.Text = dr["Address"].ToString();
                                               
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All details cleared sussessfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtnm.Clear();
            txtnm.Clear();
            txtadd.Clear();
            txtage.Clear();
            txtphn.Clear();
            txteml.Clear();
            comboBox1.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
        public void view()
        {
            con.Open();
            string query = "SELECT * from client";
            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            view();
        }
    }
}

//if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(txtnm.Text) || string.IsNullOrEmpty(txtadd.Text) || string.IsNullOrEmpty(txtage.Text) || string.IsNullOrEmpty(txtphn.Text) || string.IsNullOrEmpty(txteml.Text))
//{
//    MessageBox.Show("Please fill in your all details ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//}
//else