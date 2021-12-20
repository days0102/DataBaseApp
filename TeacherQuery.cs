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
    public partial class TeacherQuery : Form
    {
        public TeacherQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = Teacher.QueryTeacher(this.textBox1.Text);
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
            Teacher t = (Teacher)row.DataBoundItem;
            if(t==null)
                return;
            try
            {
                switch (e.ColumnIndex)
                {
                    case 4:
                        if (MessageBox.Show("是否删除", "请确定", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                            return;
                        if (Teacher.deleteTeacher(t.Tno) == 1)
                        {
                            MessageBox.Show("删除成功");
                        }
                        else
                            MessageBox.Show("删除失败");
                        break;
                    case 5:
                        TeacherUpdate teacherUpdate = new TeacherUpdate();
                        teacherUpdate.tbTno.Text = t.Tno;
                        teacherUpdate.tbTname.Text = t.Tname;
                        teacherUpdate.tbPost.Text = t.Post;
                        teacherUpdate.tbSalary.Text = t.Salary.ToString();
                        teacherUpdate.Show();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
