namespace version0._1
{
    partial class 顾客选桌并点菜Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.查找TextBox = new System.Windows.Forms.TextBox();
            this.快速查找btn = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.menuDataView = new System.Windows.Forms.DataGridView();
            this.foodGroupBox = new System.Windows.Forms.GroupBox();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.typeList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.orderDishListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allDesksCheckBox = new System.Windows.Forms.CheckBox();
            this.deskDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.deskGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn模糊查询 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataView)).BeginInit();
            this.foodGroupBox.SuspendLayout();
            this.typeGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskDataView)).BeginInit();
            this.deskGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 查找TextBox
            // 
            this.查找TextBox.Location = new System.Drawing.Point(5, 16);
            this.查找TextBox.Name = "查找TextBox";
            this.查找TextBox.Size = new System.Drawing.Size(100, 21);
            this.查找TextBox.TabIndex = 26;
            // 
            // 快速查找btn
            // 
            this.快速查找btn.Location = new System.Drawing.Point(117, 3);
            this.快速查找btn.Name = "快速查找btn";
            this.快速查找btn.Size = new System.Drawing.Size(45, 45);
            this.快速查找btn.TabIndex = 25;
            this.快速查找btn.Text = "快速\r\n查找";
            this.快速查找btn.UseVisualStyleBackColor = true;
            this.快速查找btn.Click += new System.EventHandler(this.快速查找btn_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(70, 226);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitOrder.TabIndex = 2;
            this.btnSubmitOrder.Text = "提交";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
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
            this.menuDataView.Size = new System.Drawing.Size(415, 214);
            this.menuDataView.TabIndex = 0;
            this.menuDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddFoodToList);
            // 
            // foodGroupBox
            // 
            this.foodGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foodGroupBox.AutoSize = true;
            this.foodGroupBox.Controls.Add(this.menuDataView);
            this.foodGroupBox.Enabled = false;
            this.foodGroupBox.Location = new System.Drawing.Point(89, 304);
            this.foodGroupBox.Name = "foodGroupBox";
            this.foodGroupBox.Size = new System.Drawing.Size(421, 234);
            this.foodGroupBox.TabIndex = 21;
            this.foodGroupBox.TabStop = false;
            this.foodGroupBox.Text = "具体菜谱";
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeGroupBox.AutoSize = true;
            this.typeGroupBox.Controls.Add(this.typeList);
            this.typeGroupBox.Enabled = false;
            this.typeGroupBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeGroupBox.Location = new System.Drawing.Point(9, 304);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(74, 234);
            this.typeGroupBox.TabIndex = 20;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "种类";
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
            this.typeList.Size = new System.Drawing.Size(68, 214);
            this.typeList.TabIndex = 0;
            this.typeList.SelectedIndexChanged += new System.EventHandler(this.SearchFoodInThisType);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubmitOrder);
            this.groupBox2.Controls.Add(this.summaryLabel);
            this.groupBox2.Controls.Add(this.orderDishListBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(297, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 255);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已经点的菜";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(68, 204);
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
            this.orderDishListBox.Size = new System.Drawing.Size(204, 184);
            this.orderDishListBox.TabIndex = 0;
            this.orderDishListBox.DoubleClick += new System.EventHandler(this.RemoveFoodFromList);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "请选择房间：";
            // 
            // roomComboBox
            // 
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(79, 9);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(392, 20);
            this.roomComboBox.TabIndex = 29;
            this.roomComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectRoomToSeeUseableDesks);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn模糊查询);
            this.panel1.Controls.Add(this.查找TextBox);
            this.panel1.Controls.Add(this.快速查找btn);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(15, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 50);
            this.panel1.TabIndex = 33;
            // 
            // allDesksCheckBox
            // 
            this.allDesksCheckBox.AutoSize = true;
            this.allDesksCheckBox.Location = new System.Drawing.Point(174, 14);
            this.allDesksCheckBox.Name = "allDesksCheckBox";
            this.allDesksCheckBox.Size = new System.Drawing.Size(48, 16);
            this.allDesksCheckBox.TabIndex = 31;
            this.allDesksCheckBox.Text = "全部";
            this.allDesksCheckBox.UseVisualStyleBackColor = true;
            this.allDesksCheckBox.CheckedChanged += new System.EventHandler(this.allDesksCheckBox_CheckedChanged);
            // 
            // deskDataView
            // 
            this.deskDataView.AllowUserToAddRows = false;
            this.deskDataView.AllowUserToDeleteRows = false;
            this.deskDataView.AllowUserToResizeColumns = false;
            this.deskDataView.AllowUserToResizeRows = false;
            this.deskDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.deskDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.deskDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deskDataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.deskDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deskDataView.Location = new System.Drawing.Point(3, 36);
            this.deskDataView.Name = "deskDataView";
            this.deskDataView.RowTemplate.Height = 23;
            this.deskDataView.Size = new System.Drawing.Size(226, 160);
            this.deskDataView.TabIndex = 30;
            this.deskDataView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OtherToolEnable);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "请勾选餐桌号";
            // 
            // deskGroupBox
            // 
            this.deskGroupBox.Controls.Add(this.label1);
            this.deskGroupBox.Controls.Add(this.deskDataView);
            this.deskGroupBox.Controls.Add(this.allDesksCheckBox);
            this.deskGroupBox.Enabled = false;
            this.deskGroupBox.Location = new System.Drawing.Point(12, 43);
            this.deskGroupBox.Name = "deskGroupBox";
            this.deskGroupBox.Size = new System.Drawing.Size(232, 199);
            this.deskGroupBox.TabIndex = 32;
            this.deskGroupBox.TabStop = false;
            this.deskGroupBox.Text = "选择餐桌";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.roomComboBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(15, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 35);
            this.panel2.TabIndex = 34;
            // 
            // btn模糊查询
            // 
            this.btn模糊查询.Location = new System.Drawing.Point(174, 3);
            this.btn模糊查询.Name = "btn模糊查询";
            this.btn模糊查询.Size = new System.Drawing.Size(45, 45);
            this.btn模糊查询.TabIndex = 35;
            this.btn模糊查询.Text = "模糊\r\n查找";
            this.btn模糊查询.UseVisualStyleBackColor = true;
            this.btn模糊查询.Click += new System.EventHandler(this.btn模糊查询_Click);
            // 
            // 顾客选桌并点菜Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deskGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.foodGroupBox);
            this.Controls.Add(this.typeGroupBox);
            this.Controls.Add(this.panel1);
            this.Name = "顾客选桌并点菜Form";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.顾客选桌并点菜Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataView)).EndInit();
            this.foodGroupBox.ResumeLayout(false);
            this.typeGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskDataView)).EndInit();
            this.deskGroupBox.ResumeLayout(false);
            this.deskGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 查找TextBox;
        private System.Windows.Forms.Button 快速查找btn;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.DataGridView menuDataView;
        private System.Windows.Forms.GroupBox foodGroupBox;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.ListBox typeList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.ListBox orderDishListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox allDesksCheckBox;
        private System.Windows.Forms.DataGridView deskDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox deskGroupBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn模糊查询;

    }
}