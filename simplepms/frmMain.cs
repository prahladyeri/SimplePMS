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
        private DataRow current;

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
            //Util.cmd = new SQLiteCommand("select id,name,name||':'||id as pname from projects order by name;", Util.conn);
            //SQLiteDataReader reader= Util.cmd.ExecuteReader();
            
            foreach(DataRow row in Util.getTable("projects").Rows) {
                //cboProject.Items.Add(reader["pname"].ToString());
                TextData item = new TextData(row["name"].ToString(), row["id"].ToString());
                cboProject.Items.Add(item);
                if (row["id"].ToString() == oldKey) cboProject.SelectedItem = item;
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
            Util.initdb();

            //remove extra tabs
            for (int i = 1; i < tabControl1.TabCount; i++)
            {
                tabControl1.TabPages.RemoveAt(i);
            }
            //init grids
            Util.getTable("milestones").DefaultView.RowFilter = "1=2"; //don't overstuff grid by default
            Util.getTable("tasks").DefaultView.RowFilter = "1=2"; //don't overstuff grid by default
            dgvMilestones.DataSource = Util.getTable("milestones");
            dgvTasks.DataSource = Util.getTable("tasks");

            refreshProjects();

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

        private void cmdEditProject_Click(object sender, EventArgs e)
        {
            frmAddProject addProject = new frmAddProject();
            DialogResult r = addProject.EditRecord(Convert.ToInt32(current["id"].ToString()));
            if (r != System.Windows.Forms.DialogResult.Cancel) {
                this.refreshProjects();
            }
        }

        private void cmdDeleteProject_Click(object sender, EventArgs e)
        {
            //TextData td =  (TextData)this.cboProject.SelectedItem;
            string id = current["id"].ToString();
            if (id == "1") {
                MessageBox.Show("Cannot delete the default (auto generated) project");
                return;
            }
            DialogResult r = MessageBox.Show("Are you sure you want to delete project " + current["name"] + "?", "", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.No) return;
            current.Delete();
            //Util.getTable("projects").AcceptChanges();
            Util.saveData("projects");
            //Util.getTable("projects").Rows.Remove(current);
            //Util.cmd = new SQLiteCommand("delete from projects where id=@id", Util.conn);
            //Util.cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //Util.cmd.ExecuteNonQuery();
            //MessageBox.Show("Record Deleted");
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

        private void cmdNewMilestone_Click(object sender, EventArgs e)
        {
            //new DataGridViewRow()
            //int i = this.dgvMilestones.Rows.Add();
            DataRow row = Util.getTable("milestones").NewRow();
            row["project_id"] = int.Parse(current["id"].ToString());
            Random rnd = new Random();
            row["name"]= "NONAME_" + rnd.Next(1000,9999).ToString();
            row["status"]= "Pending";
            row["tags"] = "";
            Util.getTable("milestones").Rows.Add(row);
        }

        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextData td = (TextData)cboProject.SelectedItem;
            int id = int.Parse(td.Data);
            current =  Util.findById("projects", id);
            Util.getTable("milestones").DefaultView.RowFilter = "project_id = " + current["id"].ToString();
            Util.getTable("tasks").DefaultView.RowFilter = "1=2";
        }
    }
}
