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
    public partial class UpdateGrade : Form
    {
        public UpdateGrade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            Sc sc = new Sc();
            sc.Cno = Cno;
            sc.Sno = Sno;
            try
            {
                sc.Grade = Convert.ToInt32(tbGrade.Text);
            }
            catch(Exception)
            {
                label4.Text = "成绩输入错误";
                label4.Visible = true;
                return;
            }
            try
            {
                if (Sc.UpdateGrade(sc) == 1)
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
    }
}
