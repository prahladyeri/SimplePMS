namespace simplepms
{
    partial class frmQuitMinimize
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
            this.cmdMinimize = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdMinimize
            // 
            this.cmdMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdMinimize.Location = new System.Drawing.Point(12, 12);
            this.cmdMinimize.Name = "cmdMinimize";
            this.cmdMinimize.Size = new System.Drawing.Size(129, 31);
            this.cmdMinimize.TabIndex = 0;
            this.cmdMinimize.Text = "Minimize to Tray";
            this.cmdMinimize.UseVisualStyleBackColor = true;
            // 
            // cmdQuit
            // 
            this.cmdQuit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdQuit.Location = new System.Drawing.Point(147, 12);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(129, 31);
            this.cmdQuit.TabIndex = 1;
            this.cmdQuit.Text = "Quit";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // frmQuitMinimize
            // 
            this.AcceptButton = this.cmdQuit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdMinimize;
            this.ClientSize = new System.Drawing.Size(290, 59);
            this.ControlBox = false;
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdMinimize);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQuitMinimize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmQuitMinimize_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdMinimize;
        private System.Windows.Forms.Button cmdQuit;
    }
}