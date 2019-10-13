namespace MIMIC
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemPatientsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPatientsManager = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPatients_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemICU_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemICU_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemICU_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGroup = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPatientsInfo,
            this.toolStripMenuItemICU_Info,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(891, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemPatientsInfo
            // 
            this.toolStripMenuItemPatientsInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPatientsManager,
            this.toolStripMenuItemPatients_Search});
            this.toolStripMenuItemPatientsInfo.Name = "toolStripMenuItemPatientsInfo";
            this.toolStripMenuItemPatientsInfo.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItemPatientsInfo.Text = "病人信息";
            // 
            // toolStripMenuItemPatientsManager
            // 
            this.toolStripMenuItemPatientsManager.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemPatientsManager.Image")));
            this.toolStripMenuItemPatientsManager.Name = "toolStripMenuItemPatientsManager";
            this.toolStripMenuItemPatientsManager.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemPatientsManager.Text = "病人管理";
            // 
            // toolStripMenuItemPatients_Search
            // 
            this.toolStripMenuItemPatients_Search.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemPatients_Search.Image")));
            this.toolStripMenuItemPatients_Search.Name = "toolStripMenuItemPatients_Search";
            this.toolStripMenuItemPatients_Search.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemPatients_Search.Text = "病人查询";
            // 
            // toolStripMenuItemICU_Info
            // 
            this.toolStripMenuItemICU_Info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemICU_Add,
            this.toolStripMenuItemICU_Search});
            this.toolStripMenuItemICU_Info.Name = "toolStripMenuItemICU_Info";
            this.toolStripMenuItemICU_Info.Size = new System.Drawing.Size(65, 21);
            this.toolStripMenuItemICU_Info.Text = "ICU信息";
            // 
            // toolStripMenuItemICU_Add
            // 
            this.toolStripMenuItemICU_Add.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemICU_Add.Image")));
            this.toolStripMenuItemICU_Add.Name = "toolStripMenuItemICU_Add";
            this.toolStripMenuItemICU_Add.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemICU_Add.Text = "ICU管理";
            // 
            // toolStripMenuItemICU_Search
            // 
            this.toolStripMenuItemICU_Search.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemICU_Search.Image")));
            this.toolStripMenuItemICU_Search.Name = "toolStripMenuItemICU_Search";
            this.toolStripMenuItemICU_Search.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemICU_Search.Text = "ICU查询";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 21);
            this.toolStripMenuItem1.Text = " ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_User,
            this.toolStripStatusLabelGroup});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(891, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_User
            // 
            this.toolStripStatusLabel_User.Name = "toolStripStatusLabel_User";
            this.toolStripStatusLabel_User.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel_User.Text = "用户信息";
            // 
            // toolStripStatusLabelGroup
            // 
            this.toolStripStatusLabelGroup.Name = "toolStripStatusLabelGroup";
            this.toolStripStatusLabelGroup.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabelGroup.Text = "toolStripStatusLabel1";
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel1.Location = new System.Drawing.Point(0, 25);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.ShowDocumentIcon = true;
            this.dockPanel1.Size = new System.Drawing.Size(891, 394);
            this.dockPanel1.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 441);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "病人信息管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPatientsInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPatientsManager;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPatients_Search;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemICU_Info;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemICU_Add;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemICU_Search;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_User;
        public WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGroup;
    }
}