
namespace WindowsFormsApp1
{
    partial class CourseUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbCno = new System.Windows.Forms.TextBox();
            this.tbCname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCcredit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCno
            // 
            this.tbCno.Location = new System.Drawing.Point(167, 65);
            this.tbCno.Name = "tbCno";
            this.tbCno.ReadOnly = true;
            this.tbCno.Size = new System.Drawing.Size(127, 25);
            this.tbCno.TabIndex = 1;
            this.tbCno.TextChanged += new System.EventHandler(this.tbCno_TextChanged);
            // 
            // tbCname
            // 
            this.tbCname.Location = new System.Drawing.Point(167, 160);
            this.tbCname.Name = "tbCname";
            this.tbCname.Size = new System.Drawing.Size(127, 25);
            this.tbCname.TabIndex = 3;
            this.tbCname.TextChanged += new System.EventHandler(this.tbCname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "课程名";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbCcredit
            // 
            this.tbCcredit.Location = new System.Drawing.Point(167, 242);
            this.tbCcredit.Name = "tbCcredit";
            this.tbCcredit.Size = new System.Drawing.Size(127, 25);
            this.tbCcredit.TabIndex = 7;
            this.tbCcredit.TextChanged += new System.EventHandler(this.tbCcredit_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "课程学分";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "修改课程信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CourseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCcredit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCno);
            this.Controls.Add(this.label1);
            this.Name = "CourseUpdate";
            this.Text = "CourseUpdate";
            this.Load += new System.EventHandler(this.CourseUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbCno;
        public System.Windows.Forms.TextBox tbCname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbCcredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}