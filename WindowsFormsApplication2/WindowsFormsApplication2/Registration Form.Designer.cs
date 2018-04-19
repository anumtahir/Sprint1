namespace WindowsFormsApplication2
{
    partial class login
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtHospitalname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.lbllogin = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(423, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtHospitalname
            // 
            this.txtHospitalname.Location = new System.Drawing.Point(140, 127);
            this.txtHospitalname.Name = "txtHospitalname";
            this.txtHospitalname.Size = new System.Drawing.Size(423, 20);
            this.txtHospitalname.TabIndex = 2;
            this.txtHospitalname.TextChanged += new System.EventHandler(this.txtHospitalname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(423, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(140, 49);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(423, 20);
            this.txtCNIC.TabIndex = 7;
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(55, 303);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(33, 13);
            this.lbllogin.TabIndex = 8;
            this.lbllogin.TabStop = true;
            this.lbllogin.Tag = "";
            this.lbllogin.Text = "Login";
            this.lbllogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllogin_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CNIC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Doctor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hospital Nmae";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(336, 209);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(36, 13);
            this.Admin.TabIndex = 16;
            this.Admin.Text = "Admin";
            this.Admin.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Paitent";
            // 
            // cmdRegister
            // 
            this.cmdRegister.Location = new System.Drawing.Point(397, 293);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(75, 23);
            this.cmdRegister.TabIndex = 18;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = true;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(164, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(140, 205);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(406, 211);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 356);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmdRegister);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtHospitalname);
            this.Controls.Add(this.txtPassword);
            this.Name = "login";
            this.Text = "Regiatration Form";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtHospitalname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.LinkLabel lbllogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}