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
    public partial class 修改职工信息Form : Form
    {
        public 修改职工信息Form()
        {
            InitializeComponent();
        }
        public int flat { get; set; }//用于记录是那个按钮触发本窗体的,0为服务员，1为厨师
        public string ID { get; set; }
        public string oldName { get; set; }
        public string sex { get; set; }
        public string oldJob { get; set; }
        private string newName { get; set; }
        private string newJob { get; set; }
        private void 修改职工信息Form_Load(object sender, EventArgs e)
        {
            选定员工信息ListBox.Items.Clear();
            选定员工信息ListBox.Items.Add("   选定员工信息");
            选定员工信息ListBox.Items.Add("工号：" + ID);
            选定员工信息ListBox.Items.Add("姓名：" + oldName);
            选定员工信息ListBox.Items.Add("性别：" + sex);
            姓名TextBox.Text = oldName;
            
            //服务员就不用显示分工的选择了
            if (flat == 0)
            {
                panel1.Hide();
            }
            else
            {
                选定员工信息ListBox.Items.Add("分工：" + oldJob);
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select distinct Ftype from Menu;", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    分工ComboBox.Items.Add(sdr["Ftype"].ToString());
                }
                分工ComboBox.Items.Add("其他");
                cmd.Dispose();
                sdr.Dispose();
                conn.Dispose();
                conn.Close();
                panel1.Show();
            }
        }
        private bool ReasonableCheck()
        {
            #region 确定没有漏填或漏选

            if (姓名TextBox.Text == "")
            {
                MessageBox.Show("姓名不能为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (flat == 1)
            {
                newJob = 分工ComboBox.SelectedItem.ToString();
                if (newJob == "")
                {
                    MessageBox.Show("请选择分工！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
            }
            #endregion

            #region 赋值对用户输入内容合法性检查
            newName = 姓名TextBox.Text.Trim();
            if (newName.Length > 20)
            {
                MessageBox.Show("抱歉！\n姓名长度不得长于10个汉字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            #endregion

            return true;
        }

        private void 修改btn_Click(object sender, EventArgs e)
        {
            if (ReasonableCheck() == false)
            {
                return;
            }

            DialogResult result = DialogResult.Cancel;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd0 = new SqlCommand();
            if (flat == 0)
            {
                cmd0.CommandText = string.Format("update Waiter set Wname = '{0}' where Wid = '{1}';", newName, ID);
            }
            else
            {
                cmd0.CommandText = string.Format("update Chref set COname = '{0}', COjob = '{1}' where COid = '{2}';", newName, newJob, ID);
            }
            cmd0.Connection = conn;
            int n = cmd0.ExecuteNonQuery();
            if (n > 0)
            {
                result = MessageBox.Show
                    ("成功修改员工信息！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cmd0.Dispose();
            conn.Dispose();
            conn.Close();

            if (result == DialogResult.OK)
            {
                this.Close();
            }
            this.Close();
        }
    }
}
