namespace version0._1
{
    partial class 菜谱Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.typeList = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.foodGroupBox = new System.Windows.Forms.GroupBox();
            this.menuDataView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CusMenuDataView = new System.Windows.Forms.DataGridView();
            this.btn点菜 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.orderDishListBox = new System.Windows.Forms.ListBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.快速查找btn = new System.Windows.Forms.Button();
            this.快速查找TextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox模糊搜索 = new System.Windows.Forms.TextBox();
            this.btn模糊查询 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.typeGroupBox.SuspendLayout();
            this.foodGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusMenuDataView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeList
            // 
            this.typeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeList.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeList.FormattingEnabled = true;
            this.typeList.ItemHeight = 12;
            this.typeList.Items.AddRange(new object[] {
            "全部"});
            this.typeList.Location = new System.Drawing.Point(3, 17);
            this.typeList.Name = "typeList";
            this.typeList.Size = new System.Drawing.Size(68, 315);
            this.typeList.TabIndex = 0;
            this.typeList.SelectedIndexChanged += new System.EventHandler(this.SearchFoodInThisType);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(384, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(465, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(384, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeGroupBox.AutoSize = true;
            this.typeGroupBox.Controls.Add(this.typeList);
            this.typeGroupBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(74, 335);
            this.typeGroupBox.TabIndex = 6;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "种类";
            // 
            // foodGroupBox
            // 
            this.foodGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foodGroupBox.AutoSize = true;
            this.foodGroupBox.Controls.Add(this.menuDataView);
            this.foodGroupBox.Location = new System.Drawing.Point(83, 3);
            this.foodGroupBox.Name = "foodGroupBox";
            this.foodGroupBox.Size = new System.Drawing.Size(477, 335);
            this.foodGroupBox.TabIndex = 7;
            this.foodGroupBox.TabStop = false;
            this.foodGroupBox.Text = "具体菜谱";
            // 
            // menuDataView
            // 
            this.menuDataView.AllowUserToAddRows = false;
            this.menuDataView.AllowUserToDeleteRows = false;
            this.menuDataView.AllowUserToResizeColumns = false;
            this.menuDataView.AllowUserToResizeRows = false;
            this.menuDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.menuDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.menuDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuDataView.Location = new System.Drawing.Point(3, 17);
            this.menuDataView.MultiSelect = false;
            this.menuDataView.Name = "menuDataView";
            this.menuDataView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.menuDataView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.menuDataView.RowTemplate.Height = 23;
            this.menuDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuDataView.Size = new System.Drawing.Size(471, 315);
            this.menuDataView.TabIndex = 0;
            this.menuDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectMenuShowCustomer);
            this.menuDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddFoodToList);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CusMenuDataView);
            this.groupBox1.Location = new System.Drawing.Point(6, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 164);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "点过这道菜的客人";
            // 
            // CusMenuDataView
            // 
            this.CusMenuDataView.AllowUserToAddRows = false;
            this.CusMenuDataView.AllowUserToDeleteRows = false;
            this.CusMenuDataView.AllowUserToResizeColumns = false;
            this.CusMenuDataView.AllowUserToResizeRows = false;
            this.CusMenuDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CusMenuDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CusMenuDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CusMenuDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CusMenuDataView.Location = new System.Drawing.Point(3, 17);
            this.CusMenuDataView.Name = "CusMenuDataView";
            this.CusMenuDataView.ReadOnly = true;
            this.CusMenuDataView.RowTemplate.Height = 23;
            this.CusMenuDataView.Size = new System.Drawing.Size(344, 144);
            this.CusMenuDataView.TabIndex = 0;
            // 
            // btn点菜
            // 
            this.btn点菜.Location = new System.Drawing.Point(465, 420);
            this.btn点菜.Name = "btn点菜";
            this.btn点菜.Size = new System.Drawing.Size(75, 23);
            this.btn点菜.TabIndex = 9;
            this.btn点菜.Text = "点菜";
            this.btn点菜.UseVisualStyleBackColor = true;
            this.btn点菜.Click += new System.EventHandler(this.btn点菜_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.summaryLabel);
            this.groupBox2.Controls.Add(this.orderDishListBox);
            this.groupBox2.Location = new System.Drawing.Point(10, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 282);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已经点的菜";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(62, 260);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(125, 12);
            this.summaryLabel.TabIndex = 1;
            this.summaryLabel.Text = "已选0道菜，共计：0元";
            // 
            // orderDishListBox
            // 
            this.orderDishListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderDishListBox.FormattingEnabled = true;
            this.orderDishListBox.ItemHeight = 12;
            this.orderDishListBox.Items.AddRange(new object[] {
            "菜编号    菜名        菜价"});
            this.orderDishListBox.Location = new System.Drawing.Point(3, 17);
            this.orderDishListBox.Name = "orderDishListBox";
            this.orderDishListBox.Size = new System.Drawing.Size(198, 232);
            this.orderDishListBox.TabIndex = 0;
            this.orderDishListBox.DoubleClick += new System.EventHandler(this.RemoveFoodFromList);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(158, 37);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(50, 50);
            this.btnSubmitOrder.TabIndex = 2;
            this.btnSubmitOrder.Text = "提交";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // 快速查找btn
            // 
            this.快速查找btn.Location = new System.Drawing.Point(693, 20);
            this.快速查找btn.Name = "快速查找btn";
            this.快速查找btn.Size = new System.Drawing.Size(75, 23);
            this.快速查找btn.TabIndex = 12;
            this.快速查找btn.Text = "快速查找";
            this.快速查找btn.UseVisualStyleBackColor = true;
            this.快速查找btn.Click += new System.EventHandler(this.快速查找btn_Click);
            // 
            // 快速查找TextBox
            // 
            this.快速查找TextBox.Location = new System.Drawing.Point(582, 22);
            this.快速查找TextBox.Name = "快速查找TextBox";
            this.快速查找TextBox.Size = new System.Drawing.Size(100, 21);
            this.快速查找TextBox.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 20);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.SelectCustomerDoneShowBtn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "选择客人：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(8, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(126, 20);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.SelectDeskDoneShowBtn);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "选择餐桌";
            // 
            // textBox模糊搜索
            // 
            this.textBox模糊搜索.Location = new System.Drawing.Point(582, 51);
            this.textBox模糊搜索.Name = "textBox模糊搜索";
            this.textBox模糊搜索.Size = new System.Drawing.Size(100, 21);
            this.textBox模糊搜索.TabIndex = 18;
            // 
            // btn模糊查询
            // 
            this.btn模糊查询.Location = new System.Drawing.Point(693, 49);
            this.btn模糊查询.Name = "btn模糊查询";
            this.btn模糊查询.Size = new System.Drawing.Size(75, 23);
            this.btn模糊查询.TabIndex = 17;
            this.btn模糊查询.Text = "模糊查找";
            this.btn模糊查询.UseVisualStyleBackColor = true;
            this.btn模糊查询.Click += new System.EventHandler(this.btn模糊查询_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSubmitOrder);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(560, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 413);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "快速点菜";
            // 
            // 菜谱Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 506);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox模糊搜索);
            this.Controls.Add(this.btn模糊查询);
            this.Controls.Add(this.快速查找TextBox);
            this.Controls.Add(this.快速查找btn);
            this.Controls.Add(this.btn点菜);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.foodGroupBox);
            this.Controls.Add(this.typeGroupBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "菜谱Form";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.typeGroupBox.ResumeLayout(false);
            this.foodGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CusMenuDataView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox typeList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.GroupBox foodGroupBox;
        private System.Windows.Forms.DataGridView menuDataView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView CusMenuDataView;
        private System.Windows.Forms.Button btn点菜;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox orderDishListBox;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button 快速查找btn;
        private System.Windows.Forms.TextBox 快速查找TextBox;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox模糊搜索;
        private System.Windows.Forms.Button btn模糊查询;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}