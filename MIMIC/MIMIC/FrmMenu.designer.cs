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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("admissions");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("callout");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("icustays");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("patients");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("services");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("transfers");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("caregivers");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("chartevents");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("datetimeevents");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("inputevents_cv");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("inputevents_mv");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("noteevents");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("outputevents");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("procedureevents_mv");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("cptevents");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("diagnoses_icd");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("drgcodes");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("labevents");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("microbiologyevents");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("prescriptions");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("procedures_icd");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("d_cpt");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("d_icd_diagnoses");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("d_icd_procedures");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("d_items");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("d_labitems");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("所有表", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            this.lblPatientsSelect = new System.Windows.Forms.Label();
            this.lblPatientsSearch = new System.Windows.Forms.Label();
            this.lblicuSelect = new System.Windows.Forms.Label();
            this.lblicuSearch = new System.Windows.Forms.Label();
            this.lblCaseSelect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lblPatientsSelect
            // 
            this.lblPatientsSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPatientsSelect.ForeColor = System.Drawing.Color.Black;
            this.lblPatientsSelect.Image = ((System.Drawing.Image)(resources.GetObject("lblPatientsSelect.Image")));
            this.lblPatientsSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPatientsSelect.Location = new System.Drawing.Point(18, 13);
            this.lblPatientsSelect.Name = "lblPatientsSelect";
            this.lblPatientsSelect.Size = new System.Drawing.Size(60, 55);
            this.lblPatientsSelect.TabIndex = 0;
            this.lblPatientsSelect.Text = "基本查询";
            this.lblPatientsSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPatientsSelect.Click += new System.EventHandler(this.lblPatientsSelect_Click);
            // 
            // lblPatientsSearch
            // 
            this.lblPatientsSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPatientsSearch.Image = ((System.Drawing.Image)(resources.GetObject("lblPatientsSearch.Image")));
            this.lblPatientsSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPatientsSearch.Location = new System.Drawing.Point(103, 13);
            this.lblPatientsSearch.Name = "lblPatientsSearch";
            this.lblPatientsSearch.Size = new System.Drawing.Size(60, 55);
            this.lblPatientsSearch.TabIndex = 1;
            this.lblPatientsSearch.Text = "数据库1";
            this.lblPatientsSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPatientsSearch.Click += new System.EventHandler(this.lblPatientsSearch_Click);
            // 
            // lblicuSelect
            // 
            this.lblicuSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblicuSelect.Image = ((System.Drawing.Image)(resources.GetObject("lblicuSelect.Image")));
            this.lblicuSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblicuSelect.Location = new System.Drawing.Point(18, 114);
            this.lblicuSelect.Name = "lblicuSelect";
            this.lblicuSelect.Size = new System.Drawing.Size(60, 55);
            this.lblicuSelect.TabIndex = 1;
            this.lblicuSelect.Text = "ICU查询";
            this.lblicuSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblicuSelect.Click += new System.EventHandler(this.lblICUSelect_Click);
            // 
            // lblicuSearch
            // 
            this.lblicuSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblicuSearch.Image = ((System.Drawing.Image)(resources.GetObject("lblicuSearch.Image")));
            this.lblicuSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblicuSearch.Location = new System.Drawing.Point(103, 114);
            this.lblicuSearch.Name = "lblicuSearch";
            this.lblicuSearch.Size = new System.Drawing.Size(60, 55);
            this.lblicuSearch.TabIndex = 1;
            this.lblicuSearch.Text = "数据库2";
            this.lblicuSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblicuSearch.Click += new System.EventHandler(this.lblPatientsSearch1_Click);
            // 
            // lblCaseSelect
            // 
            this.lblCaseSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCaseSelect.Image = ((System.Drawing.Image)(resources.GetObject("lblCaseSelect.Image")));
            this.lblCaseSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCaseSelect.Location = new System.Drawing.Point(18, 217);
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
            this.label2.Location = new System.Drawing.Point(103, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库3";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Click += new System.EventHandler(this.lblPatientsSearch2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 294);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "admissions";
            treeNode1.Text = "admissions";
            treeNode1.ToolTipText = "患者的基本信息，比如性别、民族、入院日期、出院日期等数据库中每个患者的每个特定住院(定义HADM ID)";
            treeNode2.Name = "callout";
            treeNode2.Text = "callout";
            treeNode2.ToolTipText = "患者离开ICU的过程（包含ICU声明和实际出院信息）";
            treeNode3.Name = "icustays";
            treeNode3.Text = "icustays";
            treeNode3.ToolTipText = "患者在ICU内的住院概要，比如进出ICU的时间数据库中每个唯一的ICU住院日(定义ICUSTAY ID)";
            treeNode4.Name = "patients";
            treeNode4.Text = "patients";
            treeNode4.ToolTipText = "患者的基本信息，包括年龄、性别数据库中每个唯一的患者(定义SUBJECT_ID)";
            treeNode5.Name = "services";
            treeNode5.Text = "services";
            treeNode5.ToolTipText = "记录患者在医院内的流转登记病人的临床服务";
            treeNode6.Name = "transfers";
            treeNode6.Text = "transfers";
            treeNode6.ToolTipText = "记录患者在医院内的流转病人在医院内床与床之间的移动，包括ICU的入院和出院";
            treeNode7.Name = "caregivers";
            treeNode7.Text = "caregivers";
            treeNode7.ToolTipText = "给予患者诊疗的医生类型每个在数据库中记录数据的照顾者(定义CGID)";
            treeNode8.Name = "chartevents";
            treeNode8.Text = "chartevents";
            treeNode8.ToolTipText = "患者住院期间的所有症状、体质、精神状态、实验室检查等";
            treeNode9.Name = "datetimeevents";
            treeNode9.Text = "datetimeevents";
            treeNode9.ToolTipText = "患者在ICU的每日表现所有记录的观察都是日期，例如透析时间或插入线的时间。";
            treeNode10.Name = "inputevents_cv";
            treeNode10.Text = "inputevents_cv";
            treeNode10.ToolTipText = "进入患者内的液体信息（数据来源于carevue）在ICU期间使用飞利浦护理系统监测患者的进食量";
            treeNode11.Name = "inputevents_mv";
            treeNode11.Text = "inputevents_mv";
            treeNode11.ToolTipText = "进入患者内的液体信息（数据来源于metavision）在ICU期间使用iMDSoft Metavision系统监测患者的进食量";
            treeNode12.Name = "noteevents";
            treeNode12.Text = "noteevents";
            treeNode12.ToolTipText = "患者报告，主要是一些不便于数字化的报告，包括护士和医生指出,心电图报告,成像报告和总结。";
            treeNode13.Name = "outputevents";
            treeNode13.Text = "outputevents";
            treeNode13.ToolTipText = "流出患者的液体信息输出病人在ICU期间的信息";
            treeNode14.Name = "procedureevents_mv";
            treeNode14.Text = "procedureevents_mv";
            treeNode14.ToolTipText = "患者的治疗过程（数据来源metavision）  对ICU中使用iMDSoft MetaVision系统进行监测的患者进行患者程序分析。";
            treeNode15.Name = "cptevents";
            treeNode15.Text = "cptevents";
            treeNode15.ToolTipText = "治疗措施，主要用于费用结算程序记录为当前程序的术语(CPT)代码";
            treeNode16.Name = "diagnoses_icd";
            treeNode16.Text = "diagnoses_icd";
            treeNode16.ToolTipText = "医院指定诊断，使用国际疾病和相关健康问题统计分类(ICD)系统编码";
            treeNode17.Name = "drgcodes";
            treeNode17.Text = "drgcodes";
            treeNode17.ToolTipText = "患者住院期间的所有诊断组（diagnosis related group）由医院用于计费目的";
            treeNode18.Name = "labevents";
            treeNode18.Text = "labevents";
            treeNode18.ToolTipText = "患者所有的实验室检查结果";
            treeNode19.Name = "microbiologyevents";
            treeNode19.Text = "microbiologyevents";
            treeNode19.ToolTipText = "微生物学检查结果";
            treeNode20.Name = "prescriptions";
            treeNode20.Text = "prescriptions";
            treeNode20.ToolTipText = "患者的处方";
            treeNode21.Name = "procedures_icd";
            treeNode21.Text = "procedures_icd";
            treeNode21.ToolTipText = "患者的诊断过程";
            treeNode22.Name = "d_cpt";
            treeNode22.Text = "d_cpt";
            treeNode22.ToolTipText = "治疗措施字典  (CPT)代码的高级词典";
            treeNode23.Name = "d_icd_diagnoses";
            treeNode23.Text = "d_icd_diagnoses";
            treeNode23.ToolTipText = "ICD-9诊断代码";
            treeNode24.Name = "d_icd_procedures";
            treeNode24.Text = "d_icd_procedures";
            treeNode24.ToolTipText = "诊断代码（针对治疗措施）";
            treeNode25.Name = "d_items";
            treeNode25.Text = "d_items";
            treeNode25.ToolTipText = "治疗措施治疗字典";
            treeNode26.Name = "d_labitems";
            treeNode26.Text = "d_labitems";
            treeNode26.ToolTipText = "实验室检查项目字典";
            treeNode27.Name = "Tables";
            treeNode27.Text = "所有表";
            treeNode27.ToolTipText = "所有表";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27});
            this.treeView1.Size = new System.Drawing.Size(232, 461);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 783);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblicuSearch);
            this.Controls.Add(this.lblCaseSelect);
            this.Controls.Add(this.lblicuSelect);
            this.Controls.Add(this.lblPatientsSearch);
            this.Controls.Add(this.lblPatientsSelect);
            this.Name = "FrmMenu";
            this.TabText = "菜单栏";
            this.Text = "菜单栏";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPatientsSelect;
        private System.Windows.Forms.Label lblPatientsSearch;
        private System.Windows.Forms.Label lblicuSelect;
        private System.Windows.Forms.Label lblicuSearch;
        private System.Windows.Forms.Label lblCaseSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
    }
}