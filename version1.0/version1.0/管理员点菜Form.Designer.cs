namespace version0._1
{
    partial class 管理员点菜Form
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
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.快速查找TextBox = new System.Windows.Forms.TextBox();
            this.快速查找btn = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.orderDishListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.typeList = new System.Windows.Forms.ListBox();
            this.foodGroupBox = new System.Windows.Forms.GroupBox();
            this.menuDataView = new System.Windows.Forms.DataGridView();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.foodGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataView)).BeginInit();
            this.typeGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.快速查找TextBox);
            this.panel1.Controls.Add(this.快速查找btn);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(520, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 34);
            this.panel1.TabIndex = 39;
            // 
            // 快速查找TextBox
            // 
            this.快速查找TextBox.Location = new System.Drawing.Point(3, 5);
            this.快速查找TextBox.Name = "快速查找TextBox";
            this.快速查找TextBox.Size = new System.Drawing.Size(100, 21);
            this.快速查找TextBox.TabIndex = 26;
            // 
            // 快速查找btn
            // 
            this.快速查找btn.Location = new System.Drawing.Point(120, 3);
            this.快速查找btn.Name = "快速查找btn";
            this.快速查找btn.Size = new System.Drawing.Size(75, 23);
            this.快速查找btn.TabIndex = 25;
            this.快速查找btn.Text = "快速查找";
            this.快速查找btn.UseVisualStyleBackColor = true;
            this.快速查找btn.Click += new System.EventHandler(this.快速查找btn_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubmitOrder);
            this.groupBox2.Controls.Add(this.summaryLabel);
            this.groupBox2.Controls.Add(this.orderDishListBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(517, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 255);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已经点的菜";
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
            this.typeList.Size = new System.Drawing.Size(68, 272);
            this.typeList.TabIndex = 0;
            this.typeList.SelectedIndexChanged += new System.EventHandler(this.SearchFoodInThisType);
            // 
            // foodGroupBox
            // 
            this.foodGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foodGroupBox.AutoSize = true;
            this.foodGroupBox.Controls.Add(this.menuDataView);
            this.foodGroupBox.Enabled = false;
            this.foodGroupBox.Location = new System.Drawing.Point(90, 12);
            this.foodGroupBox.Name = "foodGroupBox";
            this.foodGroupBox.Size = new System.Drawing.Size(421, 292);
            this.foodGroupBox.TabIndex = 37;
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
            this.menuDataView.Size = new System.Drawing.Size(415, 272);
            this.menuDataView.TabIndex = 0;
            this.menuDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddFoodToList);
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeGroupBox.AutoSize = true;
            this.typeGroupBox.Controls.Add(this.typeList);
            this.typeGroupBox.Enabled = false;
            this.typeGroupBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeGroupBox.Location = new System.Drawing.Point(9, 12);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(74, 292);
            this.typeGroupBox.TabIndex = 36;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "种类";
            // 
            // 管理员点菜Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 319);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.foodGroupBox);
            this.Controls.Add(this.typeGroupBox);
            this.Name = "管理员点菜Form";
            this.Text = "点菜";
            this.Load += new System.EventHandler(this.管理员点菜Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.foodGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataView)).EndInit();
            this.typeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox 快速查找TextBox;
        private System.Windows.Forms.Button 快速查找btn;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.ListBox orderDishListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox typeList;
        private System.Windows.Forms.GroupBox foodGroupBox;
        private System.Windows.Forms.DataGridView menuDataView;
        private System.Windows.Forms.GroupBox typeGroupBox;
    }
}