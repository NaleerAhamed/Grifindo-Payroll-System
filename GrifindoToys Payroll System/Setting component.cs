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
    public partial class Setting_component : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SIEET30\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        SqlCommand cmd;
        public Setting_component()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlsearch = "SELECT * from Settings WHERE Settings_ID='"+cmb_settingid.Text+"' ";
                SqlCommand cmd = new SqlCommand(sqlsearch, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("Record Found", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtp_salary_cyclebd.Text = dr["Begin_Date"].ToString();
                    dtp_salary_cycleed.Text = dr["End_Date"].ToString();
                    txt_no_of_cycledays.Text = dr["No_of_Cycledays"].ToString();
                    txt_leavesperyear.Text = dr["No_of_LeavesPerYear"].ToString();
                    txt_tax.Text = dr["Tax"].ToString();
                }
                else
                {
                    MessageBox.Show("Records not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Sr)
            {
                MessageBox.Show("An Error occurred while searching record!" + Sr.Message);
            }
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                dtp_salary_cyclebd.Format = DateTimePickerFormat.Custom;
                dtp_salary_cyclebd.CustomFormat = "yyyy/MM/dd";

                dtp_salary_cycleed.Format = DateTimePickerFormat.Custom;
                dtp_salary_cycleed.CustomFormat = "yyyy/MM/dd";

                con.Open();
                string sqlupdate = "UPDATE Settings SET Begin_Date='" + dtp_salary_cyclebd.Text + "',End_Date='" + dtp_salary_cycleed.Text + "',No_of_Cycledays='" + txt_no_of_cycledays.Text + "',No_of_LeavesPerYear='" + txt_leavesperyear.Text + "',Tax='" + txt_tax.Text + "'WHERE Settings_ID='" + cmb_settingid.Text + "'";
                cmd = new SqlCommand(sqlupdate, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Has been Updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Up)
            {
                MessageBox.Show("An Error occurred" + Up.Message); 
            }
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_settingid.ResetText();
            dtp_salary_cyclebd.ResetText();
            dtp_salary_cycleed.ResetText();
            txt_no_of_cycledays.Clear();
            txt_leavesperyear.Clear();
            txt_tax.Clear();
            cmb_settingid.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Are you sure want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Exit cancled", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage Hmgp = new Homepage();
            Hmgp.Show();
            this.Hide();
        }
    }
}
