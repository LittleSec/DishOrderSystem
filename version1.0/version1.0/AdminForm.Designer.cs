namespace version0._1
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.房间和餐桌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.职工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顾客管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜谱管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labUnit = new System.Windows.Forms.ToolStripStatusLabel();
            this.labNowUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labTel = new System.Windows.Forms.ToolStripStatusLabel();
            this.nowDateTime = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.房间和餐桌ToolStripMenuItem,
            this.职工信息ToolStripMenuItem,
            this.订单管理ToolStripMenuItem,
            this.顾客管理ToolStripMenuItem,
            this.菜谱管理ToolStripMenuItem,
            this.用户界面ToolStripMenuItem,
            this.注销ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 房间和餐桌ToolStripMenuItem
            // 
            this.房间和餐桌ToolStripMenuItem.Name = "房间和餐桌ToolStripMenuItem";
            this.房间和餐桌ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.房间和餐桌ToolStripMenuItem.Text = "房间和餐桌信息";
            this.房间和餐桌ToolStripMenuItem.Click += new System.EventHandler(this.房间和餐桌ToolStripMenuItem_Click);
            // 
            // 职工信息ToolStripMenuItem
            // 
            this.职工信息ToolStripMenuItem.Name = "职工信息ToolStripMenuItem";
            this.职工信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.职工信息ToolStripMenuItem.Text = "职工信息";
            this.职工信息ToolStripMenuItem.Click += new System.EventHandler(this.职工信息ToolStripMenuItem_Click);
            // 
            // 订单管理ToolStripMenuItem
            // 
            this.订单管理ToolStripMenuItem.Name = "订单管理ToolStripMenuItem";
            this.订单管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.订单管理ToolStripMenuItem.Text = "订单管理";
            this.订单管理ToolStripMenuItem.Click += new System.EventHandler(this.订单管理ToolStripMenuItem_Click);
            // 
            // 顾客管理ToolStripMenuItem
            // 
            this.顾客管理ToolStripMenuItem.Name = "顾客管理ToolStripMenuItem";
            this.顾客管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.顾客管理ToolStripMenuItem.Text = "顾客管理";
            this.顾客管理ToolStripMenuItem.Click += new System.EventHandler(this.顾客管理ToolStripMenuItem_Click);
            // 
            // 菜谱管理ToolStripMenuItem
            // 
            this.菜谱管理ToolStripMenuItem.Name = "菜谱管理ToolStripMenuItem";
            this.菜谱管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.菜谱管理ToolStripMenuItem.Text = "菜谱管理";
            this.菜谱管理ToolStripMenuItem.Click += new System.EventHandler(this.菜谱管理ToolStripMenuItem_Click);
            // 
            // 用户界面ToolStripMenuItem
            // 
            this.用户界面ToolStripMenuItem.Name = "用户界面ToolStripMenuItem";
            this.用户界面ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.用户界面ToolStripMenuItem.Text = "进入用户界面";
            this.用户界面ToolStripMenuItem.Click += new System.EventHandler(this.用户界面ToolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labUnit,
            this.labNowUser,
            this.toolStripStatusLabel3,
            this.labTel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.status_ItemClicked);
            // 
            // labUnit
            // 
            this.labUnit.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.labUnit.Name = "labUnit";
            this.labUnit.Size = new System.Drawing.Size(204, 21);
            this.labUnit.Text = "单位：中国海洋大学数据库课程设计";
            // 
            // labNowUser
            // 
            this.labNowUser.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.labNowUser.Name = "labNowUser";
            this.labNowUser.Size = new System.Drawing.Size(105, 21);
            this.labNowUser.Text = "当前用户：Admin";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(315, 21);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // labTel
            // 
            this.labTel.Name = "labTel";
            this.labTel.Size = new System.Drawing.Size(145, 21);
            this.labTel.Text = "联系方式：18169861368";
            // 
            // nowDateTime
            // 
            this.nowDateTime.Interval = 1000;
            this.nowDateTime.Tick += new System.EventHandler(this.nowDateTime_Tick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "监测数据";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 房间和餐桌ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 职工信息ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labUnit;
        private System.Windows.Forms.ToolStripStatusLabel labNowUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel labTel;
        private System.Windows.Forms.Timer nowDateTime;
        private System.Windows.Forms.ToolStripMenuItem 订单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顾客管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜谱管理ToolStripMenuItem;

    }
}