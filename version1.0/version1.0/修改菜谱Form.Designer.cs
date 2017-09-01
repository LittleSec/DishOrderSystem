namespace version0._1
{
    partial class 修改菜谱Form
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
            this.修改btn = new System.Windows.Forms.Button();
            this.菜种类TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.菜种类ComboBox = new System.Windows.Forms.ComboBox();
            this.烹饪时长TextBox = new System.Windows.Forms.TextBox();
            this.菜价TextBox = new System.Windows.Forms.TextBox();
            this.菜名TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.选定菜ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // 修改btn
            // 
            this.修改btn.Location = new System.Drawing.Point(266, 51);
            this.修改btn.Name = "修改btn";
            this.修改btn.Size = new System.Drawing.Size(73, 23);
            this.修改btn.TabIndex = 31;
            this.修改btn.Text = "修改";
            this.修改btn.UseVisualStyleBackColor = true;
            this.修改btn.Click += new System.EventHandler(this.修改btn_Click);
            // 
            // 菜种类TextBox
            // 
            this.菜种类TextBox.Location = new System.Drawing.Point(195, 51);
            this.菜种类TextBox.MaxLength = 10;
            this.菜种类TextBox.Name = "菜种类TextBox";
            this.菜种类TextBox.Size = new System.Drawing.Size(65, 21);
            this.菜种类TextBox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "元/份";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "秒";
            // 
            // 菜种类ComboBox
            // 
            this.菜种类ComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.菜种类ComboBox.Location = new System.Drawing.Point(103, 51);
            this.菜种类ComboBox.Name = "菜种类ComboBox";
            this.菜种类ComboBox.Size = new System.Drawing.Size(86, 20);
            this.菜种类ComboBox.TabIndex = 26;
            this.菜种类ComboBox.SelectedIndexChanged += new System.EventHandler(this.IfOtherShowTextBoxToInput);
            // 
            // 烹饪时长TextBox
            // 
            this.烹饪时长TextBox.Location = new System.Drawing.Point(103, 140);
            this.烹饪时长TextBox.Name = "烹饪时长TextBox";
            this.烹饪时长TextBox.Size = new System.Drawing.Size(63, 21);
            this.烹饪时长TextBox.TabIndex = 25;
            // 
            // 菜价TextBox
            // 
            this.菜价TextBox.Location = new System.Drawing.Point(103, 110);
            this.菜价TextBox.Name = "菜价TextBox";
            this.菜价TextBox.Size = new System.Drawing.Size(57, 21);
            this.菜价TextBox.TabIndex = 24;
            // 
            // 菜名TextBox
            // 
            this.菜名TextBox.Location = new System.Drawing.Point(103, 80);
            this.菜名TextBox.MaxLength = 20;
            this.菜名TextBox.Name = "菜名TextBox";
            this.菜名TextBox.Size = new System.Drawing.Size(86, 21);
            this.菜名TextBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "大概烹饪时长：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "菜价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "菜名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "菜的种类：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(112, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "请填写修改需要的菜的信息";
            // 
            // 选定菜ListBox
            // 
            this.选定菜ListBox.FormattingEnabled = true;
            this.选定菜ListBox.ItemHeight = 12;
            this.选定菜ListBox.Items.AddRange(new object[] {
            "      选定菜的信息",
            "菜的编号：",
            "菜名：",
            "菜的种类：",
            "菜价：",
            "大概烹饪时长："});
            this.选定菜ListBox.Location = new System.Drawing.Point(228, 80);
            this.选定菜ListBox.Name = "选定菜ListBox";
            this.选定菜ListBox.Size = new System.Drawing.Size(156, 88);
            this.选定菜ListBox.TabIndex = 32;
            // 
            // 修改菜谱Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 177);
            this.Controls.Add(this.选定菜ListBox);
            this.Controls.Add(this.修改btn);
            this.Controls.Add(this.菜种类TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.菜种类ComboBox);
            this.Controls.Add(this.烹饪时长TextBox);
            this.Controls.Add(this.菜价TextBox);
            this.Controls.Add(this.菜名TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "修改菜谱Form";
            this.Text = "修改菜谱";
            this.Load += new System.EventHandler(this.修改菜谱Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 修改btn;
        private System.Windows.Forms.TextBox 菜种类TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox 菜种类ComboBox;
        private System.Windows.Forms.TextBox 烹饪时长TextBox;
        private System.Windows.Forms.TextBox 菜价TextBox;
        private System.Windows.Forms.TextBox 菜名TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox 选定菜ListBox;
    }
}