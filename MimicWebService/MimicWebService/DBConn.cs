using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using System.Data;


namespace MimicWebService
{
    public class DBConn
    {

        public NpgsqlConnection OpenConn()
        {
            string scsb = UserinfoService.GetconnectionStringConfig("PostgreSQL");
            NpgsqlConnection conn = new NpgsqlConnection(scsb.ToString());//参数：连接数据库的字符串
            conn.Open();//打开连接
            return conn;
        }

    }
}