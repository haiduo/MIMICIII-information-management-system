namespace MIMIC
{
    partial class FrmPatientsSearch1
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
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountuom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkorderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newbottle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordercategoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondaryordercategoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordercomponenttypedescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordercategorydescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountuom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isopenbag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continueinnextdept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelreason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments_editedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments_canceledby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_charttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_valueuom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_storetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seq_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icd9_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costcenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpt_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpt_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpt_suffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_id_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionheader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subsectionheader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcpt_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionrange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcpt_sectionheader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subsectionrange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcp_subsectionheader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codesuffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mincodeinsubsection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxcodeinsubsection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_p_short_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_p_long_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.amount,
            this.amountuom,
            this.rate,
            this.orderid,
            this.linkorderid,
            this.stopped,
            this.newbottle,
            this.ordercategoryname,
            this.secondaryordercategoryname,
            this.ordercomponenttypedescription,
            this.ordercategorydescription,
            this.patientweight,
            this.totalamount,
            this.totalamountuom,
            this.isopenbag,
            this.continueinnextdept,
            this.cancelreason,
            this.statusdescription,
            this.comments_editedby,
            this.comments_canceledby,
            this.comments_date,
            this.originalamount,
            this.originalrate,
            this.o_charttime,
            this.o_value,
            this.o_valueuom,
            this.o_storetime,
            this.seq_num,
            this.icd9_code,
            this.costcenter,
            this.cpt_cd,
            this.cpt_number,
            this.cpt_suffix,
            this.ticket_id_seq,
            this.sectionheader,
            this.subsectionheader,
            this.cp_description,
            this.dcpt_category,
            this.sectionrange,
            this.dcpt_sectionheader,
            this.subsectionrange,
            this.dcp_subsectionheader,
            this.codesuffix,
            this.mincodeinsubsection,
            this.maxcodeinsubsection,
            this.d_p_short_title,
            this.d_p_long_title});
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
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "给予患者的药物或物质的量";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.ToolTipText = "给予患者的药物或物质的量";
            // 
            // amountuom
            // 
            this.amountuom.DataPropertyName = "amountuom";
            this.amountuom.HeaderText = "给予患者的药物或物质的量单位";
            this.amountuom.Name = "amountuom";
            this.amountuom.ReadOnly = true;
            this.amountuom.ToolTipText = "给予患者的药物或物质的量单位";
            // 
            // rate
            // 
            this.rate.DataPropertyName = "rate";
            this.rate.HeaderText = "给药的速率";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            this.rate.ToolTipText = "给药的速率";
            // 
            // orderid
            // 
            this.orderid.DataPropertyName = "orderid";
            this.orderid.HeaderText = "同⼀解决⽅案中包含的多个项⽬链接在⼀起";
            this.orderid.Name = "orderid";
            this.orderid.ReadOnly = true;
            this.orderid.ToolTipText = "同⼀解决⽅案中包含的多个项⽬链接在⼀起";
            // 
            // linkorderid
            // 
            this.linkorderid.DataPropertyName = "linkorderid";
            this.linkorderid.HeaderText = "多个实例中链接相同的顺序";
            this.linkorderid.Name = "linkorderid";
            this.linkorderid.ReadOnly = true;
            this.linkorderid.ToolTipText = "多个实例中链接相同的顺序";
            // 
            // stopped
            // 
            this.stopped.DataPropertyName = "stopped";
            this.stopped.HeaderText = "输液是否已断开或继续";
            this.stopped.Name = "stopped";
            this.stopped.ReadOnly = true;
            this.stopped.ToolTipText = "输液是否已断开或继续";
            // 
            // newbottle
            // 
            this.newbottle.DataPropertyName = "newbottle";
            this.newbottle.HeaderText = "是否在床边悬挂了新的溶液制剂";
            this.newbottle.Name = "newbottle";
            this.newbottle.ReadOnly = true;
            this.newbottle.ToolTipText = "是否在床边悬挂了新的溶液制剂";
            // 
            // ordercategoryname
            // 
            this.ordercategoryname.DataPropertyName = "ordercategoryname";
            this.ordercategoryname.HeaderText = "命令类型";
            this.ordercategoryname.Name = "ordercategoryname";
            this.ordercategoryname.ReadOnly = true;
            this.ordercategoryname.ToolTipText = "命令类型";
            // 
            // secondaryordercategoryname
            // 
            this.secondaryordercategoryname.DataPropertyName = "secondaryordercategoryname";
            this.secondaryordercategoryname.HeaderText = "⼆级命令类型";
            this.secondaryordercategoryname.Name = "secondaryordercategoryname";
            this.secondaryordercategoryname.ReadOnly = true;
            this.secondaryordercategoryname.ToolTipText = "⼆级命令类型";
            // 
            // ordercomponenttypedescription
            // 
            this.ordercomponenttypedescription.DataPropertyName = "ordercomponenttypedescription";
            this.ordercomponenttypedescription.HeaderText = "药物成分在治疗⽅案中的作⽤";
            this.ordercomponenttypedescription.Name = "ordercomponenttypedescription";
            this.ordercomponenttypedescription.ReadOnly = true;
            this.ordercomponenttypedescription.ToolTipText = "药物成分在治疗⽅案中的作⽤";
            // 
            // ordercategorydescription
            // 
            this.ordercategorydescription.DataPropertyName = "ordercategorydescription";
            this.ordercategorydescription.HeaderText = "药物类别在治疗⽅案中的作⽤";
            this.ordercategorydescription.Name = "ordercategorydescription";
            this.ordercategorydescription.ReadOnly = true;
            this.ordercategorydescription.ToolTipText = "药物类别在治疗⽅案中的作⽤";
            // 
            // patientweight
            // 
            this.patientweight.DataPropertyName = "patientweight";
            this.patientweight.HeaderText = "病⼈体重";
            this.patientweight.Name = "patientweight";
            this.patientweight.ReadOnly = true;
            this.patientweight.ToolTipText = "病⼈体重";
            // 
            // totalamount
            // 
            this.totalamount.DataPropertyName = "totalamount";
            this.totalamount.HeaderText = "溶液的袋中的流体总量";
            this.totalamount.Name = "totalamount";
            this.totalamount.ReadOnly = true;
            this.totalamount.ToolTipText = "溶液的袋中的流体总量";
            // 
            // totalamountuom
            // 
            this.totalamountuom.DataPropertyName = "totalamountuom";
            this.totalamountuom.HeaderText = "溶液的袋中的流体总量单位";
            this.totalamountuom.Name = "totalamountuom";
            this.totalamountuom.ReadOnly = true;
            this.totalamountuom.ToolTipText = "溶液的袋中的流体总量单位";
            // 
            // isopenbag
            // 
            this.isopenbag.DataPropertyName = "isopenbag";
            this.isopenbag.HeaderText = "是否是打开的袋";
            this.isopenbag.Name = "isopenbag";
            this.isopenbag.ReadOnly = true;
            this.isopenbag.ToolTipText = "是否是打开的袋";
            // 
            // continueinnextdept
            // 
            this.continueinnextdept.DataPropertyName = "continueinnextdept";
            this.continueinnextdept.HeaderText = "是否进⼊下⼀个部门";
            this.continueinnextdept.Name = "continueinnextdept";
            this.continueinnextdept.ReadOnly = true;
            this.continueinnextdept.ToolTipText = "是否进⼊下⼀个部门";
            // 
            // cancelreason
            // 
            this.cancelreason.DataPropertyName = "cancelreason";
            this.cancelreason.HeaderText = "治疗命令取消的原因";
            this.cancelreason.Name = "cancelreason";
            this.cancelreason.ReadOnly = true;
            this.cancelreason.ToolTipText = "治疗命令取消的原因";
            // 
            // statusdescription
            // 
            this.statusdescription.DataPropertyName = "statusdescription";
            this.statusdescription.HeaderText = "输液停⽌的原因";
            this.statusdescription.Name = "statusdescription";
            this.statusdescription.ReadOnly = true;
            this.statusdescription.ToolTipText = "输液停⽌的原因";
            // 
            // comments_editedby
            // 
            this.comments_editedby.DataPropertyName = "comments_editedby";
            this.comments_editedby.HeaderText = "治疗命令是否已编辑或取消";
            this.comments_editedby.Name = "comments_editedby";
            this.comments_editedby.ReadOnly = true;
            this.comments_editedby.ToolTipText = "治疗命令是否已编辑或取消";
            // 
            // comments_canceledby
            // 
            this.comments_canceledby.DataPropertyName = "comments_canceledby";
            this.comments_canceledby.HeaderText = "取消或编辑订单的⼈的职位";
            this.comments_canceledby.Name = "comments_canceledby";
            this.comments_canceledby.ReadOnly = true;
            this.comments_canceledby.ToolTipText = "取消或编辑订单的⼈的职位";
            // 
            // comments_date
            // 
            this.comments_date.DataPropertyName = "comments_date";
            this.comments_date.HeaderText = "取消或编辑订单的⼈的⽇期";
            this.comments_date.Name = "comments_date";
            this.comments_date.ReadOnly = true;
            this.comments_date.ToolTipText = "取消或编辑订单的⼈的⽇期";
            // 
            // originalamount
            // 
            this.originalamount.DataPropertyName = "originalamount";
            this.originalamount.HeaderText = "药物的剩余量";
            this.originalamount.Name = "originalamount";
            this.originalamount.ReadOnly = true;
            this.originalamount.ToolTipText = "药物的剩余量";
            // 
            // originalrate
            // 
            this.originalrate.DataPropertyName = "originalrate";
            this.originalrate.HeaderText = "原始输液速率";
            this.originalrate.Name = "originalrate";
            this.originalrate.ReadOnly = true;
            this.originalrate.ToolTipText = "原始输液速率";
            // 
            // o_charttime
            // 
            this.o_charttime.DataPropertyName = "charttime";
            this.o_charttime.HeaderText = "液体输出时间";
            this.o_charttime.Name = "o_charttime";
            this.o_charttime.ReadOnly = true;
            this.o_charttime.ToolTipText = "液体输出时间";
            // 
            // o_value
            // 
            this.o_value.DataPropertyName = "value";
            this.o_value.HeaderText = "流出液体物质的量";
            this.o_value.Name = "o_value";
            this.o_value.ReadOnly = true;
            this.o_value.ToolTipText = "流出液体物质的量";
            // 
            // o_valueuom
            // 
            this.o_valueuom.DataPropertyName = "valueuom";
            this.o_valueuom.HeaderText = "流出液体物质的量的单位";
            this.o_valueuom.Name = "o_valueuom";
            this.o_valueuom.ReadOnly = true;
            this.o_valueuom.ToolTipText = "流出液体物质的量的单位";
            // 
            // o_storetime
            // 
            this.o_storetime.DataPropertyName = "storetime";
            this.o_storetime.HeaderText = "流出液体医护⼈员⼿动验证和输⼊数据的时间";
            this.o_storetime.Name = "o_storetime";
            this.o_storetime.ReadOnly = true;
            this.o_storetime.ToolTipText = "流出液体医护⼈员⼿动验证和输⼊数据的时间";
            // 
            // seq_num
            // 
            this.seq_num.DataPropertyName = "seq_num";
            this.seq_num.HeaderText = "procedure执⾏顺序";
            this.seq_num.Name = "seq_num";
            this.seq_num.ReadOnly = true;
            this.seq_num.ToolTipText = "procedure执⾏顺序";
            // 
            // icd9_code
            // 
            this.icd9_code.DataPropertyName = "icd9_code";
            this.icd9_code.HeaderText = "给定procedure对应的ICD-9代码";
            this.icd9_code.Name = "icd9_code";
            this.icd9_code.ReadOnly = true;
            this.icd9_code.ToolTipText = "给定procedure对应的ICD-9代码";
            // 
            // costcenter
            // 
            this.costcenter.DataPropertyName = "costcenter";
            this.costcenter.HeaderText = "收费的成本中⼼";
            this.costcenter.Name = "costcenter";
            this.costcenter.ReadOnly = true;
            this.costcenter.ToolTipText = "收费的成本中⼼";
            // 
            // cpt_cd
            // 
            this.cpt_cd.DataPropertyName = "cpt_cd";
            this.cpt_cd.HeaderText = "治疗代码";
            this.cpt_cd.Name = "cpt_cd";
            this.cpt_cd.ReadOnly = true;
            this.cpt_cd.ToolTipText = "治疗代码";
            // 
            // cpt_number
            // 
            this.cpt_number.DataPropertyName = "cpt_number";
            this.cpt_number.HeaderText = "CPT_CD列的数字形式";
            this.cpt_number.Name = "cpt_number";
            this.cpt_number.ReadOnly = true;
            this.cpt_number.ToolTipText = "CPT_CD列的数字形式";
            // 
            // cpt_suffix
            // 
            this.cpt_suffix.DataPropertyName = "cpt_suffix";
            this.cpt_suffix.HeaderText = "CPT_SUFFIX列包含⽂本后缀";
            this.cpt_suffix.Name = "cpt_suffix";
            this.cpt_suffix.ReadOnly = true;
            this.cpt_suffix.ToolTipText = "CPT_SUFFIX列包含⽂本后缀";
            // 
            // ticket_id_seq
            // 
            this.ticket_id_seq.DataPropertyName = "ticket_id_seq";
            this.ticket_id_seq.HeaderText = "CPT_CD顺序";
            this.ticket_id_seq.Name = "ticket_id_seq";
            this.ticket_id_seq.ReadOnly = true;
            this.ticket_id_seq.ToolTipText = "CPT_CD顺序";
            // 
            // sectionheader
            // 
            this.sectionheader.DataPropertyName = "sectionheader";
            this.sectionheader.HeaderText = "标题，标志CPT类别";
            this.sectionheader.Name = "sectionheader";
            this.sectionheader.ReadOnly = true;
            this.sectionheader.ToolTipText = "标题，标志CPT类别";
            // 
            // subsectionheader
            // 
            this.subsectionheader.DataPropertyName = "subsectionheader";
            this.subsectionheader.HeaderText = "⼦标题，标志CPT类别";
            this.subsectionheader.Name = "subsectionheader";
            this.subsectionheader.ReadOnly = true;
            this.subsectionheader.ToolTipText = "⼦标题，标志CPT类别";
            // 
            // cp_description
            // 
            this.cp_description.DataPropertyName = "description";
            this.cp_description.HeaderText = "呼吸成本中⼼的CPT代码的解释";
            this.cp_description.Name = "cp_description";
            this.cp_description.ReadOnly = true;
            this.cp_description.ToolTipText = "呼吸成本中⼼的CPT代码的解释";
            // 
            // dcpt_category
            // 
            this.dcpt_category.DataPropertyName = "category";
            this.dcpt_category.HeaderText = "定义CPT_Code的类别";
            this.dcpt_category.Name = "dcpt_category";
            this.dcpt_category.ReadOnly = true;
            this.dcpt_category.ToolTipText = "定义CPT_Code的类别";
            // 
            // sectionrange
            // 
            this.sectionrange.DataPropertyName = "sectionrange";
            this.sectionrange.HeaderText = "给定部分的代码范围";
            this.sectionrange.Name = "sectionrange";
            this.sectionrange.ReadOnly = true;
            this.sectionrange.ToolTipText = "给定部分的代码范围";
            // 
            // dcpt_sectionheader
            // 
            this.dcpt_sectionheader.DataPropertyName = "dcpt_sectionheader";
            this.dcpt_sectionheader.HeaderText = "给定部分的描述";
            this.dcpt_sectionheader.Name = "dcpt_sectionheader";
            this.dcpt_sectionheader.ReadOnly = true;
            this.dcpt_sectionheader.ToolTipText = "给定部分的描述";
            // 
            // subsectionrange
            // 
            this.subsectionrange.DataPropertyName = "subsectionrange";
            this.subsectionrange.HeaderText = "给定⼦部分的代码范围";
            this.subsectionrange.Name = "subsectionrange";
            this.subsectionrange.ReadOnly = true;
            this.subsectionrange.ToolTipText = "给定⼦部分的代码范围";
            // 
            // dcp_subsectionheader
            // 
            this.dcp_subsectionheader.DataPropertyName = "dcp_subsectionheader";
            this.dcp_subsectionheader.HeaderText = "给定⼦部分的描述";
            this.dcp_subsectionheader.Name = "dcp_subsectionheader";
            this.dcp_subsectionheader.ReadOnly = true;
            this.dcp_subsectionheader.ToolTipText = "给定⼦部分的描述";
            // 
            // codesuffix
            // 
            this.codesuffix.DataPropertyName = "codesuffix";
            this.codesuffix.HeaderText = "⽂本后缀";
            this.codesuffix.Name = "codesuffix";
            this.codesuffix.ReadOnly = true;
            this.codesuffix.ToolTipText = "⽂本后缀";
            // 
            // mincodeinsubsection
            // 
            this.mincodeinsubsection.DataPropertyName = "mincodeinsubsection";
            this.mincodeinsubsection.HeaderText = "代码范围的最小值";
            this.mincodeinsubsection.Name = "mincodeinsubsection";
            this.mincodeinsubsection.ReadOnly = true;
            this.mincodeinsubsection.ToolTipText = "代码范围的最小值";
            // 
            // maxcodeinsubsection
            // 
            this.maxcodeinsubsection.DataPropertyName = "maxcodeinsubsection";
            this.maxcodeinsubsection.HeaderText = "代码范围的最大值";
            this.maxcodeinsubsection.Name = "maxcodeinsubsection";
            this.maxcodeinsubsection.ReadOnly = true;
            this.maxcodeinsubsection.ToolTipText = "代码范围的最大值";
            // 
            // d_p_short_title
            // 
            this.d_p_short_title.DataPropertyName = "short_title";
            this.d_p_short_title.HeaderText = "对icd9_code代码procedure的简单描述";
            this.d_p_short_title.Name = "d_p_short_title";
            this.d_p_short_title.ReadOnly = true;
            this.d_p_short_title.ToolTipText = "对icd9_code代码procedure的简单描述";
            // 
            // d_p_long_title
            // 
            this.d_p_long_title.DataPropertyName = "long_title";
            this.d_p_long_title.HeaderText = "对icd9_code代码procedure的详细描述";
            this.d_p_long_title.Name = "d_p_long_title";
            this.d_p_long_title.ReadOnly = true;
            this.d_p_long_title.ToolTipText = "对icd9_code代码procedure的详细描述";
            // 
            // FrmPatientsSearch1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 470);
            this.Controls.Add(this.DGViewPatients);
            this.Name = "FrmPatientsSearch1";
            this.TabText = "搜索结果1";
            this.Text = "搜索结果1";
            this.Load += new System.EventHandler(this.FrmPatientsSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGViewPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountuom;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkorderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopped;
        private System.Windows.Forms.DataGridViewTextBoxColumn newbottle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordercategoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondaryordercategoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordercomponenttypedescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordercategorydescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountuom;
        private System.Windows.Forms.DataGridViewTextBoxColumn isopenbag;
        private System.Windows.Forms.DataGridViewTextBoxColumn continueinnextdept;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelreason;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments_editedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments_canceledby;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_charttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_valueuom;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_storetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn seq_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn icd9_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn costcenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpt_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpt_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpt_suffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_id_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionheader;
        private System.Windows.Forms.DataGridViewTextBoxColumn subsectionheader;
        private System.Windows.Forms.DataGridViewTextBoxColumn cp_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcpt_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionrange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcpt_sectionheader;
        private System.Windows.Forms.DataGridViewTextBoxColumn subsectionrange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcp_subsectionheader;
        private System.Windows.Forms.DataGridViewTextBoxColumn codesuffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn mincodeinsubsection;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxcodeinsubsection;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_p_short_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_p_long_title;
    }
}