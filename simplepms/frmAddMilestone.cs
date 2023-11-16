#region License Information (Apache 2.0)
/*
   Copyright 2023 Prahlad Yeri

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */
#endregion

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
    public partial class frmAddMilestone : Form
    {
        private char mode;
        private int id = -1;
        private DataRow row;

        public frmAddMilestone()
        {
            InitializeComponent();
        }

        public DialogResult EditRecord(int projectId, int id = -1)
        {
            if (id == -1)
            {
                this.mode = 'a';
                this.Text = "Add Milestone";
            }
            else
            {
                this.mode = 'e';
                this.Text = "Edit Milestone";
            }

            this.id = id;
            if (id != -1)
            {
                row = Util.findById("milestones", id);
                txtName.Text = row["name"].ToString();
                cboStatus.Text = row["status"].ToString();
                txtTags.Text = row["tags"].ToString();
            }
            else
            {
                row = Util.getTable("milestones").NewRow();
                row["project_id"] = projectId;
            }

            return this.ShowDialog();
        }

        private void frmAddMilestone_Load(object sender, EventArgs e)
        {
            txtName.Tag = new ControlTag("Name", true);
            if (this.mode == 'a')
            {
                cboStatus.SelectedIndex = 0;
            }
            
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //validation
            foreach (Control ctl in this.tableLayoutPanel1.Controls)
            {
                if (ctl.Tag is ControlTag)
                {
                    ControlTag tag = (ControlTag)ctl.Tag;
                    if (tag.Required && ctl.Text == "")
                    {
                        MessageBox.Show(string.Format("{0} can't be empty.", tag.Name), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ctl.Focus();
                        return;
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            row["name"] = txtName.Text;
            row["status"] = cboStatus.Text;
            row["tags"] = txtTags.Text;
            //row.AcceptChanges();
            if (mode=='a') Util.getTable("milestones").Rows.Add(row);
            Util.saveData("milestones");
            MessageBox.Show("Record saved");
            this.Close();
        }
    }
}
