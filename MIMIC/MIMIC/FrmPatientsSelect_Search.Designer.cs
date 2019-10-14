namespace MIMIC
{
    partial class FrmPatientsSelect_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientsSelect_Search));
            this.DGViewPatients = new System.Windows.Forms.DataGridView();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hadm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marital_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ethnicity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dod_hosp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dod_ssn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expire_flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admittime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dischtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admission_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admission_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discharge_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edregtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edouttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospital_expire_flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.has_chartevents_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.insurance,
            this.language,
            this.gender,
            this.age,
            this.religion,
            this.marital_status,
            this.ethnicity,
            this.dob,
            this.dod,
            this.dod_hosp,
            this.dod_ssn,
            this.expire_flag,
            this.admittime,
            this.dischtime,
            this.deathtime,
            this.admission_type,
            this.admission_location,
            this.discharge_location,
            this.edregtime,
            this.edouttime,
            this.diagnosis,
            this.hospital_expire_flag,
            this.has_chartevents_data});
            this.DGViewPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewPatients.Location = new System.Drawing.Point(0, 0);
            this.DGViewPatients.Name = "DGViewPatients";
            this.DGViewPatients.ReadOnly = true;
            this.DGViewPatients.Size = new System.Drawing.Size(923, 457);
            this.DGViewPatients.TabIndex = 1;
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
            // insurance
            // 
            this.insurance.DataPropertyName = "insurance";
            this.insurance.HeaderText = "保险类型";
            this.insurance.Name = "insurance";
            this.insurance.ReadOnly = true;
            this.insurance.ToolTipText = "保险类型";
            // 
            // language
            // 
            this.language.DataPropertyName = "language";
            this.language.HeaderText = "语言";
            this.language.Name = "language";
            this.language.ReadOnly = true;
            this.language.ToolTipText = "语言";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.ToolTipText = "性别";
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "入院时年龄";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.ToolTipText = "入院时年龄";
            // 
            // religion
            // 
            this.religion.DataPropertyName = "religion";
            this.religion.HeaderText = "宗教信仰";
            this.religion.Name = "religion";
            this.religion.ReadOnly = true;
            this.religion.ToolTipText = "宗教信仰";
            // 
            // marital_status
            // 
            this.marital_status.DataPropertyName = "marital_status";
            this.marital_status.HeaderText = "婚姻状态";
            this.marital_status.Name = "marital_status";
            this.marital_status.ReadOnly = true;
            this.marital_status.ToolTipText = "婚姻状态";
            // 
            // ethnicity
            // 
            this.ethnicity.DataPropertyName = "ethnicity";
            this.ethnicity.HeaderText = "种族";
            this.ethnicity.Name = "ethnicity";
            this.ethnicity.ReadOnly = true;
            this.ethnicity.ToolTipText = "种族";
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "出生日期";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.ToolTipText = "出生日期";
            // 
            // dod
            // 
            this.dod.DataPropertyName = "dod";
            this.dod.HeaderText = "死亡时间";
            this.dod.Name = "dod";
            this.dod.ReadOnly = true;
            this.dod.ToolTipText = "死亡时间";
            // 
            // dod_hosp
            // 
            this.dod_hosp.DataPropertyName = "dod_hosp";
            this.dod_hosp.HeaderText = "医院数据库记录的死亡日期";
            this.dod_hosp.Name = "dod_hosp";
            this.dod_hosp.ReadOnly = true;
            this.dod_hosp.ToolTipText = "医院数据库记录的死亡日期";
            // 
            // dod_ssn
            // 
            this.dod_ssn.DataPropertyName = "dod_ssn";
            this.dod_ssn.HeaderText = "社会保障数据库记录的死亡日期";
            this.dod_ssn.Name = "dod_ssn";
            this.dod_ssn.ReadOnly = true;
            this.dod_ssn.ToolTipText = "社会保障数据库记录的死亡日期";
            // 
            // expire_flag
            // 
            this.expire_flag.DataPropertyName = "expire_flag";
            this.expire_flag.HeaderText = "病人是否死亡";
            this.expire_flag.Name = "expire_flag";
            this.expire_flag.ReadOnly = true;
            this.expire_flag.ToolTipText = "病人是否死亡";
            // 
            // admittime
            // 
            this.admittime.DataPropertyName = "admittime";
            this.admittime.HeaderText = "入院时间";
            this.admittime.Name = "admittime";
            this.admittime.ReadOnly = true;
            this.admittime.ToolTipText = "入院时间";
            // 
            // dischtime
            // 
            this.dischtime.DataPropertyName = "dischtime";
            this.dischtime.HeaderText = "出院时间";
            this.dischtime.Name = "dischtime";
            this.dischtime.ReadOnly = true;
            this.dischtime.ToolTipText = "出院时间";
            // 
            // deathtime
            // 
            this.deathtime.DataPropertyName = "deathtime";
            this.deathtime.HeaderText = "住院死亡时间";
            this.deathtime.Name = "deathtime";
            this.deathtime.ReadOnly = true;
            this.deathtime.ToolTipText = "住院死亡时间";
            // 
            // admission_type
            // 
            this.admission_type.DataPropertyName = "admission_type";
            this.admission_type.HeaderText = "住院类型";
            this.admission_type.Name = "admission_type";
            this.admission_type.ReadOnly = true;
            this.admission_type.ToolTipText = "住院类型";
            // 
            // admission_location
            // 
            this.admission_location.DataPropertyName = "admission_location";
            this.admission_location.HeaderText = "入院前病人的位置";
            this.admission_location.Name = "admission_location";
            this.admission_location.ReadOnly = true;
            this.admission_location.ToolTipText = "入院前病人的位置";
            // 
            // discharge_location
            // 
            this.discharge_location.DataPropertyName = "discharge_location";
            this.discharge_location.HeaderText = "出院位置";
            this.discharge_location.Name = "discharge_location";
            this.discharge_location.ReadOnly = true;
            this.discharge_location.ToolTipText = "出院位置";
            // 
            // edregtime
            // 
            this.edregtime.DataPropertyName = "edregtime";
            this.edregtime.HeaderText = "进入急诊部时间";
            this.edregtime.Name = "edregtime";
            this.edregtime.ReadOnly = true;
            this.edregtime.ToolTipText = "进入急诊部时间";
            // 
            // edouttime
            // 
            this.edouttime.DataPropertyName = "edouttime";
            this.edouttime.HeaderText = "搬离急诊部时间";
            this.edouttime.Name = "edouttime";
            this.edouttime.ReadOnly = true;
            this.edouttime.ToolTipText = "搬离急诊部时间";
            // 
            // diagnosis
            // 
            this.diagnosis.DataPropertyName = "diagnosis";
            this.diagnosis.HeaderText = "诊断结果";
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.ReadOnly = true;
            this.diagnosis.ToolTipText = "诊断结果";
            // 
            // hospital_expire_flag
            // 
            this.hospital_expire_flag.DataPropertyName = "hospital_expire_flag";
            this.hospital_expire_flag.HeaderText = "住院期间是否死亡";
            this.hospital_expire_flag.Name = "hospital_expire_flag";
            this.hospital_expire_flag.ReadOnly = true;
            this.hospital_expire_flag.ToolTipText = "住院期间是否死亡";
            // 
            // has_chartevents_data
            // 
            this.has_chartevents_data.DataPropertyName = "has_chartevents_data";
            this.has_chartevents_data.HeaderText = "是否有图表数据";
            this.has_chartevents_data.Name = "has_chartevents_data";
            this.has_chartevents_data.ReadOnly = true;
            this.has_chartevents_data.ToolTipText = "是否有图表数据";
            // 
            // FrmPatientsSelect_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 457);
            this.Controls.Add(this.DGViewPatients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPatientsSelect_Search";
            this.TabText = "FrmPatientsSelect_Search";
            this.Text = "病人查询结果";
            this.Load += new System.EventHandler(this.FrmPatientsSelect_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGViewPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hadm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn marital_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ethnicity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dod_hosp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dod_ssn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expire_flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn admittime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dischtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn admission_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn admission_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn discharge_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn edregtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn edouttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospital_expire_flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn has_chartevents_data;
    }
}