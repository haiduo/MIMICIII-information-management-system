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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text =FrmLogin.user_id;//获取当前用户信息
            FrmMenu menu = new FrmMenu();
            menu.Show(dockPanel1, DockState.DockLeft);//菜单栏显示在dockpanel的左边
            dockPanel1.DockLeftPortion = 240;//菜单栏初始的宽度（像素）
            FrmHome home = new FrmHome();
            home.Show(dockPanel1);
        }
      
    }
}
