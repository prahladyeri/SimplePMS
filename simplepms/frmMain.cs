using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Data.SQLite;

namespace simplepms
{
    public partial class frmMain : Form
    {
        private SQLiteConnection conn;
        private SQLiteCommand cmd;

        public frmMain()
        {
            InitializeComponent();
        }

        private void refreshProjects() {
            cboProject.Items.Clear();
            cmd = new SQLiteCommand("select id,name,name||':'||id as pname from projects order by name;", conn);
            SQLiteDataReader reader= cmd.ExecuteReader();
            while (reader.Read()) {
                //cboProject.Items.Add(reader["pname"].ToString());
                TextData item = new TextData(reader["name"].ToString(), reader["id"]);
                cboProject.Items.Add(item);
            }
            cboProject.SelectedIndex = 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Version ver = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += string.Format(" ({0}.{1})", ver.Major, ver.Minor) + "";
            this.notifyIcon1.Icon = this.Icon;

            //initialize db
            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "pms.db";
            string connstr = @"Data Source=" + dbpath + @";Version=3;New=True;Compress=True";
            bool dbexists = File.Exists(dbpath);
            conn = new SQLiteConnection(connstr);
            conn.Open();
            if (!dbexists)
            {
                string sql = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "schema.sql");
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            //remove extra tabs
            for (int i = 1; i < tabControl1.TabCount; i++)
            {
                tabControl1.TabPages.RemoveAt(i);
            }

            lblStatus.Text = "Ready";
            refreshProjects();
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

        private void cmdEditProject_Click(object sender, EventArgs e)
        {
            string id =  ((TextData)cboProject.SelectedItem).Data.ToString();
            MessageBox.Show(id, Application.ProductName);
        }
    }
}
