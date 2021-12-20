
namespace WindowsFormsApp1
{
    partial class StudentInsert
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.tbSno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SnoNotNull = new System.Windows.Forms.Label();
            this.NameNotNull = new System.Windows.Forms.Label();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "添加学生信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "年龄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "姓名";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbSname
            // 
            this.tbSname.Location = new System.Drawing.Point(198, 122);
            this.tbSname.Name = "tbSname";
            this.tbSname.Size = new System.Drawing.Size(100, 25);
            this.tbSname.TabIndex = 10;
            this.tbSname.TextChanged += new System.EventHandler(this.tbSname_TextChanged);
            // 
            // tbSno
            // 
            this.tbSno.Location = new System.Drawing.Point(198, 44);
            this.tbSno.Name = "tbSno";
            this.tbSno.Size = new System.Drawing.Size(100, 25);
            this.tbSno.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "学号";
            // 
            // tbSage
            // 
            this.tbSage.Location = new System.Drawing.Point(198, 276);
            this.tbSage.Name = "tbSage";
            this.tbSage.Size = new System.Drawing.Size(100, 25);
            this.tbSage.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "性别";
            // 
            // SnoNotNull
            // 
            this.SnoNotNull.AutoSize = true;
            this.SnoNotNull.ForeColor = System.Drawing.Color.Red;
            this.SnoNotNull.Location = new System.Drawing.Point(198, 76);
            this.SnoNotNull.Name = "SnoNotNull";
            this.SnoNotNull.Size = new System.Drawing.Size(0, 15);
            this.SnoNotNull.TabIndex = 17;
            // 
            // NameNotNull
            // 
            this.NameNotNull.AutoSize = true;
            this.NameNotNull.ForeColor = System.Drawing.Color.Red;
            this.NameNotNull.Location = new System.Drawing.Point(198, 150);
            this.NameNotNull.Name = "NameNotNull";
            this.NameNotNull.Size = new System.Drawing.Size(0, 15);
            this.NameNotNull.TabIndex = 18;
            this.NameNotNull.Visible = false;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(201, 197);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(17, 16);
            this.rbmale.TabIndex = 19;
            this.rbmale.TabStop = true;
            this.rbmale.UseVisualStyleBackColor = true;
            this.rbmale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(281, 197);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(17, 16);
            this.rbfemale.TabIndex = 20;
            this.rbfemale.TabStop = true;
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "男";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "女";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(195, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // StudentInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 426);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.NameNotNull);
            this.Controls.Add(this.SnoNotNull);
            this.Controls.Add(this.tbSage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSname);
            this.Controls.Add(this.tbSno);
            this.Controls.Add(this.label1);
            this.Name = "StudentInsert";
            this.Text = "StudentInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbSname;
        public System.Windows.Forms.TextBox tbSno;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbSage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SnoNotNull;
        private System.Windows.Forms.Label NameNotNull;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}