using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace version0._1
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Administrator_Click(object sender, EventArgs e)
        {
            new AdminLoginForm().Show();
            this.Hide();
        }

        private void NowDateTime_Tick(object sender, EventArgs e)
        {
            this.labShowDateTime.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            new CustomerForm().Show();
        }
    }
}
