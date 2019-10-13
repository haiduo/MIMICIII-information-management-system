using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Npgsql;
using System.Data;

namespace MimicWebService
{
    /// <summary>
    /// PatientsService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class PatientsService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        /// <summary>
        /// 根据关键字查询病人信息
        /// </summary>
        /// <param name="patients"></param>
        /// <returns></returns>
        [WebMethod]
        public DataTable SelectPatients(Patients patients)
        {
            DBConn dbconn = new DBConn();//实例化连接数据库的对象
            NpgsqlConnection conn = dbconn.OpenConn();//调用对象的打开数据库方法
            string strSQL = @"set search_path to mimiciii;
              SELECT p.subject_id,a.hadm_id, a.insurance,language, gender,round((cast(a.admittime as date) - cast(p.dob as date)) / 365.2 ) as age,religion,
                    marital_status,ethnicity,dob,dod,dod_hosp,dod_ssn,expire_flag,admittime,dischtime,deathtime,admission_type,admission_location,discharge_location,edregtime,
                    edouttime,diagnosis,hospital_expire_flag,has_chartevents_data
                FROM patients p INNER JOIN admissions a ON p.subject_id = a.subject_id
                WHERE cast(p.subject_id as varchar) LIKE '%" + patients.subject_id + @"%'
                    AND LOWER(gender)LIKE '%" + patients.gender + @"%'
                    AND cast(round((cast(a.admittime as date) - cast(p.dob as date)) / 365.2 ) as varchar) LIKE '%" + patients.age + @"%'
                    AND LOWER(ethnicity) LIKE '%" + patients.ethnicity + @"%' 
                    AND cast(expire_flag as varchar) LIKE '%" + patients.expire_flag + @"%'
                    AND cast(admittime as varchar) LIKE '%" + patients.admittime + @"%'
                    AND cast(hospital_expire_flag as varchar)LIKE '%" + patients.hospital_expire_flag + @"%'
                    AND  diagnosis LIKE '%" + patients.diagnosis + @"%'
                    AND cast(has_chartevents_data as varchar) LIKE '%" + patients.has_chartevents_data + @"%'
                ORDER BY p.subject_id,a.hadm_id";

            //执行SQL语句
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(strSQL, conn); //实例化NpsqlCommand对象
            da.Fill(ds, "patients");//填充数据源（表的容器）
            dt = ds.Tables["patients"];//获取数据源中的表
            return dt;
        }

        /// <summary>
        /// 显示所有病人信息
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataTable SearchPatients()
        {
            DBConn dbconn = new DBConn();//实例化连接数据库的对象
            NpgsqlConnection conn = dbconn.OpenConn();//调用对象的打开数据库方法
            string strSQL = @"set search_path to mimiciii;SELECT p.subject_id,a.hadm_id, a.insurance,language, 
                gender,ROUND((cast(a.admittime as date) - cast(p.dob as date)) / 365.2 ) as age,religion, 
                marital_status,ethnicity,dob,dod,dod_hosp,dod_ssn,expire_flag,admittime,dischtime,deathtime,admission_type,
                admission_location,discharge_location,edregtime,edouttime,diagnosis,hospital_expire_flag,has_chartevents_data
                                   FROM patients p INNER JOIN admissions a ON p.subject_id = a.subject_id
                ORDER BY subject_id";
            //执行SQL语句
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(strSQL, conn); //实例化NpsqlCommand对象
            da.Fill(ds, "patients");//填充数据源（表的容器）
            dt = ds.Tables["patients"];//获取数据源中的表
            return dt;
        }

        //Model对象
        //对应是表
        //表中的每一列都对应一个属性
        public class Patients
        {
            /// <summary>
            /// 病人标识
            /// </summary>
            public string  subject_id { get; set; } //属性自动生成输入prop然后按下Tab键，修改类型，再Tab键修改属性名
            /// <summary>
            /// 入院记录标识
            /// </summary>
            public string hadm_id { get; set; }
            /// <summary>
            /// 保险类型
            /// </summary>
            public string insurance { get; set; }
            /// <summary>
            /// 语言
            /// </summary>
            public string language { get; set; }
            /// <summary>
            /// 性别
            /// </summary>
            public string gender { get; set; }
            /// <summary>
            /// 入院时年龄
            /// </summary>
            public string age { get; set; }
            /// <summary>
            /// 宗教信仰
            /// </summary>
            public string religion { get; set; }
            /// <summary>
            /// 婚姻状态
            /// </summary>
            public string marital_status { get; set; }
            /// <summary>
            /// 种族
            /// </summary>
            public string ethnicity { get; set; }
            /// <summary>
            /// 出生日期
            /// </summary>
            public string dob { get; set; }
            /// <summary>
            /// 死亡时间
            /// </summary>
            public string dod { get; set; }
            /// <summary>
            /// 医院数据库记录的死亡日期
            /// </summary>
            public string dod_hosp { get; set; }
            /// <summary>
            /// 社会保障数据库记录的死亡日期
            /// </summary>
            public string dod_ssn { get; set; }
            /// <summary>
            /// 病人是否死亡
            /// </summary>
            public string expire_flag { get; set; }
            /// <summary>
            /// 入院时间
            /// </summary>
            public string admittime { get; set; }
            /// <summary>
            /// 出院时间
            /// </summary>
            public string dischtime { get; set; }
            /// <summary>
            /// 住院死亡时间
            /// </summary>
            public string deathtime { get; set; }
            /// <summary>
            /// 住院类型
            /// </summary>
            public string admission_type { get; set; }
            /// <summary>
            /// 入院前病人的位置
            /// </summary>
            public string admission_location { get; set; }
            /// <summary>
            /// 出院位置
            /// </summary>
            public string discharge_location { get; set; }
            /// <summary>
            /// 进入急诊部时间
            /// </summary>
            public string edregtime { get; set; }
            /// <summary>
            /// 搬离急诊部时间
            /// </summary>
            public string edouttime { get; set; }
            /// <summary>
            /// 诊断结果
            /// </summary>
            public string diagnosis { get; set; }
            /// <summary>
            /// 住院期间是否死亡
            /// </summary>
            public string hospital_expire_flag { get; set; }
            /// <summary>
            /// 是否有图表数据
            /// </summary>
            public string has_chartevents_data { get; set; }
        }
    }
    
}
