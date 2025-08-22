namespace HealthDoc
{
    partial class patient_update_delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient_update_delete));
            this.lblpatientid = new System.Windows.Forms.Label();
            this.txtpatientid = new System.Windows.Forms.TextBox();
            this.lblpatientcontact = new System.Windows.Forms.Label();
            this.txtpatientcontact = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblARF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblpatientid
            // 
            this.lblpatientid.AutoSize = true;
            this.lblpatientid.BackColor = System.Drawing.Color.LightGray;
            this.lblpatientid.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientid.Location = new System.Drawing.Point(44, 117);
            this.lblpatientid.Name = "lblpatientid";
            this.lblpatientid.Size = new System.Drawing.Size(87, 18);
            this.lblpatientid.TabIndex = 69;
            this.lblpatientid.Text = "Patient ID";
            // 
            // txtpatientid
            // 
            this.txtpatientid.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpatientid.Location = new System.Drawing.Point(224, 114);
            this.txtpatientid.Name = "txtpatientid";
            this.txtpatientid.Size = new System.Drawing.Size(180, 23);
            this.txtpatientid.TabIndex = 68;
            // 
            // lblpatientcontact
            // 
            this.lblpatientcontact.AutoSize = true;
            this.lblpatientcontact.BackColor = System.Drawing.Color.LightGray;
            this.lblpatientcontact.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientcontact.Location = new System.Drawing.Point(44, 172);
            this.lblpatientcontact.Name = "lblpatientcontact";
            this.lblpatientcontact.Size = new System.Drawing.Size(70, 18);
            this.lblpatientcontact.TabIndex = 71;
            this.lblpatientcontact.Text = "Contact";
            // 
            // txtpatientcontact
            // 
            this.txtpatientcontact.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpatientcontact.Location = new System.Drawing.Point(224, 169);
            this.txtpatientcontact.Name = "txtpatientcontact";
            this.txtpatientcontact.Size = new System.Drawing.Size(180, 23);
            this.txtpatientcontact.TabIndex = 70;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(487, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 72;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(201, 288);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 31);
            this.btnBack.TabIndex = 74;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(358, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 31);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(47, 288);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(107, 31);
            this.btnupdate.TabIndex = 75;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblARF
            // 
            this.lblARF.AutoSize = true;
            this.lblARF.BackColor = System.Drawing.Color.Transparent;
            this.lblARF.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARF.Location = new System.Drawing.Point(80, 15);
            this.lblARF.Name = "lblARF";
            this.lblARF.Size = new System.Drawing.Size(296, 22);
            this.lblARF.TabIndex = 76;
            this.lblARF.Text = "PATIENT UPDATE / DELETE";
            // 
            // patient_update_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 341);
            this.Controls.Add(this.lblARF);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblpatientcontact);
            this.Controls.Add(this.txtpatientcontact);
            this.Controls.Add(this.lblpatientid);
            this.Controls.Add(this.txtpatientid);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "patient_update_delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patient_update_delete";
            this.Load += new System.EventHandler(this.patient_update_delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpatientid;
        private System.Windows.Forms.TextBox txtpatientid;
        private System.Windows.Forms.Label lblpatientcontact;
        private System.Windows.Forms.TextBox txtpatientcontact;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblARF;
    }
}