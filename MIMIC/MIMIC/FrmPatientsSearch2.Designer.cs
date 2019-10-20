namespace MIMIC
{
    partial class FrmPatientsSearch2
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
            this.icustay_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbsource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_wardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_wardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_careunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_careunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.los = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drg_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drg_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dr_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drg_severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drg_mortality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_charttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_valuenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_valueuom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_chartdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_charttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spec_itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spec_type_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isolate_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dilution_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dilution_comparison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dilution_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interpretation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drug_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drug_name_poe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drug_name_generic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formulary_drug_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_strength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dose_val_rx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dose_unit_rx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form_val_disp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form_unit_disp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.short_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.long_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_l_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fluid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loinc_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.icustay_id,
            this.dbsource,
            this.first_wardid,
            this.last_wardid,
            this.first_careunit,
            this.last_careunit,
            this.intime,
            this.outtime,
            this.los,
            this.drg_type,
            this.drg_code,
            this.dr_description,
            this.drg_severity,
            this.drg_mortality,
            this.l_charttime,
            this.l_value,
            this.l_valuenum,
            this.l_valueuom,
            this.l_flag,
            this.m_chartdate,
            this.m_charttime,
            this.spec_itemid,
            this.spec_type_desc,
            this.org_itemid,
            this.org_name,
            this.isolate_num,
            this.ab_itemid,
            this.ab_name,
            this.dilution_text,
            this.dilution_comparison,
            this.dilution_value,
            this.interpretation,
            this.startdate,
            this.enddate,
            this.drug_type,
            this.drug,
            this.drug_name_poe,
            this.drug_name_generic,
            this.formulary_drug_cd,
            this.gsn,
            this.ndc,
            this.prod_strength,
            this.dose_val_rx,
            this.dose_unit_rx,
            this.form_val_disp,
            this.form_unit_disp,
            this.route,
            this.short_title,
            this.long_title,
            this.d_l_label,
            this.fluid,
            this.category,
            this.loinc_code});
            this.DGViewPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewPatients.Location = new System.Drawing.Point(0, 0);
            this.DGViewPatients.Name = "DGViewPatients";
            this.DGViewPatients.ReadOnly = true;
            this.DGViewPatients.Size = new System.Drawing.Size(981, 470);
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
            // icustay_id
            // 
            this.icustay_id.DataPropertyName = "icustay_id";
            this.icustay_id.HeaderText = "入ICU记录标识";
            this.icustay_id.Name = "icustay_id";
            this.icustay_id.ReadOnly = true;
            this.icustay_id.ToolTipText = "入ICU记录标识";
            // 
            // dbsource
            // 
            this.dbsource.DataPropertyName = "dbsource";
            this.dbsource.HeaderText = "数据库来源";
            this.dbsource.Name = "dbsource";
            this.dbsource.ReadOnly = true;
            this.dbsource.ToolTipText = "数据库来源";
            // 
            // first_wardid
            // 
            this.first_wardid.DataPropertyName = "first_wardid";
            this.first_wardid.HeaderText = "患者第⼀次⼊住的ICU单元";
            this.first_wardid.Name = "first_wardid";
            this.first_wardid.ReadOnly = true;
            this.first_wardid.ToolTipText = "患者第⼀次⼊住的ICU单元";
            // 
            // last_wardid
            // 
            this.last_wardid.DataPropertyName = "last_wardid";
            this.last_wardid.HeaderText = "患者最后⼀次⼊住的ICU单元";
            this.last_wardid.Name = "last_wardid";
            this.last_wardid.ReadOnly = true;
            this.last_wardid.ToolTipText = "患者最后⼀次⼊住的ICU单元";
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
            this.los.HeaderText = "入住ICU的时长";
            this.los.Name = "los";
            this.los.ReadOnly = true;
            this.los.ToolTipText = "入住ICU的时长";
            // 
            // drg_type
            // 
            this.drg_type.DataPropertyName = "drg_type";
            this.drg_type.HeaderText = "DRG代码的类型";
            this.drg_type.Name = "drg_type";
            this.drg_type.ReadOnly = true;
            this.drg_type.ToolTipText = "DRG代码的类型";
            // 
            // drg_code
            // 
            this.drg_code.DataPropertyName = "drg_code";
            this.drg_code.HeaderText = "诊断代码";
            this.drg_code.Name = "drg_code";
            this.drg_code.ReadOnly = true;
            this.drg_code.ToolTipText = "诊断代码";
            // 
            // dr_description
            // 
            this.dr_description.DataPropertyName = "description";
            this.dr_description.HeaderText = "DRG_CODE进⾏⾃然语⾔的简述";
            this.dr_description.Name = "dr_description";
            this.dr_description.ReadOnly = true;
            this.dr_description.ToolTipText = "DRG_CODE进⾏⾃然语⾔的简述";
            // 
            // drg_severity
            // 
            this.drg_severity.DataPropertyName = "drg_severity";
            this.drg_severity.HeaderText = "额外的severity粒度";
            this.drg_severity.Name = "drg_severity";
            this.drg_severity.ReadOnly = true;
            this.drg_severity.ToolTipText = "额外的severity粒度";
            // 
            // drg_mortality
            // 
            this.drg_mortality.DataPropertyName = "drg_mortality";
            this.drg_mortality.HeaderText = "额外的mortality粒度";
            this.drg_mortality.Name = "drg_mortality";
            this.drg_mortality.ReadOnly = true;
            this.drg_mortality.ToolTipText = "额外的mortality粒度";
            // 
            // l_charttime
            // 
            this.l_charttime.DataPropertyName = "charttime";
            this.l_charttime.HeaderText = "labevents记录观察图表的时间";
            this.l_charttime.Name = "l_charttime";
            this.l_charttime.ReadOnly = true;
            this.l_charttime.ToolTipText = "labevents记录观察图表的时间";
            // 
            // l_value
            // 
            this.l_value.DataPropertyName = "value";
            this.l_value.HeaderText = "测量的值";
            this.l_value.Name = "l_value";
            this.l_value.ReadOnly = true;
            this.l_value.ToolTipText = "测量的值";
            // 
            // l_valuenum
            // 
            this.l_valuenum.DataPropertyName = "valuenum";
            this.l_valuenum.HeaderText = "分数和描述分数含义的⽂本";
            this.l_valuenum.Name = "l_valuenum";
            this.l_valuenum.ReadOnly = true;
            this.l_valuenum.ToolTipText = "分数和描述分数含义的⽂本";
            // 
            // l_valueuom
            // 
            this.l_valueuom.DataPropertyName = "valueuom";
            this.l_valueuom.HeaderText = "测量的值的单位";
            this.l_valueuom.Name = "l_valueuom";
            this.l_valueuom.ReadOnly = true;
            this.l_valueuom.ToolTipText = "测量的值的单位";
            // 
            // l_flag
            // 
            this.l_flag.DataPropertyName = "flag";
            this.l_flag.HeaderText = "实验室值是否正常";
            this.l_flag.Name = "l_flag";
            this.l_flag.ReadOnly = true;
            this.l_flag.ToolTipText = "实验室值是否正常";
            // 
            // m_chartdate
            // 
            this.m_chartdate.DataPropertyName = "chartdate";
            this.m_chartdate.HeaderText = "记录微⽣物学信息检测的时间";
            this.m_chartdate.Name = "m_chartdate";
            this.m_chartdate.ReadOnly = true;
            this.m_chartdate.ToolTipText = "记录微⽣物学信息检测的时间";
            // 
            // m_charttime
            // 
            this.m_charttime.DataPropertyName = "m_charttime";
            this.m_charttime.HeaderText = "具体时间";
            this.m_charttime.Name = "m_charttime";
            this.m_charttime.ReadOnly = true;
            this.m_charttime.ToolTipText = "具体时间";
            // 
            // spec_itemid
            // 
            this.spec_itemid.DataPropertyName = "spec_itemid";
            this.spec_itemid.HeaderText = "细菌⽣⻓的标本ID";
            this.spec_itemid.Name = "spec_itemid";
            this.spec_itemid.ReadOnly = true;
            this.spec_itemid.ToolTipText = "细菌⽣⻓的标本ID";
            // 
            // spec_type_desc
            // 
            this.spec_type_desc.DataPropertyName = "spec_type_desc";
            this.spec_type_desc.HeaderText = "描述标本类型";
            this.spec_type_desc.Name = "spec_type_desc";
            this.spec_type_desc.ReadOnly = true;
            this.spec_type_desc.ToolTipText = "描述标本类型";
            // 
            // org_itemid
            // 
            this.org_itemid.DataPropertyName = "org_itemid";
            this.org_itemid.HeaderText = "⽣物体ID";
            this.org_itemid.Name = "org_itemid";
            this.org_itemid.ReadOnly = true;
            this.org_itemid.ToolTipText = "⽣物体ID";
            // 
            // org_name
            // 
            this.org_name.DataPropertyName = "org_name";
            this.org_name.HeaderText = "⽣物体名称";
            this.org_name.Name = "org_name";
            this.org_name.ReadOnly = true;
            this.org_name.ToolTipText = "⽣物体名称";
            // 
            // isolate_num
            // 
            this.isolate_num.DataPropertyName = "isolate_num";
            this.isolate_num.HeaderText = "测试抗⽣素，分离的菌落";
            this.isolate_num.Name = "isolate_num";
            this.isolate_num.ReadOnly = true;
            this.isolate_num.ToolTipText = "测试抗⽣素，分离的菌落";
            // 
            // ab_itemid
            // 
            this.ab_itemid.DataPropertyName = "ab_itemid";
            this.ab_itemid.HeaderText = "抗⽣素针敏感性测试编号";
            this.ab_itemid.Name = "ab_itemid";
            this.ab_itemid.ReadOnly = true;
            this.ab_itemid.ToolTipText = "抗⽣素针敏感性测试编号";
            // 
            // ab_name
            // 
            this.ab_name.DataPropertyName = "ab_name";
            this.ab_name.HeaderText = "抗⽣素针敏感性测试名称";
            this.ab_name.Name = "ab_name";
            this.ab_name.ReadOnly = true;
            this.ab_name.ToolTipText = "抗⽣素针敏感性测试名称";
            // 
            // dilution_text
            // 
            this.dilution_text.DataPropertyName = "dilution_text";
            this.dilution_text.HeaderText = "稀释的文本";
            this.dilution_text.Name = "dilution_text";
            this.dilution_text.ReadOnly = true;
            this.dilution_text.ToolTipText = "稀释的文本";
            // 
            // dilution_comparison
            // 
            this.dilution_comparison.DataPropertyName = "dilution_comparison";
            this.dilution_comparison.HeaderText = "稀释的比较";
            this.dilution_comparison.Name = "dilution_comparison";
            this.dilution_comparison.ReadOnly = true;
            this.dilution_comparison.ToolTipText = "稀释的比较";
            // 
            // dilution_value
            // 
            this.dilution_value.DataPropertyName = "dilution_value";
            this.dilution_value.HeaderText = "测试抗⽣素敏感性时的稀释值";
            this.dilution_value.Name = "dilution_value";
            this.dilution_value.ReadOnly = true;
            this.dilution_value.ToolTipText = "测试抗⽣素敏感性时的稀释值";
            // 
            // interpretation
            // 
            this.interpretation.DataPropertyName = "interpretation";
            this.interpretation.HeaderText = "抗⽣素的敏感性并指出试验结果";
            this.interpretation.Name = "interpretation";
            this.interpretation.ReadOnly = true;
            this.interpretation.ToolTipText = "抗⽣素的敏感性并指出试验结果";
            // 
            // startdate
            // 
            this.startdate.DataPropertyName = "startdate";
            this.startdate.HeaderText = "制定处⽅有效的起始⽇期";
            this.startdate.Name = "startdate";
            this.startdate.ReadOnly = true;
            this.startdate.ToolTipText = "制定处⽅有效的起始⽇期";
            // 
            // enddate
            // 
            this.enddate.DataPropertyName = "enddate";
            this.enddate.HeaderText = "制定处⽅有效的结束⽇期";
            this.enddate.Name = "enddate";
            this.enddate.ReadOnly = true;
            this.enddate.ToolTipText = "制定处⽅有效的结束⽇期";
            // 
            // drug_type
            // 
            this.drug_type.DataPropertyName = "drug_type";
            this.drug_type.HeaderText = "药品的类型";
            this.drug_type.Name = "drug_type";
            this.drug_type.ReadOnly = true;
            this.drug_type.ToolTipText = "药品的类型";
            // 
            // drug
            // 
            this.drug.DataPropertyName = "drug";
            this.drug.HeaderText = "药品名称";
            this.drug.Name = "drug";
            this.drug.ReadOnly = true;
            this.drug.ToolTipText = "药品名称";
            // 
            // drug_name_poe
            // 
            this.drug_name_poe.DataPropertyName = "drug_name_poe";
            this.drug_name_poe.HeaderText = "药品名称1";
            this.drug_name_poe.Name = "drug_name_poe";
            this.drug_name_poe.ReadOnly = true;
            this.drug_name_poe.ToolTipText = "药品名称1";
            // 
            // drug_name_generic
            // 
            this.drug_name_generic.DataPropertyName = "drug_name_generic";
            this.drug_name_generic.HeaderText = "药品名称2";
            this.drug_name_generic.Name = "drug_name_generic";
            this.drug_name_generic.ReadOnly = true;
            this.drug_name_generic.ToolTipText = "药品名称2";
            // 
            // formulary_drug_cd
            // 
            this.formulary_drug_cd.DataPropertyName = "formulary_drug_cd";
            this.formulary_drug_cd.HeaderText = "标准药品编码";
            this.formulary_drug_cd.Name = "formulary_drug_cd";
            this.formulary_drug_cd.ReadOnly = true;
            this.formulary_drug_cd.ToolTipText = "标准药品编码";
            // 
            // gsn
            // 
            this.gsn.DataPropertyName = "gsn";
            this.gsn.HeaderText = "通⽤序列号";
            this.gsn.Name = "gsn";
            this.gsn.ReadOnly = true;
            this.gsn.ToolTipText = "通⽤序列号";
            // 
            // ndc
            // 
            this.ndc.DataPropertyName = "ndc";
            this.ndc.HeaderText = "国家（美国）药品编码";
            this.ndc.Name = "ndc";
            this.ndc.ReadOnly = true;
            this.ndc.ToolTipText = "国家（美国）药品编码";
            // 
            // prod_strength
            // 
            this.prod_strength.DataPropertyName = "prod_strength";
            this.prod_strength.HeaderText = "刺激强度";
            this.prod_strength.Name = "prod_strength";
            this.prod_strength.ReadOnly = true;
            this.prod_strength.ToolTipText = "刺激强度";
            // 
            // dose_val_rx
            // 
            this.dose_val_rx.DataPropertyName = "dose_val_rx";
            this.dose_val_rx.HeaderText = "剂量值";
            this.dose_val_rx.Name = "dose_val_rx";
            this.dose_val_rx.ReadOnly = true;
            this.dose_val_rx.ToolTipText = "剂量值";
            // 
            // dose_unit_rx
            // 
            this.dose_unit_rx.DataPropertyName = "dose_unit_rx";
            this.dose_unit_rx.HeaderText = "剂量单位";
            this.dose_unit_rx.Name = "dose_unit_rx";
            this.dose_unit_rx.ReadOnly = true;
            this.dose_unit_rx.ToolTipText = "剂量单位";
            // 
            // form_val_disp
            // 
            this.form_val_disp.DataPropertyName = "form_val_disp";
            this.form_val_disp.HeaderText = "剂量值1";
            this.form_val_disp.Name = "form_val_disp";
            this.form_val_disp.ReadOnly = true;
            this.form_val_disp.ToolTipText = "剂量值1";
            // 
            // form_unit_disp
            // 
            this.form_unit_disp.DataPropertyName = "form_unit_disp";
            this.form_unit_disp.HeaderText = "剂量单位1";
            this.form_unit_disp.Name = "form_unit_disp";
            this.form_unit_disp.ReadOnly = true;
            this.form_unit_disp.ToolTipText = "剂量单位1";
            // 
            // route
            // 
            this.route.DataPropertyName = "route";
            this.route.HeaderText = "用药途径";
            this.route.Name = "route";
            this.route.ReadOnly = true;
            this.route.ToolTipText = "用药途径";
            // 
            // short_title
            // 
            this.short_title.DataPropertyName = "short_title";
            this.short_title.HeaderText = "对icd9_code代码diagnoses的简单描述";
            this.short_title.Name = "short_title";
            this.short_title.ReadOnly = true;
            this.short_title.ToolTipText = "对icd9_code代码diagnoses的简单描述";
            // 
            // long_title
            // 
            this.long_title.DataPropertyName = "long_title";
            this.long_title.HeaderText = "对icd9_code代码diagnoses的详细描述";
            this.long_title.Name = "long_title";
            this.long_title.ReadOnly = true;
            this.long_title.ToolTipText = "对icd9_code代码diagnoses的详细描述";
            // 
            // d_l_label
            // 
            this.d_l_label.DataPropertyName = "label";
            this.d_l_label.HeaderText = "labevents的itemid代表的意思";
            this.d_l_label.Name = "d_l_label";
            this.d_l_label.ReadOnly = true;
            this.d_l_label.ToolTipText = "labevents的itemid代表的意思";
            // 
            // fluid
            // 
            this.fluid.DataPropertyName = "fluid";
            this.fluid.HeaderText = "检测的液体";
            this.fluid.Name = "fluid";
            this.fluid.ReadOnly = true;
            this.fluid.ToolTipText = "检测的液体";
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "数据类型";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.ToolTipText = "数据类型";
            // 
            // loinc_code
            // 
            this.loinc_code.DataPropertyName = "loinc_code";
            this.loinc_code.HeaderText = "itemid相关概念";
            this.loinc_code.Name = "loinc_code";
            this.loinc_code.ReadOnly = true;
            this.loinc_code.ToolTipText = "itemid相关概念";
            // 
            // FrmPatientsSearch2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 470);
            this.Controls.Add(this.DGViewPatients);
            this.Name = "FrmPatientsSearch2";
            this.TabText = "搜索结果2";
            this.Text = "搜索结果2";
            this.Load += new System.EventHandler(this.FrmPatientsSearch2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGViewPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn icustay_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbsource;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_wardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_wardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_careunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_careunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn intime;
        private System.Windows.Forms.DataGridViewTextBoxColumn outtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn los;
        private System.Windows.Forms.DataGridViewTextBoxColumn drg_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn drg_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dr_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn drg_severity;
        private System.Windows.Forms.DataGridViewTextBoxColumn drg_mortality;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_charttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_valuenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_valueuom;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_chartdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_charttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn spec_itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn spec_type_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn isolate_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dilution_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn dilution_comparison;
        private System.Windows.Forms.DataGridViewTextBoxColumn dilution_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn interpretation;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn drug_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn drug;
        private System.Windows.Forms.DataGridViewTextBoxColumn drug_name_poe;
        private System.Windows.Forms.DataGridViewTextBoxColumn drug_name_generic;
        private System.Windows.Forms.DataGridViewTextBoxColumn formulary_drug_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndc;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_strength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dose_val_rx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dose_unit_rx;
        private System.Windows.Forms.DataGridViewTextBoxColumn form_val_disp;
        private System.Windows.Forms.DataGridViewTextBoxColumn form_unit_disp;
        private System.Windows.Forms.DataGridViewTextBoxColumn route;
        private System.Windows.Forms.DataGridViewTextBoxColumn short_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn long_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_l_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn fluid;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn loinc_code;
    }
}