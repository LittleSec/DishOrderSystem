namespace version0._1
{
    partial class WelcomeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.NowDateTime = new System.Windows.Forms.Timer(this.components);
            this.labShowDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(54, 145);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(95, 34);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "顾客";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Location = new System.Drawing.Point(197, 144);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(95, 35);
            this.btnAdministrator.TabIndex = 1;
            this.btnAdministrator.Text = "管理员";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.Click += new System.EventHandler(this.Administrator_Click);
            // 
            // txtWelcome
            // 
            this.txtWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWelcome.ForeColor = System.Drawing.Color.Crimson;
            this.txtWelcome.Location = new System.Drawing.Point(119, 87);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(112, 25);
            this.txtWelcome.TabIndex = 2;
            this.txtWelcome.Text = "欢迎光临";
            this.txtWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NowDateTime
            // 
            this.NowDateTime.Enabled = true;
            this.NowDateTime.Interval = 1000;
            this.NowDateTime.Tick += new System.EventHandler(this.NowDateTime_Tick);
            // 
            // labShowDateTime
            // 
            this.labShowDateTime.AutoSize = true;
            this.labShowDateTime.Location = new System.Drawing.Point(71, 40);
            this.labShowDateTime.Name = "labShowDateTime";
            this.labShowDateTime.Size = new System.Drawing.Size(65, 12);
            this.labShowDateTime.TabIndex = 3;
            this.labShowDateTime.Text = "当前时间：";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.labShowDateTime);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.btnAdministrator);
            this.Controls.Add(this.btnCustomer);
            this.Name = "WelcomeForm";
            this.Text = "点菜管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Timer NowDateTime;
        private System.Windows.Forms.Label labShowDateTime;
    }
}

