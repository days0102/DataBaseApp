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
    public partial class StudentQuery : Form
    {
        public StudentQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击查询按钮
            //string sql = "SELECT * FROM Student WHERE sname LIKE'" + this.textBox1.Text + "%'";
            string sql = string.Format("SELECT * FROM Student WHERE sname LIKE '{0}%' AND sno!='admin'", this.textBox1.Text);
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr;
                    dataGridView1.DataSource = bs;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //删除按钮
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("是否删除", "请确认", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string sno = row.Cells[0].Value.ToString();
            string sql = string.Format("DELETE FROM Student WHERE sno='{0}'", sno);
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                if (cmd.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("删除成功");
                    dataGridView1.Rows.Remove(row);
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //双击DataGridView内容，修改选中学生信息
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            StudentUpdate studentUpdate = new StudentUpdate();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            studentUpdate.tbSno.Text = row.Cells[0].Value.ToString();
            studentUpdate.tbSname.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "")
            {
                studentUpdate.rbfemale.Checked = false;
                studentUpdate.rbmale.Checked = false;
            }
            else
            {
                if (row.Cells[2].Value.ToString() == "男")
                    studentUpdate.rbmale.Checked = true;
                else
                    studentUpdate.rbfemale.Checked = true;
            }
            
            studentUpdate.tbSage.Text = row.Cells[3].Value.ToString();
            //studentUpdate.tbSdept.Text = row.Cells[4].Value.ToString();
            studentUpdate.ShowDialog(this);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            if (MessageBox.Show("是否重置密码", "请确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string sno = row.Cells[0].Value.ToString();
                string sql = string.Format("UPDATE LoginUser SET Passwd='123456' WHERE UserId='{0}'", sno);
                OracleConnection con = new OracleConnection(Program.connect);
                try
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand(sql, con);
                    if (cmd.ExecuteNonQuery() == 1)
                    {

                        MessageBox.Show("重置成功");
                    }
                    else
                    {
                        MessageBox.Show("!");
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
            else
                return;
        }
    }
}
