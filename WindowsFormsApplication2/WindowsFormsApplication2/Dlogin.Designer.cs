namespace WindowsFormsApplication2
{
    partial class Dlogin
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
            this.txtDoctorname = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtHospitalname = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.CNIC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDoctorname
            // 
            this.txtDoctorname.Location = new System.Drawing.Point(175, 88);
            this.txtDoctorname.Name = "txtDoctorname";
            this.txtDoctorname.Size = new System.Drawing.Size(422, 20);
            this.txtDoctorname.TabIndex = 0;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(175, 115);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(215, 20);
            this.txtCNIC.TabIndex = 1;
            this.txtCNIC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtHospitalname
            // 
            this.txtHospitalname.Location = new System.Drawing.Point(175, 141);
            this.txtHospitalname.Name = "txtHospitalname";
            this.txtHospitalname.Size = new System.Drawing.Size(422, 20);
            this.txtHospitalname.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(175, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(175, 198);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(215, 20);
            this.textBox5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(519, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Timings";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(52, 268);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(46, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Register";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // CNIC
            // 
            this.CNIC.AutoSize = true;
            this.CNIC.Location = new System.Drawing.Point(72, 115);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(32, 13);
            this.CNIC.TabIndex = 9;
            this.CNIC.Text = "CNIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hospital Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date";
            // 
            // Dlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CNIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtHospitalname);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtDoctorname);
            this.Name = "Dlogin";
            this.Text = "Dlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoctorname;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtHospitalname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}