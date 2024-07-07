namespace Grifindo_Toys
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_un = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.btn_lg = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grifindo Toys";
            // 
            // txt_un
            // 
            this.txt_un.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_un.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_un.Location = new System.Drawing.Point(204, 137);
            this.txt_un.Multiline = true;
            this.txt_un.Name = "txt_un";
            this.txt_un.Size = new System.Drawing.Size(161, 22);
            this.txt_un.TabIndex = 3;
            // 
            // txt_pw
            // 
            this.txt_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pw.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pw.Location = new System.Drawing.Point(204, 205);
            this.txt_pw.Multiline = true;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(161, 22);
            this.txt_pw.TabIndex = 4;
            // 
            // btn_lg
            // 
            this.btn_lg.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_lg.FlatAppearance.BorderSize = 0;
            this.btn_lg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btn_lg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lg.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lg.ForeColor = System.Drawing.Color.Black;
            this.btn_lg.Location = new System.Drawing.Point(204, 286);
            this.btn_lg.Name = "btn_lg";
            this.btn_lg.Size = new System.Drawing.Size(75, 30);
            this.btn_lg.TabIndex = 5;
            this.btn_lg.Text = "Log in";
            this.btn_lg.UseVisualStyleBackColor = false;
            this.btn_lg.Click += new System.EventHandler(this.btn_lg_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_clr.FlatAppearance.BorderSize = 0;
            this.btn_clr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btn_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clr.ForeColor = System.Drawing.Color.Black;
            this.btn_clr.Location = new System.Drawing.Point(308, 286);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(75, 30);
            this.btn_clr.TabIndex = 6;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = false;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(103, 286);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 30);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 285);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(175, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(482, 436);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_lg);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_un);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_un;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Button btn_lg;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

