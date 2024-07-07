using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            Employee Emp = new Employee();
            Emp.Show();
            this.Hide();
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            Salary_Component sc = new Salary_Component();
            sc.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Are you sure want to exit","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(exit==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Exit cancled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btb_setting_Click(object sender, EventArgs e)
        {
            Setting_component setting = new Setting_component();
            setting.Show();
            this.Hide();
        }
    }
}
