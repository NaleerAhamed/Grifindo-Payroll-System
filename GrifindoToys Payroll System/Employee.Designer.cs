namespace Grifindo_Toys
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_dlt = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_alw = new System.Windows.Forms.TextBox();
            this.txt_orh = new System.Windows.Forms.TextBox();
            this.txt_mnsl = new System.Windows.Forms.TextBox();
            this.txt_eml = new System.Windows.Forms.TextBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.txt_dprt = new System.Windows.Forms.TextBox();
            this.txt_enm = new System.Windows.Forms.TextBox();
            this.cmb_emp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_vwdt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_dlt);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_alw);
            this.groupBox1.Controls.Add(this.txt_orh);
            this.groupBox1.Controls.Add(this.txt_mnsl);
            this.groupBox1.Controls.Add(this.txt_eml);
            this.groupBox1.Controls.Add(this.txt_add);
            this.groupBox1.Controls.Add(this.txt_dprt);
            this.groupBox1.Controls.Add(this.txt_enm);
            this.groupBox1.Controls.Add(this.cmb_emp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Info";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Location = new System.Drawing.Point(506, 297);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(126, 24);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_dlt
            // 
            this.btn_dlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_dlt.FlatAppearance.BorderSize = 0;
            this.btn_dlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_dlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dlt.Location = new System.Drawing.Point(506, 246);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(126, 24);
            this.btn_dlt.TabIndex = 19;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseVisualStyleBackColor = false;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(506, 192);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(126, 24);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_insert.FlatAppearance.BorderSize = 0;
            this.btn_insert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Location = new System.Drawing.Point(506, 137);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(126, 24);
            this.btn_insert.TabIndex = 17;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(506, 80);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(126, 24);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_alw
            // 
            this.txt_alw.Location = new System.Drawing.Point(160, 317);
            this.txt_alw.Name = "txt_alw";
            this.txt_alw.Size = new System.Drawing.Size(213, 24);
            this.txt_alw.TabIndex = 15;
            // 
            // txt_orh
            // 
            this.txt_orh.Location = new System.Drawing.Point(160, 277);
            this.txt_orh.Name = "txt_orh";
            this.txt_orh.Size = new System.Drawing.Size(213, 24);
            this.txt_orh.TabIndex = 14;
            // 
            // txt_mnsl
            // 
            this.txt_mnsl.Location = new System.Drawing.Point(160, 234);
            this.txt_mnsl.Name = "txt_mnsl";
            this.txt_mnsl.Size = new System.Drawing.Size(213, 24);
            this.txt_mnsl.TabIndex = 13;
            // 
            // txt_eml
            // 
            this.txt_eml.Location = new System.Drawing.Point(160, 198);
            this.txt_eml.Name = "txt_eml";
            this.txt_eml.Size = new System.Drawing.Size(213, 24);
            this.txt_eml.TabIndex = 12;
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(160, 164);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(213, 24);
            this.txt_add.TabIndex = 11;
            // 
            // txt_dprt
            // 
            this.txt_dprt.Location = new System.Drawing.Point(160, 125);
            this.txt_dprt.Name = "txt_dprt";
            this.txt_dprt.Size = new System.Drawing.Size(213, 24);
            this.txt_dprt.TabIndex = 10;
            // 
            // txt_enm
            // 
            this.txt_enm.Location = new System.Drawing.Point(160, 80);
            this.txt_enm.Name = "txt_enm";
            this.txt_enm.Size = new System.Drawing.Size(213, 24);
            this.txt_enm.TabIndex = 9;
            // 
            // cmb_emp
            // 
            this.cmb_emp.FormattingEnabled = true;
            this.cmb_emp.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07"});
            this.cmb_emp.Location = new System.Drawing.Point(160, 33);
            this.cmb_emp.Name = "cmb_emp";
            this.cmb_emp.Size = new System.Drawing.Size(213, 26);
            this.cmb_emp.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Allowances :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Overtime Rate Hour :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Month Salary :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID :";
            // 
            // btn_vwdt
            // 
            this.btn_vwdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_vwdt.FlatAppearance.BorderSize = 0;
            this.btn_vwdt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_vwdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vwdt.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vwdt.Location = new System.Drawing.Point(56, 437);
            this.btn_vwdt.Name = "btn_vwdt";
            this.btn_vwdt.Size = new System.Drawing.Size(211, 24);
            this.btn_vwdt.TabIndex = 20;
            this.btn_vwdt.Text = "View Employee Data";
            this.btn_vwdt.UseVisualStyleBackColor = false;
            this.btn_vwdt.Click += new System.EventHandler(this.btn_vwdt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 467);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 249);
            this.dataGridView1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 24);
            this.button1.TabIndex = 21;
            this.button1.Text = "Bact to Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 727);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_vwdt);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employee";
            this.Text = "Employee Component";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_alw;
        private System.Windows.Forms.TextBox txt_orh;
        private System.Windows.Forms.TextBox txt_mnsl;
        private System.Windows.Forms.TextBox txt_eml;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.TextBox txt_dprt;
        private System.Windows.Forms.TextBox txt_enm;
        private System.Windows.Forms.ComboBox cmb_emp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dlt;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_vwdt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button1;
    }
}