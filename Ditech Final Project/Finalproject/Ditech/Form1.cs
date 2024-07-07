using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ditech
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var ex = MessageBox.Show("Are you sure want to exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (ex == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }
    }
}
