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
    public partial class 雇佣厨师或服务员Form : Form
    {
        public 雇佣厨师或服务员Form()
        {
            InitializeComponent();
        }
        public int flat { set; get; }//用于记录是那个按钮触发本窗体的,0为服务员，1为厨师
        private string ID { set; get; }
        private string name { set; get; }
        private string sex { set; get; }
        private string job { set; get; }
        private void 雇佣厨师或服务员Form_Load(object sender, EventArgs e)
        {
            //服务员就不用显示分工的选择了
            if (flat == 0)
            {
                panel1.Hide();
            }
            else
            {
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
            if (工号TextBox.Text == "")
            {
                MessageBox.Show("工号不能空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (姓名TextBox.Text == "")
            {
                MessageBox.Show("姓名不能为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (!radioBtnMale.Checked && !radioBtnFemale.Checked)
            {
                MessageBox.Show("请选择性别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (flat == 1)
            {
                job = 分工ComboBox.SelectedItem.ToString();
                if (job == "")
                {
                    MessageBox.Show("请选择分工！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
            }

            #endregion

            #region 赋值对用户输入内容合法性检查
            name = 姓名TextBox.Text.Trim();
            if (name.Length > 20)
            {
                MessageBox.Show("抱歉！\n姓名长度不得长于10个汉字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            // 性别
            if (radioBtnMale.Checked)
            {
                sex = "男";
            }
            if (radioBtnFemale.Checked)
            {
                sex = "女";
            }

            ID = 工号TextBox.Text.Trim();
            if (ID.Length > 4)
            {
                MessageBox.Show("抱歉！\n工号长度不正确！\n请重新输入四位工号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            // 检查是否为数字
            try
            {
                Int16 temp = Convert.ToInt16(ID);
            }
            catch
            {
                MessageBox.Show("工号不应当含有非数字！\n请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            #endregion

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                cmd0.CommandText = string.Format("select * from Waiter where Wid = '{0}'", ID);
            }
            else
            {
                cmd0.CommandText = string.Format("select * from Chref where COid = '{0}'", ID);
            }
            cmd0.Connection = conn;
            SqlDataReader sdr0 = cmd0.ExecuteReader();
            if (sdr0.Read())
            {
                MessageBox.Show("工号重复，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sdr0.Dispose();
            }
            else
            {
                sdr0.Dispose();
                string strInsert;
                if (flat == 0)//添加服务员
                {
                    strInsert = string.Format
                        ("insert into Waiter(Wid, Wname, Wsex, Wifwork) values('{0}', '{1}', '{2}', '空闲')",
                            ID, name, sex);
                }
                else//添加
                {
                    strInsert = string.Format
                        ("insert into Chref(COid, COname, COsex, COjob, COifwork, CObethumbup) values('{0}', '{1}', '{2}', '{3}', '空闲', 0)",
                            ID, name, sex, job);
                }

                SqlCommand cmd1 = new SqlCommand(strInsert, conn);
                int n = cmd1.ExecuteNonQuery();
                if (n > 0)
                {
                    result = MessageBox.Show
                        ("添加员工成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cmd1.Dispose();
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
