namespace MIMIC
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblPatientsSelect = new System.Windows.Forms.Label();
            this.lblPatientsSearch = new System.Windows.Forms.Label();
            this.lblicuSelect = new System.Windows.Forms.Label();
            this.lblicuSearch = new System.Windows.Forms.Label();
            this.lblCaseSelect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPatientsSelect
            // 
            this.lblPatientsSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPatientsSelect.ForeColor = System.Drawing.Color.Black;
            this.lblPatientsSelect.Image = ((System.Drawing.Image)(resources.GetObject("lblPatientsSelect.Image")));
            this.lblPatientsSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPatientsSelect.Location = new System.Drawing.Point(18, 40);
            this.lblPatientsSelect.Name = "lblPatientsSelect";
            this.lblPatientsSelect.Size = new System.Drawing.Size(60, 55);
            this.lblPatientsSelect.TabIndex = 0;
            this.lblPatientsSelect.Text = "精确查询";
            this.lblPatientsSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPatientsSelect.Click += new System.EventHandler(this.lblPatientsSelect_Click);
            // 
            // lblPatientsSearch
            // 
            this.lblPatientsSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPatientsSearch.Image = ((System.Drawing.Image)(resources.GetObject("lblPatientsSearch.Image")));
            this.lblPatientsSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPatientsSearch.Location = new System.Drawing.Point(103, 40);
            this.lblPatientsSearch.Name = "lblPatientsSearch";
            this.lblPatientsSearch.Size = new System.Drawing.Size(60, 55);
            this.lblPatientsSearch.TabIndex = 1;
            this.lblPatientsSearch.Text = "病人搜索";
            this.lblPatientsSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPatientsSearch.Click += new System.EventHandler(this.lblPatientsSearch_Click);
            // 
            // lblicuSelect
            // 
            this.lblicuSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblicuSelect.Image = ((System.Drawing.Image)(resources.GetObject("lblicuSelect.Image")));
            this.lblicuSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblicuSelect.Location = new System.Drawing.Point(18, 141);
            this.lblicuSelect.Name = "lblicuSelect";
            this.lblicuSelect.Size = new System.Drawing.Size(60, 55);
            this.lblicuSelect.TabIndex = 1;
            this.lblicuSelect.Text = "ICU查询";
            this.lblicuSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblicuSelect.Click += new System.EventHandler(this.lblCaseSelect_Click);
            // 
            // lblicuSearch
            // 
            this.lblicuSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblicuSearch.Image = ((System.Drawing.Image)(resources.GetObject("lblicuSearch.Image")));
            this.lblicuSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblicuSearch.Location = new System.Drawing.Point(103, 141);
            this.lblicuSearch.Name = "lblicuSearch";
            this.lblicuSearch.Size = new System.Drawing.Size(60, 55);
            this.lblicuSearch.TabIndex = 1;
            this.lblicuSearch.Text = "ICU搜索";
            this.lblicuSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblicuSearch.Click += new System.EventHandler(this.lblicuSearch_Click);
            // 
            // lblCaseSelect
            // 
            this.lblCaseSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCaseSelect.Image = ((System.Drawing.Image)(resources.GetObject("lblCaseSelect.Image")));
            this.lblCaseSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCaseSelect.Location = new System.Drawing.Point(18, 244);
            this.lblCaseSelect.Name = "lblCaseSelect";
            this.lblCaseSelect.Size = new System.Drawing.Size(60, 55);
            this.lblCaseSelect.TabIndex = 1;
            this.lblCaseSelect.Text = "病例查询";
            this.lblCaseSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCaseSelect.Click += new System.EventHandler(this.lblCaseSelect_Click);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(103, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "病例搜索";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Click += new System.EventHandler(this.lblicuSearch_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblicuSearch);
            this.Controls.Add(this.lblCaseSelect);
            this.Controls.Add(this.lblicuSelect);
            this.Controls.Add(this.lblPatientsSearch);
            this.Controls.Add(this.lblPatientsSelect);
            this.Name = "FrmMenu";
            this.TabText = "菜单栏";
            this.Text = "菜单栏";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPatientsSelect;
        private System.Windows.Forms.Label lblPatientsSearch;
        private System.Windows.Forms.Label lblicuSelect;
        private System.Windows.Forms.Label lblicuSearch;
        private System.Windows.Forms.Label lblCaseSelect;
        private System.Windows.Forms.Label label2;
    }
}