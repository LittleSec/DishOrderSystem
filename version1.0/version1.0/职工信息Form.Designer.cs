namespace version0._1
{
    partial class 职工信息Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.waiterDataView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.编辑服务员btn = new System.Windows.Forms.Button();
            this.解雇服务员btn = new System.Windows.Forms.Button();
            this.雇佣服务员btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chrefDataView = new System.Windows.Forms.DataGridView();
            this.编辑厨师btn = new System.Windows.Forms.Button();
            this.解雇厨师btn = new System.Windows.Forms.Button();
            this.btn雇佣厨师 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chrefMenuDataView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waiterDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrefDataView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrefMenuDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.waiterDataView);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务员信息";
            // 
            // waiterDataView
            // 
            this.waiterDataView.AllowUserToAddRows = false;
            this.waiterDataView.AllowUserToDeleteRows = false;
            this.waiterDataView.AllowUserToResizeColumns = false;
            this.waiterDataView.AllowUserToResizeRows = false;
            this.waiterDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.waiterDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.waiterDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waiterDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waiterDataView.Location = new System.Drawing.Point(3, 17);
            this.waiterDataView.Name = "waiterDataView";
            this.waiterDataView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.waiterDataView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.waiterDataView.RowTemplate.Height = 23;
            this.waiterDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.waiterDataView.Size = new System.Drawing.Size(297, 358);
            this.waiterDataView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.编辑服务员btn);
            this.panel1.Controls.Add(this.解雇服务员btn);
            this.panel1.Controls.Add(this.雇佣服务员btn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 467);
            this.panel1.TabIndex = 2;
            // 
            // 编辑服务员btn
            // 
            this.编辑服务员btn.Location = new System.Drawing.Point(230, 405);
            this.编辑服务员btn.Name = "编辑服务员btn";
            this.编辑服务员btn.Size = new System.Drawing.Size(75, 23);
            this.编辑服务员btn.TabIndex = 4;
            this.编辑服务员btn.Text = "编辑";
            this.编辑服务员btn.UseVisualStyleBackColor = true;
            this.编辑服务员btn.Click += new System.EventHandler(this.编辑服务员btn_Click);
            // 
            // 解雇服务员btn
            // 
            this.解雇服务员btn.Location = new System.Drawing.Point(122, 405);
            this.解雇服务员btn.Name = "解雇服务员btn";
            this.解雇服务员btn.Size = new System.Drawing.Size(75, 23);
            this.解雇服务员btn.TabIndex = 3;
            this.解雇服务员btn.Text = "解雇";
            this.解雇服务员btn.UseVisualStyleBackColor = true;
            this.解雇服务员btn.Click += new System.EventHandler(this.解雇服务员btn_Click);
            // 
            // 雇佣服务员btn
            // 
            this.雇佣服务员btn.Location = new System.Drawing.Point(11, 405);
            this.雇佣服务员btn.Name = "雇佣服务员btn";
            this.雇佣服务员btn.Size = new System.Drawing.Size(75, 23);
            this.雇佣服务员btn.TabIndex = 2;
            this.雇佣服务员btn.Text = "雇佣";
            this.雇佣服务员btn.UseVisualStyleBackColor = true;
            this.雇佣服务员btn.Click += new System.EventHandler(this.雇佣服务员btn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.编辑厨师btn);
            this.panel2.Controls.Add(this.解雇厨师btn);
            this.panel2.Controls.Add(this.btn雇佣厨师);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(315, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 467);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chrefDataView);
            this.groupBox2.Location = new System.Drawing.Point(4, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 254);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "厨师基本信息";
            // 
            // chrefDataView
            // 
            this.chrefDataView.AllowUserToAddRows = false;
            this.chrefDataView.AllowUserToDeleteRows = false;
            this.chrefDataView.AllowUserToResizeColumns = false;
            this.chrefDataView.AllowUserToResizeRows = false;
            this.chrefDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.chrefDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.chrefDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chrefDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrefDataView.Location = new System.Drawing.Point(3, 17);
            this.chrefDataView.MultiSelect = false;
            this.chrefDataView.Name = "chrefDataView";
            this.chrefDataView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.chrefDataView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.chrefDataView.RowTemplate.Height = 23;
            this.chrefDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chrefDataView.Size = new System.Drawing.Size(430, 234);
            this.chrefDataView.TabIndex = 0;
            this.chrefDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChooseChrefToSeeHisWorkRecord);
            // 
            // 编辑厨师btn
            // 
            this.编辑厨师btn.Location = new System.Drawing.Point(301, 272);
            this.编辑厨师btn.Name = "编辑厨师btn";
            this.编辑厨师btn.Size = new System.Drawing.Size(75, 23);
            this.编辑厨师btn.TabIndex = 7;
            this.编辑厨师btn.Text = "编辑";
            this.编辑厨师btn.UseVisualStyleBackColor = true;
            this.编辑厨师btn.Click += new System.EventHandler(this.编辑厨师btn_Click);
            // 
            // 解雇厨师btn
            // 
            this.解雇厨师btn.Location = new System.Drawing.Point(197, 272);
            this.解雇厨师btn.Name = "解雇厨师btn";
            this.解雇厨师btn.Size = new System.Drawing.Size(75, 23);
            this.解雇厨师btn.TabIndex = 6;
            this.解雇厨师btn.Text = "解雇";
            this.解雇厨师btn.UseVisualStyleBackColor = true;
            this.解雇厨师btn.Click += new System.EventHandler(this.解雇厨师btn_Click);
            // 
            // btn雇佣厨师
            // 
            this.btn雇佣厨师.Location = new System.Drawing.Point(93, 272);
            this.btn雇佣厨师.Name = "btn雇佣厨师";
            this.btn雇佣厨师.Size = new System.Drawing.Size(75, 23);
            this.btn雇佣厨师.TabIndex = 5;
            this.btn雇佣厨师.Text = "雇佣";
            this.btn雇佣厨师.UseVisualStyleBackColor = true;
            this.btn雇佣厨师.Click += new System.EventHandler(this.btn雇佣厨师_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chrefMenuDataView);
            this.groupBox3.Location = new System.Drawing.Point(3, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 166);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "做菜历史";
            // 
            // chrefMenuDataView
            // 
            this.chrefMenuDataView.AllowUserToAddRows = false;
            this.chrefMenuDataView.AllowUserToDeleteRows = false;
            this.chrefMenuDataView.AllowUserToResizeColumns = false;
            this.chrefMenuDataView.AllowUserToResizeRows = false;
            this.chrefMenuDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.chrefMenuDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.chrefMenuDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chrefMenuDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrefMenuDataView.Location = new System.Drawing.Point(3, 17);
            this.chrefMenuDataView.Name = "chrefMenuDataView";
            this.chrefMenuDataView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.chrefMenuDataView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.chrefMenuDataView.RowTemplate.Height = 23;
            this.chrefMenuDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chrefMenuDataView.Size = new System.Drawing.Size(437, 146);
            this.chrefMenuDataView.TabIndex = 0;
            // 
            // 职工信息Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "职工信息Form";
            this.Text = "职工信息Form";
            this.Load += new System.EventHandler(this.职工信息Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waiterDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrefDataView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrefMenuDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView waiterDataView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button 编辑服务员btn;
        private System.Windows.Forms.Button 解雇服务员btn;
        private System.Windows.Forms.Button 雇佣服务员btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button 编辑厨师btn;
        private System.Windows.Forms.Button 解雇厨师btn;
        private System.Windows.Forms.Button btn雇佣厨师;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView chrefMenuDataView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView chrefDataView;
    }
}