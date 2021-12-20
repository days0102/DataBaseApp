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
            Course c = new Course();
            c.Cno = tbCno.Text;
            c.Cname = tbCname.Text;
            if (tbCcredit.Text == "")
                c.Ccredit = 0;
            else
                c.Ccredit = Convert.ToInt32(tbCcredit.Text);
            try
            {
                Course.InsertCourse(c);
                MessageBox.Show("插入成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
