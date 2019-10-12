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
            this.lblicuAdd = new System.Windows.Forms.Label();
            this.lblicusearch = new System.Windows.Forms.Label();
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
            this.lblPatientsSearch.Text = "病人查询";
            this.lblPatientsSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPatientsSearch.Click += new System.EventHandler(this.lblPatientsSearch_Click);
            // 
            // lblicuAdd
            // 
            this.lblicuAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblicuAdd.Image = ((System.Drawing.Image)(resources.GetObject("lblicuAdd.Image")));
            this.lblicuAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblicuAdd.Location = new System.Drawing.Point(18, 141);
            this.lblicuAdd.Name = "lblicuAdd";
            this.lblicuAdd.Size = new System.Drawing.Size(60, 55);
            this.lblicuAdd.TabIndex = 1;
            this.lblicuAdd.Text = "ICU";
            this.lblicuAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblicusearch
            // 
            this.lblicusearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblicusearch.Image = ((System.Drawing.Image)(resources.GetObject("lblicusearch.Image")));
            this.lblicusearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblicusearch.Location = new System.Drawing.Point(103, 141);
            this.lblicusearch.Name = "lblicusearch";
            this.lblicusearch.Size = new System.Drawing.Size(60, 55);
            this.lblicusearch.TabIndex = 1;
            this.lblicusearch.Text = "ICU查询";
            this.lblicusearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 546);
            this.Controls.Add(this.lblicusearch);
            this.Controls.Add(this.lblicuAdd);
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
        private System.Windows.Forms.Label lblicuAdd;
        private System.Windows.Forms.Label lblicusearch;
    }
}