using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public static string UserId { get; set; }
        public static string UserType { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //登录
            string username = tbUsrname.Text;
            string pwd = tbPwd.Text;
            //string sql = string.Format("SELECT sno,sname FROM Student WHERE sno='{0}' and pwd='{1}'", username, pwd);
            string sql = "SELECT UserId,UserType FROM LoginUser WHERE userid=:id and passwd=:pwd";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":id",OracleDbType.Varchar2,20),
                new OracleParameter(":pwd",OracleDbType.Varchar2,20)
            };
            para[0].Value = username;
            para[1].Value = pwd;

            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.HasRows)
                {
                    //UserId = username;
                    odr.Read();//将内容读取开始标志由属性列移向第一行数据行
                    UserId = odr.GetString(0);
                    UserType = odr.GetString(1);
                    //MessageBox.Show(odr.GetString(1));
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    label4.Text= "用户名或密码错误";
                    label4.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
