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
                ORDER BY p.subject_id,a.hadm_id,admittime";

            //执行SQL语句
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(strSQL, conn); //实例化NpsqlCommand对象
            da.Fill(ds, "patients");//填充数据源（表的容器）
            dt = ds.Tables["patients"];//获取数据源中的表
            return dt;
        }

        [WebMethod]
        public DataTable ICUSelectPatients(Patients patients)
        {
            DBConn dbconn = new DBConn();//实例化连接数据库的对象
            NpgsqlConnection conn = dbconn.OpenConn();//调用对象的打开数据库方法
            string strSQL = @"set search_path to mimiciii;
              SELECT p.subject_id,a.hadm_id,i.icustay_id , gender,first_careunit,last_careunit,intime,outtime,los
              FROM icustays i INNER JOIN admissions a ON i.hadm_id = a.hadm_id
                              INNER JOIN patients p ON i.subject_id =p.subject_id
                WHERE cast(p.subject_id as varchar) LIKE '%" + patients.subject_id + @"%'
                    AND cast(a.hadm_id as varchar) LIKE '%" + patients.hadm_id + @"%'
                    AND cast(i.icustay_id as varchar) LIKE '%" + patients.icustay_id + @"%'
                    AND LOWER(gender)LIKE '%" + patients.gender + @"%'
                    AND first_careunit  LIKE '%" + patients.first_careunit + @"%'
                    AND last_careunit   LIKE '%" + patients.last_careunit + @"%'
                    AND cast(intime as varchar)LIKE '%" + patients.intime + @"%'
                    AND cast(outtime as varchar)LIKE '%" + patients.outtime + @"%'
                    AND cast(los as varchar)LIKE '%" + patients.intime + @"%'
                ORDER BY p.subject_id,a.hadm_id,i.icustay_id,intime";

            //执行SQL语句
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(strSQL, conn); //实例化NpsqlCommand对象
            da.Fill(ds, "patients");//填充数据源（表的容器）
            dt = ds.Tables["patients"];//获取数据源中的表
            return dt;
        }

        [WebMethod]
        public DataTable SearchICUPatients()
        {
            DBConn dbconn = new DBConn();//实例化连接数据库的对象
            NpgsqlConnection conn = dbconn.OpenConn();//调用对象的打开数据库方法
            string strSQL = @"set search_path to mimiciii;SELECT p.subject_id,a.hadm_id,i.icustay_id , 
                gender,first_careunit,last_careunit,intime,outtime,los
                                   FROM icustays i INNER JOIN admissions a ON i.hadm_id = a.hadm_id
                                                   INNER JOIN patients p ON i.subject_id =p.subject_id
                ORDER BY p.subject_id,a.hadm_id,i.icustay_id,intime";
            //执行SQL语句
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(strSQL, conn); //实例化NpsqlCommand对象
            da.Fill(ds, "patients");//填充数据源（表的容器）
            dt = ds.Tables["patients"];//获取数据源中的表
            return dt;
        }

        [WebMethod]
        public DataTable CaseSelect(Patients patients)
        {
            DBConn dbconn = new DBConn();//实例化连接数据库的对象
            NpgsqlConnection conn = dbconn.OpenConn();//调用对象的打开数据库方法
            string strSQL = @"set search_path to mimiciii;
              SELECT p.subject_id,a.hadm_id,i.icustay_id ,d.itemid,label,gender,charttime,valuenum,valueuom
              FROM chartevents c INNER JOIN admissions a ON c.hadm_id = a.hadm_id
                                 INNER JOIN patients p ON c.subject_id =p.subject_id
                                 INNER JOIN icustays i ON c.icustay_id =i.icustay_id
                                 INNER JOIN d_items d ON c.itemid =d.itemid
                WHERE cast(p.subject_id as varchar) LIKE '%" + patients.subject_id + @"%'
                     AND cast(a.hadm_id as varchar) LIKE '%" + patients.hadm_id + @"%'
                     AND cast(i.icustay_id as varchar) LIKE '%" + patients.icustay_id + @"%'
                     AND cast(d.itemid as varchar) LIKE '%" + patients.itemid + @"%'
                     AND label  LIKE '%" + patients.label + @"%'
                     AND LOWER(gender)LIKE '%" + patients.gender + @"%'
                     AND cast(charttime as varchar) LIKE '%" + patients.charttime + @"%'
                     AND cast(valuenum as varchar)  LIKE '%" + patients.valuenum + @"%'
                     AND valueuom  LIKE '%" + patients.valueuom + @"%'
                ORDER BY p.subject_id,a.hadm_id,i.icustay_id,d.itemid,charttime";

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
            string strSQL = @"set search_path to mimiciii;
                SELECT p.subject_id,a.hadm_id,icustay_id,d.itemid,label,charttime,valuenum,valueuom,first_careunit,last_careunit,intime
                    ,outtime,los,insurance,language,gender,ROUND((cast(a.admittime as date) - cast(p.dob as date)) / 365.2 ) as age,religion, 
                    marital_status,ethnicity,dob,dod,dod_hosp,dod_ssn,expire_flag,admittime,dischtime,deathtime,admission_type,
                    admission_location,discharge_location,edregtime,edouttime,diagnosis,hospital_expire_flag,has_chartevents_data
dbsource

                FROM chartevents c 
                    INNER JOIN admissions a ON c.hadm_id = a.hadm_id
                    INNER JOIN patients p ON c.subject_id =p.subject_id
                    INNER JOIN icustays i ON c.icustay_id =i.icustay_id
                    INNER JOIN d_items d ON c.itemid =d.itemid
                ORDER BY p.subject_id,a.hadm_id,admittime";
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
            public string subject_id { get; set; } //属性自动生成输入prop然后按下Tab键，修改类型，再Tab键修改属性名
            /// <summary>
            /// 入院记录标识
            /// </summary>
            public string hadm_id { get; set; }
            /// <summary>
            /// 入ICU记录标识
            /// </summary>
            public string icustay_id { get; set; }
            /// <summary>
            /// 测量类型标识
            /// </summary>
            public string itemid { get; set; }
            /// <summary>
            /// 测量类型标识所表示的值
            /// </summary>
            public string label { get; set; }
            /// <summary>
            /// 观测进行的时间
            /// </summary>
            public string charttime { get; set; }
            /// <summary>
            /// 项目测量的值或描述
            /// </summary>
            public string valuenum { get; set; }
            /// <summary>
            /// 测量值的单位
            /// </summary>
            public string valueuom { get; set; }
            /// <summary>
            /// 给予患者的第一种护理
            /// </summary>
            public string first_careunit { get; set; }
            /// <summary>
            /// 给予患者最后一种护理
            /// </summary>
            public string last_careunit { get; set; }
            /// <summary>
            /// 入住ICU的时间
            /// </summary>
            public string intime { get; set; }
            /// <summary>
            /// 转出ICU的时间
            /// </summary>
            public string outtime { get; set; }
            /// <summary>
            /// 入住ICU的时长
            /// </summary>
            public string los { get; set; }
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
            /// <summary>
            /// 数据库来源
            /// </summary>
            public string dbsource { get; set; }
            /// <summary>
            /// 患者第⼀次⼊住的ICU单元
            /// </summary>
            public string first_wardid { get; set; }
            /// <summary>
            /// 患者最后⼀次⼊住的ICU单元
            /// </summary>
            public string last_wardid { get; set; }
            /// <summary>
            /// 记录值被⼈⼯验证输⼊系统的时间
            /// </summary>
            public string storetime { get; set; }
            /// <summary>
            /// 医护⼈员标识
            /// </summary>
            public string cgid { get; set; }
            /// <summary>
            /// ITEMID标识的项⽬测量的值
            /// </summary>
            public string value { get; set; }
            /// <summary>
            /// Metaversion特定值增⾼警告的记录
            /// </summary>
            public string warning { get; set; }
            /// <summary>
            /// 测量过程中发⽣了错误
            /// </summary>
            public string error { get; set; }
            /// <summary>
            /// CareVue特定测量的类型
            /// </summary>
            public string resultststus { get; set; }
            /// <summary>
            /// CareVue特定记录是否停⽌了测量
            /// </summary>
            public string stopped { get; set; }
            /// <summary>
            /// Metavision特有，LABEL的缩写
            /// </summary>
            public string abbreviation { get; set; }
            /// <summary>
            /// 数据链接到的表名
            /// </summary>
            public string linksto { get; set; }
            /// <summary>
            /// ITEMID对应的数据类型
            /// </summary>
            public string category { get; set; }
            /// <summary>
            /// ITEMID表⽰的测量⽅法的单位
            /// </summary>
            public string unitname { get; set; }
            /// <summary>
            /// 描述记录的数据类型
            /// </summary>
            public string param_type { get; set; }
            /// <summary>
            /// 未知
            /// </summary>
            public string conceptid { get; set; }

            /// <summary>
            /// 提交出院申请的病房ID
            /// </summary>
            public string submit_wardid { get; set; }
            /// <summary>
            /// ICU费⽤中⼼类型
            /// </summary>
            public string submit_careunit { get; set; }
            /// <summary>
            /// 病⼈callout时所在的病房ID
            /// </summary>
            public string curr_wardid { get; set; }
            /// <summary>
            /// CURR_WARDID对应的ICU费⽤中⼼
            /// </summary>
            public string curr_careunit { get; set; }
            /// <summary>
            /// 病⼈从哪个病房出院
            /// </summary>
            public string callout_wardid { get; set; }
            /// <summary>
            /// 病⼈出院的服务
            /// </summary>
            public string callout_service { get; set; }
            /// <summary>
            /// 值为⼆进制,表⽰病⼈是否要求了某种预防措施
            /// </summary>
            public string request_tele { get; set; }
            /// <summary>
            /// 病⼈是否要求了某种预防措施
            /// </summary>
            public string request_resp { get; set; }
            /// <summary>
            /// 病⼈是否要求了某种预防措施
            /// </summary>
            public string request_cdiff { get; set; }
            /// <summary>
            /// 病⼈是否要求了某种预防措施
            /// </summary>
            public string request_mrsa { get; set; }
            /// <summary>
            /// 病⼈是否要求了某种预防措施
            /// </summary>
            public string request_vre { get; set; }
            /// <summary>
            /// 病⼈最终是否出院
            /// </summary>
            public string callout_outcome { get; set; }
            /// <summary>
            /// 病⼈出院的病房号,0代表home
            /// </summary>
            public string discharge_wardid { get; set; }
            /// <summary>
            /// 对callout请求的处理
            /// </summary>
            public string acknowledge_status { get; set; }
            /// <summary>
            /// callout请求发起时间
            /// </summary>
            public string createtime { get; set; }
            /// <summary>
            /// callout请求变更时间
            /// </summary>
            public string updatetime { get; set; }
            /// <summary>
            /// callout请求⾸次应答时间
            /// </summary>
            public string acknowledgetime { get; set; }
            /// <summary>
            /// 记录CALLOUT_OUTCOME的时间
            /// </summary>
            public string outcometime { get; set; }
            /// <summary>
            /// 病房预定信息
            /// </summary>
            public string firstreservationtime { get; set; }
            /// <summary>
            /// 病房预定信息
            /// </summary>
            public string currentreservationtime { get; set; }


            /// <summary>
            /// 从PREV_SERVICE转到CURR_SERVICE的时间
            /// </summary>
            public string transfertime { get; set; }
            /// <summary>
            /// 患者之前接受的服务
            /// </summary>
            public string prev_service { get; set; }
            /// <summary>
            /// 患者现在接受的服务
            /// </summary>
            public string curr_service { get; set; }


            /// <summary>
            /// 描述了入院，转院，出院事件
            /// </summary>
            public string eventtype { get; set; }
            /// <summary>
            /// 患者之前住的护理单元
            /// </summary>
            public string prev_careunit { get; set; }
            /// <summary>
            /// 患者现在住的护理单元
            /// </summary>
            public string curr_careunit { get; set; }
            /// <summary>
            /// 患者住的前⼀个病房
            /// </summary>
            public string prev_wardid { get; set; }
            /// <summary>
            /// 患者住的当前病房
            /// </summary>
            public string curr_wardid { get; set; }

            
            /// <summary>
            /// 医护⼈员ID
            /// </summary>
            public string cgid { get; set; }
            /// <summary>
            /// 医护⼈员的类型
            /// </summary>
            public string care_label { get; set; }
            /// <summary>
            /// 医护⼈员的附加信息
            /// </summary>
            public string description { get; set; }


            /// <summary>
            /// 给予患者的药物或物质的量
            /// </summary>
            public string amount { get; set; }
            /// <summary>
            /// 给予患者的药物或物质的量单位
            /// </summary>
            public string amountuom { get; set; }
            /// <summary>
            /// 给药的速率
            /// </summary>
            public string rate { get; set; }
            /// <summary>
            /// 同⼀解决⽅案中包含的多个项⽬链接在⼀起
            /// </summary>
            public string orderid { get; set; }
            /// <summary>
            /// 多个实例中链接相同的顺序
            /// </summary>
            public string linkorderid { get; set; }
            /// <summary>
            /// 输液是否已断开或继续
            /// </summary>
            public string inp_stopped { get; set; }
            /// <summary>
            /// 是否在床边悬挂了新的溶液制剂
            /// </summary>
            public string newbottle { get; set; }


            /// <summary>
            /// 命令类型
            /// </summary>
            public string ordercategoryname { get; set; }
            /// <summary>
            /// ⼆级命令类型
            /// </summary>
            public string secondaryordercategoryname { get; set; }
            /// <summary>
            /// 药物成分在治疗⽅案中的作⽤
            /// </summary>
            public string ordercomponenttypedescription { get; set; }
            /// <summary>
            /// 药物类别在治疗⽅案中的作⽤
            /// </summary>
            public string ordercategorydescription { get; set; }
            /// <summary>
            /// 病⼈体重
            /// </summary>
            public string patientweight { get; set; }
            /// <summary>
            /// 溶液的袋中的流体总量
            /// </summary>
            public string totalamount { get; set; }
            /// <summary>
            /// 溶液的袋中的流体总量单位
            /// </summary>
            public string totalamountuom { get; set; }
            /// <summary>
            /// 是否是打开的袋
            /// </summary>
            public string isopenbag { get; set; }
            /// <summary>
            /// 是否进⼊下⼀个部门
            /// </summary>
            public string continueinnextdept { get; set; }
            /// <summary>
            /// 治疗命令取消的原因
            /// </summary>
            public string cancelreason { get; set; }
            /// <summary>
            /// 输液停⽌的原因
            /// </summary>
            public string statusdescription { get; set; }
            /// <summary>
            /// 治疗命令是否已编辑或取消
            /// </summary>
            public string comments_status { get; set; }
            /// <summary>
            /// 取消或编辑订单的⼈的职位
            /// </summary>
            public string comments_title { get; set; }
            /// <summary>
            /// 取消或编辑订单的⼈的⽇期
            /// </summary>
            public string comments_date { get; set; }
            /// <summary>
            /// 药物的剩余量
            /// </summary>
            public string originalamount { get; set; }
            /// <summary>
            /// 原始输液速率
            /// </summary>
            public string originalrate { get; set; }


            /// <summary>
            /// 记录患者注释的时间
            /// </summary>
            public string n_chartdate { get; set; }
            /// <summary>
            /// 注释类别
            /// </summary>
            public string n_category { get; set; }
            /// <summary>
            /// 注释类别的描述
            /// </summary>
            public string n_description { get; set; }
            /// <summary>
            /// 医护⼈员是否认为该注释有错
            /// </summary>
            public string iserror { get; set; }
            /// <summary>
            /// 注释文本
            /// </summary>
            public string text { get; set; }


            /// <summary>
            /// 液体输出时间
            /// </summary>
            public string o_charttime { get; set; }
            /// <summary>
            /// 流出液体物质的量
            /// </summary>
            public string o_value { get; set; }
            /// <summary>
            /// 流出液体物质的量的单位
            /// </summary>
            public string o_valueuom { get; set; }
            /// <summary>
            /// 流出液体医护⼈员⼿动验证和输⼊数据的时间
            /// </summary>
            public string o_storetime { get; set; }


            /// <summary>
            /// 收费的成本中⼼
            /// </summary>
            public string s { get; set; }
            /// <summary>
            /// 治疗代码
            /// </summary>
            public string s { get; set; }
            /// <summary>
            /// CPT_CD列的数字形式
            /// </summary>
            public string s { get; set; }
            /// <summary>
            /// CPT_SUFFIX列包含⽂本后缀
            /// </summary>
            public string s { get; set; }
            /// <summary>
            /// CPT_CD顺序
            /// </summary>
            public string s { get; set; }
            /// <summary>
            /// 标题，标志CPT类别
            /// </summary>
            public string s { get; set; }
            /// <summary>
            /// ⼦标题，标志CPT类别
            /// </summary>
            public string s { get; set; }
            /// <summary>
            /// 呼吸成本中⼼的CPT代码的解释
            /// </summary>
            public string s { get; set; }

        }
    }
}
