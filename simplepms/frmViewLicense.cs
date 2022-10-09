using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simplepms
{
    public partial class frmViewLicense : Form
    {
        //public string LicenseText = "";

        public frmViewLicense()
        {
            InitializeComponent();
        }

        public void ShowLicense(string text) { 
            this.txtLicenseText.Text = text.Replace("\n", Environment.NewLine);
            this.ShowDialog();
        }


        private void frmViewLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
