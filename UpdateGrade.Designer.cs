﻿
namespace WindowsFormsApp1
{
    partial class UpdateGrade
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
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCname = new System.Windows.Forms.TextBox();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(181, 142);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(137, 25);
            this.tbGrade.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "课程成绩";
            // 
            // tbCname
            // 
            this.tbCname.Location = new System.Drawing.Point(181, 83);
            this.tbCname.Name = "tbCname";
            this.tbCname.ReadOnly = true;
            this.tbCname.Size = new System.Drawing.Size(137, 25);
            this.tbCname.TabIndex = 14;
            // 
            // tbSname
            // 
            this.tbSname.Location = new System.Drawing.Point(181, 28);
            this.tbSname.Name = "tbSname";
            this.tbSname.ReadOnly = true;
            this.tbSname.Size = new System.Drawing.Size(137, 25);
            this.tbSname.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "课程名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "学生姓名";
            // 
            // UpdateGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCname);
            this.Controls.Add(this.tbSname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateGrade";
            this.Text = "UpdateGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public string Sno { get; set; }
        public string Cno { get; set; }


        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbCname;
        public System.Windows.Forms.TextBox tbSname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}