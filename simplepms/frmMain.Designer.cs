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
            this.mnuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.cmdStartTracking = new System.Windows.Forms.Button();
            this.cmdNewTask = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekly_hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdNewMilestone = new System.Windows.Forms.Button();
            this.cmdDeleteMilestone = new System.Windows.Forms.Button();
            this.cmdEditMilestone = new System.Windows.Forms.Button();
            this.cboMilestone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.cmdEditProject = new System.Windows.Forms.Button();
            this.cmdDeleteProject = new System.Windows.Forms.Button();
            this.cmdNewProject = new System.Windows.Forms.Button();
            this.tabMindMaps = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMindMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTimesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTray.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.mnuTray;
            this.notifyIcon1.Text = "Simple PMS";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // mnuTray
            // 
            this.mnuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.mnuTray.Name = "mnuTray";
            this.mnuTray.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
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
            this.tabProjects.Controls.Add(this.cmdStartTracking);
            this.tabProjects.Controls.Add(this.cmdNewTask);
            this.tabProjects.Controls.Add(this.dgvTasks);
            this.tabProjects.Controls.Add(this.label1);
            this.tabProjects.Controls.Add(this.tableLayoutPanel1);
            this.tabProjects.Location = new System.Drawing.Point(4, 4);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjects.Size = new System.Drawing.Size(608, 454);
            this.tabProjects.TabIndex = 0;
            this.tabProjects.Text = "Projects";
            this.tabProjects.UseVisualStyleBackColor = true;
            this.tabProjects.Click += new System.EventHandler(this.tabProjects_Click);
            // 
            // cmdStartTracking
            // 
            this.cmdStartTracking.Location = new System.Drawing.Point(500, 57);
            this.cmdStartTracking.Name = "cmdStartTracking";
            this.cmdStartTracking.Size = new System.Drawing.Size(105, 21);
            this.cmdStartTracking.TabIndex = 10;
            this.cmdStartTracking.Text = "Start Tracking";
            this.cmdStartTracking.UseVisualStyleBackColor = true;
            this.cmdStartTracking.Click += new System.EventHandler(this.cmdStartTracking_Click);
            // 
            // cmdNewTask
            // 
            this.cmdNewTask.Location = new System.Drawing.Point(529, 97);
            this.cmdNewTask.Name = "cmdNewTask";
            this.cmdNewTask.Size = new System.Drawing.Size(76, 23);
            this.cmdNewTask.TabIndex = 8;
            this.cmdNewTask.Text = "New Task";
            this.cmdNewTask.UseVisualStyleBackColor = true;
            this.cmdNewTask.Click += new System.EventHandler(this.cmdNewTask_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.status,
            this.tags,
            this.weekly_hrs,
            this.notes});
            this.dgvTasks.Location = new System.Drawing.Point(0, 122);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(602, 329);
            this.dgvTasks.TabIndex = 7;
            this.dgvTasks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellEndEdit);
            this.dgvTasks.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_RowValidated);
            this.dgvTasks.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvTasks_RowValidating);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 130;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Items.AddRange(new object[] {
            "Pending",
            "WIP",
            "Complete"});
            this.status.Name = "status";
            this.status.Width = 70;
            // 
            // tags
            // 
            this.tags.DataPropertyName = "tags";
            this.tags.HeaderText = "Tags";
            this.tags.Name = "tags";
            // 
            // weekly_hrs
            // 
            this.weekly_hrs.DataPropertyName = "weekly_hrs";
            this.weekly_hrs.HeaderText = "Weekly Hrs";
            this.weekly_hrs.Name = "weekly_hrs";
            this.weekly_hrs.Width = 60;
            // 
            // notes
            // 
            this.notes.DataPropertyName = "notes";
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.Width = 150;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tasks (To delete, select  entire row and hit [DEL] key)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.75648F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.24352F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Controls.Add(this.cmdNewMilestone, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmdDeleteMilestone, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmdEditMilestone, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboMilestone, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboProject, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdEditProject, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdDeleteProject, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdNewProject, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 54);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cmdNewMilestone
            // 
            this.cmdNewMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdNewMilestone.Location = new System.Drawing.Point(519, 30);
            this.cmdNewMilestone.Name = "cmdNewMilestone";
            this.cmdNewMilestone.Size = new System.Drawing.Size(83, 21);
            this.cmdNewMilestone.TabIndex = 12;
            this.cmdNewMilestone.Text = "New";
            this.cmdNewMilestone.UseVisualStyleBackColor = true;
            this.cmdNewMilestone.Click += new System.EventHandler(this.cmdNewMilestone_Click);
            // 
            // cmdDeleteMilestone
            // 
            this.cmdDeleteMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDeleteMilestone.Location = new System.Drawing.Point(437, 30);
            this.cmdDeleteMilestone.Name = "cmdDeleteMilestone";
            this.cmdDeleteMilestone.Size = new System.Drawing.Size(76, 21);
            this.cmdDeleteMilestone.TabIndex = 11;
            this.cmdDeleteMilestone.Text = "Delete";
            this.cmdDeleteMilestone.UseVisualStyleBackColor = true;
            this.cmdDeleteMilestone.Click += new System.EventHandler(this.cmdDeleteMilestone_Click);
            // 
            // cmdEditMilestone
            // 
            this.cmdEditMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEditMilestone.Location = new System.Drawing.Point(380, 30);
            this.cmdEditMilestone.Name = "cmdEditMilestone";
            this.cmdEditMilestone.Size = new System.Drawing.Size(51, 21);
            this.cmdEditMilestone.TabIndex = 10;
            this.cmdEditMilestone.Text = "Edit";
            this.cmdEditMilestone.UseVisualStyleBackColor = true;
            this.cmdEditMilestone.Click += new System.EventHandler(this.cmdEditMilestone_Click);
            // 
            // cboMilestone
            // 
            this.cboMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMilestone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMilestone.FormattingEnabled = true;
            this.cboMilestone.Location = new System.Drawing.Point(111, 30);
            this.cboMilestone.Name = "cboMilestone";
            this.cboMilestone.Size = new System.Drawing.Size(263, 21);
            this.cboMilestone.TabIndex = 4;
            this.cboMilestone.SelectedIndexChanged += new System.EventHandler(this.cboMilestone_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Current Milestone:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current Project:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboProject
            // 
            this.cboProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(111, 3);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(263, 21);
            this.cboProject.TabIndex = 1;
            this.cboProject.SelectedIndexChanged += new System.EventHandler(this.cboProject_SelectedIndexChanged);
            // 
            // cmdEditProject
            // 
            this.cmdEditProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEditProject.Location = new System.Drawing.Point(380, 3);
            this.cmdEditProject.Name = "cmdEditProject";
            this.cmdEditProject.Size = new System.Drawing.Size(51, 21);
            this.cmdEditProject.TabIndex = 2;
            this.cmdEditProject.Text = "Edit";
            this.cmdEditProject.UseVisualStyleBackColor = true;
            this.cmdEditProject.Click += new System.EventHandler(this.cmdEditProject_Click);
            // 
            // cmdDeleteProject
            // 
            this.cmdDeleteProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDeleteProject.Location = new System.Drawing.Point(437, 3);
            this.cmdDeleteProject.Name = "cmdDeleteProject";
            this.cmdDeleteProject.Size = new System.Drawing.Size(76, 21);
            this.cmdDeleteProject.TabIndex = 3;
            this.cmdDeleteProject.Text = "Delete";
            this.cmdDeleteProject.UseVisualStyleBackColor = true;
            this.cmdDeleteProject.Click += new System.EventHandler(this.cmdDeleteProject_Click);
            // 
            // cmdNewProject
            // 
            this.cmdNewProject.Location = new System.Drawing.Point(519, 3);
            this.cmdNewProject.Name = "cmdNewProject";
            this.cmdNewProject.Size = new System.Drawing.Size(74, 21);
            this.cmdNewProject.TabIndex = 6;
            this.cmdNewProject.Text = "New";
            this.cmdNewProject.UseVisualStyleBackColor = true;
            this.cmdNewProject.Click += new System.EventHandler(this.cmdNewProject_Click);
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
            this.lblStatus.Size = new System.Drawing.Size(38, 17);
            this.lblStatus.Text = "Ready";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
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
            this.addNotesToolStripMenuItem,
            this.addMindMapToolStripMenuItem,
            this.viewTimesheetToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.projectsToolStripMenuItem.Text = "Actions";
            // 
            // addNotesToolStripMenuItem
            // 
            this.addNotesToolStripMenuItem.Name = "addNotesToolStripMenuItem";
            this.addNotesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNotesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.addNotesToolStripMenuItem.Text = "Add Note";
            // 
            // addMindMapToolStripMenuItem
            // 
            this.addMindMapToolStripMenuItem.Name = "addMindMapToolStripMenuItem";
            this.addMindMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.addMindMapToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.addMindMapToolStripMenuItem.Text = "Add Mind Map";
            // 
            // viewTimesheetToolStripMenuItem
            // 
            this.viewTimesheetToolStripMenuItem.Name = "viewTimesheetToolStripMenuItem";
            this.viewTimesheetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.viewTimesheetToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewTimesheetToolStripMenuItem.Text = "View Timesheet";
            this.viewTimesheetToolStripMenuItem.Click += new System.EventHandler(this.viewTimesheetToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.mnuTray.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Button cmdEditProject;
        private System.Windows.Forms.ComboBox cboMilestone;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTimesheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMindMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button cmdDeleteProject;
        private System.Windows.Forms.Button cmdNewTask;
        private System.Windows.Forms.Button cmdStartTracking;
        private System.Windows.Forms.Button cmdNewMilestone;
        private System.Windows.Forms.Button cmdDeleteMilestone;
        private System.Windows.Forms.Button cmdEditMilestone;
        private System.Windows.Forms.Button cmdNewProject;
        private System.Windows.Forms.ContextMenuStrip mnuTray;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekly_hrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
    }
}

