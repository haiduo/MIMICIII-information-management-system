using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Npgsql;
using MIMIC.UserinfoService;
using Microsoft.Win32;
using System.Net;
using System.Net.Sockets;

namespace MIMIC
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FemLogin_Load(object sender, EventArgs e)
        {

        }

        //登录按钮
        private void btnYes_Click_1(object sender, EventArgs e)
        {
            Login();
            
        }

        //取消按钮
        private void btnNo_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            frm.ShowDialog();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return) //判断用户按下的见是否为回车
            {
                Login();
            }
        }

        private void Login()
        {
            string user_id = txtUser.Text.Trim();
            string user_pwd = Program.md5(txtPwd.Text);
            //获取本地IP地址
            string ip_addr =string.Empty ;//局部变量记得赋值
            string HostName = Dns.GetHostName();//得到主机名
            IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
            for (int i = 0; i < IpEntry.AddressList.Length; i++)
            {
                //从IP地址列表筛选出IPv4类型的IP地址
                //AddressFamily.InterNetwork表示为Ipv4
                 //AddressFamily.InterNetworkV6表示IPv6
                if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    ip_addr = IpEntry.AddressList[i].ToString();
                }
            }

            UserinfoServiceSoapClient us = new UserinfoServiceSoapClient();
            string flag;
                flag = us.Login(user_id, user_pwd, ip_addr);
                //FrmMain.user_group = "A";
                if (flag == "true")
                {
                   // FrmMain.user_id = user_id;
                    MessageBox.Show("登陆成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    if (flag == "login_false")
                        MessageBox.Show("登陆失败，用户名或密码错误", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("IP地址受限，登录失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           

    }
}
