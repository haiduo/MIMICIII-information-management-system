using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MIMIC
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmLogin());
		}

        /// <summary>
        /// 加密用户密码
        /// </summary>
        /// <param name="password">密码</param>
        /// <param name="codeLength">加密位数</param>
        /// <returns>加密密码</returns>
        public static string md5(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                // 32位加密        
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5").ToLower();
            }
            return string.Empty;
        }
	}
}
