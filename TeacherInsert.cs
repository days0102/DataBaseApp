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
    public partial class TeacherInsert : Form
    {
        public TeacherInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            Teacher t = new Teacher();
            if(tbTno.Text=="")
            {
                label5.Text = "工号不能为空";
                label5.Visible = true;
                return;
            }
            else
                t.Tno = tbTno.Text;
            if (tbTname.Text == "")
            {
                label6.Text = "姓名不能为空";
                label6.Visible = true;
                return;
            }
            else
                t.Tname = tbTname.Text;
            t.Post = tbPost.Text;
            try
            {
                t.Salary = Convert.ToInt32(tbSalary.Text);
            }
            catch(Exception ex)
            {
                label7.Text = "工资输入错误";
                label7.Visible = true;
                return;
            }
            try
            {
                Teacher.InsertTeacher(t);
                label7.Text = "添加成功";
                label7.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
