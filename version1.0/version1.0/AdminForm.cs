using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace version0._1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void status_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.nowDateTime.Start();
        }

        private void nowDateTime_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void 用户界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerForm().Show();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定注销？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                ControlOrderClass.UpdateCusAndChrefThumbUp();
                this.Close();
            }
                
        }

        private void 房间和餐桌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            房间和餐桌信息Form rf = new 房间和餐桌信息Form();
            rf.MdiParent = this;
            rf.Dock = DockStyle.Fill;
            rf.Show();
        }

        private void 职工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            职工信息Form wf = new 职工信息Form();
            wf.MdiParent = this;
            wf.Dock = DockStyle.Fill;
            wf.Show();
        }

        private void 菜谱管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            菜谱Form mf = new 菜谱Form();
            mf.MdiParent = this;
            mf.Dock = DockStyle.Fill;
            mf.Show();
        }

        private void 顾客管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            顾客管理Form cf = new 顾客管理Form();
            cf.MdiParent = this;
            cf.Dock = DockStyle.Fill;
            cf.Show();
        }

        private void 订单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            订单管理Form of = new 订单管理Form();
            of.MdiParent = this;
            of.Dock = DockStyle.Fill;
            of.Show();
        }

    }
}
