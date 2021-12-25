using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CourseQuery : Form
    {
        public CourseQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = Course.QueryCourse(this.textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Course c = (Course)row.DataBoundItem;
            if (c == null)
                return;
            try
            {
                //MessageBox.Show(e.RowIndex.ToString() + " " + e.ColumnIndex.ToString());
                switch (e.ColumnIndex)
                {
                    case 3:
                        if (MessageBox.Show("是否删除", "请确定", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                            return;
                        if (Course.deleteCourse(c.Cno) == 1)
                        {
                            MessageBox.Show("删除成功");
                        }
                        else
                            MessageBox.Show("删除失败");
                        break;
                    case 4:
                        CourseUpdate courseUpdate = new CourseUpdate();
                        courseUpdate.tbCno.Text = c.Cno;
                        courseUpdate.tbCname.Text = c.Cname;
                        //courseUpdate.tbCpno.Text = c.Cpno;
                        courseUpdate.tbCcredit.Text = c.Ccredit.ToString();
                        courseUpdate.ShowDialog(this);
                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
