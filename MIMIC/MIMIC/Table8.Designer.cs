namespace MIMIC
{
    partial class Table8
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
            this.DGViewPatients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // DGViewPatients
            // 
            this.DGViewPatients.AllowUserToAddRows = false;
            this.DGViewPatients.AllowUserToDeleteRows = false;
            this.DGViewPatients.BackgroundColor = System.Drawing.Color.White;
            this.DGViewPatients.ColumnHeadersHeight = 30;
            this.DGViewPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewPatients.Location = new System.Drawing.Point(0, 0);
            this.DGViewPatients.Name = "DGViewPatients";
            this.DGViewPatients.ReadOnly = true;
            this.DGViewPatients.Size = new System.Drawing.Size(981, 470);
            this.DGViewPatients.TabIndex = 1;
            // 
            // Table8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 470);
            this.Controls.Add(this.DGViewPatients);
            this.Name = "Table8";
            this.TabText = "chartevents";
            this.Text = "chartevents";
            this.Load += new System.EventHandler(this.Table8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGViewPatients;
    }
}