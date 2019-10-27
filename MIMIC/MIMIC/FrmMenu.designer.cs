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
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("admissions");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("callout");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("icustays");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("patients");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("services");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("transfers");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("caregivers");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("chartevents");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("datetimeevents");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("inputevents_cv");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("inputevents_mv");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("noteevents");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("outputevents");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("procedureevents_mv");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("cptevents");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("diagnoses_icd");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("drgcodes");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("labevents");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("microbiologyevents");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("prescriptions");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("procedures_icd");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("d_cpt");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("d_icd_diagnoses");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("d_icd_procedures");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("d_items");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("d_labitems");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("所有表", new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode67,
            treeNode68,
            treeNode69,
            treeNode70,
            treeNode71,
            treeNode72,
            treeNode73,
            treeNode74,
            treeNode75,
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80});
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
            treeNode55.Name = "admissions";
            treeNode55.Text = "admissions";
            treeNode55.ToolTipText = "患者的基本信息，比如性别、民族、入院日期、出院日期等数据库中每个患者的每个特定住院(定义HADM ID)";
            treeNode56.Name = "callout";
            treeNode56.Text = "callout";
            treeNode56.ToolTipText = "患者离开ICU的过程（包含ICU声明和实际出院信息）";
            treeNode57.Name = "icustays";
            treeNode57.Text = "icustays";
            treeNode57.ToolTipText = "患者在ICU内的住院概要，比如进出ICU的时间数据库中每个唯一的ICU住院日(定义ICUSTAY ID)";
            treeNode58.Name = "patients";
            treeNode58.Text = "patients";
            treeNode58.ToolTipText = "患者的基本信息，包括年龄、性别数据库中每个唯一的患者(定义SUBJECT_ID)";
            treeNode59.Name = "services";
            treeNode59.Text = "services";
            treeNode59.ToolTipText = "记录患者在医院内的流转登记病人的临床服务";
            treeNode60.Name = "transfers";
            treeNode60.Text = "transfers";
            treeNode60.ToolTipText = "记录患者在医院内的流转病人在医院内床与床之间的移动，包括ICU的入院和出院";
            treeNode61.Name = "caregivers";
            treeNode61.Text = "caregivers";
            treeNode61.ToolTipText = "给予患者诊疗的医生类型每个在数据库中记录数据的照顾者(定义CGID)";
            treeNode62.Name = "chartevents";
            treeNode62.Text = "chartevents";
            treeNode62.ToolTipText = "患者住院期间的所有症状、体质、精神状态、实验室检查等";
            treeNode63.Name = "datetimeevents";
            treeNode63.Text = "datetimeevents";
            treeNode63.ToolTipText = "患者在ICU的每日表现所有记录的观察都是日期，例如透析时间或插入线的时间。";
            treeNode64.Name = "inputevents_cv";
            treeNode64.Text = "inputevents_cv";
            treeNode64.ToolTipText = "进入患者内的液体信息（数据来源于carevue）在ICU期间使用飞利浦护理系统监测患者的进食量";
            treeNode65.Name = "inputevents_mv";
            treeNode65.Text = "inputevents_mv";
            treeNode65.ToolTipText = "进入患者内的液体信息（数据来源于metavision）在ICU期间使用iMDSoft Metavision系统监测患者的进食量";
            treeNode66.Name = "noteevents";
            treeNode66.Text = "noteevents";
            treeNode66.ToolTipText = "患者报告，主要是一些不便于数字化的报告，包括护士和医生指出,心电图报告,成像报告和总结。";
            treeNode67.Name = "outputevents";
            treeNode67.Text = "outputevents";
            treeNode67.ToolTipText = "流出患者的液体信息输出病人在ICU期间的信息";
            treeNode68.Name = "procedureevents_mv";
            treeNode68.Text = "procedureevents_mv";
            treeNode68.ToolTipText = "患者的治疗过程（数据来源metavision）  对ICU中使用iMDSoft MetaVision系统进行监测的患者进行患者程序分析。";
            treeNode69.Name = "cptevents";
            treeNode69.Text = "cptevents";
            treeNode69.ToolTipText = "治疗措施，主要用于费用结算程序记录为当前程序的术语(CPT)代码";
            treeNode70.Name = "diagnoses_icd";
            treeNode70.Text = "diagnoses_icd";
            treeNode70.ToolTipText = "医院指定诊断，使用国际疾病和相关健康问题统计分类(ICD)系统编码";
            treeNode71.Name = "drgcodes";
            treeNode71.Text = "drgcodes";
            treeNode71.ToolTipText = "患者住院期间的所有诊断组（diagnosis related group）由医院用于计费目的";
            treeNode72.Name = "labevents";
            treeNode72.Text = "labevents";
            treeNode72.ToolTipText = "患者所有的实验室检查结果";
            treeNode73.Name = "microbiologyevents";
            treeNode73.Text = "microbiologyevents";
            treeNode73.ToolTipText = "微生物学检查结果";
            treeNode74.Name = "prescriptions";
            treeNode74.Text = "prescriptions";
            treeNode74.ToolTipText = "患者的处方";
            treeNode75.Name = "procedures_icd";
            treeNode75.Text = "procedures_icd";
            treeNode75.ToolTipText = "患者的诊断过程";
            treeNode76.Name = "d_cpt";
            treeNode76.Text = "d_cpt";
            treeNode76.ToolTipText = "治疗措施字典  (CPT)代码的高级词典";
            treeNode77.Name = "d_icd_diagnoses";
            treeNode77.Text = "d_icd_diagnoses";
            treeNode77.ToolTipText = "ICD-9诊断代码";
            treeNode78.Name = "d_icd_procedures";
            treeNode78.Text = "d_icd_procedures";
            treeNode78.ToolTipText = "诊断代码（针对治疗措施）";
            treeNode79.Name = "d_items";
            treeNode79.Text = "d_items";
            treeNode79.ToolTipText = "治疗措施治疗字典";
            treeNode80.Name = "d_labitems";
            treeNode80.Text = "d_labitems";
            treeNode80.ToolTipText = "实验室检查项目字典";
            treeNode81.Name = "Tables";
            treeNode81.Text = "所有表";
            treeNode81.ToolTipText = "所有表";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode81});
            this.treeView1.Size = new System.Drawing.Size(233, 328);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 673);
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