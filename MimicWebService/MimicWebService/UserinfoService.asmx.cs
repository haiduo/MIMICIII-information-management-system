using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using Npgsql;

namespace stuSysWebService
{
    /// <summary>
    /// UserinfoService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class UserinfoService : System.Web.Services.WebService
    {

        /// <summary>
        /// 依据连接串名字connectionName返回数据连接字符串
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        public static string GetconnectionStringConfig(string connectionName)
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings[connectionName].ConnectionString.ToString();
            //Console.WriteLine(connectionString);
            return connectionString;

        }

        /// <summary>
        /// 更新连接字符串
        /// </summary>
        /// <param name="newName">连接字符串名称</param>
        /// <param name="newConString">连接字符串内容</param>
        /// <param name="newProviderName">数据提供程序名称</param>
        private static void UpdateConnectionStringconfig(string newName,
            string newConString, string newProviderName)
        {
            bool isModified = false;    // 记录该连接串是否已经存在
            // 如果要更改的连接串已经存在
            if (ConfigurationManager.ConnectionStrings[newName] != null)
            {
                isModified = true;
            }
            // 新建一个连接字符串实例
            ConnectionStringSettings mySettings =
                new ConnectionStringSettings(newName, newConString, newProviderName);
            // 打开可执行的配置文件*.exe.config
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // 如果连接串已存在，首先删除它
            if (isModified)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(newName);
            }
            // 将新的连接串添加到配置文件中.
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节
            ConfigurationManager.RefreshSection("ConnectionStrings");
        }

        /// <summary>
        /// 返回＊.exe.config文件中appSettings配置节的value项
        /// </summary>
        /// <param name="strKey"></param>
        /// <returns></returns>
        private static string GetAppConfig(string strKey)
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == strKey)
                {
                    return ConfigurationManager.AppSettings[strKey];
                }
            }
            return null;
        }

        /// <summary>
        /// 在＊.exe.config文件中appSettings配置节增加一对键、值对
        /// </summary>
        /// <param name="newKey"></param>
        /// <param name="newValue"></param>
        private static void UpdateAppConfig(string newKey, string newValue)
        {
            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == newKey)
                {
                    isModified = true;
                }
            }

            // Open App.Config of executable
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // You need to remove the old settings object before you can replace it
            if (isModified)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            // Add an Application Setting.
            config.AppSettings.Settings.Add(newKey, newValue);
            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);
            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");

        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Login(string user_id, string user_pwd, string ip_addr)
        {
            //拼接T-SQL语句
            string strSQL = "set search_path to mimiciii;select * from userinfo where user_id = '"
                + user_id + "'and user_pwd='" + user_pwd + "'";
            //执行SQL语句
            DBConn dbconn = new DBConn();//实例化连接数据库的对象
            NpgsqlConnection conn = dbconn.OpenConn();//调用对象的打开数据库方法
            NpgsqlCommand comm = new NpgsqlCommand(strSQL, conn); //实例化NpsqlCommand对象
            NpgsqlDataReader dr = comm.ExecuteReader();//执行SQL语句
            if (dr.Read())
            {
                if (dr["ip_addr"].ToString() == ip_addr)
                {
                    dr.Close();//NpgsqlDataReader对象使用完后，必须Close掉
                    return "true";
                }
                else
                {
                    dr.Close();//NpgsqlDataReader对象使用完后，必须Close掉
                    return "ip_false";
                }
            }
            dr.Close();//NpgsqlDataReader对象使用完后，必须Close掉
            return "login_false";
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user_id">用户名</param>
        /// <param name="user_pwd">密码</param>
        /// <param name="ip_addr">限制登陆的IP</param>
        /// <param name="mac_addr">限制登陆的MAC地址</param>
        /// <returns></returns>
        [WebMethod]
        public string Register(string user_id, string user_pwd, string ip_addr, string mac_addr)
        {
            //拼接T-SQL语句
            string strSQL = @"INSERT INTO mimiciii.userinfo(
	                       user_id, user_pwd, ip_addr, mac_addr )
	                VALUES ('" + user_id + @"'
                            ,'" + user_pwd + @"'
                           ,'" + ip_addr + @"'
                         ,'" + mac_addr + @"'
                            )";
            //执行SQL语句
            DBConn dbconn = new DBConn();//实例化连接数据库的对象
            NpgsqlCommand comm = new NpgsqlCommand(strSQL, dbconn.OpenConn()); //调用对象的打开数据库方法并实例化NpsqlCommand对象
            NpgsqlDataReader dr = comm.ExecuteReader();//执行SQL语句
            try
            {
                dr.Read();//如果能前进到下一条，说明有数据
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            dr.Close();//NpgsqlDataReader对象使用完后，必须Close掉
            return "true";
        }

    }
}
