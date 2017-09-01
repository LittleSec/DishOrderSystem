namespace version0._1
{
    partial class 订单管理Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nowOrderDataView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nowMenuListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.beforeCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.historyOrderDataView = new System.Windows.Forms.DataGridView();
            this.orderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.historyMenuListBox = new System.Windows.Forms.ListBox();
            this.结账btn = new System.Windows.Forms.Button();
            this.btn点菜 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nowOrderDataView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyOrderDataView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.nowOrderDataView);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前订单";
            // 
            // nowOrderDataView
            // 
            this.nowOrderDataView.AllowUserToAddRows = false;
            this.nowOrderDataView.AllowUserToDeleteRows = false;
            this.nowOrderDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.nowOrderDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.nowOrderDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nowOrderDataView.DefaultCellStyle = dataGridViewCellStyle5;
            this.nowOrderDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nowOrderDataView.Location = new System.Drawing.Point(3, 17);
            this.nowOrderDataView.MultiSelect = false;
            this.nowOrderDataView.Name = "nowOrderDataView";
            this.nowOrderDataView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nowOrderDataView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.nowOrderDataView.RowTemplate.Height = 23;
            this.nowOrderDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nowOrderDataView.Size = new System.Drawing.Size(512, 233);
            this.nowOrderDataView.TabIndex = 0;
            this.nowOrderDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChooseNowOrderToSeeMenu);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nowMenuListBox);
            this.groupBox2.Location = new System.Drawing.Point(541, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单信息";
            // 
            // nowMenuListBox
            // 
            this.nowMenuListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nowMenuListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nowMenuListBox.FormattingEnabled = true;
            this.nowMenuListBox.ItemHeight = 12;
            this.nowMenuListBox.Items.AddRange(new object[] {
            "列出菜名和是否已经上菜即可"});
            this.nowMenuListBox.Location = new System.Drawing.Point(3, 17);
            this.nowMenuListBox.Name = "nowMenuListBox";
            this.nowMenuListBox.Size = new System.Drawing.Size(221, 181);
            this.nowMenuListBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.beforeCheckBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.historyOrderDataView);
            this.groupBox3.Controls.Add(this.orderDatePicker);
            this.groupBox3.Location = new System.Drawing.Point(3, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 241);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "历史订单";
            // 
            // beforeCheckBox
            // 
            this.beforeCheckBox.AutoSize = true;
            this.beforeCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.beforeCheckBox.Checked = true;
            this.beforeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.beforeCheckBox.Location = new System.Drawing.Point(414, 21);
            this.beforeCheckBox.Name = "beforeCheckBox";
            this.beforeCheckBox.Size = new System.Drawing.Size(72, 16);
            this.beforeCheckBox.TabIndex = 6;
            this.beforeCheckBox.Text = "前的订单";
            this.beforeCheckBox.UseVisualStyleBackColor = true;
            this.beforeCheckBox.CheckedChanged += new System.EventHandler(this.ChooseDateBeforeOrder);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择日期查看对应历史订单：";
            // 
            // historyOrderDataView
            // 
            this.historyOrderDataView.AllowUserToAddRows = false;
            this.historyOrderDataView.AllowUserToDeleteRows = false;
            this.historyOrderDataView.AllowUserToResizeColumns = false;
            this.historyOrderDataView.AllowUserToResizeRows = false;
            this.historyOrderDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.historyOrderDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.historyOrderDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historyOrderDataView.DefaultCellStyle = dataGridViewCellStyle7;
            this.historyOrderDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.historyOrderDataView.Location = new System.Drawing.Point(3, 38);
            this.historyOrderDataView.MultiSelect = false;
            this.historyOrderDataView.Name = "historyOrderDataView";
            this.historyOrderDataView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.historyOrderDataView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.historyOrderDataView.RowTemplate.Height = 23;
            this.historyOrderDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyOrderDataView.Size = new System.Drawing.Size(512, 200);
            this.historyOrderDataView.TabIndex = 0;
            this.historyOrderDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChooseOrderToSeeMenu);
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Location = new System.Drawing.Point(239, 17);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(168, 21);
            this.orderDatePicker.TabIndex = 4;
            this.orderDatePicker.ValueChanged += new System.EventHandler(this.ChooseDateToSeeOrder);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.historyMenuListBox);
            this.groupBox4.Location = new System.Drawing.Point(541, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 203);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "订单信息";
            // 
            // historyMenuListBox
            // 
            this.historyMenuListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyMenuListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyMenuListBox.FormattingEnabled = true;
            this.historyMenuListBox.ItemHeight = 12;
            this.historyMenuListBox.Items.AddRange(new object[] {
            "该订单点的菜："});
            this.historyMenuListBox.Location = new System.Drawing.Point(3, 17);
            this.historyMenuListBox.Name = "historyMenuListBox";
            this.historyMenuListBox.Size = new System.Drawing.Size(221, 183);
            this.historyMenuListBox.TabIndex = 0;
            // 
            // 结账btn
            // 
            this.结账btn.Location = new System.Drawing.Point(676, 219);
            this.结账btn.Name = "结账btn";
            this.结账btn.Size = new System.Drawing.Size(75, 23);
            this.结账btn.TabIndex = 5;
            this.结账btn.Text = "结账";
            this.结账btn.UseVisualStyleBackColor = true;
            this.结账btn.Click += new System.EventHandler(this.结账btn_Click);
            // 
            // btn点菜
            // 
            this.btn点菜.Location = new System.Drawing.Point(562, 219);
            this.btn点菜.Name = "btn点菜";
            this.btn点菜.Size = new System.Drawing.Size(75, 23);
            this.btn点菜.TabIndex = 6;
            this.btn点菜.Text = "点菜";
            this.btn点菜.UseVisualStyleBackColor = true;
            this.btn点菜.Click += new System.EventHandler(this.btn点菜_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "评价";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // 订单管理Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 506);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn点菜);
            this.Controls.Add(this.结账btn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "订单管理Form";
            this.Text = "订单管理Form";
            this.Load += new System.EventHandler(this.订单管理Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nowOrderDataView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyOrderDataView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView nowOrderDataView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox nowMenuListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView historyOrderDataView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox historyMenuListBox;
        private System.Windows.Forms.DateTimePicker orderDatePicker;
        private System.Windows.Forms.Button 结账btn;
        private System.Windows.Forms.Button btn点菜;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox beforeCheckBox;
        private System.Windows.Forms.Label label1;
    }
}