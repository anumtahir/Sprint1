namespace WindowsFormsApplication5
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cmdTimimgs = new System.Windows.Forms.Button();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdResetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(37, 127);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(32, 13);
            this.lblCNIC.TabIndex = 1;
            this.lblCNIC.Text = "CNIC";
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Location = new System.Drawing.Point(37, 172);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(76, 13);
            this.lblHospital.TabIndex = 2;
            this.lblHospital.Text = "Hospital Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(37, 219);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(152, 122);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(295, 20);
            this.txtCNIC.TabIndex = 5;
            // 
            // txtHospital
            // 
            this.txtHospital.Location = new System.Drawing.Point(153, 169);
            this.txtHospital.Name = "txtHospital";
            this.txtHospital.Size = new System.Drawing.Size(295, 20);
            this.txtHospital.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(153, 215);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(294, 20);
            this.txtDate.TabIndex = 7;
            // 
            // cmdTimimgs
            // 
            this.cmdTimimgs.Location = new System.Drawing.Point(426, 20);
            this.cmdTimimgs.Name = "cmdTimimgs";
            this.cmdTimimgs.Size = new System.Drawing.Size(137, 31);
            this.cmdTimimgs.TabIndex = 8;
            this.cmdTimimgs.Text = "Timings";
            this.cmdTimimgs.UseVisualStyleBackColor = true;
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(110, 332);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(170, 39);
            this.cmdLogin.TabIndex = 9;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            // 
            // cmdResetPassword
            // 
            this.cmdResetPassword.Location = new System.Drawing.Point(363, 332);
            this.cmdResetPassword.Name = "cmdResetPassword";
            this.cmdResetPassword.Size = new System.Drawing.Size(171, 38);
            this.cmdResetPassword.TabIndex = 10;
            this.cmdResetPassword.Text = "Reset Password";
            this.cmdResetPassword.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 441);
            this.Controls.Add(this.cmdResetPassword);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.cmdTimimgs);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtHospital);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHospital);
            this.Controls.Add(this.lblCNIC);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button cmdTimimgs;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Button cmdResetPassword;
    }
}

