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
    public partial class CourseUpdate : Form
    {
        public CourseUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Cno = this.tbCno.Text;
            c.Cname = this.tbCname.Text;
            //c.Cpno = this.tbCpno.Text;
            if (tbCcredit.Text == "")
                c.Ccredit = 0;
            else
                c.Ccredit = Convert.ToInt32(this.tbCcredit.Text);
            try
            {
                if (Course.UpdateCourse(c) == 1)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbCno_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CourseUpdate_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbCcredit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
