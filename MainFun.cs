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
    public partial class MainFun : Form
    {
        public MainFun()
        {
            InitializeComponent();
        }

        private void 查询学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //点击菜单->查询学生，打开一个窗体
            StudentQuery stu = new StudentQuery();
            stu.MdiParent = this;
            stu.Show();
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInsert studentInsert = new StudentInsert();
            studentInsert.MdiParent = this;
            studentInsert.Show();
        }

        private void 查询课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开查询课程窗体
            StudentCourseQuery courseQuery = new StudentCourseQuery();
            courseQuery.MdiParent = this;
            courseQuery.btnUpdate.Visible = true;
            if (Login.UserType == "Student")
            {
                courseQuery.btnUpdate.Visible = false;
            }
            courseQuery.Show();
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertCourse insertCourse = new InsertCourse();
            insertCourse.MdiParent = this;
            insertCourse.Show();
        }

        private void 统计信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //显示统计窗体
            Statistics statistics = new Statistics();
            statistics.MdiParent= this;
            if (Login.UserType == "Student")
            {
                statistics.button1.Visible = false;
                statistics.button2.Visible = false;
            }
            statistics.Show();
        }

        private void MainFun_Load(object sender, EventArgs e)
        {
            学生管理ToolStripMenuItem.Visible = true;
            选修ToolStripMenuItem.Visible = true;
            添加课程ToolStripMenuItem.Visible = true;
            教师管理ToolStripMenuItem.Visible = true;
            this.Text = "学生信息管理系统--" + Login.UserId;
            if (Login.UserType == "Student")
            {
                学生管理ToolStripMenuItem.Visible = false;
                添加课程ToolStripMenuItem.Visible = false;
                教师管理ToolStripMenuItem.Visible = false;
            }
            if (Login.UserType == "Admin")
            {
                选修ToolStripMenuItem.Visible = false;
            }
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出？", "请确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach(Form f in this.MdiChildren)
                {
                    f.Close();//关闭所有子窗口
                }
                学生管理ToolStripMenuItem.Visible = true;
                选修ToolStripMenuItem.Visible = true;
                教师管理ToolStripMenuItem.Visible = true;
                添加课程ToolStripMenuItem.Visible = true;
                this.Text = "学生信息管理系统";
                Login login = new Login();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    this.Text = "学生信息管理系统--" + Login.UserId;
                    if (Login.UserType == "Student")
                    {
                        学生管理ToolStripMenuItem.Visible = false;
                        教师管理ToolStripMenuItem.Visible = false;
                        添加课程ToolStripMenuItem.Visible = false;
                    }
                }
                else
                    Application.Exit();
            }
        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudentInfo updateStudentInfo = new UpdateStudentInfo();
            
            string sql = string.Format("SELECT * FROM Student WHERE sno='{0}'", Login.UserId);
            OracleConnection con = new OracleConnection(Program.connect);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.HasRows)
                {
                    while (odr.Read())
                    {
                        updateStudentInfo.tbSno.Text = odr.GetString(0);
                        updateStudentInfo.tbSname.Text = odr.GetString(1);
                        if (odr.IsDBNull(2))
                        {
                            updateStudentInfo.rbfemale.Checked = false;
                            updateStudentInfo.rbmale.Checked = false;
                        }
                        else
                        {
                            if (odr.GetString(2) == "男")
                            {
                                updateStudentInfo.rbmale.Checked = true;
                            }
                            else
                            {
                                updateStudentInfo.rbfemale.Checked = true;
                            }
                        }
                        if (odr.IsDBNull(3))
                        {
                            updateStudentInfo.tbSage.Text = "";
                        }
                        else
                        {
                            updateStudentInfo.tbSage.Text = odr.GetString(3);
                        }
                    }
                }
                updateStudentInfo.ShowDialog();
                
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

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePwd updatePwd = new UpdatePwd();
            //updatePwd.MdiParent = this;
            updatePwd.ShowDialog();
        }

        private void 选修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertSc insertSc = new InsertSc();
            insertSc.MdiParent = this;
            insertSc.Show();
        }

        private void 查询课程ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CourseQuery courseQuery = new CourseQuery();
            courseQuery.MdiParent = this;
            courseQuery.btnDelete.Visible = true;
            courseQuery.btnUpdate.Visible = true;
            if (Login.UserType == "Student")
            {
                courseQuery.btnDelete.Visible = false;
                courseQuery.btnUpdate.Visible = false;
            }
            courseQuery.Show();
        }

        private void 查询教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherQuery teacherQuery = new TeacherQuery();
            teacherQuery.MdiParent = this;
            teacherQuery.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeacherInsert teacherInsert = new TeacherInsert();
            teacherInsert.MdiParent = this;
            teacherInsert.Show();
        }
    }
}
