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

        private void lblPatientsSearch_Click(object sender, EventArgs e)
        {
            FrmPatientsSearch search = new FrmPatientsSearch();//实例化子窗体
            OpenForm(search);
        }
    
        private void lblicuSelect_Click(object sender, EventArgs e)
        {
            FrmICUPatientsSelect icu_select = new FrmICUPatientsSelect();
            OpenForm(icu_select);
        }

        private void lblicuSearch_Click(object sender, EventArgs e)
        {
            FrmICUPatientsSearch icu_search = new FrmICUPatientsSearch();
            OpenForm(icu_search);
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
