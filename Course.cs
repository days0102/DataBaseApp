using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public class Course
    {
        public string Cno { get; set; }
        public string Sname { get; set; }
        public string Cname { get; set; }
        //public string Cpno { get; set; }
        public int Ccredit { get; set; }
        public int Grade { get; set; }

        //与Course表相关的数据库操作在Course类中实现

        //根据输入的课程名查找课程列表
        public static List<Course> QueryCourse(string cname)
        {
            List<Course> list = new List<Course>();
            string sql = "SELECT * FROM Course WHERE cname LIKE :cname";

            OracleParameter[] para = new OracleParameter[]
                {
                new OracleParameter(":cname",OracleDbType.Varchar2,10)
                };


            para[0].Value = cname + "%";
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);

                cmd.Parameters.AddRange(para);

                OracleDataReader ord = cmd.ExecuteReader();

                while (ord.Read())
                {
                    Course c = new Course();
                    c.Cno = ord.GetString(0);
                    c.Cname = ord.GetString(1);
                    //if (ord.IsDBNull(2))
                    //    c.Cpno = null;
                    //else
                    //    c.Cpno = ord.GetString(2);
                    if (ord.IsDBNull(2))
                        c.Ccredit = 0;
                    else
                        c.Ccredit = ord.GetInt16(2);
                    list.Add(c);
                }
            }
            finally
            {
                con.Close();
            }
            return list;
        }


        //根据课程号删除学生的课程
        public static int deleteCourse(string cno)
        {
            int result = 0;

            string sql = "DELETE FROM Course WHERE cno=:cno";

            OracleParameter[] para = new OracleParameter[]
            {
            new OracleParameter(":cno",OracleDbType.Varchar2,4)
            };
            para[0].Value = cno;

            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);

                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return result;
        }


        public static int UpdateCourse(Course c)
        {
            string sql = "UPDATE Course SET cname=:cname,ccredit=:credit WHERE cno=:cno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":cname",OracleDbType.Varchar2,40),
                //new OracleParameter(":cpno",OracleDbType.Varchar2,4),
                new OracleParameter(":credit",OracleDbType.Int16),
                new OracleParameter(":cno",OracleDbType.Varchar2,4)
            };
            para[0].Value = c.Cname;
            //if (string.IsNullOrEmpty(c.Cpno))
            //    para[1].Value = DBNull.Value;
            //else
            //    para[1].Value = c.Cpno;
            para[1].Value = c.Ccredit;
            para[2].Value = c.Cno;

            int result = 0;
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);

                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return result;
        }


        public static int InsertCourse(Course c)
        {
            string sql = "INSERT INTO Course(cno,cname,Ccredit) VALUES(:cno,:cname,:Ccredit)";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":cno",OracleDbType.Varchar2,10),
                new OracleParameter(":cname",OracleDbType.Varchar2,20),
                //new OracleParameter(":cpno",OracleDbType.Varchar2,4),
                new OracleParameter(":Ccredit",OracleDbType.Int16)
            };
            para[1].Value = c.Cname;
            //if (string.IsNullOrEmpty(c.Cpno))
            //    para[2].Value = DBNull.Value;
            //else
            //    para[1].Value = c.Cpno;
            para[2].Value = c.Ccredit;
            para[0].Value = c.Cno;

            int result = 0;
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);

                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return result;

        }
    }
}
