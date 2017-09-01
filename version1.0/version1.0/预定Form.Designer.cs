namespace version0._1
{
    partial class 预定Form
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
            this.deskGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deskDataView = new System.Windows.Forms.DataGridView();
            this.allDesksCheckBox = new System.Windows.Forms.CheckBox();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn预约 = new System.Windows.Forms.Button();
            this.deskGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deskGroupBox
            // 
            this.deskGroupBox.Controls.Add(this.label1);
            this.deskGroupBox.Controls.Add(this.deskDataView);
            this.deskGroupBox.Controls.Add(this.allDesksCheckBox);
            this.deskGroupBox.Enabled = false;
            this.deskGroupBox.Location = new System.Drawing.Point(12, 83);
            this.deskGroupBox.Name = "deskGroupBox";
            this.deskGroupBox.Size = new System.Drawing.Size(232, 199);
            this.deskGroupBox.TabIndex = 36;
            this.deskGroupBox.TabStop = false;
            this.deskGroupBox.Text = "选择餐桌";
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
            // deskDataView
            // 
            this.deskDataView.AllowUserToAddRows = false;
            this.deskDataView.AllowUserToDeleteRows = false;
            this.deskDataView.AllowUserToResizeColumns = false;
            this.deskDataView.AllowUserToResizeRows = false;
            this.deskDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.deskDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.deskDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deskDataView.DefaultCellStyle = dataGridViewCellStyle1;
            this.deskDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deskDataView.Location = new System.Drawing.Point(3, 36);
            this.deskDataView.Name = "deskDataView";
            this.deskDataView.RowTemplate.Height = 23;
            this.deskDataView.Size = new System.Drawing.Size(226, 160);
            this.deskDataView.TabIndex = 30;
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
            // roomComboBox
            // 
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(72, 4);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(161, 20);
            this.roomComboBox.TabIndex = 35;
            this.roomComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectRoomToChooseDesks);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "请选择房间：";
            // 
            // bookDatePicker
            // 
            this.bookDatePicker.Location = new System.Drawing.Point(83, 13);
            this.bookDatePicker.MinDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.bookDatePicker.Name = "bookDatePicker";
            this.bookDatePicker.Size = new System.Drawing.Size(161, 21);
            this.bookDatePicker.TabIndex = 37;
            this.bookDatePicker.ValueChanged += new System.EventHandler(this.bookDatePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "请选择时间：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roomComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(11, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 30);
            this.panel1.TabIndex = 39;
            // 
            // btn预约
            // 
            this.btn预约.Location = new System.Drawing.Point(93, 285);
            this.btn预约.Name = "btn预约";
            this.btn预约.Size = new System.Drawing.Size(75, 23);
            this.btn预约.TabIndex = 40;
            this.btn预约.Text = "预约";
            this.btn预约.UseVisualStyleBackColor = true;
            this.btn预约.Click += new System.EventHandler(this.btn预约_Click);
            // 
            // 预定Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 320);
            this.Controls.Add(this.btn预约);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deskGroupBox);
            this.Name = "预定Form";
            this.Text = "预定Form";
            this.Load += new System.EventHandler(this.预定Form_Load);
            this.deskGroupBox.ResumeLayout(false);
            this.deskGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox deskGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView deskDataView;
        private System.Windows.Forms.CheckBox allDesksCheckBox;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker bookDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn预约;

    }
}