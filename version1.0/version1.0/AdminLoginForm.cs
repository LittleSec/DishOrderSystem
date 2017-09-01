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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (accountTextBox.Text.ToString() != "abc")
                MessageBox.Show("不存在该账号");
            else
            {
                if (passwordTextBox.Text.ToString() != "abc")
                    MessageBox.Show("密码错误");
                else
                    MessageBox.Show("成功登录");
            }
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            new WelcomeForm().Show();
            base.OnClosing(e);
        }
 
        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
