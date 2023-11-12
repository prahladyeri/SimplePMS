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
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        public void showTable(string tableName) {
            this.dgv.DataSource =  Util.getTable(tableName);
            this.Text += " " + tableName.Replace("vw_", "");
            this.ShowDialog();
        }

        private void frmView_Load(object sender, EventArgs e)
        {

        }
    }
}
