namespace version0._1
{
    partial class CustomerForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.telLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labNowUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labTel = new System.Windows.Forms.ToolStripStatusLabel();
            this.nowDateTime = new System.Windows.Forms.Timer(this.components);
            this.txtWelcome = new System.Windows.Forms.Label();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.btnFix = new System.Windows.Forms.Button();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.listBoxMsg = new System.Windows.Forms.ListBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCome = new System.Windows.Forms.Button();
            this.btnUpdateMsg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFixUpdata = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(88, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 0;
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(88, 129);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 21);
            this.telTextBox.TabIndex = 1;
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Location = new System.Drawing.Point(24, 132);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(53, 12);
            this.telLabel.TabIndex = 3;
            this.telLabel.Text = "联系方式";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(48, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 12);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "称呼";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labNowUser,
            this.toolStripStatusLabel3,
            this.labTel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(493, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labNowUser
            // 
            this.labNowUser.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.labNowUser.Name = "labNowUser";
            this.labNowUser.Size = new System.Drawing.Size(68, 17);
            this.labNowUser.Text = "当前用户：";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(265, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // labTel
            // 
            this.labTel.Name = "labTel";
            this.labTel.Size = new System.Drawing.Size(145, 17);
            this.labTel.Text = "联系方式：18169861368";
            // 
            // nowDateTime
            // 
            this.nowDateTime.Interval = 1000;
            this.nowDateTime.Tick += new System.EventHandler(this.nowDateTime_Tick);
            // 
            // txtWelcome
            // 
            this.txtWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWelcome.ForeColor = System.Drawing.Color.Crimson;
            this.txtWelcome.Location = new System.Drawing.Point(190, 9);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(112, 25);
            this.txtWelcome.TabIndex = 5;
            this.txtWelcome.Text = "欢迎光临";
            this.txtWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(88, 96);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(47, 16);
            this.radioBtnMale.TabIndex = 6;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "先生";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(141, 96);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(47, 16);
            this.radioBtnFemale.TabIndex = 7;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "女士";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(71, 180);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 8;
            this.btnFix.Text = "确定";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMsg.AutoSize = true;
            this.groupBoxMsg.Controls.Add(this.listBoxMsg);
            this.groupBoxMsg.Location = new System.Drawing.Point(22, 11);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(224, 126);
            this.groupBoxMsg.TabIndex = 9;
            this.groupBoxMsg.TabStop = false;
            this.groupBoxMsg.Text = "基本信息";
            // 
            // listBoxMsg
            // 
            this.listBoxMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMsg.FormattingEnabled = true;
            this.listBoxMsg.ItemHeight = 12;
            this.listBoxMsg.Location = new System.Drawing.Point(3, 17);
            this.listBoxMsg.Name = "listBoxMsg";
            this.listBoxMsg.Size = new System.Drawing.Size(218, 106);
            this.listBoxMsg.TabIndex = 0;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(120, 153);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(60, 23);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "预定";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCome
            // 
            this.btnCome.Location = new System.Drawing.Point(186, 153);
            this.btnCome.Name = "btnCome";
            this.btnCome.Size = new System.Drawing.Size(60, 23);
            this.btnCome.TabIndex = 11;
            this.btnCome.Text = "就餐";
            this.btnCome.UseVisualStyleBackColor = true;
            this.btnCome.Click += new System.EventHandler(this.btnCome_Click);
            // 
            // btnUpdateMsg
            // 
            this.btnUpdateMsg.Location = new System.Drawing.Point(22, 153);
            this.btnUpdateMsg.Name = "btnUpdateMsg";
            this.btnUpdateMsg.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMsg.TabIndex = 12;
            this.btnUpdateMsg.Text = "修改信息";
            this.btnUpdateMsg.UseVisualStyleBackColor = true;
            this.btnUpdateMsg.Click += new System.EventHandler(this.btnUpdateMsg_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnUpdateMsg);
            this.panel1.Controls.Add(this.btnCome);
            this.panel1.Controls.Add(this.btnBook);
            this.panel1.Controls.Add(this.groupBoxMsg);
            this.panel1.Location = new System.Drawing.Point(213, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 187);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // btnFixUpdata
            // 
            this.btnFixUpdata.Location = new System.Drawing.Point(88, 180);
            this.btnFixUpdata.Name = "btnFixUpdata";
            this.btnFixUpdata.Size = new System.Drawing.Size(75, 23);
            this.btnFixUpdata.TabIndex = 14;
            this.btnFixUpdata.Text = "确认";
            this.btnFixUpdata.UseVisualStyleBackColor = true;
            this.btnFixUpdata.Visible = false;
            this.btnFixUpdata.Click += new System.EventHandler(this.btnFixUpdata_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 261);
            this.Controls.Add(this.btnFixUpdata);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.radioBtnFemale);
            this.Controls.Add(this.radioBtnMale);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxMsg.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TextBox nameTextBox;
        internal System.Windows.Forms.TextBox telTextBox;
        internal System.Windows.Forms.Label telLabel;
        internal System.Windows.Forms.Label nameLabel;
        internal System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel labNowUser;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        internal System.Windows.Forms.ToolStripStatusLabel labTel;
        internal System.Windows.Forms.Timer nowDateTime;
        internal System.Windows.Forms.Label txtWelcome;
        internal System.Windows.Forms.RadioButton radioBtnMale;
        internal System.Windows.Forms.RadioButton radioBtnFemale;
        internal System.Windows.Forms.Button btnFix;
        internal System.Windows.Forms.GroupBox groupBoxMsg;
        internal System.Windows.Forms.ListBox listBoxMsg;
        internal System.Windows.Forms.Button btnBook;
        internal System.Windows.Forms.Button btnCome;
        internal System.Windows.Forms.Button btnUpdateMsg;
        internal System.Windows.Forms.Button btnFixUpdata;

    }
}