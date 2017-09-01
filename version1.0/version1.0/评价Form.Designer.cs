namespace version0._1
{
    partial class 评价Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataViewDish = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.allDesksCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewDish)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号：";
            // 
            // dataViewDish
            // 
            this.dataViewDish.AllowUserToAddRows = false;
            this.dataViewDish.AllowUserToDeleteRows = false;
            this.dataViewDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataViewDish.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataViewDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewDish.Location = new System.Drawing.Point(22, 37);
            this.dataViewDish.Name = "dataViewDish";
            this.dataViewDish.RowTemplate.Height = 23;
            this.dataViewDish.Size = new System.Drawing.Size(240, 183);
            this.dataViewDish.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(105, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // allDesksCheckBox
            // 
            this.allDesksCheckBox.AutoSize = true;
            this.allDesksCheckBox.Location = new System.Drawing.Point(214, 15);
            this.allDesksCheckBox.Name = "allDesksCheckBox";
            this.allDesksCheckBox.Size = new System.Drawing.Size(48, 16);
            this.allDesksCheckBox.TabIndex = 32;
            this.allDesksCheckBox.Text = "全部";
            this.allDesksCheckBox.UseVisualStyleBackColor = true;
            this.allDesksCheckBox.CheckedChanged += new System.EventHandler(this.allDishCheckBox_CheckedChanged);
            // 
            // 评价Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.allDesksCheckBox);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dataViewDish);
            this.Controls.Add(this.label1);
            this.Name = "评价Form";
            this.Text = "评价";
            this.Load += new System.EventHandler(this.评价Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataViewDish;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox allDesksCheckBox;
    }
}