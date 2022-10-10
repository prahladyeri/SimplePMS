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
            if (id != -1) {
                Util.cmd = new SQLiteCommand("select * from projects where id=@id", Util.conn);
                Util.cmd.Parameters.Add(new SQLiteParameter("@id", id));
                SQLiteDataReader reader = Util.cmd.ExecuteReader();
                reader.Read();
                txtName.Text = reader["name"].ToString();
                cboCategory.Text = reader["category"].ToString();
                cboStatus.Text = reader["status"].ToString();
                txtTags.Text = reader["tags"].ToString();
                txtNotes.Text = reader["notes"].ToString();
                if (!reader.IsDBNull(reader.GetOrdinal("start_date")))
                {
                    dtpStartDate.Value = Convert.ToDateTime(reader["start_date"]);
                }
                if (!reader.IsDBNull(reader.GetOrdinal("end_date")))
                {
                    dtpEndDate.Value = Convert.ToDateTime(reader["end_date"]);
                }
            }
            
            return this.ShowDialog();
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {
            txtName.Tag = new ControlTag("Name", true);
            if (this.mode == 'a') {
                dtpStartDate.Value = DateTime.Now;
                dtpEndDate.Value = DateTime.Now;
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
            string sql = "";
            switch (mode) { 
                case 'a':
                    sql = "insert into projects(status, name, category, tags, start_date, end_date, notes) values(@status,@name,@category,@tags,@start_date,@end_date,@notes)";
                    break;
                case 'e':
                    sql = "update projects set status=@status, name=@name, category=@category, tags=@tags, start_date=@start_date, end_date=@end_date, notes=@notes where id=@id;";
                    break;
            }
            Util.cmd = new SQLiteCommand(sql, Util.conn);
            Util.cmd.Parameters.Add(new SQLiteParameter("@status", cboStatus.Text));
            Util.cmd.Parameters.Add(new SQLiteParameter("@name", txtName.Text));
            Util.cmd.Parameters.Add(new SQLiteParameter("@category", cboCategory.Text));
            Util.cmd.Parameters.Add(new SQLiteParameter("@tags", txtTags.Text));
            Util.cmd.Parameters.Add(new SQLiteParameter("@start_date", dtpStartDate.Value));
            Util.cmd.Parameters.Add(new SQLiteParameter("@end_date", dtpEndDate.Value));
            Util.cmd.Parameters.Add(new SQLiteParameter("@notes", txtNotes.Text));
            if (mode == 'e')
                Util.cmd.Parameters.Add(new SQLiteParameter("@id", this.id));
            Util.cmd.ExecuteNonQuery();
            MessageBox.Show("Record saved");
            this.Close();
        }
    }
}
