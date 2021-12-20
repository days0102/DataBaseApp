using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{

    class Teacher
    {
        public string Tno { get; set; }
        public string Tname { get; set; }
        public string Post { get; set; }
        public int Salary { get; set; }


        public static List<Teacher> QueryTeacher(string tname)
        {
            List<Teacher> list = new List<Teacher>();
            string sql = "SELECT * FROM Teacher WHERE tname LIKE :tname";

            OracleParameter[] para = new OracleParameter[]
                {
                new OracleParameter(":cname",OracleDbType.Varchar2,10)
                };


            para[0].Value = tname + "%";
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);

                cmd.Parameters.AddRange(para);

                OracleDataReader ord = cmd.ExecuteReader();

                while (ord.Read())
                {
                    Teacher t = new Teacher();
                    t.Tno = ord.GetString(0);
                    t.Tname = ord.GetString(1);
                    //if (ord.IsDBNull(2))
                    //    c.Cpno = null;
                    //else
                    //    c.Cpno = ord.GetString(2);
                    if (ord.IsDBNull(2))
                        t.Post = "";
                    else
                        t.Post = ord.GetString(2);
                    if (ord.IsDBNull(3))
                        t.Salary = 0;
                    else
                        t.Salary = ord.GetInt16(3);
                    list.Add(t);
                }
            }
            finally
            {
                con.Close();
            }
            return list;
        }


        public static int deleteTeacher(string tno)
        {
            int result = 0;

            string sql = "DELETE FROM Teacher WHERE tno=:tno";

            OracleParameter[] para = new OracleParameter[]
            {
            new OracleParameter(":tno",OracleDbType.Varchar2,10)
            };
            para[0].Value = tno;

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

        public static int InsertTeacher(Teacher t)
        {
            int result = 0;
            string sql = "INSERT INTO Teacher(tno,tname,post,salary) VALUES(:tno,:tname,:post,:salary)";

            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":tno",OracleDbType.Varchar2,10),
                new OracleParameter(":tname",OracleDbType.Varchar2,10),
                new OracleParameter(":post",OracleDbType.Varchar2,10),
                new OracleParameter(":salary",OracleDbType.Int16)
            };
            para[0].Value = t.Tno;
            para[1].Value = t.Tname;
            para[2].Value = t.Post;
            para[3].Value = t.Salary;
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);

                result = cmd.ExecuteNonQuery();
                //MessageBox.Show(result.ToString());
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int UpdateTeacher(Teacher t)
        {
            string sql = "UPDATE Teacher SET tname=:tname,post=:post,salary=:salary WHERE tno=:tno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":tname",OracleDbType.Varchar2,40),
                //new OracleParameter(":cpno",OracleDbType.Varchar2,4),
                new OracleParameter(":post",OracleDbType.Varchar2,10),
                new OracleParameter(":salary",OracleDbType.Int16),
                new OracleParameter(":tno",OracleDbType.Varchar2,10)
            };
            para[0].Value = t.Tname;
            //if (string.IsNullOrEmpty(c.Cpno))
            //    para[1].Value = DBNull.Value;
            //else
            //    para[1].Value = c.Cpno;
            para[1].Value = t.Post;
            para[2].Value = t.Salary;
            para[3].Value = t.Tno;
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
