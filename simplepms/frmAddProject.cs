using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace simplepms
{
    public partial class frmAddProject : Form
    {
        private char mode;
        private int id = -1;
        private DataRow row;

        public frmAddProject()
        {
            InitializeComponent();
        }

        public DialogResult EditRecord(int id = -1) {
            if (id==-1) {
                this.mode = 'a';
                this.Text = "Add Project";
            }
            else {
                this.mode = 'e';
                this.Text = "Edit Project";
            }
            
            this.id = id;
            if (id != -1)
            {
                //Util.cmd = new SQLiteCommand("select * from projects where id=@id", Util.conn);
                //Util.cmd.Parameters.Add(new SQLiteParameter("@id", id));
                //SQLiteDataReader reader = Util.cmd.ExecuteReader();
                //reader.Read();
                //DataTable tbl = Util.getTable("projects");
                //tbl.DefaultView.RowFilter = "id = " + id.ToString();
                row = Util.findById("projects", id); // tbl.DefaultView.ToTable().Rows[0];
                //tbl.f
                //tbl.DefaultView.RowFilter = "id = " + id.ToString();
                txtName.Text = row["name"].ToString();
                cboCategory.Text = row["category"].ToString();
                cboStatus.Text = row["status"].ToString();
                txtTags.Text = row["tags"].ToString();
                txtNotes.Text = row["notes"].ToString();

                if (!(row["start_date"] is DBNull))
                {
                    dtpStartDate.Value = Convert.ToDateTime(row["start_date"]);
                }
                if (!(row["end_date"] is DBNull))
                {
                    dtpEndDate.Value = Convert.ToDateTime(row["end_date"]);
                }
            }
            else {
                row = Util.getTable("projects").NewRow();
            }
            
            return this.ShowDialog();
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {
            txtName.Tag = new ControlTag("Name", true);
            if (this.mode == 'a') {
                dtpStartDate.Value = DateTime.Now;
                dtpEndDate.Value = DateTime.Now;
                cboCategory.SelectedIndex = 0;
                cboStatus.SelectedIndex = 0;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //validation
            foreach (Control ctl in this.tableLayoutPanel1.Controls) {
                if (ctl.Tag is ControlTag) {
                    ControlTag tag = (ControlTag)ctl.Tag;
                    if (tag.Required && ctl.Text == "") {
                        MessageBox.Show(string.Format("{0} can't be empty.", tag.Name),"", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        ctl.Focus();
                        return;
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            row["name"] = txtName.Text;
            row["status"] = cboStatus.Text;
            row["category"] = cboCategory.Text;
            row["tags"] = txtTags.Text;
            row["start_date"] = dtpStartDate.Value;
            row["end_date"] = dtpEndDate.Value;
            row["notes"] = txtNotes.Text;
            //row.AcceptChanges();
            if (mode == 'a') Util.getTable("projects").Rows.Add(row);
            Util.saveData("projects");
            MessageBox.Show("Record saved");
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
