using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MIMIC
{
    public partial class FrmMenu : DockContent
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void lblPatientsSelect_Click(object sender, EventArgs e)
        {
            FrmPatientsSelect select = new FrmPatientsSelect();//实例化子窗体
            OpenForm(select);
        }

        private void lblICUSelect_Click(object sender, EventArgs e)
        {
            FrmICUPatientsSelect icu_select = new FrmICUPatientsSelect();
            OpenForm(icu_select);
        }

        private void lblCaseSelect_Click(object sender, EventArgs e)
        {
            FrmCaseSelect case_select = new FrmCaseSelect();
            OpenForm(case_select);
        }

        private void lblPatientsSearch_Click(object sender, EventArgs e)
        {
            FrmPatientsSearch search = new FrmPatientsSearch();//实例化子窗体
            OpenForm(search);
        }

        private void lblPatientsSearch1_Click(object sender, EventArgs e)
        {
            FrmPatientsSearch1 search1 = new FrmPatientsSearch1();
            OpenForm(search1);
        }

        private void lblPatientsSearch2_Click(object sender, EventArgs e)
        {
            FrmPatientsSearch2 search2 = new FrmPatientsSearch2();
            OpenForm(search2);
        }

        private void OpenForm(DockContent frm)
        {
            FrmMain main = (FrmMain)this.Parent.Parent.Parent.Parent;//获取当前窗体的父窗体
            string name = frm.Name;
            foreach (Form item in main.MdiChildren)
            {
                if (item.Name == name)
                {
                    item.Activate();//激活当前窗体，给予焦点
                    return;
                }
            }
            main.IsMdiContainer = true;//设置父窗体为容器窗体,与下句代码作用一样
            frm.MdiParent = main;//设置子窗体的父窗体 
            frm.Show(main.dockPanel1);//与上句代码效果一样

        }

    }
}
