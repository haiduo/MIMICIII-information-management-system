using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MIMIC.PatientsService;

namespace MIMIC
{
    public partial class FrmCaseSelect : DockContent
    {
        public FrmCaseSelect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 病人控件的键盘事件,用户查询病人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtstu_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return) //判断用户按下的是不是回车键
            {
                patients.subject_id = txtsubject_id.Text.Trim();//把控件中的值，赋给实体对象的属
                patients.hadm_id = txthadm_id.Text;
                patients.icustay_id = txticustay_id.Text;
                patients.gender = txtgender.Text;
                patients.itemid = txtitemid.Text;
                patients.label = txtlabel.Text;
                patients.charttime = txtcharttime.Text;
                patients.valuenum = txtvaluenum.Text;
                patients.valueuom = txtvalueuom.Text;

                FrmCaseSelect_Search Case_Select_Search = new FrmCaseSelect_Search();//实例化子窗体
                OpenForm(Case_Select_Search);
            }
        }

        /// <summary>
        /// 点击查询
        /// </summary>
        public static Patients patients = new Patients();//对应表的实体（Model)对象

        private void btnSelect_Click(object sender, EventArgs e)
        {
            patients.subject_id = txtsubject_id.Text.Trim();//把控件中的值，赋给实体对象的属
            patients.hadm_id = txthadm_id.Text;
            patients.icustay_id = txticustay_id.Text;
            patients.gender = txtgender.Text;
            patients.itemid = txtitemid.Text;
            patients.label = txtlabel.Text;
            patients.charttime = txtcharttime.Text;
            patients.valuenum = txtvaluenum.Text;
            patients.valueuom = txtvalueuom.Text;

            FrmCaseSelect_Search Case_Select_Search = new FrmCaseSelect_Search();//实例化子窗体
            OpenForm(Case_Select_Search);
        }

        private void OpenForm(DockContent frm)
        {
            FrmMain main = (FrmMain)this.Parent.Parent;//获取当前窗体的父窗体
            string name = frm.Name;

            main.IsMdiContainer = true;//设置父窗体为容器窗体,与下句代码作用一样
            frm.MdiParent = main;//设置子窗体的父窗体 
            frm.Show(main.dockPanel1);//与上句代码效果一样

        }
    }
}
