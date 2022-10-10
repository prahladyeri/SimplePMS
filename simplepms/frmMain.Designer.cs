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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdStartTracking = new System.Windows.Forms.Button();
            this.cboTask = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.cmdEditProject = new System.Windows.Forms.Button();
            this.dgvMilestones = new System.Windows.Forms.DataGridView();
            this.tabMindMaps = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTimesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMindMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDeleteProject = new System.Windows.Forms.Button();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasks";
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(3, 216);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(602, 232);
            this.dgvTasks.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Milestones";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.1405F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.8595F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
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
            this.cmdStartTracking.Location = new System.Drawing.Point(466, 30);
            this.cmdStartTracking.Name = "cmdStartTracking";
            this.cmdStartTracking.Size = new System.Drawing.Size(136, 21);
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
            this.cboTask.Size = new System.Drawing.Size(350, 21);
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
            this.cboProject.Size = new System.Drawing.Size(350, 21);
            this.cboProject.TabIndex = 1;
            // 
            // cmdEditProject
            // 
            this.cmdEditProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEditProject.Location = new System.Drawing.Point(466, 3);
            this.cmdEditProject.Name = "cmdEditProject";
            this.cmdEditProject.Size = new System.Drawing.Size(60, 21);
            this.cmdEditProject.TabIndex = 2;
            this.cmdEditProject.Text = "Edit";
            this.cmdEditProject.UseVisualStyleBackColor = true;
            this.cmdEditProject.Click += new System.EventHandler(this.cmdEditProject_Click);
            // 
            // dgvMilestones
            // 
            this.dgvMilestones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMilestones.Location = new System.Drawing.Point(3, 99);
            this.dgvMilestones.Name = "dgvMilestones";
            this.dgvMilestones.Size = new System.Drawing.Size(602, 84);
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
            // viewTimesheetToolStripMenuItem
            // 
            this.viewTimesheetToolStripMenuItem.Name = "viewTimesheetToolStripMenuItem";
            this.viewTimesheetToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewTimesheetToolStripMenuItem.Text = "View Timesheet";
            // 
            // addNotesToolStripMenuItem
            // 
            this.addNotesToolStripMenuItem.Name = "addNotesToolStripMenuItem";
            this.addNotesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addNotesToolStripMenuItem.Text = "Add Note";
            // 
            // addMindMapToolStripMenuItem
            // 
            this.addMindMapToolStripMenuItem.Name = "addMindMapToolStripMenuItem";
            this.addMindMapToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addMindMapToolStripMenuItem.Text = "Add Mind Map";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cmdDeleteProject
            // 
            this.cmdDeleteProject.Location = new System.Drawing.Point(532, 3);
            this.cmdDeleteProject.Name = "cmdDeleteProject";
            this.cmdDeleteProject.Size = new System.Drawing.Size(70, 21);
            this.cmdDeleteProject.TabIndex = 3;
            this.cmdDeleteProject.Text = "Delete";
            this.cmdDeleteProject.UseVisualStyleBackColor = true;
            this.cmdDeleteProject.Click += new System.EventHandler(this.cmdDeleteProject_Click);
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addProjectToolStripMenuItem.Text = "Add Project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
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
    }
}

