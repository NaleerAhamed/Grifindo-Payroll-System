using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Global variables
        int No1,No2, Output; 

        private void btn_sub_Click(object sender, EventArgs e)
        {
            No1 = int.Parse(txt_no1.Text);
            No2 = int.Parse(txt_no2.Text);
            Output = No1 - No2;
            txt_output.Text = Output.ToString();
                  
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            No1 = int.Parse(txt_no1.Text);
            No2 = int.Parse(txt_no2.Text);
            Output = No1 * No2;
            txt_output.Text = Output.ToString();
                       
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            float Output; //Local variable
            No1 = int.Parse(txt_no1.Text);
            No2 = int.Parse(txt_no2.Text);
            Output =(float) No1 / No2;
            txt_output.Text = Output.ToString();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_no1.Clear();
            txt_no2.Clear();
            txt_output.Clear();
            txt_no1.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var Exit = MessageBox.Show("Are you sure want to exit!","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(Exit== DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Exit canceled.","Infromation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            No1 = int.Parse(txt_no1.Text);
            No2 = int.Parse(txt_no2.Text);
            Output = No1 + No2;
            txt_output.Text = Output.ToString();
                       
        }
    }
}

