namespace MIMIC
{
    partial class FrmICUPatientsSelect_Search
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
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hadm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icustay_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_careunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_careunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.los = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // DGViewPatients
            // 
            this.DGViewPatients.AllowUserToAddRows = false;
            this.DGViewPatients.AllowUserToDeleteRows = false;
            this.DGViewPatients.BackgroundColor = System.Drawing.Color.White;
            this.DGViewPatients.ColumnHeadersHeight = 30;
            this.DGViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_id,
            this.hadm_id,
            this.icustay_id,
            this.gender,
            this.first_careunit,
            this.last_careunit,
            this.intime,
            this.outtime,
            this.los});
            this.DGViewPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewPatients.Location = new System.Drawing.Point(0, 0);
            this.DGViewPatients.Name = "DGViewPatients";
            this.DGViewPatients.ReadOnly = true;
            this.DGViewPatients.Size = new System.Drawing.Size(746, 392);
            this.DGViewPatients.TabIndex = 2;
            // 
            // subject_id
            // 
            this.subject_id.DataPropertyName = "subject_id";
            this.subject_id.HeaderText = "病人标识";
            this.subject_id.Name = "subject_id";
            this.subject_id.ReadOnly = true;
            this.subject_id.ToolTipText = "病人标识";
            // 
            // hadm_id
            // 
            this.hadm_id.DataPropertyName = "hadm_id";
            this.hadm_id.HeaderText = "入院记录标识";
            this.hadm_id.Name = "hadm_id";
            this.hadm_id.ReadOnly = true;
            this.hadm_id.ToolTipText = "入院记录标识";
            // 
            // icustay_id
            // 
            this.icustay_id.DataPropertyName = "icustay_id";
            this.icustay_id.HeaderText = "入ICU记录标识";
            this.icustay_id.Name = "icustay_id";
            this.icustay_id.ReadOnly = true;
            this.icustay_id.ToolTipText = "入ICU记录标识";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.ToolTipText = "性别";
            // 
            // first_careunit
            // 
            this.first_careunit.DataPropertyName = "first_careunit";
            this.first_careunit.HeaderText = "给予患者的第一种护理";
            this.first_careunit.Name = "first_careunit";
            this.first_careunit.ReadOnly = true;
            this.first_careunit.ToolTipText = "给予患者的第一种护理";
            // 
            // last_careunit
            // 
            this.last_careunit.DataPropertyName = "last_careunit";
            this.last_careunit.HeaderText = "给予患者最后一种护理";
            this.last_careunit.Name = "last_careunit";
            this.last_careunit.ReadOnly = true;
            this.last_careunit.ToolTipText = "给予患者最后一种护理";
            // 
            // intime
            // 
            this.intime.DataPropertyName = "intime";
            this.intime.HeaderText = "入住ICU的时间";
            this.intime.Name = "intime";
            this.intime.ReadOnly = true;
            this.intime.ToolTipText = "入住ICU的时间";
            // 
            // outtime
            // 
            this.outtime.DataPropertyName = "outtime";
            this.outtime.HeaderText = "转出ICU的时间";
            this.outtime.Name = "outtime";
            this.outtime.ReadOnly = true;
            this.outtime.ToolTipText = "转出ICU的时间";
            // 
            // los
            // 
            this.los.DataPropertyName = "los";
            this.los.HeaderText = "入住ICU的时长(天）";
            this.los.Name = "los";
            this.los.ReadOnly = true;
            this.los.ToolTipText = "入住ICU的时长";
            // 
            // FrmICUPatientsSelect_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 392);
            this.Controls.Add(this.DGViewPatients);
            this.Name = "FrmICUPatientsSelect_Search";
            this.TabText = "查询结果";
            this.Text = "查询结果";
            this.Load += new System.EventHandler(this.FrmICUPatientsSelect_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGViewPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hadm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn icustay_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_careunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_careunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn intime;
        private System.Windows.Forms.DataGridViewTextBoxColumn outtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn los;
    }
}