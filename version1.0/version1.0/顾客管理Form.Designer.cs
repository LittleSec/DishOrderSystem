namespace version0._1
{
    partial class 顾客管理Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cusMsgDataView = new System.Windows.Forms.DataGridView();
            this.btn新增顾客 = new System.Windows.Forms.Button();
            this.btn光顾 = new System.Windows.Forms.Button();
            this.btn删除顾客 = new System.Windows.Forms.Button();
            this.btn修改信息 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.btn确定 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cusMsgDataView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cusMsgDataView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "所有顾客信息";
            // 
            // cusMsgDataView
            // 
            this.cusMsgDataView.AllowUserToAddRows = false;
            this.cusMsgDataView.AllowUserToDeleteRows = false;
            this.cusMsgDataView.AllowUserToResizeColumns = false;
            this.cusMsgDataView.AllowUserToResizeRows = false;
            this.cusMsgDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cusMsgDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cusMsgDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cusMsgDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cusMsgDataView.Location = new System.Drawing.Point(3, 17);
            this.cusMsgDataView.MultiSelect = false;
            this.cusMsgDataView.Name = "cusMsgDataView";
            this.cusMsgDataView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cusMsgDataView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.cusMsgDataView.RowTemplate.Height = 23;
            this.cusMsgDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cusMsgDataView.Size = new System.Drawing.Size(561, 237);
            this.cusMsgDataView.TabIndex = 0;
            this.cusMsgDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectCustomerToSeeHistory);
            // 
            // btn新增顾客
            // 
            this.btn新增顾客.Location = new System.Drawing.Point(585, 211);
            this.btn新增顾客.Name = "btn新增顾客";
            this.btn新增顾客.Size = new System.Drawing.Size(85, 23);
            this.btn新增顾客.TabIndex = 5;
            this.btn新增顾客.Text = "新增顾客";
            this.btn新增顾客.UseVisualStyleBackColor = true;
            this.btn新增顾客.Click += new System.EventHandler(this.btn新增顾客_Click);
            // 
            // btn光顾
            // 
            this.btn光顾.Location = new System.Drawing.Point(693, 211);
            this.btn光顾.Name = "btn光顾";
            this.btn光顾.Size = new System.Drawing.Size(75, 23);
            this.btn光顾.TabIndex = 6;
            this.btn光顾.Text = "光顾";
            this.btn光顾.UseVisualStyleBackColor = true;
            this.btn光顾.Click += new System.EventHandler(this.btn光顾_Click);
            // 
            // btn删除顾客
            // 
            this.btn删除顾客.Location = new System.Drawing.Point(585, 240);
            this.btn删除顾客.Name = "btn删除顾客";
            this.btn删除顾客.Size = new System.Drawing.Size(85, 23);
            this.btn删除顾客.TabIndex = 7;
            this.btn删除顾客.Text = "删除顾客信息";
            this.btn删除顾客.UseVisualStyleBackColor = true;
            this.btn删除顾客.Click += new System.EventHandler(this.btn删除顾客_Click);
            // 
            // btn修改信息
            // 
            this.btn修改信息.Location = new System.Drawing.Point(693, 240);
            this.btn修改信息.Name = "btn修改信息";
            this.btn修改信息.Size = new System.Drawing.Size(75, 23);
            this.btn修改信息.TabIndex = 8;
            this.btn修改信息.Text = "修改";
            this.btn修改信息.UseVisualStyleBackColor = true;
            this.btn修改信息.Click += new System.EventHandler(this.btn修改信息_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 219);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "光顾记录";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(358, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(394, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 218);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "点菜历史";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(375, 198);
            this.dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "称呼：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "联系方式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "性别：";
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(123, 106);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(47, 16);
            this.radioBtnFemale.TabIndex = 16;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "女士";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(70, 106);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(47, 16);
            this.radioBtnMale.TabIndex = 15;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "先生";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(78, 70);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.ReadOnly = true;
            this.telTextBox.Size = new System.Drawing.Size(100, 21);
            this.telTextBox.TabIndex = 18;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(78, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 17;
            // 
            // btn确定
            // 
            this.btn确定.Enabled = false;
            this.btn确定.Location = new System.Drawing.Point(58, 143);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(75, 23);
            this.btn确定.TabIndex = 19;
            this.btn确定.Text = "确定";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nameTextBox);
            this.groupBox4.Controls.Add(this.btn确定);
            this.groupBox4.Controls.Add(this.radioBtnFemale);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.radioBtnMale);
            this.groupBox4.Controls.Add(this.telTextBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(585, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 183);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "当前顾客信息";
            // 
            // 顾客管理Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 506);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn修改信息);
            this.Controls.Add(this.btn删除顾客);
            this.Controls.Add(this.btn光顾);
            this.Controls.Add(this.btn新增顾客);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "顾客管理Form";
            this.Text = "顾客管理Form";
            this.Load += new System.EventHandler(this.顾客管理Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cusMsgDataView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView cusMsgDataView;
        private System.Windows.Forms.Button btn新增顾客;
        private System.Windows.Forms.Button btn光顾;
        private System.Windows.Forms.Button btn删除顾客;
        private System.Windows.Forms.Button btn修改信息;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.RadioButton radioBtnFemale;
        internal System.Windows.Forms.RadioButton radioBtnMale;
        internal System.Windows.Forms.TextBox telTextBox;
        internal System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}