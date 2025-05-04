namespace HealthDoc
{
    partial class patient_appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient_appointment));
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPRF = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAppoint = new System.Windows.Forms.Button();
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.lblDateofAppointment = new System.Windows.Forms.Label();
            this.dtpAppoint = new System.Windows.Forms.DateTimePicker();
            this.lblAppointmentpurpose = new System.Windows.Forms.Label();
            this.rtbAppointmentpurpose = new System.Windows.Forms.RichTextBox();
            this.lblPatient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(863, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Note: OPD Schedule is for Reference only. Kindly contact Admin.";
            // 
            // lblPRF
            // 
            this.lblPRF.AutoSize = true;
            this.lblPRF.BackColor = System.Drawing.Color.Transparent;
            this.lblPRF.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPRF.Location = new System.Drawing.Point(12, 12);
            this.lblPRF.Name = "lblPRF";
            this.lblPRF.Size = new System.Drawing.Size(219, 28);
            this.lblPRF.TabIndex = 53;
            this.lblPRF.Text = "FIND A DOCTOR";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(571, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 31);
            this.btnExit.TabIndex = 54;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(406, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 31);
            this.btnBack.TabIndex = 55;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Doctors";
            // 
            // btnAppoint
            // 
            this.btnAppoint.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppoint.Location = new System.Drawing.Point(244, 407);
            this.btnAppoint.Name = "btnAppoint";
            this.btnAppoint.Size = new System.Drawing.Size(107, 31);
            this.btnAppoint.TabIndex = 57;
            this.btnAppoint.Text = "Appoint";
            this.btnAppoint.UseVisualStyleBackColor = true;
            this.btnAppoint.Click += new System.EventHandler(this.btnAppoint_Click);
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvDoctor.Location = new System.Drawing.Point(39, 153);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.Size = new System.Drawing.Size(362, 238);
            this.dgvDoctor.TabIndex = 58;
            this.dgvDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctor_CellContentClick);
            // 
            // lblDateofAppointment
            // 
            this.lblDateofAppointment.AutoSize = true;
            this.lblDateofAppointment.BackColor = System.Drawing.Color.Transparent;
            this.lblDateofAppointment.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofAppointment.Location = new System.Drawing.Point(450, 167);
            this.lblDateofAppointment.Name = "lblDateofAppointment";
            this.lblDateofAppointment.Size = new System.Drawing.Size(170, 18);
            this.lblDateofAppointment.TabIndex = 68;
            this.lblDateofAppointment.Text = "Date of Appointment";
            // 
            // dtpAppoint
            // 
            this.dtpAppoint.CalendarFont = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.dtpAppoint.Location = new System.Drawing.Point(636, 164);
            this.dtpAppoint.Name = "dtpAppoint";
            this.dtpAppoint.Size = new System.Drawing.Size(200, 20);
            this.dtpAppoint.TabIndex = 69;
            this.dtpAppoint.ValueChanged += new System.EventHandler(this.dtpAppoint_ValueChanged);
            // 
            // lblAppointmentpurpose
            // 
            this.lblAppointmentpurpose.AutoSize = true;
            this.lblAppointmentpurpose.BackColor = System.Drawing.Color.Transparent;
            this.lblAppointmentpurpose.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentpurpose.Location = new System.Drawing.Point(450, 211);
            this.lblAppointmentpurpose.Name = "lblAppointmentpurpose";
            this.lblAppointmentpurpose.Size = new System.Drawing.Size(176, 18);
            this.lblAppointmentpurpose.TabIndex = 71;
            this.lblAppointmentpurpose.Text = "Appointment Purpose";
            // 
            // rtbAppointmentpurpose
            // 
            this.rtbAppointmentpurpose.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.rtbAppointmentpurpose.Location = new System.Drawing.Point(636, 211);
            this.rtbAppointmentpurpose.Name = "rtbAppointmentpurpose";
            this.rtbAppointmentpurpose.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbAppointmentpurpose.Size = new System.Drawing.Size(200, 69);
            this.rtbAppointmentpurpose.TabIndex = 72;
            this.rtbAppointmentpurpose.Text = "";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.BackColor = System.Drawing.Color.Transparent;
            this.lblPatient.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPatient.Location = new System.Drawing.Point(84, 84);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(0, 20);
            this.lblPatient.TabIndex = 73;
            // 
            // patient_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.rtbAppointmentpurpose);
            this.Controls.Add(this.lblAppointmentpurpose);
            this.Controls.Add(this.dtpAppoint);
            this.Controls.Add(this.lblDateofAppointment);
            this.Controls.Add(this.dgvDoctor);
            this.Controls.Add(this.btnAppoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPRF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "patient_appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patient_appointment";
            this.Load += new System.EventHandler(this.patient_appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPRF;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAppoint;
        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.Label lblDateofAppointment;
        private System.Windows.Forms.DateTimePicker dtpAppoint;
        private System.Windows.Forms.Label lblAppointmentpurpose;
        private System.Windows.Forms.RichTextBox rtbAppointmentpurpose;
        private System.Windows.Forms.Label lblPatient;
    }
}