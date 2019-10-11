using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MIMIC.UserinfoService;
using System.ServiceModel;

namespace MIMIC
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user_id = txtUser.Text.Trim();
            string user_pwd = Program.md5(txtPwd.Text);
            string ip_addr = txtIp_addr.Text.Trim();
            string mac_addr = txtMac_addr.Text.Trim();
            UserinfoServiceSoapClient us = new UserinfoServiceSoapClient();
            try
            {
                string message = us.Register(user_id, user_pwd, ip_addr, mac_addr);
                if (message == "true")
                {
                    MessageBox.Show("恭喜，注册成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("注册信息格式不正确", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FaultException )
            {
                MessageBox.Show("用户名已经注册过啦", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // MessageBox.Show(faultEx.Message, "异常");
            }

        }

        //取消按钮
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
