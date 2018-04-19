namespace WindowsFormsApplication2
{
    partial class Reset_Password
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdPassword = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(193, 90);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(230, 20);
            this.txtCNIC.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(193, 127);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(230, 20);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // cmdPassword
            // 
            this.cmdPassword.Location = new System.Drawing.Point(333, 204);
            this.cmdPassword.Name = "cmdPassword";
            this.cmdPassword.Size = new System.Drawing.Size(117, 23);
            this.cmdPassword.TabIndex = 6;
            this.cmdPassword.Text = "Confirm Password";
            this.cmdPassword.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(24, 209);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.TabStop = true;
            this.lblLogin.Text = "Login";
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.cmdPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtName);
            this.Name = "Reset_Password";
            this.Text = "Reset_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdPassword;
        private System.Windows.Forms.LinkLabel lblLogin;
    }
}