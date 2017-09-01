namespace version0._1
{
    partial class 增加菜谱Form
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
            this.label6 = new System.Windows.Forms.Label();
            this.菜编号TextBox = new System.Windows.Forms.TextBox();
            this.菜名TextBox = new System.Windows.Forms.TextBox();
            this.菜价TextBox = new System.Windows.Forms.TextBox();
            this.烹饪时长TextBox = new System.Windows.Forms.TextBox();
            this.菜种类ComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.菜种类TextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(123, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "请填写新增菜的信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "菜的编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "菜的种类：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "菜名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "菜价：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "大概烹饪时长：";
            // 
            // 菜编号TextBox
            // 
            this.菜编号TextBox.Location = new System.Drawing.Point(107, 48);
            this.菜编号TextBox.MaxLength = 6;
            this.菜编号TextBox.Name = "菜编号TextBox";
            this.菜编号TextBox.Size = new System.Drawing.Size(86, 21);
            this.菜编号TextBox.TabIndex = 6;
            // 
            // 菜名TextBox
            // 
            this.菜名TextBox.Location = new System.Drawing.Point(107, 107);
            this.菜名TextBox.MaxLength = 20;
            this.菜名TextBox.Name = "菜名TextBox";
            this.菜名TextBox.Size = new System.Drawing.Size(86, 21);
            this.菜名TextBox.TabIndex = 7;
            // 
            // 菜价TextBox
            // 
            this.菜价TextBox.Location = new System.Drawing.Point(107, 137);
            this.菜价TextBox.Name = "菜价TextBox";
            this.菜价TextBox.Size = new System.Drawing.Size(57, 21);
            this.菜价TextBox.TabIndex = 8;
            // 
            // 烹饪时长TextBox
            // 
            this.烹饪时长TextBox.Location = new System.Drawing.Point(107, 167);
            this.烹饪时长TextBox.Name = "烹饪时长TextBox";
            this.烹饪时长TextBox.Size = new System.Drawing.Size(63, 21);
            this.烹饪时长TextBox.TabIndex = 9;
            // 
            // 菜种类ComboBox
            // 
            this.菜种类ComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.菜种类ComboBox.Location = new System.Drawing.Point(107, 78);
            this.菜种类ComboBox.Name = "菜种类ComboBox";
            this.菜种类ComboBox.Size = new System.Drawing.Size(86, 20);
            this.菜种类ComboBox.TabIndex = 10;
            this.菜种类ComboBox.SelectedIndexChanged += new System.EventHandler(this.IfOtherShowTextBoxToInput);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "秒";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "元/份";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 84);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tips：\r\n1、菜的编号是6位。\r\n2、菜的种类如果是新增，\r\n   请选择其他，\r\n   并输入种类名。\r\n   种类名最长支持5个汉字。\r\n3、菜名最长支持" +
    "10个汉字。";
            // 
            // 菜种类TextBox
            // 
            this.菜种类TextBox.Location = new System.Drawing.Point(199, 78);
            this.菜种类TextBox.MaxLength = 10;
            this.菜种类TextBox.Name = "菜种类TextBox";
            this.菜种类TextBox.Size = new System.Drawing.Size(65, 21);
            this.菜种类TextBox.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(270, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 48);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "添\r\n加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // 增加菜谱Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 200);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.菜种类TextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.菜种类ComboBox);
            this.Controls.Add(this.烹饪时长TextBox);
            this.Controls.Add(this.菜价TextBox);
            this.Controls.Add(this.菜名TextBox);
            this.Controls.Add(this.菜编号TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "增加菜谱Form";
            this.Text = "增加菜谱";
            this.Load += new System.EventHandler(this.增加菜谱Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 菜编号TextBox;
        private System.Windows.Forms.TextBox 菜名TextBox;
        private System.Windows.Forms.TextBox 菜价TextBox;
        private System.Windows.Forms.TextBox 烹饪时长TextBox;
        private System.Windows.Forms.ComboBox 菜种类ComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox 菜种类TextBox;
        private System.Windows.Forms.Button btnAdd;
    }
}