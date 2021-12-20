using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Teacherinfo";
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader odr = cmd.ExecuteReader();
                if(odr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr;
                    dataGridView1.DataSource = bs;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Courseinfo";
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr;
                    dataGridView1.DataSource = bs;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql;
            if (Login.UserType == "Admin")
                sql = "SELECT * FROM Studentinfo WHERE sno!='admin'";
            else
                sql = string.Format("SELECT sno,sname,SUM(ccredit) 通过学分 FROM StudentCourse WHERE grade>60 AND sno='{0}' GROUP BY sno,sname", Login.UserId);
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr;
                    dataGridView1.DataSource = bs;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
