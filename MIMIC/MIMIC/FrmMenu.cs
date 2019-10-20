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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Index)//字符串
            {
                case 0:
                    {
                        Table1 search = new Table1();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 1:
                    {
                        Table2 search = new Table2();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 2:
                    {
                        Table3 search = new Table3();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 3:
                    {
                        Table4 search = new Table4();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 4:
                    {
                        Table5 search = new Table5();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 5:
                    {
                        Table6 search = new Table6();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 6:
                    {
                        Table7 search = new Table7();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 7:
                    {
                        Table8 search = new Table8();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 8:
                    {
                        Table9 search = new Table9();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 9:
                    {
                        Table10 search = new Table10();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 10:
                    {
                        Table11 search = new Table11();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 11:
                    {
                        Table12 search = new Table12();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 12:
                    {
                        Table13 search = new Table13();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 13:
                    {
                        Table14 search = new Table14();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 14:
                    {
                        Table15 search = new Table15();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 15:
                    {
                        Table16 search = new Table16();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 16:
                    {
                        Table17 search = new Table17();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 17:
                    {
                        Table18 search = new Table18();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 18:
                    {
                        Table19 search = new Table19();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 19:
                    {
                        Table20 search = new Table20();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 20:
                    {
                        Table21 search = new Table21();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 21:
                    {
                        Table22 search = new Table22();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 22:
                    {
                        Table23 search = new Table23();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 23:
                    {
                        Table24 search = new Table24();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 24:
                    {
                        Table25 search = new Table25();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
                case 25:
                    {
                        Table26 search = new Table26();//实例化子窗体
                        OpenForm(search);
                    }
                    break;
            }

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            treeView1.LabelEdit = true;//可编辑状态
            treeView1.ExpandAll();
        }

    }
}
