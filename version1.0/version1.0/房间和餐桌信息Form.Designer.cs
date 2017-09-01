namespace version0._1
{
    partial class 房间和餐桌信息Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roomGroupBox = new System.Windows.Forms.GroupBox();
            this.roomDataView = new System.Windows.Forms.DataGridView();
            this.deskGroupBox = new System.Windows.Forms.GroupBox();
            this.deskDataView = new System.Windows.Forms.DataGridView();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnAddDesk = new System.Windows.Forms.Button();
            this.btnDeleteDesk = new System.Windows.Forms.Button();
            this.delBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.添加btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.房间名TextBox = new System.Windows.Forms.TextBox();
            this.四位房间号TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn餐桌信息确认 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.容纳人数TextBox = new System.Windows.Forms.TextBox();
            this.三位餐桌号TextBox = new System.Windows.Forms.TextBox();
            this.房间选择ComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.roomGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataView)).BeginInit();
            this.deskGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskDataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomGroupBox
            // 
            this.roomGroupBox.AutoSize = true;
            this.roomGroupBox.Controls.Add(this.roomDataView);
            this.roomGroupBox.Location = new System.Drawing.Point(12, 3);
            this.roomGroupBox.Name = "roomGroupBox";
            this.roomGroupBox.Size = new System.Drawing.Size(470, 234);
            this.roomGroupBox.TabIndex = 4;
            this.roomGroupBox.TabStop = false;
            this.roomGroupBox.Text = "房间概况";
            // 
            // roomDataView
            // 
            this.roomDataView.AllowUserToAddRows = false;
            this.roomDataView.AllowUserToDeleteRows = false;
            this.roomDataView.AllowUserToResizeColumns = false;
            this.roomDataView.AllowUserToResizeRows = false;
            this.roomDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.roomDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.roomDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomDataView.Location = new System.Drawing.Point(3, 17);
            this.roomDataView.MultiSelect = false;
            this.roomDataView.Name = "roomDataView";
            this.roomDataView.ReadOnly = true;
            this.roomDataView.RowTemplate.Height = 23;
            this.roomDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomDataView.Size = new System.Drawing.Size(464, 214);
            this.roomDataView.TabIndex = 0;
            this.roomDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChooseRoomToSeeDesk);
            // 
            // deskGroupBox
            // 
            this.deskGroupBox.Controls.Add(this.deskDataView);
            this.deskGroupBox.Location = new System.Drawing.Point(12, 249);
            this.deskGroupBox.Name = "deskGroupBox";
            this.deskGroupBox.Size = new System.Drawing.Size(370, 251);
            this.deskGroupBox.TabIndex = 5;
            this.deskGroupBox.TabStop = false;
            this.deskGroupBox.Text = "当前房间的餐桌概况";
            // 
            // deskDataView
            // 
            this.deskDataView.AllowUserToAddRows = false;
            this.deskDataView.AllowUserToDeleteRows = false;
            this.deskDataView.AllowUserToResizeColumns = false;
            this.deskDataView.AllowUserToResizeRows = false;
            this.deskDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deskDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.deskDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deskDataView.DefaultCellStyle = dataGridViewCellStyle4;
            this.deskDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deskDataView.Location = new System.Drawing.Point(3, 17);
            this.deskDataView.Name = "deskDataView";
            this.deskDataView.ReadOnly = true;
            this.deskDataView.RowTemplate.Height = 23;
            this.deskDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deskDataView.Size = new System.Drawing.Size(364, 231);
            this.deskDataView.TabIndex = 0;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(488, 167);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteRoom.TabIndex = 10;
            this.btnDeleteRoom.Text = "删除房间";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            this.btnDeleteRoom.MouseEnter += new System.EventHandler(this.DelRoomTips);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(488, 26);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(40, 40);
            this.btnAddRoom.TabIndex = 9;
            this.btnAddRoom.Text = "添加房间";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnAddDesk
            // 
            this.btnAddDesk.Location = new System.Drawing.Point(400, 312);
            this.btnAddDesk.Name = "btnAddDesk";
            this.btnAddDesk.Size = new System.Drawing.Size(45, 45);
            this.btnAddDesk.TabIndex = 13;
            this.btnAddDesk.Text = "添加餐桌";
            this.btnAddDesk.UseVisualStyleBackColor = true;
            this.btnAddDesk.Click += new System.EventHandler(this.btnAddDesk_Click);
            // 
            // btnDeleteDesk
            // 
            this.btnDeleteDesk.Location = new System.Drawing.Point(400, 386);
            this.btnDeleteDesk.Name = "btnDeleteDesk";
            this.btnDeleteDesk.Size = new System.Drawing.Size(45, 45);
            this.btnDeleteDesk.TabIndex = 12;
            this.btnDeleteDesk.Text = "删除餐桌";
            this.btnDeleteDesk.UseVisualStyleBackColor = true;
            this.btnDeleteDesk.Click += new System.EventHandler(this.btnDeleteDesk_Click);
            this.btnDeleteDesk.MouseEnter += new System.EventHandler(this.DelDeskTips);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.添加btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.房间名TextBox);
            this.groupBox1.Controls.Add(this.四位房间号TextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(541, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 234);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "录入房间信息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(63, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "请录入房间信息";
            // 
            // 添加btn
            // 
            this.添加btn.Location = new System.Drawing.Point(174, 164);
            this.添加btn.Name = "添加btn";
            this.添加btn.Size = new System.Drawing.Size(47, 48);
            this.添加btn.TabIndex = 21;
            this.添加btn.Text = "确定";
            this.添加btn.UseVisualStyleBackColor = true;
            this.添加btn.Click += new System.EventHandler(this.房间信息确认btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 72);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tips：\r\n1.房间号共4位。\r\n2.房间名最长不超过5个汉字。\r\n3.注意不能与已有编号重复。\r\n4.房间容纳餐桌数和人数只能\r\n  通过添加餐桌进行自动更新" +
    "。";
            // 
            // 房间名TextBox
            // 
            this.房间名TextBox.Location = new System.Drawing.Point(99, 101);
            this.房间名TextBox.Name = "房间名TextBox";
            this.房间名TextBox.Size = new System.Drawing.Size(100, 21);
            this.房间名TextBox.TabIndex = 19;
            // 
            // 四位房间号TextBox
            // 
            this.四位房间号TextBox.Location = new System.Drawing.Point(99, 63);
            this.四位房间号TextBox.Name = "四位房间号TextBox";
            this.四位房间号TextBox.Size = new System.Drawing.Size(100, 21);
            this.四位房间号TextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "房间名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "房间号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn餐桌信息确认);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.容纳人数TextBox);
            this.groupBox2.Controls.Add(this.三位餐桌号TextBox);
            this.groupBox2.Controls.Add(this.房间选择ComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(456, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 232);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "录入餐桌信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(108, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "请录入餐桌信息";
            // 
            // btn餐桌信息确认
            // 
            this.btn餐桌信息确认.Location = new System.Drawing.Point(216, 190);
            this.btn餐桌信息确认.Name = "btn餐桌信息确认";
            this.btn餐桌信息确认.Size = new System.Drawing.Size(75, 23);
            this.btn餐桌信息确认.TabIndex = 16;
            this.btn餐桌信息确认.Text = "确定";
            this.btn餐桌信息确认.UseVisualStyleBackColor = true;
            this.btn餐桌信息确认.Click += new System.EventHandler(this.btn餐桌信息确认_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 60);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tips：\r\n1.餐桌编号填写3位即可。\r\n2.系统自动生成7位正式编号。\r\n3.注意不能与已有编号重复。\r\n4.添加后系统会自动更新房间信息。";
            // 
            // 容纳人数TextBox
            // 
            this.容纳人数TextBox.Location = new System.Drawing.Point(145, 137);
            this.容纳人数TextBox.Name = "容纳人数TextBox";
            this.容纳人数TextBox.Size = new System.Drawing.Size(100, 21);
            this.容纳人数TextBox.TabIndex = 14;
            // 
            // 三位餐桌号TextBox
            // 
            this.三位餐桌号TextBox.Location = new System.Drawing.Point(145, 63);
            this.三位餐桌号TextBox.Name = "三位餐桌号TextBox";
            this.三位餐桌号TextBox.Size = new System.Drawing.Size(100, 21);
            this.三位餐桌号TextBox.TabIndex = 13;
            // 
            // 房间选择ComboBox
            // 
            this.房间选择ComboBox.FormattingEnabled = true;
            this.房间选择ComboBox.Location = new System.Drawing.Point(145, 99);
            this.房间选择ComboBox.Name = "房间选择ComboBox";
            this.房间选择ComboBox.Size = new System.Drawing.Size(100, 20);
            this.房间选择ComboBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "容纳人数：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "所在房间：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "餐桌编号：";
            // 
            // btnRoomUpdate
            // 
            this.btnRoomUpdate.Location = new System.Drawing.Point(488, 88);
            this.btnRoomUpdate.Name = "btnRoomUpdate";
            this.btnRoomUpdate.Size = new System.Drawing.Size(40, 50);
            this.btnRoomUpdate.TabIndex = 16;
            this.btnRoomUpdate.Text = "修改房间信息";
            this.btnRoomUpdate.UseVisualStyleBackColor = true;
            this.btnRoomUpdate.Click += new System.EventHandler(this.btnRoomUpdate_Click);
            // 
            // 房间和餐桌信息Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(780, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRoomUpdate);
            this.Controls.Add(this.btnAddDesk);
            this.Controls.Add(this.btnDeleteDesk);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.deskGroupBox);
            this.Controls.Add(this.roomGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "房间和餐桌信息Form";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.roomGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataView)).EndInit();
            this.deskGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deskDataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox roomGroupBox;
        private System.Windows.Forms.GroupBox deskGroupBox;
        private System.Windows.Forms.DataGridView deskDataView;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnAddDesk;
        private System.Windows.Forms.Button btnDeleteDesk;
        private System.Windows.Forms.DataGridView roomDataView;
        private System.Windows.Forms.ToolTip delBtnToolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button 添加btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox 房间名TextBox;
        private System.Windows.Forms.TextBox 四位房间号TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn餐桌信息确认;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 容纳人数TextBox;
        private System.Windows.Forms.TextBox 三位餐桌号TextBox;
        private System.Windows.Forms.ComboBox 房间选择ComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRoomUpdate;
    }
}