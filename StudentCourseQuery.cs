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
    public partial class StudentCourseQuery : Form
    {
        public StudentCourseQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sql = string.Format("SELECT * FROM Sc WHERE Cname LIKE '{0}%'", this.textBox1.Text);
            //OracleConnection con = new OracleConnection(Program.connect);
            //try
            //{
            //    con.Open();
            //    OracleCommand cmd = new OracleCommand(sql, con);
            //    OracleDataReader odr = cmd.ExecuteReader();
            //    if (odr.HasRows)
            //    {
            //        BindingSource bs = new BindingSource();
            //        bs.DataSource = odr;
            //        dataGridView1.DataSource = bs;
            //    }
            //    else
            //    {
            //        dataGridView1.DataSource = null;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
            try
            {
                this.dataGridView1.DataSource = Sc.QueryCourse(this.textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //参数e记录单击的是哪一行哪一列
            //MessageBox.Show(e.RowIndex.ToString() + "," + e.ColumnIndex.ToString());
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Sc sc = (Sc)row.DataBoundItem;
            if (sc == null)
                return;
            try
            {
                //MessageBox.Show(e.RowIndex.ToString() + " " + e.ColumnIndex.ToString());
                switch (e.ColumnIndex)
                {
                    case 6:
                        if (MessageBox.Show("是否退选", "请确定", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                            return;
                        if (Sc.deleteCourse(sc.Cno) == 1)
                        {
                            MessageBox.Show("退选成功");
                        }
                        else
                            MessageBox.Show("退选失败");
                        break;
                    //case 7:
                    //    MessageBox.Show(sc.Cno);

                    //    if (Sc.InsertSc(sc.Cno) == 1)
                    //    {
                    //        MessageBox.Show("选课成功");
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("错误");
                    //    }
                    //    //TODO
                    //    break;
                    case 7:
                        UpdateGrade updateGrade = new UpdateGrade();
                        updateGrade.Cno = sc.Cno;
                        updateGrade.Sno = sc.Sno;
                        updateGrade.tbSname.Text = sc.Sname;
                        updateGrade.tbCname.Text = sc.Cname;
                        updateGrade.tbGrade.Text = sc.Grade.ToString();
                        updateGrade.ShowDialog(this);
                        break;
                    default:
                        break;
                }
                //if (e.ColumnIndex == 4)
                //{
                //    //点击了删除按钮
                //    if (MessageBox.Show("是否删除", "请确定", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                //        return;
                //    if (Course.deleteCourse(c.Cno) == 1)
                //    {
                //        MessageBox.Show("删除成功");
                //    }
                //    else
                //        MessageBox.Show("删除失败");
                //}
                //else if (e.ColumnIndex == 5)
                //{
                //    //点击了修改按钮
                //    CourseUpdate courseUpdate = new CourseUpdate();
                //    courseUpdate.tbCno.Text = c.Cno;
                //    courseUpdate.tbCname.Text = c.Cname;
                //    courseUpdate.tbCpno.Text = c.Cpno;
                //    courseUpdate.tbCcredit.Text = c.Ccredit.ToString();

                //    courseUpdate.ShowDialog(this);
                //}

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString() + "," + e.ColumnIndex.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
