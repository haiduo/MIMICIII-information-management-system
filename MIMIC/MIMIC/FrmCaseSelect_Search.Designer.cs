namespace MIMIC
{
    partial class FrmCaseSelect_Search
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
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueuom = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.itemid,
            this.label,
            this.charttime,
            this.valuenum,
            this.valueuom});
            this.DGViewPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewPatients.Location = new System.Drawing.Point(0, 0);
            this.DGViewPatients.Name = "DGViewPatients";
            this.DGViewPatients.ReadOnly = true;
            this.DGViewPatients.Size = new System.Drawing.Size(880, 506);
            this.DGViewPatients.TabIndex = 3;
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
            // itemid
            // 
            this.itemid.DataPropertyName = "itemid";
            this.itemid.HeaderText = "测量类型标识";
            this.itemid.Name = "itemid";
            this.itemid.ReadOnly = true;
            this.itemid.ToolTipText = "测量类型标识";
            // 
            // label
            // 
            this.label.DataPropertyName = "label";
            this.label.HeaderText = "测量类型标识所表示的值";
            this.label.Name = "label";
            this.label.ReadOnly = true;
            this.label.ToolTipText = "测量类型标识所表示的值";
            // 
            // charttime
            // 
            this.charttime.DataPropertyName = "charttime";
            this.charttime.HeaderText = "观测进行的时间";
            this.charttime.Name = "charttime";
            this.charttime.ReadOnly = true;
            this.charttime.ToolTipText = "观测进行的时间";
            // 
            // valuenum
            // 
            this.valuenum.DataPropertyName = "valuenum";
            this.valuenum.HeaderText = "项目测量的值或描述";
            this.valuenum.Name = "valuenum";
            this.valuenum.ReadOnly = true;
            this.valuenum.ToolTipText = "项目测量的值或描述";
            // 
            // valueuom
            // 
            this.valueuom.DataPropertyName = "valueuom";
            this.valueuom.HeaderText = "测量值的单位";
            this.valueuom.Name = "valueuom";
            this.valueuom.ReadOnly = true;
            this.valueuom.ToolTipText = "测量值的单位";
            // 
            // FrmCaseSelect_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 506);
            this.Controls.Add(this.DGViewPatients);
            this.Name = "FrmCaseSelect_Search";
            this.Text = "病例查询结果";
            this.Load += new System.EventHandler(this.FrmCaseSelect_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGViewPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hadm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn icustay_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn label;
        private System.Windows.Forms.DataGridViewTextBoxColumn charttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueuom;
    }
}