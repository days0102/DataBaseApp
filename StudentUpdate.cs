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
    public partial class StudentUpdate : Form
    {
        public StudentUpdate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //点击修改按钮
            label5.Visible = false;
            string sql = "UPDATE Student SET Sname=:sname,sage=:sage,ssex=:ssex WHERE Sno=:sno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":sname",OracleDbType.Varchar2,10),
                new OracleParameter(":sage",OracleDbType.Int16),
                new OracleParameter(":ssex",OracleDbType.Varchar2,10),
                new OracleParameter(":sno",OracleDbType.Varchar2,10)
            };
            if(tbSname.Text=="")
            {
                label5.Text = "姓名不能为空";
                label5.Visible = true;
                return;
            }
            else
            {
                para[0].Value = tbSname.Text;
            }
            try
            {
                if (tbSage.Text == "")
                    para[1].Value = DBNull.Value;
                else
                    para[1].Value = Convert.ToInt32(tbSage.Text);
            }
            catch(Exception)
            {
                label6.Text = "年龄输入错误";
                label6.Visible = true;
                return;
            }
            if (rbfemale.Checked == false && rbmale.Checked == false)
                para[2].Value = DBNull.Value;
            else
            {
                if (rbfemale.Checked == true)
                    para[2].Value = "女";
                else
                    para[2].Value = "男";
            }
            para[3].Value = tbSno.Text;
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                if (cmd.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("修改成功");
                    this.Close();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbSage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
