using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//step 1
using System.Globalization;// step 2
using Microsoft.Reporting.WinForms;//step 3

namespace Grifindo_Toys
{
    public partial class Salary_Component : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SIEET30\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        //SqlCommand cmd;
        public Salary_Component()
        {
            InitializeComponent();
        }

        private void btn_lv_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * from Settings WHERE Settings_ID='" + txt_settingid.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Record Found", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ncd.Text = dr["No_of_Cycledays"].ToString();
                    txt_lpy.Text = dr["No_of_LeavesPerYear"].ToString();
                    txt_tax.Text = dr["Tax"].ToString();

                    DateTime Begindate = Convert.ToDateTime(dr["Begin_Date"]);
                    string MonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Begindate.Month);
                    txt_mnth.Text = MonthName; // Corrected: Set the Text property to the extracted month name

                    string yearName = Begindate.Year.ToString();
                    txt_year.Text = yearName;
                }
                else
                {
                    MessageBox.Show("Records not found!","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            con.Close();

            }
            catch (Exception cl)
            {

                MessageBox.Show("An Error Occurred" + cl.Message);
            }
                
        }

        private void btn_ccd_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                DateTime begin, end; // Variables to store start and end dates       
                TimeSpan SP;    // Variable to store time span between dates
                double total_days; // Variable to store total days between dates

                begin = DateTime.Parse(dtpsbd.Text);
                end = DateTime.Parse(dtpsed.Text);
                SP = end - begin;   //calculation process

                total_days = SP.Days;
                txt_ncd.Text = total_days.ToString(); //converting process

                DateTime sd = dtpsbd.Value;   // Get start date from DateTimePicker

                //extract month and year
                int month = sd.Month;       
                int year = sd.Year;         

                //display converted onth and year to textboxes
                txt_mnth.Text = month.ToString();       // Convert month to string and display in txt_mnth
                txt_year.Text = year.ToString();        // Convert year to string and display in txt_year
            }
            catch (Exception cal)
            {
                MessageBox.Show("An Error occurred while calculating the days" + cal.Message);
            }
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            try
            {
                dtpsbd.Format = DateTimePickerFormat.Custom;
                dtpsbd.CustomFormat = "yyyy/MM/dd";

                dtpsed.Format = DateTimePickerFormat.Custom;
                dtpsed.CustomFormat = "yyyy/MM/dd";

                con.Open();
                string query = "INSERT into Settings values('"+txt_settingid.Text+"','"+dtpsbd.Text+"','"+dtpsed.Text+"','"+txt_ncd.Text+"','"+txt_lpy.Text+"','"+txt_tax.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Has been Validated");
            }
            catch (Exception vl)
            {

                MessageBox.Show("An Error occurred while inserting data" + vl.Message);
            }
            con.Close();
        }

        private void btn_Deletevalues_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                var ans = MessageBox.Show("Are you sure want to delete","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(ans==DialogResult.Yes)
                {
                    string query = "DELETE from Settings WHERE Settings_ID='"+txt_settingid.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Has been Deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deletion process canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Dlt)
            {
                MessageBox.Show("An Error occurred while deleting the data!" + Dlt.Message);               
            }
            con.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * from Employee WHERE Emp_ID='"+cmb_eid.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    txt_empname.Text = dr["Emp_Name"].ToString();
                    txt_mnsalary.Text = dr["Month_Salary"].ToString();
                    txt_Otrt.Text = dr["Overtime_rate_hour"].ToString();
                    txt_allow.Text = dr["Allowances"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception Em)
            {
                MessageBox.Show("An Error occurred" + Em.Message);                
            }
        }

        private void btn_cd_Click(object sender, EventArgs e)
        {
            cmb_eid.ResetText();
            txt_empname.Clear();
            txt_mnsalary.Clear();
            txt_Otrt.Clear();
            txt_allow.Clear();
            cmb_eid.Focus();
        }

        private void btn_calculatesa_Click(object sender, EventArgs e)
        {
            try
            {
                int totalabsentdays;
                int leavesperyear = int.Parse(txt_lpy.Text);
                int leavestaken = int.Parse(txt_levtak.Text);

                if(leavestaken > leavesperyear)
                {
                    totalabsentdays = leavestaken - leavesperyear + int.Parse(txt_absentd.Text) + int.Parse(txt_holigiv.Text);
                    int remainingleaves = 0;
                    txt_rlev.Text = remainingleaves.ToString();

                }
                else
                {
                    totalabsentdays = int.Parse(txt_absentd.Text) + int.Parse(txt_holigiv.Text);
                    int remainingleaves = leavesperyear - leavestaken;
                    txt_rlev.Text = remainingleaves.ToString();

                }
                double tot_salary = (double.Parse(txt_mnsalary.Text));
                int salary_cycle_date_range = int.Parse(txt_ncd.Text);

                double base_pay_value = tot_salary + (double.Parse(txt_allow.Text)) + ((double.Parse(txt_Otrt.Text)) * (int.Parse(txt_addhw.Text)));
                txt_bpv.Text = base_pay_value.ToString();

                //Employee couldn't cover the salary cycle range (eg: 30days) attendance system might be calculate no pay value
                int Totaldays = int.Parse(txt_ncd.Text) - leavestaken - int.Parse(txt_absentd.Text) - int.Parse(txt_holigiv.Text);
                txt_wrkdy.Text = Totaldays.ToString();

                //salary cycle date range will be changed if holidays given
                int New_salary_cycle_range = int.Parse(txt_ncd.Text) - int.Parse(txt_holigiv.Text);
                txt_cdahg.Text = New_salary_cycle_range.ToString();

                if(Totaldays <= New_salary_cycle_range)
                {
                    double Nopayvalue = (tot_salary / New_salary_cycle_range) * (int.Parse(txt_absentd.Text));
                    txt_npv.Text = Nopayvalue.ToString();

                    float Tax = float.Parse(txt_tax.Text);
                    double Grosspay = base_pay_value - (Nopayvalue + (base_pay_value * Tax));
                    txt_gpv.Text = Grosspay.ToString();

                }
                else
                {
                    double Grosspay = base_pay_value - (base_pay_value * (int.Parse(txt_tax.Text)));
                    txt_gpv.Text = Grosspay.ToString();
                }
                
            }
            catch (Exception cc)
            {
                MessageBox.Show("An Error occurred"+ cc.Message);                
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT into Salary (Emp_ID,Emp_Name,Month,Year,No_pay_value,Base_pay_value,Gross_pay,Tot_worked_days,OT_Hours,Leaves_Taken,Absent_Days,Holidays_Given)VALUES ('"+cmb_eid.Text+"','"+txt_empname.Text+"','"+txt_mnth.Text+"','"+txt_year.Text+"','"+txt_npv.Text+"','"+txt_bpv.Text+"','"+txt_gpv.Text+"','"+txt_wrkdy.Text+"','"+txt_addhw.Text+"','"+txt_levtak.Text+"','"+txt_absentd.Text+"','"+txt_holigiv.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Has been Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception In)
            {
                MessageBox.Show("An Error occurred" + In.Message);
            }
            con.Close();

            try
            {
                con.Open();
                string query = "UPDATE Settings set No_of_LeavesPerYear='"+txt_lpy.Text+"' WHERE Settings_ID='"+txt_settingid.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception up)
            {
                MessageBox.Show("An Error occurred while updating settings" + up.Message);
            }
            con.Close();
        }

        private void Salary_Component_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            this.reportViewer1.RefreshReport();
          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage Hm = new Homepage();
            Hm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_settingid.Clear();
            dtpsbd.ResetText();
            dtpsed.ResetText();
            txt_mnth.Clear();
            txt_year.Clear();
            txt_ncd.Clear();
            txt_lpy.Clear();
            txt_tax.Clear();
            txt_settingid.Focus();
        }
    }
}
