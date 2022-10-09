using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace simplepms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //string[] ver = Application.ProductVersion.Split('.');
            //string[] ver = Assembly.GetExecutingAssembly().GetName().Version.ToString().Split('.');
            //string[] ver = vname.Split('.');
            Version ver = Assembly.GetExecutingAssembly().GetName().Version;
            //MessageBox.Show(vname);
            this.Text += string.Format(" ({0}.{1})", ver.Major, ver.Minor) + "";
            //test
            //this.pictureBox1.Image = this.Icon.ToBitmap(); //@todo: remove later
            //IntPtr hicon = ((Bitmap)pictureBox1.Image).GetHicon();
            //Application.resourse
            //this.Icon = Icon.FromHandle(hicon);
            this.notifyIcon1.Icon = this.Icon;

            //for (int i = 1; i < tabControl1.TabCount; i++) {
            //    tabControl1.TabPages.RemoveAt(i);
            //}
            lblStatus.Text = "Ready";
            //timer1.Start();
            notifyIcon1.ShowBalloonTip(20000, Application.ProductName, "I am running in the system tray.", ToolTipIcon.Info);
        }




        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Icon = this.Icon;
            about.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
