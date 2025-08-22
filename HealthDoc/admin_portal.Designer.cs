namespace HealthDoc
{
    partial class admin_portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_portal));
            this.lblpat = new System.Windows.Forms.Label();
            this.btnlgpat = new System.Windows.Forms.Button();
            this.btnrgpat = new System.Windows.Forms.Button();
            this.lbldoc = new System.Windows.Forms.Label();
            this.btnlgdoc = new System.Windows.Forms.Button();
            this.btnrgdoc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnupdatedelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblpat
            // 
            this.lblpat.AutoSize = true;
            this.lblpat.BackColor = System.Drawing.Color.Transparent;
            this.lblpat.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblpat.Location = new System.Drawing.Point(432, 155);
            this.lblpat.Name = "lblpat";
            this.lblpat.Size = new System.Drawing.Size(85, 19);
            this.lblpat.TabIndex = 73;
            this.lblpat.Text = "PATIENT";
            // 
            // btnlgpat
            // 
            this.btnlgpat.BackColor = System.Drawing.SystemColors.Control;
            this.btnlgpat.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlgpat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlgpat.Location = new System.Drawing.Point(481, 184);
            this.btnlgpat.Name = "btnlgpat";
            this.btnlgpat.Size = new System.Drawing.Size(126, 37);
            this.btnlgpat.TabIndex = 72;
            this.btnlgpat.Text = "Login";
            this.btnlgpat.UseVisualStyleBackColor = false;
            this.btnlgpat.Click += new System.EventHandler(this.btnlgpat_Click);
            // 
            // btnrgpat
            // 
            this.btnrgpat.BackColor = System.Drawing.SystemColors.Control;
            this.btnrgpat.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrgpat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrgpat.Location = new System.Drawing.Point(332, 184);
            this.btnrgpat.Name = "btnrgpat";
            this.btnrgpat.Size = new System.Drawing.Size(126, 37);
            this.btnrgpat.TabIndex = 71;
            this.btnrgpat.Text = "Register";
            this.btnrgpat.UseVisualStyleBackColor = false;
            this.btnrgpat.Click += new System.EventHandler(this.btnrgpat_Click);
            // 
            // lbldoc
            // 
            this.lbldoc.AutoSize = true;
            this.lbldoc.BackColor = System.Drawing.Color.Transparent;
            this.lbldoc.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbldoc.Location = new System.Drawing.Point(112, 155);
            this.lbldoc.Name = "lbldoc";
            this.lbldoc.Size = new System.Drawing.Size(83, 19);
            this.lbldoc.TabIndex = 70;
            this.lbldoc.Text = "DOCTOR";
            // 
            // btnlgdoc
            // 
            this.btnlgdoc.BackColor = System.Drawing.SystemColors.Control;
            this.btnlgdoc.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlgdoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlgdoc.Location = new System.Drawing.Point(161, 184);
            this.btnlgdoc.Name = "btnlgdoc";
            this.btnlgdoc.Size = new System.Drawing.Size(126, 37);
            this.btnlgdoc.TabIndex = 69;
            this.btnlgdoc.Text = "Login";
            this.btnlgdoc.UseVisualStyleBackColor = false;
            this.btnlgdoc.Click += new System.EventHandler(this.btnlgdoc_Click);
            // 
            // btnrgdoc
            // 
            this.btnrgdoc.BackColor = System.Drawing.SystemColors.Control;
            this.btnrgdoc.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrgdoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrgdoc.Location = new System.Drawing.Point(12, 184);
            this.btnrgdoc.Name = "btnrgdoc";
            this.btnrgdoc.Size = new System.Drawing.Size(126, 37);
            this.btnrgdoc.TabIndex = 68;
            this.btnrgdoc.Text = "Register";
            this.btnrgdoc.UseVisualStyleBackColor = false;
            this.btnrgdoc.Click += new System.EventHandler(this.btnrgdoc_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(603, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 75;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(258, 341);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 31);
            this.btnBack.TabIndex = 76;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnupdatedelete
            // 
            this.btnupdatedelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnupdatedelete.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatedelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnupdatedelete.Location = new System.Drawing.Point(397, 232);
            this.btnupdatedelete.Name = "btnupdatedelete";
            this.btnupdatedelete.Size = new System.Drawing.Size(165, 37);
            this.btnupdatedelete.TabIndex = 77;
            this.btnupdatedelete.Text = "Update / Delete";
            this.btnupdatedelete.UseVisualStyleBackColor = false;
            this.btnupdatedelete.Click += new System.EventHandler(this.btnupdatedelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(75, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 78;
            this.button1.Text = "Update / Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.BackColor = System.Drawing.Color.LightGray;
            this.lblDC.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDC.Location = new System.Drawing.Point(211, 9);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(232, 38);
            this.lblDC.TabIndex = 79;
            this.lblDC.Text = "HEALTHDOC";
            // 
            // admin_portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 384);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnupdatedelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblpat);
            this.Controls.Add(this.btnlgpat);
            this.Controls.Add(this.btnrgpat);
            this.Controls.Add(this.lbldoc);
            this.Controls.Add(this.btnlgdoc);
            this.Controls.Add(this.btnrgdoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Portal";
            this.Load += new System.EventHandler(this.Admin_Portal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpat;
        private System.Windows.Forms.Button btnlgpat;
        private System.Windows.Forms.Button btnrgpat;
        private System.Windows.Forms.Label lbldoc;
        private System.Windows.Forms.Button btnlgdoc;
        private System.Windows.Forms.Button btnrgdoc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnupdatedelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDC;
    }
}