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
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SIEET30\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        SqlCommand cmd;
        public Employee()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * from Employee WHERE Emp_ID='"+cmb_emp.Text+"'";
                cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    txt_enm.Text = dr["Emp_Name"].ToString();
                    txt_dprt.Text = dr["Emp_Deparment"].ToString();
                    txt_add.Text = dr["Emp_Address"].ToString();
                    txt_eml.Text = dr["Emp_Email"].ToString();
                    txt_mnsl.Text = dr["Month_Salary"].ToString();
                    txt_orh.Text = dr["Overtime_rate_hour"].ToString();
                    txt_alw.Text = dr["Allowances"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found!","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception er)
            {

                MessageBox.Show("An Error occurred"+ er.Message);
            }
            con.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT into Employee values ('"+cmb_emp.Text+"','"+txt_enm.Text+"','"+txt_dprt.Text+"','"+txt_add.Text+"','"+txt_eml.Text+"','"+txt_mnsl.Text+"','"+txt_orh.Text+"','"+txt_alw.Text+"')";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Has been Inserted ","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cmb_emp.ResetText();
                txt_enm.Clear();
                txt_dprt.Clear();
                txt_add.Clear();
                txt_eml.Clear();
                txt_mnsl.Clear();
                txt_orh.Clear();
                txt_alw.Clear();
                cmb_emp.Focus();
                               
            }
            catch (Exception ins)
            {

                MessageBox.Show("An Error occurred"+ ins.Message);
            }
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Employee SET Emp_name='"+txt_enm.Text+"',Emp_Deparment='"+txt_dprt.Text+"',Emp_Address='"+txt_add.Text+"',Emp_Email='"+txt_eml.Text+"',Month_Salary='"+txt_mnsl.Text+"',Overtime_rate_hour='"+txt_orh.Text+"',Allowances='"+txt_alw.Text+"' WHERE Emp_ID='"+cmb_emp.Text+"'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Has been Updated","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cmb_emp.ResetText();
                txt_enm.Clear();
                txt_dprt.Clear();
                txt_add.Clear();
                txt_eml.Clear();
                txt_mnsl.Clear();
                txt_orh.Clear();
                txt_alw.Clear();
                cmb_emp.Focus();
                               
            }
            catch (Exception upt)
            {

                MessageBox.Show("An Error occurred"+ upt.Message);
            }
            con.Close();
           
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            var Delete = MessageBox.Show("Are you sure want to delete this record","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if(Delete==DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string query = "DELETE from Employee WHERE Emp_ID='"+cmb_emp.Text+"'";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Has been Deleted","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cmb_emp.ResetText();
                    txt_enm.Clear();
                    txt_dprt.Clear();
                    txt_add.Clear();
                    txt_eml.Clear();
                    txt_mnsl.Clear();
                    txt_orh.Clear();
                    txt_alw.Clear();
                    cmb_emp.Focus();
                }
                catch (Exception dlt)
                {

                    MessageBox.Show("An Error occurred"+ dlt.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Deletion process canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_emp.ResetText();
            txt_enm.Clear();
            txt_dprt.Clear();
            txt_add.Clear();
            txt_eml.Clear();
            txt_mnsl.Clear();
            txt_orh.Clear();
            txt_alw.Clear();
            cmb_emp.Focus();
        }

        

        private void btn_vwdt_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Employee";
            cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage Hmg = new Homepage();
            Hmg.Show();
            this.Hide();
        }
    }
}
