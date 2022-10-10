namespace simplepms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.cmdNewTask = new System.Windows.Forms.Button();
            this.cmdNewMilestone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.task_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.task_tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_weekly_hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdStartTracking = new System.Windows.Forms.Button();
            this.cboTask = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.cmdEditProject = new System.Windows.Forms.Button();
            this.cmdDeleteProject = new System.Windows.Forms.Button();
            this.dgvMilestones = new System.Windows.Forms.DataGridView();
            this.tabMindMaps = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMindMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTimesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milestone_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milestone_project_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milestone_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milestone_status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.milestone_tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilestones)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabProjects);
            this.tabControl1.Controls.Add(this.tabMindMaps);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 480);
            this.tabControl1.TabIndex = 3;
            // 
            // tabProjects
            // 
            this.tabProjects.Controls.Add(this.cmdNewTask);
            this.tabProjects.Controls.Add(this.cmdNewMilestone);
            this.tabProjects.Controls.Add(this.label2);
            this.tabProjects.Controls.Add(this.dgvTasks);
            this.tabProjects.Controls.Add(this.label1);
            this.tabProjects.Controls.Add(this.tableLayoutPanel1);
            this.tabProjects.Controls.Add(this.dgvMilestones);
            this.tabProjects.Location = new System.Drawing.Point(4, 4);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjects.Size = new System.Drawing.Size(608, 454);
            this.tabProjects.TabIndex = 0;
            this.tabProjects.Text = "Projects";
            this.tabProjects.UseVisualStyleBackColor = true;
            // 
            // cmdNewTask
            // 
            this.cmdNewTask.Location = new System.Drawing.Point(536, 223);
            this.cmdNewTask.Name = "cmdNewTask";
            this.cmdNewTask.Size = new System.Drawing.Size(69, 23);
            this.cmdNewTask.TabIndex = 9;
            this.cmdNewTask.Text = "New";
            this.cmdNewTask.UseVisualStyleBackColor = true;
            // 
            // cmdNewMilestone
            // 
            this.cmdNewMilestone.Location = new System.Drawing.Point(535, 72);
            this.cmdNewMilestone.Name = "cmdNewMilestone";
            this.cmdNewMilestone.Size = new System.Drawing.Size(69, 23);
            this.cmdNewMilestone.TabIndex = 8;
            this.cmdNewMilestone.Text = "New";
            this.cmdNewMilestone.UseVisualStyleBackColor = true;
            this.cmdNewMilestone.Click += new System.EventHandler(this.cmdNewMilestone_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasks";
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.task_id,
            this.task_name,
            this.task_status,
            this.task_tags,
            this.task_weekly_hrs,
            this.task_notes});
            this.dgvTasks.Location = new System.Drawing.Point(3, 252);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(602, 196);
            this.dgvTasks.TabIndex = 7;
            // 
            // task_id
            // 
            this.task_id.HeaderText = "id";
            this.task_id.Name = "task_id";
            this.task_id.ReadOnly = true;
            this.task_id.Width = 30;
            // 
            // task_name
            // 
            this.task_name.HeaderText = "Name";
            this.task_name.Name = "task_name";
            // 
            // task_status
            // 
            this.task_status.HeaderText = "Status";
            this.task_status.Items.AddRange(new object[] {
            "Pending",
            "WIP",
            "Complete"});
            this.task_status.Name = "task_status";
            // 
            // task_tags
            // 
            this.task_tags.HeaderText = "Tags";
            this.task_tags.Name = "task_tags";
            // 
            // task_weekly_hrs
            // 
            this.task_weekly_hrs.HeaderText = "Weekly Hrs";
            this.task_weekly_hrs.Name = "task_weekly_hrs";
            // 
            // task_notes
            // 
            this.task_notes.HeaderText = "Notes";
            this.task_notes.Name = "task_notes";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Milestones (To delete, select  entire row and hit [DEL] key";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.1405F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.8595F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Controls.Add(this.cmdStartTracking, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboTask, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboProject, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdEditProject, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdDeleteProject, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 54);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cmdStartTracking
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmdStartTracking, 2);
            this.cmdStartTracking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdStartTracking.Location = new System.Drawing.Point(465, 30);
            this.cmdStartTracking.Name = "cmdStartTracking";
            this.cmdStartTracking.Size = new System.Drawing.Size(137, 21);
            this.cmdStartTracking.TabIndex = 5;
            this.cmdStartTracking.Text = "Start Tracking";
            this.cmdStartTracking.UseVisualStyleBackColor = true;
            // 
            // cboTask
            // 
            this.cboTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTask.FormattingEnabled = true;
            this.cboTask.Location = new System.Drawing.Point(110, 30);
            this.cboTask.Name = "cboTask";
            this.cboTask.Size = new System.Drawing.Size(349, 21);
            this.cboTask.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Track Task:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current Project:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboProject
            // 
            this.cboProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(110, 3);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(349, 21);
            this.cboProject.TabIndex = 1;
            this.cboProject.SelectedIndexChanged += new System.EventHandler(this.cboProject_SelectedIndexChanged);
            // 
            // cmdEditProject
            // 
            this.cmdEditProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEditProject.Location = new System.Drawing.Point(465, 3);
            this.cmdEditProject.Name = "cmdEditProject";
            this.cmdEditProject.Size = new System.Drawing.Size(60, 21);
            this.cmdEditProject.TabIndex = 2;
            this.cmdEditProject.Text = "Edit";
            this.cmdEditProject.UseVisualStyleBackColor = true;
            this.cmdEditProject.Click += new System.EventHandler(this.cmdEditProject_Click);
            // 
            // cmdDeleteProject
            // 
            this.cmdDeleteProject.Location = new System.Drawing.Point(531, 3);
            this.cmdDeleteProject.Name = "cmdDeleteProject";
            this.cmdDeleteProject.Size = new System.Drawing.Size(70, 21);
            this.cmdDeleteProject.TabIndex = 3;
            this.cmdDeleteProject.Text = "Delete";
            this.cmdDeleteProject.UseVisualStyleBackColor = true;
            this.cmdDeleteProject.Click += new System.EventHandler(this.cmdDeleteProject_Click);
            // 
            // dgvMilestones
            // 
            this.dgvMilestones.AllowUserToAddRows = false;
            this.dgvMilestones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMilestones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.milestone_id,
            this.milestone_project_id,
            this.milestone_name,
            this.milestone_status,
            this.milestone_tags});
            this.dgvMilestones.Location = new System.Drawing.Point(3, 99);
            this.dgvMilestones.Name = "dgvMilestones";
            this.dgvMilestones.Size = new System.Drawing.Size(602, 118);
            this.dgvMilestones.TabIndex = 6;
            // 
            // tabMindMaps
            // 
            this.tabMindMaps.Location = new System.Drawing.Point(4, 4);
            this.tabMindMaps.Name = "tabMindMaps";
            this.tabMindMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabMindMaps.Size = new System.Drawing.Size(608, 454);
            this.tabMindMaps.TabIndex = 1;
            this.tabMindMaps.Text = "Mind Maps";
            this.tabMindMaps.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(616, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem,
            this.addNotesToolStripMenuItem,
            this.addMindMapToolStripMenuItem,
            this.viewTimesheetToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.projectsToolStripMenuItem.Text = "Actions";
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addProjectToolStripMenuItem.Text = "Add Project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // addNotesToolStripMenuItem
            // 
            this.addNotesToolStripMenuItem.Name = "addNotesToolStripMenuItem";
            this.addNotesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNotesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addNotesToolStripMenuItem.Text = "Add Note";
            // 
            // addMindMapToolStripMenuItem
            // 
            this.addMindMapToolStripMenuItem.Name = "addMindMapToolStripMenuItem";
            this.addMindMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.addMindMapToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addMindMapToolStripMenuItem.Text = "Add Mind Map";
            // 
            // viewTimesheetToolStripMenuItem
            // 
            this.viewTimesheetToolStripMenuItem.Name = "viewTimesheetToolStripMenuItem";
            this.viewTimesheetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.viewTimesheetToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.viewTimesheetToolStripMenuItem.Text = "View Timesheet";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // milestone_id
            // 
            this.milestone_id.DataPropertyName = "id";
            this.milestone_id.Frozen = true;
            this.milestone_id.HeaderText = "id";
            this.milestone_id.Name = "milestone_id";
            this.milestone_id.ReadOnly = true;
            this.milestone_id.Width = 40;
            // 
            // milestone_project_id
            // 
            this.milestone_project_id.DataPropertyName = "project_id";
            this.milestone_project_id.HeaderText = "project_id";
            this.milestone_project_id.Name = "milestone_project_id";
            this.milestone_project_id.ReadOnly = true;
            this.milestone_project_id.Visible = false;
            // 
            // milestone_name
            // 
            this.milestone_name.DataPropertyName = "name";
            this.milestone_name.HeaderText = "Name";
            this.milestone_name.Name = "milestone_name";
            this.milestone_name.Width = 200;
            // 
            // milestone_status
            // 
            this.milestone_status.DataPropertyName = "status";
            this.milestone_status.HeaderText = "Status";
            this.milestone_status.Items.AddRange(new object[] {
            "Pending",
            "WIP",
            "Complete"});
            this.milestone_status.Name = "milestone_status";
            // 
            // milestone_tags
            // 
            this.milestone_tags.DataPropertyName = "tags";
            this.milestone_tags.HeaderText = "Tags";
            this.milestone_tags.Name = "milestone_tags";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 526);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple PMS";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilestones)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProjects;
        private System.Windows.Forms.TabPage tabMindMaps;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvMilestones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Button cmdEditProject;
        private System.Windows.Forms.Button cmdStartTracking;
        private System.Windows.Forms.ComboBox cboTask;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTimesheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMindMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button cmdDeleteProject;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.Button cmdNewTask;
        private System.Windows.Forms.Button cmdNewMilestone;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn task_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_weekly_hrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestone_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestone_project_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestone_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn milestone_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestone_tags;
    }
}

