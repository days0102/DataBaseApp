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
            Sc sc = new Sc();
            sc.Cno = Cno;
            sc.Sno = Sno;

            sc.Grade = Convert.ToInt32(tbGrade.Text);
            if(Sc.UpdateGrade(sc)==1)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
