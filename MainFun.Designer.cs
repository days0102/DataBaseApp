
namespace WindowsFormsApp1
{
    partial class MainFun
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询教师ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询课程ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.添加课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.教师管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.统计信息ToolStripMenuItem,
            this.修改信息ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询学生ToolStripMenuItem,
            this.添加学生ToolStripMenuItem});
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            // 
            // 查询学生ToolStripMenuItem
            // 
            this.查询学生ToolStripMenuItem.Name = "查询学生ToolStripMenuItem";
            this.查询学生ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.查询学生ToolStripMenuItem.Text = "查询学生";
            this.查询学生ToolStripMenuItem.Click += new System.EventHandler(this.查询学生ToolStripMenuItem_Click);
            // 
            // 添加学生ToolStripMenuItem
            // 
            this.添加学生ToolStripMenuItem.Name = "添加学生ToolStripMenuItem";
            this.添加学生ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.添加学生ToolStripMenuItem.Text = "添加学生";
            this.添加学生ToolStripMenuItem.Click += new System.EventHandler(this.添加学生ToolStripMenuItem_Click);
            // 
            // 教师管理ToolStripMenuItem
            // 
            this.教师管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询教师ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.教师管理ToolStripMenuItem.Name = "教师管理ToolStripMenuItem";
            this.教师管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.教师管理ToolStripMenuItem.Text = "教师管理";
            // 
            // 查询教师ToolStripMenuItem
            // 
            this.查询教师ToolStripMenuItem.Name = "查询教师ToolStripMenuItem";
            this.查询教师ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.查询教师ToolStripMenuItem.Text = "查询教师";
            this.查询教师ToolStripMenuItem.Click += new System.EventHandler(this.查询教师ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItem1.Text = "添加教师";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询课程ToolStripMenuItem1,
            this.添加课程ToolStripMenuItem,
            this.选修ToolStripMenuItem,
            this.查询课程ToolStripMenuItem});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            // 
            // 查询课程ToolStripMenuItem1
            // 
            this.查询课程ToolStripMenuItem1.Name = "查询课程ToolStripMenuItem1";
            this.查询课程ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.查询课程ToolStripMenuItem1.Text = "查询课程";
            this.查询课程ToolStripMenuItem1.Click += new System.EventHandler(this.查询课程ToolStripMenuItem1_Click);
            // 
            // 添加课程ToolStripMenuItem
            // 
            this.添加课程ToolStripMenuItem.Name = "添加课程ToolStripMenuItem";
            this.添加课程ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.添加课程ToolStripMenuItem.Text = "添加课程";
            this.添加课程ToolStripMenuItem.Click += new System.EventHandler(this.添加课程ToolStripMenuItem_Click);
            // 
            // 选修ToolStripMenuItem
            // 
            this.选修ToolStripMenuItem.Name = "选修ToolStripMenuItem";
            this.选修ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.选修ToolStripMenuItem.Text = "选修课程";
            this.选修ToolStripMenuItem.Click += new System.EventHandler(this.选修ToolStripMenuItem_Click);
            // 
            // 查询课程ToolStripMenuItem
            // 
            this.查询课程ToolStripMenuItem.Name = "查询课程ToolStripMenuItem";
            this.查询课程ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询课程ToolStripMenuItem.Text = "查询已选课程";
            this.查询课程ToolStripMenuItem.Click += new System.EventHandler(this.查询课程ToolStripMenuItem_Click);
            // 
            // 统计信息ToolStripMenuItem
            // 
            this.统计信息ToolStripMenuItem.Name = "统计信息ToolStripMenuItem";
            this.统计信息ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.统计信息ToolStripMenuItem.Text = "统计信息";
            this.统计信息ToolStripMenuItem.Click += new System.EventHandler(this.统计信息ToolStripMenuItem_Click);
            // 
            // 修改信息ToolStripMenuItem
            // 
            this.修改信息ToolStripMenuItem.Name = "修改信息ToolStripMenuItem";
            this.修改信息ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.修改信息ToolStripMenuItem.Text = "修改信息";
            this.修改信息ToolStripMenuItem.Click += new System.EventHandler(this.修改信息ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // MainFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Gzhu;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFun";
            this.Text = "学生信息管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFun_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选修ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询课程ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 教师管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询教师ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

