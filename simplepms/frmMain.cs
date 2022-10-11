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
        private DataRow currentProject;
        private DataView milestones;

        public frmMain()
        {
            InitializeComponent();
        }

        private void refreshMilestones() 
        {
            cboMilestone.Items.Clear();
            foreach (DataRow row in milestones.ToTable().Rows)
            {
                TextData item = new TextData(row["name"].ToString(), row["id"].ToString());
                cboMilestone.Items.Add(item);
            }
            if (cboMilestone.Items.Count > 0) {
                cboMilestone.SelectedIndex = 0;
            }
        }

        private void refreshProjects() {
            string oldKey = null;
            if (cboProject.SelectedIndex >= 0)
                oldKey =  ((TextData)cboProject.SelectedItem).Data ;
            cboProject.Items.Clear();
            
            foreach(DataRow row in Util.getTable("projects").Rows) {
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
            Util.getTable("tasks").DefaultView.RowFilter = "1=2"; //don't overstuff grid by default
            dgvTasks.DataSource = Util.getTable("tasks");
            foreach (DataGridViewColumn col in dgvTasks.Columns) {
                switch (col.Name) { 
                    case "id":
                    case "milestone_id":
                        col.Visible = false;
                        col.ReadOnly = true;
                        break;
                }
            }

            milestones = Util.getTable("milestones").DefaultView;
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
            DialogResult r = addProject.EditRecord(Convert.ToInt32(currentProject["id"].ToString()));
            if (r != System.Windows.Forms.DialogResult.Cancel) {
                this.refreshProjects();
            }
        }

        private void cmdDeleteProject_Click(object sender, EventArgs e)
        {
            //TextData td =  (TextData)this.cboProject.SelectedItem;
            string id = currentProject["id"].ToString();
            if (id == "1") {
                MessageBox.Show("Cannot delete the default (auto generated) project");
                return;
            }
            DialogResult r = MessageBox.Show("Are you sure you want to delete project " + currentProject["name"] + "?", "", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.No) return;
            currentProject.Delete();
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
            cmdNewProject_Click(this, null);
        }


        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextData td = (TextData)cboProject.SelectedItem;
            int id = int.Parse(td.Data);
            currentProject =  Util.findById("projects", id);
            Util.getTable("tasks").DefaultView.RowFilter = "1=2";
            Util.getTable("milestones").DefaultView.RowFilter = "project_id = " + currentProject["id"].ToString();
            refreshMilestones();
        }

        private void cmdNewTask_Click(object sender, EventArgs e)
        {
            //new DataGridViewRow()
            //int i = this.dgvMilestones.Rows.Add();
            TextData td = (TextData) cboMilestone.SelectedItem;
            if (td == null) return;
            int mid = int.Parse(td.Data);
            DataRow row = Util.getTable("tasks").NewRow();
            //row["project_id"] = int.Parse(currentProject["id"].ToString());
            row["milestone_id"] = mid;
            Random rnd = new Random();
            row["name"] = "NONAME_" + rnd.Next(1000, 9999).ToString();
            row["status"] = "Pending";
            //row["category"] = "Test";
            row["tags"] = "";
            row["weekly_hrs"] = 0;
            row["notes"] = "";
            Util.getTable("tasks").Rows.Add(row);
            Util.saveData("tasks");
        }

        private void tabProjects_Click(object sender, EventArgs e)
        {

        }

        private void cmdNewMilestone_Click(object sender, EventArgs e)
        {
            frmAddMilestone addMilestone = new frmAddMilestone();
            DialogResult r = addMilestone.EditRecord(int.Parse(currentProject["id"].ToString()));
            if (r!=DialogResult.Cancel) {
                refreshMilestones();
            }
        }

        private void cboMilestone_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextData td = (TextData)cboMilestone.SelectedItem;
            if (td == null) return;
            Util.getTable("tasks").DefaultView.RowFilter = "milestone_id = " + td.Data;
            //@todo: populate grid
            
        }

        private void cmdDeleteMilestone_Click(object sender, EventArgs e)
        {
            TextData td = (TextData)cboMilestone.SelectedItem;
            if (td == null) return;
            int id = int.Parse(td.Data);
            DialogResult r = MessageBox.Show("Are you sure you want to delete milestone " + cboMilestone.SelectedText + "?", "", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.No) return;
            //currentProject.Delete();
            DataRow row = Util.findById("milestones", id);
            row.Delete();
            Util.saveData("milestones");
            refreshMilestones();
        }

        private void cmdNewProject_Click(object sender, EventArgs e)
        {
            frmAddProject addProject = new frmAddProject();
            DialogResult r = addProject.EditRecord();
            if (r != System.Windows.Forms.DialogResult.Cancel)
            {
                refreshProjects();
            }

        }

        private void cmdEditMilestone_Click(object sender, EventArgs e)
        {
            TextData td = (TextData) cboMilestone.SelectedItem;
            if (td == null) return;
            int id = int.Parse(td.Data);
            int projectId = int.Parse(currentProject["id"].ToString());
            frmAddMilestone addMilestone = new frmAddMilestone();
            DialogResult r = addMilestone.EditRecord(projectId, id);
            if (r != DialogResult.Cancel) {
                refreshMilestones();
            }
        }

        private void dgvTasks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Util.saveData("tasks");
        }

        private void dgvTasks_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dgvTasks_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            Util.saveData("tasks");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //check for any pending database changes
            for (int i = 0; i < Util.adapter.TableMappings.Count; i++) {
                string tb = Util.adapter.TableMappings[i].DataSetTable;
                Util.saveData(tb);
            }
        }
    }
}
