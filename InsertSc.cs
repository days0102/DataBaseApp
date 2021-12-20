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
    public partial class InsertSc : Form
    {
        public InsertSc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = Sc.QuerySc(this.textBox1.Text);
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
            Sc sc = (Sc)row.DataBoundItem;
            if (sc == null)
                return;
            try
            {
                if ((e.ColumnIndex) == 3)
                {
                    if (MessageBox.Show("是否选修", "请确定", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                    if (Sc.InsertSc(sc.Cno) == 1)
                    {
                        MessageBox.Show("选修成功");
                    }
                    else
                        MessageBox.Show("选修失败");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }
    }
}
