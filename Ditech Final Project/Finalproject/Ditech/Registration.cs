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
    public partial class Registration : Form
    {
        //connecting to database
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SIEET30\SQLEXPRESS;Initial Catalog=library_ms;Integrated Security=True");
        SqlCommand cmd;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //back button codes
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //exit button codes
            var ex = MessageBox.Show("Would you like to exit","Confirm Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(ex == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Fill your details","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            //register button codes
            dtpdob.Format = DateTimePickerFormat.Custom;
            dtpdob.CustomFormat = "yyyy/MM/dd";

            string gender;
            if(rdml.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            ddprd.Format = DateTimePickerFormat.Custom;
            ddprd.CustomFormat = "yyyy/MM/dd";

            con.Open();
            string query = "INSERT into Reg_lb values ('"+textBox1.Text+"','"+txtfn.Text+"','"+txtadd.Text+"','"+dtpdob.Text+"','"+gender+"','"+txtpn.Text+"','"+txteml.Text+"','"+txtlbc.Text+"','"+cmbmt.Text+"','"+cmbbkn.Text+"','"+ddprd.Text+"')";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registration successful","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            textBox1.Clear();
            txtfn.Clear();
            txtadd.Clear();
            dtpdob.ResetText();
            rdml.Checked = false;
            rdfml.Checked = false;
            txtpn.Clear();
            txteml.Clear();
            txtlbc.Clear();
            cmbmt.ResetText();
            cmbbkn.ResetText();
            ddprd.ResetText();
            textBox1.Focus();
        }

        private void btn_ins_Click(object sender, EventArgs e)
        {
            //insert button codes
            dtpdob.Format = DateTimePickerFormat.Custom;
            dtpdob.CustomFormat = "yyyy/MM/dd";

            string gender;
            if (rdml.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            ddprd.Format = DateTimePickerFormat.Custom;
            ddprd.CustomFormat = "yyyy/MM/dd";
            con.Open();
            string query = "INSERT into Reg_lb values('" + textBox1.Text + "','" + txtfn.Text + "','" + txtadd.Text + "','" + dtpdob.Text + "','" + gender + "','" + txtpn.Text + "','" + txteml.Text + "','" + txtlbc.Text + "','" + cmbmt.Text + "','" + cmbbkn.Text + "','" + ddprd.Text + "')";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Records inserted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            txtfn.Clear();
            txtadd.Clear();
            dtpdob.ResetText();
            rdml.Checked = false;
            rdfml.Checked = false;
            txtpn.Clear();
            txteml.Clear();
            txtlbc.Clear();
            cmbmt.ResetText();
            cmbbkn.ResetText();
            ddprd.ResetText();
            textBox1.Focus();


        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            //delete button codes
            con.Open();
            string query = "DELETE from Reg_lb WHERE user_id = '"+textBox1.Text+"'";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Records deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        
            textBox1.Clear();
            txtfn.Clear();
            txtadd.Clear();
            dtpdob.ResetText();
            rdml.Checked = false;
            rdfml.Checked = false;
            txtpn.Clear();
            txteml.Clear();
            txtlbc.Clear();
            cmbmt.ResetText();
            cmbbkn.ResetText();
            ddprd.ResetText();
            textBox1.Focus();
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            //update button codes
            dtpdob.Format = DateTimePickerFormat.Custom;
            dtpdob.CustomFormat = "yyyy/MM/dd";

            string gender;
            if(rdml.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            ddprd.Format = DateTimePickerFormat.Custom;
            ddprd.CustomFormat = "yyyy/MM/dd";

            con.Open();
            string query = "UPDATE Reg_lb set full_name ='"+txtfn.Text+"',Address ='"+txtadd.Text+"',dob ='"+dtpdob.Text+"',gender='"+gender+"',phone_number ='"+txtpn.Text+"',email_address ='"+txteml.Text+"',library_card_number ='"+txtlbc.Text+"',membership_type ='"+cmbmt.Text+"',bookname ='"+cmbbkn.Text+"',registration_date ='"+ddprd.Text+"' WHERE user_id ='"+textBox1.Text+"'";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Records updated successfully","Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
            textBox1.Clear();
            txtfn.Clear();
            txtadd.Clear();
            dtpdob.ResetText();
            rdml.Checked = false;
            rdfml.Checked = false;
            txtpn.Clear();
            txteml.Clear();
            txtlbc.Clear();
            cmbmt.ResetText();
            cmbbkn.ResetText();
            ddprd.ResetText();
            textBox1.Focus();
        }

        private void btn_srh_Click(object sender, EventArgs e)
        {
            //Search button codes
            con.Open();
            string query = "SELECT * from Reg_lb WHERE user_id ='" + textBox1.Text + "'";
            cmd = new SqlCommand(query, con);
            SqlDataReader Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                MessageBox.Show("Records found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtfn.Text = Dr["full_name"].ToString();
                txtadd.Text = Dr["Address"].ToString();
                dtpdob.Text = Dr["dob"].ToString();

                if (Dr["gender"].ToString() == "Male")
                {
                    rdml.Checked = true;
                }
                else if (Dr["gender"].ToString() == "Female")
                {
                    rdfml.Checked = true;
                }
                txtpn.Text = Dr["phone_number"].ToString();
                txteml.Text = Dr["email_address"].ToString();
                txtlbc.Text = Dr["library_card_number"].ToString();
                cmbmt.Text = Dr["membership_type"].ToString();
                cmbbkn.Text = Dr["bookname"].ToString();
                ddprd.Text = Dr["registration_date"].ToString();
            }
            con.Close();


        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txtfn.Clear();
            txtadd.Clear();
            dtpdob.ResetText();
            rdml.Checked = false;
            rdfml.Checked = false;
            txtpn.Clear();
            txteml.Clear();
            txtlbc.Clear();
            cmbmt.ResetText();
            cmbbkn.ResetText();
            ddprd.ResetText();
            textBox1.Focus();
            MessageBox.Show("Records cleared", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member_Records mb = new Member_Records();
            mb.Show();
            this.Hide();
        }
    }
}
