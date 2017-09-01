namespace version0._1
{
    partial class 雇佣厨师或服务员Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.分工ComboBox = new System.Windows.Forms.ComboBox();
            this.姓名TextBox = new System.Windows.Forms.TextBox();
            this.工号TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "请录入新员工信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "分工：";
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(113, 114);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(35, 16);
            this.radioBtnFemale.TabIndex = 9;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "女";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(72, 114);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(35, 16);
            this.radioBtnMale.TabIndex = 8;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "男";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // 分工ComboBox
            // 
            this.分工ComboBox.FormattingEnabled = true;
            this.分工ComboBox.Location = new System.Drawing.Point(50, 11);
            this.分工ComboBox.Name = "分工ComboBox";
            this.分工ComboBox.Size = new System.Drawing.Size(100, 20);
            this.分工ComboBox.TabIndex = 10;
            // 
            // 姓名TextBox
            // 
            this.姓名TextBox.Location = new System.Drawing.Point(72, 80);
            this.姓名TextBox.Name = "姓名TextBox";
            this.姓名TextBox.Size = new System.Drawing.Size(100, 21);
            this.姓名TextBox.TabIndex = 11;
            // 
            // 工号TextBox
            // 
            this.工号TextBox.Location = new System.Drawing.Point(72, 44);
            this.工号TextBox.Name = "工号TextBox";
            this.工号TextBox.Size = new System.Drawing.Size(100, 21);
            this.工号TextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 60);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tips：\r\n1、工号为4位，首位不为0。\r\n2、厨师首位为1，服务员为其他。\r\n3、姓名最长不超过10个汉字。\r\n4、添加后默认工作状态为空闲。";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(61, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.分工ComboBox);
            this.panel1.Location = new System.Drawing.Point(201, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 37);
            this.panel1.TabIndex = 15;
            // 
            // 雇佣厨师或服务员Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 179);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.工号TextBox);
            this.Controls.Add(this.姓名TextBox);
            this.Controls.Add(this.radioBtnFemale);
            this.Controls.Add(this.radioBtnMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "雇佣厨师或服务员Form";
            this.Text = "录入雇佣信息";
            this.Load += new System.EventHandler(this.雇佣厨师或服务员Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.RadioButton radioBtnFemale;
        internal System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.ComboBox 分工ComboBox;
        private System.Windows.Forms.TextBox 姓名TextBox;
        private System.Windows.Forms.TextBox 工号TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
    }
}