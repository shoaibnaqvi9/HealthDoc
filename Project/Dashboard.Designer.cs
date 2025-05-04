namespace HealthDoc
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblDC = new System.Windows.Forms.Label();
            this.lblMS = new System.Windows.Forms.Label();
            this.lbladm = new System.Windows.Forms.Label();
            this.btnlgadm = new System.Windows.Forms.Button();
            this.btnrgadm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.BackColor = System.Drawing.Color.LightGray;
            this.lblDC.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDC.Location = new System.Drawing.Point(113, 21);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(304, 28);
            this.lblDC.TabIndex = 60;
            this.lblDC.Text = "DOCTOR CONSULTANT";
            // 
            // lblMS
            // 
            this.lblMS.AutoSize = true;
            this.lblMS.BackColor = System.Drawing.Color.LightGray;
            this.lblMS.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMS.Location = new System.Drawing.Point(107, 54);
            this.lblMS.Name = "lblMS";
            this.lblMS.Size = new System.Drawing.Size(312, 28);
            this.lblMS.TabIndex = 61;
            this.lblMS.Text = "MANAGEMENT SYSTEM";
            // 
            // lbladm
            // 
            this.lbladm.AutoSize = true;
            this.lbladm.BackColor = System.Drawing.Color.Transparent;
            this.lbladm.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbladm.Location = new System.Drawing.Point(224, 297);
            this.lbladm.Name = "lbladm";
            this.lbladm.Size = new System.Drawing.Size(78, 22);
            this.lbladm.TabIndex = 70;
            this.lbladm.Text = "ADMIN";
            // 
            // btnlgadm
            // 
            this.btnlgadm.BackColor = System.Drawing.SystemColors.Control;
            this.btnlgadm.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlgadm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlgadm.Location = new System.Drawing.Point(308, 291);
            this.btnlgadm.Name = "btnlgadm";
            this.btnlgadm.Size = new System.Drawing.Size(126, 37);
            this.btnlgadm.TabIndex = 69;
            this.btnlgadm.Text = "Login";
            this.btnlgadm.UseVisualStyleBackColor = false;
            this.btnlgadm.Click += new System.EventHandler(this.btnlgadm_Click);
            // 
            // btnrgadm
            // 
            this.btnrgadm.BackColor = System.Drawing.SystemColors.Control;
            this.btnrgadm.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrgadm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrgadm.Location = new System.Drawing.Point(94, 291);
            this.btnrgadm.Name = "btnrgadm";
            this.btnrgadm.Size = new System.Drawing.Size(126, 37);
            this.btnrgadm.TabIndex = 68;
            this.btnrgadm.Text = "Register";
            this.btnrgadm.UseVisualStyleBackColor = false;
            this.btnrgadm.Click += new System.EventHandler(this.btnrgadm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(633, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 71;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(513, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 72;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 380);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbladm);
            this.Controls.Add(this.btnlgadm);
            this.Controls.Add(this.btnrgadm);
            this.Controls.Add(this.lblMS);
            this.Controls.Add(this.lblDC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblMS;
        private System.Windows.Forms.Label lbladm;
        private System.Windows.Forms.Button btnlgadm;
        private System.Windows.Forms.Button btnrgadm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExit;
    }
}