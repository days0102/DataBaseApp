using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Sc
    {
        public string Sno { get; set; }
        public string Cno { get; set; }
        public string Sname { get; set; }
        public string Cname { get; set; }
        public int Ccredit { get; set; }
        public int Grade { get; set; }

        public static List<Sc> QueryCourse(string cname)
        {
            List<Sc> list = new List<Sc>();
            string sql;
            if (Login.UserType == "Admin")
                sql = string.Format("SELECT sno,sname,cno,cname,ccredit,grade FROM StudentCourse WHERE cname LIKE '{0}%'", cname);
            else
                sql = string.Format("SELECT sno,sname,cno,cname,ccredit,grade FROM StudentCourse WHERE cname LIKE '{0}%' AND sno='{1}'", cname, Login.UserId);
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader ord = cmd.ExecuteReader();

                while (ord.Read())
                {
                    Sc sc = new Sc();
                    sc.Sno = ord.GetString(0);
                    sc.Sname = ord.GetString(1);
                    sc.Cno = ord.GetString(2);
                    sc.Cname = ord.GetString(3);
                    //if (ord.IsDBNull(2))
                    //    c.Cpno = null;
                    //else
                    //    c.Cpno = ord.GetString(2);
                    if (ord.IsDBNull(4))
                        sc.Ccredit = 0;
                    else
                        sc.Ccredit = ord.GetInt16(4);
                    if (ord.IsDBNull(5))
                        sc.Grade = 0;
                    else
                        sc.Grade = ord.GetInt16(5);
                    list.Add(sc);
                }
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public static int InsertSc(string cno)
        {
            int result = 0;
            string sql = "INSERT INTO Sc(sno,cno,grade) VALUES(:sno,:cno,:grade)";

            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":sno",OracleDbType.Varchar2,9),
                new OracleParameter(":cno",OracleDbType.Varchar2,4),
                new OracleParameter(":grade",OracleDbType.Int32)
            };
            para[0].Value = Login.UserId;
            para[1].Value = cno;
            para[2].Value = null;
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


        public static int deleteCourse(string cno)
        {
            int result = 0;

            string sql = "DELETE FROM Sc WHERE cno=:cno AND sno=:sno";

            OracleParameter[] para = new OracleParameter[]
            {
            new OracleParameter(":cno",OracleDbType.Varchar2,10),
            new OracleParameter(":sno",OracleDbType.Varchar2,10)
            };
            para[0].Value = cno;
            para[1].Value = Login.UserId;

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

        public static int UpdateGrade(Sc sc)
        {
            string sql = "UPDATE Sc SET Grade=:grade WHERE cno=:cno AND sno=:sno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":grade",OracleDbType.Int16),
                //new OracleParameter(":cpno",OracleDbType.Varchar2,4),
                new OracleParameter(":cno",OracleDbType.Varchar2,10),
                new OracleParameter(":sno",OracleDbType.Varchar2,10)
            };
            para[0].Value =sc.Grade ;
            //if (string.IsNullOrEmpty(c.Cpno))
            //    para[1].Value = DBNull.Value;
            //else
            //    para[1].Value = c.Cpno;
            para[1].Value = sc.Cno;
            para[2].Value = sc.Sno;

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

        public static List<Sc> QuerySc(string cname)
        {
            List<Sc> list = new List<Sc>();
            string sql = "SELECT * FROM Course WHERE Course.cno NOT IN (SELECT cno FROM studentcourse WHERE sno =:sno ) AND cname LIKE :cname";


            OracleParameter[] para = new OracleParameter[]
                 {
                new OracleParameter(":sno",OracleDbType.Varchar2,10),
                new OracleParameter(":cname",OracleDbType.Varchar2,10)
                 };


            para[1].Value = cname + "%";
            para[0].Value = Login.UserId;
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader ord = cmd.ExecuteReader();

                while (ord.Read())
                {
                    Sc sc = new Sc();
                    sc.Cno = ord.GetString(0);
                    sc.Cname = ord.GetString(1);
                    //if (ord.IsDBNull(2))
                    //    c.Cpno = null;
                    //else
                    //    c.Cpno = ord.GetString(2);
                    if (ord.IsDBNull(2))
                        sc.Ccredit = 0;
                    else
                        sc.Ccredit = ord.GetInt16(2);
                    
                    
                    list.Add(sc);
                }
            }
            finally
            {
                con.Close();
            }
            return list;
        }
    }
}
