namespace version0._1
{
    partial class 修改职工信息Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.分工ComboBox = new System.Windows.Forms.ComboBox();
            this.修改btn = new System.Windows.Forms.Button();
            this.姓名TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.选定员工信息ListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.分工ComboBox);
            this.panel1.Location = new System.Drawing.Point(33, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 37);
            this.panel1.TabIndex = 26;
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
            // 分工ComboBox
            // 
            this.分工ComboBox.FormattingEnabled = true;
            this.分工ComboBox.Location = new System.Drawing.Point(50, 11);
            this.分工ComboBox.Name = "分工ComboBox";
            this.分工ComboBox.Size = new System.Drawing.Size(100, 20);
            this.分工ComboBox.TabIndex = 10;
            // 
            // 修改btn
            // 
            this.修改btn.Location = new System.Drawing.Point(73, 107);
            this.修改btn.Name = "修改btn";
            this.修改btn.Size = new System.Drawing.Size(75, 23);
            this.修改btn.TabIndex = 25;
            this.修改btn.Text = "修改";
            this.修改btn.UseVisualStyleBackColor = true;
            this.修改btn.Click += new System.EventHandler(this.修改btn_Click);
            // 
            // 姓名TextBox
            // 
            this.姓名TextBox.Location = new System.Drawing.Point(83, 38);
            this.姓名TextBox.Name = "姓名TextBox";
            this.姓名TextBox.Size = new System.Drawing.Size(100, 21);
            this.姓名TextBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "请录入员工信息";
            // 
            // 选定员工信息ListBox
            // 
            this.选定员工信息ListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.选定员工信息ListBox.FormattingEnabled = true;
            this.选定员工信息ListBox.ItemHeight = 12;
            this.选定员工信息ListBox.Items.AddRange(new object[] {
            "      选定员工信息",
            "工号：",
            "姓名：",
            "性别："});
            this.选定员工信息ListBox.Location = new System.Drawing.Point(218, 38);
            this.选定员工信息ListBox.Name = "选定员工信息ListBox";
            this.选定员工信息ListBox.Size = new System.Drawing.Size(147, 88);
            this.选定员工信息ListBox.TabIndex = 27;
            // 
            // 修改职工信息Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 143);
            this.Controls.Add(this.选定员工信息ListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.修改btn);
            this.Controls.Add(this.姓名TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "修改职工信息Form";
            this.Text = "修改职工信息";
            this.Load += new System.EventHandler(this.修改职工信息Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox 分工ComboBox;
        private System.Windows.Forms.Button 修改btn;
        private System.Windows.Forms.TextBox 姓名TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox 选定员工信息ListBox;


    }
}