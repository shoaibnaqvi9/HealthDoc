namespace HealthDoc
{
    partial class doctor_registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctor_registration));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDRF = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblmsg2 = new System.Windows.Forms.Label();
            this.txtDoctorspecialization = new System.Windows.Forms.ComboBox();
            this.lblDoctoraddress = new System.Windows.Forms.Label();
            this.txtDoctoraddress = new System.Windows.Forms.TextBox();
            this.lblDoctorcontact = new System.Windows.Forms.Label();
            this.txtDoctorcontact = new System.Windows.Forms.TextBox();
            this.lblDoctorspecialization = new System.Windows.Forms.Label();
            this.lblDoctorname = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.txtDoctorname = new System.Windows.Forms.TextBox();
            this.txtDoctorid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(762, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDRF
            // 
            this.lblDRF.AutoSize = true;
            this.lblDRF.BackColor = System.Drawing.Color.Transparent;
            this.lblDRF.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDRF.Location = new System.Drawing.Point(53, 25);
            this.lblDRF.Name = "lblDRF";
            this.lblDRF.Size = new System.Drawing.Size(330, 22);
            this.lblDRF.TabIndex = 46;
            this.lblDRF.Text = "DOCTOR REGISTRATION FORM";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(216, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 31);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(57, 506);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 31);
            this.btnRegister.TabIndex = 47;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblmsg2
            // 
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg2.Font = new System.Drawing.Font("Bookman Old Style", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg2.Location = new System.Drawing.Point(167, 282);
            this.lblmsg2.Name = "lblmsg2";
            this.lblmsg2.Size = new System.Drawing.Size(90, 13);
            this.lblmsg2.TabIndex = 59;
            this.lblmsg2.Text = "*must be 12 digits";
            // 
            // txtDoctorspecialization
            // 
            this.txtDoctorspecialization.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.txtDoctorspecialization.FormattingEnabled = true;
            this.txtDoctorspecialization.Items.AddRange(new object[] {
            "Internal Medicine",
            "Pediatrics",
            "Surgery",
            "Obstetrics and Gynecology",
            "Psychiatry",
            "Anesthesiology",
            "Radiology",
            "Emergency Medicine",
            "Neurology",
            "Orthopedics",
            "Dermatology",
            "Ophthalmology",
            "Pathology",
            "Oncology",
            "Cardiology"});
            this.txtDoctorspecialization.Location = new System.Drawing.Point(170, 210);
            this.txtDoctorspecialization.Name = "txtDoctorspecialization";
            this.txtDoctorspecialization.Size = new System.Drawing.Size(132, 26);
            this.txtDoctorspecialization.TabIndex = 58;
            // 
            // lblDoctoraddress
            // 
            this.lblDoctoraddress.AutoSize = true;
            this.lblDoctoraddress.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctoraddress.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctoraddress.Location = new System.Drawing.Point(29, 306);
            this.lblDoctoraddress.Name = "lblDoctoraddress";
            this.lblDoctoraddress.Size = new System.Drawing.Size(69, 18);
            this.lblDoctoraddress.TabIndex = 57;
            this.lblDoctoraddress.Text = "Address";
            // 
            // txtDoctoraddress
            // 
            this.txtDoctoraddress.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctoraddress.Location = new System.Drawing.Point(170, 303);
            this.txtDoctoraddress.Name = "txtDoctoraddress";
            this.txtDoctoraddress.Size = new System.Drawing.Size(179, 23);
            this.txtDoctoraddress.TabIndex = 56;
            // 
            // lblDoctorcontact
            // 
            this.lblDoctorcontact.AutoSize = true;
            this.lblDoctorcontact.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorcontact.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorcontact.Location = new System.Drawing.Point(29, 261);
            this.lblDoctorcontact.Name = "lblDoctorcontact";
            this.lblDoctorcontact.Size = new System.Drawing.Size(70, 18);
            this.lblDoctorcontact.TabIndex = 55;
            this.lblDoctorcontact.Text = "Contact";
            // 
            // txtDoctorcontact
            // 
            this.txtDoctorcontact.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorcontact.Location = new System.Drawing.Point(170, 258);
            this.txtDoctorcontact.Name = "txtDoctorcontact";
            this.txtDoctorcontact.Size = new System.Drawing.Size(179, 23);
            this.txtDoctorcontact.TabIndex = 54;
            // 
            // lblDoctorspecialization
            // 
            this.lblDoctorspecialization.AutoSize = true;
            this.lblDoctorspecialization.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorspecialization.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorspecialization.Location = new System.Drawing.Point(29, 213);
            this.lblDoctorspecialization.Name = "lblDoctorspecialization";
            this.lblDoctorspecialization.Size = new System.Drawing.Size(117, 18);
            this.lblDoctorspecialization.TabIndex = 53;
            this.lblDoctorspecialization.Text = "Specialization";
            // 
            // lblDoctorname
            // 
            this.lblDoctorname.AutoSize = true;
            this.lblDoctorname.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorname.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorname.Location = new System.Drawing.Point(29, 168);
            this.lblDoctorname.Name = "lblDoctorname";
            this.lblDoctorname.Size = new System.Drawing.Size(109, 18);
            this.lblDoctorname.TabIndex = 52;
            this.lblDoctorname.Text = "Doctor Name";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorID.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(29, 123);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(82, 18);
            this.lblDoctorID.TabIndex = 51;
            this.lblDoctorID.Text = "Doctor ID";
            // 
            // txtDoctorname
            // 
            this.txtDoctorname.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorname.Location = new System.Drawing.Point(170, 165);
            this.txtDoctorname.Name = "txtDoctorname";
            this.txtDoctorname.Size = new System.Drawing.Size(196, 23);
            this.txtDoctorname.TabIndex = 50;
            // 
            // txtDoctorid
            // 
            this.txtDoctorid.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorid.Location = new System.Drawing.Point(170, 120);
            this.txtDoctorid.Name = "txtDoctorid";
            this.txtDoctorid.Size = new System.Drawing.Size(132, 23);
            this.txtDoctorid.TabIndex = 49;
            // 
            // doctor_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 563);
            this.Controls.Add(this.lblmsg2);
            this.Controls.Add(this.txtDoctorspecialization);
            this.Controls.Add(this.lblDoctoraddress);
            this.Controls.Add(this.txtDoctoraddress);
            this.Controls.Add(this.lblDoctorcontact);
            this.Controls.Add(this.txtDoctorcontact);
            this.Controls.Add(this.lblDoctorspecialization);
            this.Controls.Add(this.lblDoctorname);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.txtDoctorname);
            this.Controls.Add(this.txtDoctorid);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblDRF);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doctor_registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doctor_registration";
            this.Load += new System.EventHandler(this.doctor_registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDRF;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblmsg2;
        private System.Windows.Forms.ComboBox txtDoctorspecialization;
        private System.Windows.Forms.Label lblDoctoraddress;
        private System.Windows.Forms.TextBox txtDoctoraddress;
        private System.Windows.Forms.Label lblDoctorcontact;
        private System.Windows.Forms.TextBox txtDoctorcontact;
        private System.Windows.Forms.Label lblDoctorspecialization;
        private System.Windows.Forms.Label lblDoctorname;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.TextBox txtDoctorname;
        private System.Windows.Forms.TextBox txtDoctorid;
    }
}