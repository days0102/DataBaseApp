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
    public partial class UpdateStudentInfo : Form
    {
        public UpdateStudentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            OracleParameter[] para = new OracleParameter[]{
                new OracleParameter(":name",OracleDbType.Varchar2,10),
                new OracleParameter(":sex",OracleDbType.Varchar2,5),
                new OracleParameter(":age",OracleDbType.Int16),
                new OracleParameter(":sno",OracleDbType.Varchar2,10)
            };
            para[3].Value = tbSno.Text;
            if (tbSname.Text == "")
            {
                label7.Text = "姓名不能为空";
                label7.Visible = true;
                return;
            }
            else
            {
                para[0].Value = tbSname.Text;
            }
            if (rbmale.Checked == false && rbfemale.Checked == false)
            {
                para[1].Value = DBNull.Value;
            }
            else
            {
                if (rbfemale.Checked == true)
                {
                    para[1].Value = "女";
                }
                else
                    para[1] .Value= "男";
            }
            if (tbSage.Text == "")
            {
                para[2].Value = DBNull.Value;
            }
            else
            {
                try
                {
                    para[2].Value = Convert.ToInt32(tbSage.Text);
                }
                catch (Exception)
                {
                    label8.Text = "年龄输入错误";
                    label8.Visible = true;
                    return;
                }
            }
            string sql = "UPDATE Student SET Sname=:name,ssex=:sex,sage=:age WHERE Sno=:sno";
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

        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
