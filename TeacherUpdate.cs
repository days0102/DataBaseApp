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
    public partial class TeacherUpdate : Form
    {
        public TeacherUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            Teacher t = new Teacher();
            t.Tno = this.tbTno.Text;
            if(tbTname.Text=="")
            {
                label6.Text = "教师姓名不能为空";
                label6.Visible = true;
                return;
            }
            else
                t.Tname = this.tbTname.Text;
            t.Post = this.tbPost.Text;
            if (tbSalary.Text == "")
                t.Salary = 0;
            else
            {
                try
                {
                    t.Salary = Convert.ToInt32(this.tbSalary.Text);
                }
                catch (Exception)
                {
                    label5.Text = "工资输入错误";
                    label5.Visible = true;
                    return;
                }
            }
            try
            {
                if (Teacher.UpdateTeacher(t) == 1)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
