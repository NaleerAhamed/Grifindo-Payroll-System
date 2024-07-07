namespace Grifindo_Toys
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btb_setting = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Grifindo Toys";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(86, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btb_setting);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_salary);
            this.panel1.Controls.Add(this.btn_employee);
            this.panel1.Location = new System.Drawing.Point(62, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 256);
            this.panel1.TabIndex = 0;
            // 
            // btb_setting
            // 
            this.btb_setting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btb_setting.FlatAppearance.BorderSize = 0;
            this.btb_setting.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_setting.Location = new System.Drawing.Point(20, 145);
            this.btb_setting.Name = "btb_setting";
            this.btb_setting.Size = new System.Drawing.Size(225, 36);
            this.btb_setting.TabIndex = 3;
            this.btb_setting.Text = "Setting";
            this.btb_setting.UseVisualStyleBackColor = false;
            this.btb_setting.Click += new System.EventHandler(this.btb_setting_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(20, 200);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(225, 36);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_salary
            // 
            this.btn_salary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_salary.FlatAppearance.BorderSize = 0;
            this.btn_salary.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salary.Location = new System.Drawing.Point(20, 84);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(225, 36);
            this.btn_salary.TabIndex = 1;
            this.btn_salary.Text = "Salary";
            this.btn_salary.UseVisualStyleBackColor = false;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_employee.FlatAppearance.BorderSize = 0;
            this.btn_employee.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.Location = new System.Drawing.Point(20, 14);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(225, 36);
            this.btn_employee.TabIndex = 0;
            this.btn_employee.Text = "Employee";
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(583, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btb_setting;
    }
}