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

        public frmMain()
        {
            InitializeComponent();
        }

        private void refreshProjects() {
            //object  cboProject.SelectedItem
            //int si = cboProject.SelectedIndex;
            string oldKey = null;
            if (cboProject.SelectedIndex >= 0)
                oldKey =  ((TextData)cboProject.SelectedItem).Data ;
            cboProject.Items.Clear();
            Util.cmd = new SQLiteCommand("select id,name,name||':'||id as pname from projects order by name;", Util.conn);
            SQLiteDataReader reader= Util.cmd.ExecuteReader();
            while (reader.Read()) {
                //cboProject.Items.Add(reader["pname"].ToString());
                TextData item = new TextData(reader["name"].ToString(), reader["id"].ToString());
                cboProject.Items.Add(item);
                if (reader["id"].ToString() == oldKey) cboProject.SelectedItem = item;
            }
            if (oldKey == null || cboProject.SelectedIndex == -1)
            {
                cboProject.SelectedIndex = 0;
            }
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
            Util.conn = new SQLiteConnection(connstr);
            Util.conn.Open();
            if (!dbexists)
            {
                string sql = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "schema.sql");
                Util.cmd = new SQLiteCommand(sql, Util.conn);
                Util.cmd.ExecuteNonQuery();
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
            string id = ((TextData)cboProject.SelectedItem).Data;
            //MessageBox.Show(id, Application.ProductName);
            frmAddProject addProject = new frmAddProject();
            DialogResult r = addProject.EditRecord(Convert.ToInt32(id));
            if (r != System.Windows.Forms.DialogResult.Cancel) {
                this.refreshProjects();
            }
        }

        private void cmdDeleteProject_Click(object sender, EventArgs e)
        {
            TextData td =  (TextData)this.cboProject.SelectedItem;
            int id = int.Parse(td.Data);
            if (td.Data.ToString() == "1") {
                MessageBox.Show("Cannot delete the default (auto generated) project");
                return;
            }
            DialogResult r = MessageBox.Show("Are you sure you want to delete project " + id.ToString(), "", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.No) return;
            Util.cmd = new SQLiteCommand("delete from projects where id=@id", Util.conn);
            Util.cmd.Parameters.Add(new SQLiteParameter("@id", id));
            Util.cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");
            refreshProjects();
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProject addProject = new frmAddProject();
            DialogResult r = addProject.EditRecord();
            if (r != System.Windows.Forms.DialogResult.Cancel) {
                refreshProjects();
            }
        }
    }
}
