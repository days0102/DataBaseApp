
namespace WindowsFormsApp1
{
    partial class InsertCourse
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbCcredit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "添加课程";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCcredit
            // 
            this.tbCcredit.Location = new System.Drawing.Point(191, 257);
            this.tbCcredit.Name = "tbCcredit";
            this.tbCcredit.Size = new System.Drawing.Size(127, 25);
            this.tbCcredit.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "课程学分";
            // 
            // tbCname
            // 
            this.tbCname.Location = new System.Drawing.Point(191, 168);
            this.tbCname.Name = "tbCname";
            this.tbCname.Size = new System.Drawing.Size(127, 25);
            this.tbCname.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "课程名";
            // 
            // tbCno
            // 
            this.tbCno.Location = new System.Drawing.Point(191, 78);
            this.tbCno.Name = "tbCno";
            this.tbCno.Size = new System.Drawing.Size(127, 25);
            this.tbCno.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "课程号";
            // 
            // InsertCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCcredit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCno);
            this.Controls.Add(this.label1);
            this.Name = "InsertCourse";
            this.Text = "InsertCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbCcredit;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbCname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbCno;
        private System.Windows.Forms.Label label1;
    }
}