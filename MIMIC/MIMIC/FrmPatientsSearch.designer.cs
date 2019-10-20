namespace MIMIC
{
    partial class FrmPatientsSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientsSearch));
            this.DGViewPatients = new System.Windows.Forms.DataGridView();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hadm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.charttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueuom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linksto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submit_wardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submit_careunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curr_wardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curr_careunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callout_wardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callout_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_resp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_cdiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_mrsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_vre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callout_outcome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discharge_wardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acknowledge_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acknowledgetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outcometime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstreservationtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentreservationtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transfertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prev_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curr_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prev_careunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prev_wardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_chartdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iserror = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gender,
            this.age,
            this.religion,
            this.insurance,
            this.language,
            this.hadm_id,
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
            this.has_chartevents_data,
            this.charttime,
            this.storetime,
            this.cgid,
            this.value,
            this.valuenum,
            this.valueuom,
            this.warning,
            this.error,
            this.resultstatus,
            this.stopped,
            this.itemid,
            this.label,
            this.abbreviation,
            this.linksto,
            this.category,
            this.unitname,
            this.param_type,
            this.conceptid,
            this.submit_wardid,
            this.submit_careunit,
            this.curr_wardid,
            this.curr_careunit,
            this.callout_wardid,
            this.callout_service,
            this.request_tele,
            this.request_resp,
            this.request_cdiff,
            this.request_mrsa,
            this.request_vre,
            this.callout_outcome,
            this.discharge_wardid,
            this.acknowledge_status,
            this.createtime,
            this.updatetime,
            this.acknowledgetime,
            this.outcometime,
            this.firstreservationtime,
            this.currentreservationtime,
            this.transfertime,
            this.prev_service,
            this.curr_service,
            this.eventtype,
            this.prev_careunit,
            this.prev_wardid,
            this.n_chartdate,
            this.n_description,
            this.iserror,
            this.text});
            this.DGViewPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewPatients.Location = new System.Drawing.Point(0, 0);
            this.DGViewPatients.Name = "DGViewPatients";
            this.DGViewPatients.ReadOnly = true;
            this.DGViewPatients.Size = new System.Drawing.Size(1370, 470);
            this.DGViewPatients.TabIndex = 0;
            // 
            // subject_id
            // 
            this.subject_id.DataPropertyName = "subject_id";
            this.subject_id.HeaderText = "病人标识";
            this.subject_id.Name = "subject_id";
            this.subject_id.ReadOnly = true;
            this.subject_id.ToolTipText = "病人标识";
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
            // hadm_id
            // 
            this.hadm_id.DataPropertyName = "hadm_id";
            this.hadm_id.HeaderText = "入院记录标识";
            this.hadm_id.Name = "hadm_id";
            this.hadm_id.ReadOnly = true;
            this.hadm_id.ToolTipText = "入院记录标识";
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
            // charttime
            // 
            this.charttime.DataPropertyName = "charttime";
            this.charttime.HeaderText = " 观测进行的时间";
            this.charttime.Name = "charttime";
            this.charttime.ReadOnly = true;
            this.charttime.ToolTipText = " 观测进行的时间";
            // 
            // storetime
            // 
            this.storetime.DataPropertyName = "storetime";
            this.storetime.HeaderText = "记录值被⼈⼯验证输⼊系统的时间";
            this.storetime.Name = "storetime";
            this.storetime.ReadOnly = true;
            this.storetime.ToolTipText = "记录值被⼈⼯验证输⼊系统的时间";
            // 
            // cgid
            // 
            this.cgid.DataPropertyName = "cgid";
            this.cgid.HeaderText = "医护⼈员标识";
            this.cgid.Name = "cgid";
            this.cgid.ReadOnly = true;
            this.cgid.ToolTipText = "医护⼈员标识";
            // 
            // value
            // 
            this.value.DataPropertyName = "value";
            this.value.HeaderText = "ITEMID标识的项⽬测量的值";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.ToolTipText = "ITEMID标识的项⽬测量的值";
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
            // warning
            // 
            this.warning.DataPropertyName = "warning";
            this.warning.HeaderText = "Metaversion特定值增⾼警告的记录";
            this.warning.Name = "warning";
            this.warning.ReadOnly = true;
            this.warning.ToolTipText = "Metaversion特定值增⾼警告的记录";
            // 
            // error
            // 
            this.error.DataPropertyName = "error";
            this.error.HeaderText = "测量过程中发⽣了错误";
            this.error.Name = "error";
            this.error.ReadOnly = true;
            this.error.ToolTipText = "测量过程中发⽣了错误";
            // 
            // resultstatus
            // 
            this.resultstatus.DataPropertyName = "resultstatus";
            this.resultstatus.HeaderText = "CareVue特定测量的类型";
            this.resultstatus.Name = "resultstatus";
            this.resultstatus.ReadOnly = true;
            this.resultstatus.ToolTipText = "CareVue特定测量的类型";
            // 
            // stopped
            // 
            this.stopped.DataPropertyName = "stopped";
            this.stopped.HeaderText = "CareVue特定记录是否停⽌了测量";
            this.stopped.Name = "stopped";
            this.stopped.ReadOnly = true;
            this.stopped.ToolTipText = "CareVue特定记录是否停⽌了测量";
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
            // abbreviation
            // 
            this.abbreviation.DataPropertyName = "abbreviation";
            this.abbreviation.HeaderText = "Metavision特有，LABEL的缩写";
            this.abbreviation.Name = "abbreviation";
            this.abbreviation.ReadOnly = true;
            this.abbreviation.ToolTipText = "Metavision特有，LABEL的缩写";
            // 
            // linksto
            // 
            this.linksto.DataPropertyName = "linksto";
            this.linksto.HeaderText = "数据链接到的表名";
            this.linksto.Name = "linksto";
            this.linksto.ReadOnly = true;
            this.linksto.ToolTipText = "数据链接到的表名";
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "ITEMID对应的数据类型";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.ToolTipText = "ITEMID对应的数据类型";
            // 
            // unitname
            // 
            this.unitname.DataPropertyName = "unitname";
            this.unitname.HeaderText = "ITEMID表⽰的测量⽅法的单位";
            this.unitname.Name = "unitname";
            this.unitname.ReadOnly = true;
            this.unitname.ToolTipText = "ITEMID表⽰的测量⽅法的单位";
            // 
            // param_type
            // 
            this.param_type.DataPropertyName = "param_type";
            this.param_type.HeaderText = "描述记录的数据类型";
            this.param_type.Name = "param_type";
            this.param_type.ReadOnly = true;
            this.param_type.ToolTipText = "描述记录的数据类型";
            // 
            // conceptid
            // 
            this.conceptid.DataPropertyName = "conceptid";
            this.conceptid.HeaderText = "未知";
            this.conceptid.Name = "conceptid";
            this.conceptid.ReadOnly = true;
            this.conceptid.ToolTipText = "未知";
            // 
            // submit_wardid
            // 
            this.submit_wardid.DataPropertyName = "submit_wardid";
            this.submit_wardid.HeaderText = "提交出院申请的病房ID";
            this.submit_wardid.Name = "submit_wardid";
            this.submit_wardid.ReadOnly = true;
            this.submit_wardid.ToolTipText = "提交出院申请的病房ID";
            // 
            // submit_careunit
            // 
            this.submit_careunit.DataPropertyName = "submit_careunit";
            this.submit_careunit.HeaderText = "ICU费⽤中⼼类型";
            this.submit_careunit.Name = "submit_careunit";
            this.submit_careunit.ReadOnly = true;
            this.submit_careunit.ToolTipText = "ICU费⽤中⼼类型";
            // 
            // curr_wardid
            // 
            this.curr_wardid.DataPropertyName = "curr_wardid";
            this.curr_wardid.HeaderText = "病⼈callout时所在的病房ID";
            this.curr_wardid.Name = "curr_wardid";
            this.curr_wardid.ReadOnly = true;
            this.curr_wardid.ToolTipText = "病⼈callout时所在的病房ID";
            // 
            // curr_careunit
            // 
            this.curr_careunit.DataPropertyName = "curr_careunit";
            this.curr_careunit.HeaderText = "CURR_WARDID对应的ICU费⽤中⼼";
            this.curr_careunit.Name = "curr_careunit";
            this.curr_careunit.ReadOnly = true;
            this.curr_careunit.ToolTipText = "CURR_WARDID对应的ICU费⽤中⼼";
            // 
            // callout_wardid
            // 
            this.callout_wardid.DataPropertyName = "callout_wardid";
            this.callout_wardid.HeaderText = "病⼈从哪个病房出院";
            this.callout_wardid.Name = "callout_wardid";
            this.callout_wardid.ReadOnly = true;
            this.callout_wardid.ToolTipText = "病⼈从哪个病房出院";
            // 
            // callout_service
            // 
            this.callout_service.DataPropertyName = "callout_service";
            this.callout_service.HeaderText = "病⼈出院的服务";
            this.callout_service.Name = "callout_service";
            this.callout_service.ReadOnly = true;
            this.callout_service.ToolTipText = "病⼈出院的服务";
            // 
            // request_tele
            // 
            this.request_tele.DataPropertyName = "request_tele";
            this.request_tele.HeaderText = "值为⼆进制,表⽰病⼈是否要求了某种预防措施";
            this.request_tele.Name = "request_tele";
            this.request_tele.ReadOnly = true;
            this.request_tele.ToolTipText = "值为⼆进制,表⽰病⼈是否要求了某种预防措施";
            // 
            // request_resp
            // 
            this.request_resp.DataPropertyName = "request_resp";
            this.request_resp.HeaderText = "病⼈是否要求了某种预防措施1";
            this.request_resp.Name = "request_resp";
            this.request_resp.ReadOnly = true;
            this.request_resp.ToolTipText = "病⼈是否要求了某种预防措施1";
            // 
            // request_cdiff
            // 
            this.request_cdiff.DataPropertyName = "request_cdiff";
            this.request_cdiff.HeaderText = "病⼈是否要求了某种预防措施2";
            this.request_cdiff.Name = "request_cdiff";
            this.request_cdiff.ReadOnly = true;
            this.request_cdiff.ToolTipText = "病⼈是否要求了某种预防措施2";
            // 
            // request_mrsa
            // 
            this.request_mrsa.DataPropertyName = "request_mrsa";
            this.request_mrsa.HeaderText = "病⼈是否要求了某种预防措施3";
            this.request_mrsa.Name = "request_mrsa";
            this.request_mrsa.ReadOnly = true;
            this.request_mrsa.ToolTipText = "病⼈是否要求了某种预防措施3";
            // 
            // request_vre
            // 
            this.request_vre.DataPropertyName = "request_vre";
            this.request_vre.HeaderText = "病⼈是否要求了某种预防措施4";
            this.request_vre.Name = "request_vre";
            this.request_vre.ReadOnly = true;
            this.request_vre.ToolTipText = "病⼈是否要求了某种预防措施4";
            // 
            // callout_outcome
            // 
            this.callout_outcome.DataPropertyName = "callout_outcome";
            this.callout_outcome.HeaderText = "病⼈最终是否出院";
            this.callout_outcome.Name = "callout_outcome";
            this.callout_outcome.ReadOnly = true;
            this.callout_outcome.ToolTipText = "病⼈最终是否出院";
            // 
            // discharge_wardid
            // 
            this.discharge_wardid.DataPropertyName = "discharge_wardid";
            this.discharge_wardid.HeaderText = "病⼈出院的病房号,0代表home";
            this.discharge_wardid.Name = "discharge_wardid";
            this.discharge_wardid.ReadOnly = true;
            this.discharge_wardid.ToolTipText = "病⼈出院的病房号,0代表home";
            // 
            // acknowledge_status
            // 
            this.acknowledge_status.DataPropertyName = "acknowledge_status";
            this.acknowledge_status.HeaderText = "对callout请求的处理";
            this.acknowledge_status.Name = "acknowledge_status";
            this.acknowledge_status.ReadOnly = true;
            this.acknowledge_status.ToolTipText = "对callout请求的处理";
            // 
            // createtime
            // 
            this.createtime.DataPropertyName = "createtime";
            this.createtime.HeaderText = "callout请求发起时间";
            this.createtime.Name = "createtime";
            this.createtime.ReadOnly = true;
            this.createtime.ToolTipText = "callout请求发起时间";
            // 
            // updatetime
            // 
            this.updatetime.DataPropertyName = "updatetime";
            this.updatetime.HeaderText = "callout请求变更时间";
            this.updatetime.Name = "updatetime";
            this.updatetime.ReadOnly = true;
            this.updatetime.ToolTipText = "callout请求变更时间";
            // 
            // acknowledgetime
            // 
            this.acknowledgetime.DataPropertyName = "acknowledgetime";
            this.acknowledgetime.HeaderText = "callout请求⾸次应答时间";
            this.acknowledgetime.Name = "acknowledgetime";
            this.acknowledgetime.ReadOnly = true;
            this.acknowledgetime.ToolTipText = "callout请求⾸次应答时间";
            // 
            // outcometime
            // 
            this.outcometime.DataPropertyName = "outcometime";
            this.outcometime.HeaderText = "记录CALLOUT_OUTCOME的时间";
            this.outcometime.Name = "outcometime";
            this.outcometime.ReadOnly = true;
            this.outcometime.ToolTipText = "记录CALLOUT_OUTCOME的时间";
            // 
            // firstreservationtime
            // 
            this.firstreservationtime.DataPropertyName = "firstreservationtime";
            this.firstreservationtime.HeaderText = "病房预定信息1";
            this.firstreservationtime.Name = "firstreservationtime";
            this.firstreservationtime.ReadOnly = true;
            this.firstreservationtime.ToolTipText = "病房预定信息1";
            // 
            // currentreservationtime
            // 
            this.currentreservationtime.DataPropertyName = "currentreservationtime";
            this.currentreservationtime.HeaderText = "病房预定信息2";
            this.currentreservationtime.Name = "currentreservationtime";
            this.currentreservationtime.ReadOnly = true;
            this.currentreservationtime.ToolTipText = "病房预定信息2";
            // 
            // transfertime
            // 
            this.transfertime.DataPropertyName = "transfertime";
            this.transfertime.HeaderText = "从PREV_SERVICE转到CURR_SERVICE的时间";
            this.transfertime.Name = "transfertime";
            this.transfertime.ReadOnly = true;
            this.transfertime.ToolTipText = "从PREV_SERVICE转到CURR_SERVICE的时间";
            // 
            // prev_service
            // 
            this.prev_service.DataPropertyName = "prev_service";
            this.prev_service.HeaderText = "患者之前接受的服务";
            this.prev_service.Name = "prev_service";
            this.prev_service.ReadOnly = true;
            this.prev_service.ToolTipText = "患者之前接受的服务";
            // 
            // curr_service
            // 
            this.curr_service.DataPropertyName = "curr_service";
            this.curr_service.HeaderText = "患者现在接受的服务";
            this.curr_service.Name = "curr_service";
            this.curr_service.ReadOnly = true;
            this.curr_service.ToolTipText = "患者现在接受的服务";
            // 
            // eventtype
            // 
            this.eventtype.DataPropertyName = "eventtype";
            this.eventtype.HeaderText = "描述了入院，转院，出院事件";
            this.eventtype.Name = "eventtype";
            this.eventtype.ReadOnly = true;
            this.eventtype.ToolTipText = "描述了入院，转院，出院事件";
            // 
            // prev_careunit
            // 
            this.prev_careunit.DataPropertyName = "prev_careunit";
            this.prev_careunit.HeaderText = "患者之前住的护理单元";
            this.prev_careunit.Name = "prev_careunit";
            this.prev_careunit.ReadOnly = true;
            this.prev_careunit.ToolTipText = "患者之前住的护理单元";
            // 
            // prev_wardid
            // 
            this.prev_wardid.DataPropertyName = "prev_wardid";
            this.prev_wardid.HeaderText = "患者住的前⼀个病房";
            this.prev_wardid.Name = "prev_wardid";
            this.prev_wardid.ReadOnly = true;
            this.prev_wardid.ToolTipText = "患者住的前⼀个病房";
            // 
            // n_chartdate
            // 
            this.n_chartdate.DataPropertyName = "chartdate";
            this.n_chartdate.HeaderText = "记录患者注释的时间";
            this.n_chartdate.Name = "n_chartdate";
            this.n_chartdate.ReadOnly = true;
            this.n_chartdate.ToolTipText = "记录患者注释的时间";
            // 
            // n_description
            // 
            this.n_description.DataPropertyName = "description";
            this.n_description.HeaderText = "注释类别的描述";
            this.n_description.Name = "n_description";
            this.n_description.ReadOnly = true;
            this.n_description.ToolTipText = "注释类别的描述";
            // 
            // iserror
            // 
            this.iserror.DataPropertyName = "iserror";
            this.iserror.HeaderText = "医护⼈员是否认为该注释有错";
            this.iserror.Name = "iserror";
            this.iserror.ReadOnly = true;
            this.iserror.ToolTipText = "医护⼈员是否认为该注释有错";
            // 
            // text
            // 
            this.text.DataPropertyName = "text";
            this.text.HeaderText = "注释文本";
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.ToolTipText = "注释文本";
            // 
            // FrmPatientsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 470);
            this.Controls.Add(this.DGViewPatients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPatientsSearch";
            this.TabText = "搜索结果";
            this.Text = "搜索结果";
            this.Load += new System.EventHandler(this.FrmStuSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGViewPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.DataGridViewTextBoxColumn hadm_id;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn charttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn storetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueuom;
        private System.Windows.Forms.DataGridViewTextBoxColumn warning;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopped;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn label;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn linksto;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitname;
        private System.Windows.Forms.DataGridViewTextBoxColumn param_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptid;
        private System.Windows.Forms.DataGridViewTextBoxColumn submit_wardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn submit_careunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn curr_wardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn curr_careunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn callout_wardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn callout_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_tele;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_resp;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_cdiff;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_mrsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_vre;
        private System.Windows.Forms.DataGridViewTextBoxColumn callout_outcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn discharge_wardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn acknowledge_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn createtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn acknowledgetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn outcometime;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstreservationtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentreservationtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn transfertime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prev_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn curr_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn prev_careunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prev_wardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_chartdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn iserror;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
    }
}