namespace simplepms
{
    partial class frmViewLicense
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
            this.txtLicenseText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLicenseText
            // 
            this.txtLicenseText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLicenseText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseText.Location = new System.Drawing.Point(0, 0);
            this.txtLicenseText.Multiline = true;
            this.txtLicenseText.Name = "txtLicenseText";
            this.txtLicenseText.ReadOnly = true;
            this.txtLicenseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLicenseText.Size = new System.Drawing.Size(513, 389);
            this.txtLicenseText.TabIndex = 0;
            // 
            // frmViewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 389);
            this.Controls.Add(this.txtLicenseText);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmViewLicense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View License";
            this.Load += new System.EventHandler(this.frmViewLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLicenseText;
    }
}