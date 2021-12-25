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
    public partial class InsertCourse : Form
    {
        public InsertCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            Course c = new Course();
            if (tbCno.Text == "")
            {
                label3.Text = "课程号不能为空";
                label3.Visible = true;
                return;
            }
            c.Cno = tbCno.Text;
            if (tbCname.Text == "")
            {
                label5.Text = "课程名不能为空";
                label5.Visible = true;
                return;
            }
            c.Cname = tbCname.Text;
            if (tbCcredit.Text == "")
                c.Ccredit = 0;
            else
            {
                try
                {
                    c.Ccredit = Convert.ToInt32(tbCcredit.Text);
                }
                catch(Exception)
                {
                    label6.Text = "学分输入错误";
                    label6.Visible = true;
                    return;
                }
            }
            try
            {
                Course.InsertCourse(c);
                label6.Text = "添加成功";
                label6.Visible = true;
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                label6.Text = ex.Message;
                label6.Visible = true;
            }
        }
    }
}
