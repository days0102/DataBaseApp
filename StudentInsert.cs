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
    public partial class StudentInsert : Form
    {
        public StudentInsert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SnoNotNull.Visible = false;
            NameNotNull.Visible = false;
            label7.Visible = false;
            if (tbSno.Text == "" || tbSname.Text == "")
            {
                if (tbSno.Text == "")
                {
                    SnoNotNull.Text = "学号不能为空！";
                    SnoNotNull.Visible = true;
                }
                if (tbSname.Text == "")
                {
                    NameNotNull.Text = "姓名不能为空！";
                    NameNotNull.Visible = true;
                }
            }
            else
            {
                //string sql = string.Format("INSERT INTO Student(sno,sname,ssex,sage) VALUES({0},'{1}','{2}',{3})", tbSno.Text, tbSname.Text, tbSsex.Text, tbSage.Text);
                string sql = "INSERT INTO Student(sno,sname,ssex,sage) VALUES(:sno,:sname,:ssex,:sage)";
                OracleParameter[] para = new OracleParameter[]
                {
                    new OracleParameter(":sno",OracleDbType.Varchar2,10),
                    new OracleParameter(":sname",OracleDbType.Varchar2,10),
                    new OracleParameter(":ssex",OracleDbType.Varchar2,5),
                    new OracleParameter(":sage",OracleDbType.Int32)
                };
                para[0].Value = tbSno.Text;
                para[1].Value = tbSname.Text;
                if (rbmale.Checked == false && rbmale.Checked == false)
                {
                    para[2].Value = DBNull.Value;
                }
                else if (rbmale.Checked)
                {
                    para[2].Value = "男";
                }
                else
                {
                    para[3].Value = "女";
                }
                if (tbSage.Text == "")
                {
                    para[3].Value = DBNull.Value;
                }
                else
                {
                    try
                    {
                        para[3].Value = Convert.ToInt32(tbSage.Text);
                    }
                    catch(Exception ex)
                    {
                        label7.Text = "年龄格式错误";
                        label7.Visible = true;
                        return;
                    }
                }
                OracleConnection con = new OracleConnection(Program.connect);
                try
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand(sql, con);
                    cmd.Parameters.AddRange(para);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        sql = string.Format("INSERT INTO LoginUser(UserId,UserType) VALUES('{0}','Student')", tbSno.Text);
                        cmd = new OracleCommand(sql, con);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            label7.Text = "添加成功";
                        }
                        else
                        {
                            label7.Text = "添加失败";
                        }
                        label7.Visible = true;
                            //MessageBox.Show("添加成功");
                        //this.Close();
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

        private void tbSname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
