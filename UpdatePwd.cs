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
    public partial class UpdatePwd : Form
    {
        public UpdatePwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            string sql = string.Format("SELECT Passwd FROM LoginUser WHERE UserId='{0}'", Login.UserId);
            string pwd = null;
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    pwd = odr.GetString(0);
                }
                if (pwd == tbPwd.Text)
                {
                    label4.Visible = false;
                    if (tbPwd1.Text == "" || tbPwd2.Text == "")
                    {
                        label6.Text = "请输入新密码";
                        label6.Visible = true;
                    }
                    else
                    {
                        if (tbPwd1.Text == tbPwd2.Text)
                        {
                            sql = string.Format("UPDATE LoginUser SET Passwd='{0}' WHERE UserId='{1}'",tbPwd2.Text, Login.UserId);
                            cmd = new OracleCommand(sql, con);
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                label4.Text = "修改成功";
                                label4.Visible = true;
                            }
                            else
                            {
                                label4.Text = "修改失败，未知原因";
                                label4.Visible = true;
                            }
                        }
                        else
                        {
                            label4.Text = "密码不一致！";

                            label4.Visible = true;
                        }
                    }
                }
                else
                {
                    label5.Text = "密码错误";
                    label5.Visible = true;
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
