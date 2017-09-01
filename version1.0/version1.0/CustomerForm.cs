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
    
    public partial class CustomerForm : Form
    {
        public string Ctellphone{ get; set; }
        public string Cname{ get; set; }
        public int Ccometimes { get; set; }
        public string Csex { get; set; }
        public int CcomingTimes { get; set; } //光临次数
        public string[] CfavouritFoodId = new string[3]{"","",""};//显示三个或以下
        public string[] CfavouritFoodName = new string[3]{"","",""};
        public CustomerForm()
        {
            InitializeComponent();
            this.Cname = "";
            this.Ctellphone = "";
            this.Csex = "";
            this.CcomingTimes = 0;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.nowDateTime.Start();
        }

        private void nowDateTime_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        public bool ReasonableCheck()
        {
            #region 确定没有漏填或漏选
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("称呼不能为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (!radioBtnMale.Checked && !radioBtnFemale.Checked)
            {
                MessageBox.Show("请选择性别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (telTextBox.Text == "")
            {
                MessageBox.Show("联系方式不能为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            #endregion

            #region 赋值并对用户输入内容合法性检查
            // 称呼
            Cname = nameTextBox.Text.Trim();
            if (Cname.Length > 20)
            {
                MessageBox.Show("抱歉！\n称呼长度不得长于10个汉字！\n若您的名字较长，则输入姓氏即可！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            // 性别
            if (radioBtnMale.Checked)
            {
                Csex = "男";
            }
            if (radioBtnFemale.Checked)
            {
                Csex = "女";
            }

            // 联系方式，检查长度和是否全为数字
            Ctellphone = telTextBox.Text.Trim();
            if (Ctellphone.Length > 12 || Ctellphone.Length < 8)
            {
                MessageBox.Show("联系方式长度不正确！\n请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            try
            {
                Int64 temp = Convert.ToInt64(Ctellphone);
            }
            catch
            {
                MessageBox.Show("联系方式不应当含有非数字！\n请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            
            #endregion

            nameTextBox.ReadOnly = true; // 连接数据库阶段不允许修改，除非发生错误
            telTextBox.ReadOnly = true;
            return true;
        }

        public void ShowMsg()
        {
            listBoxMsg.Items.Clear();

            panel1.Visible = true;//显示信息空间可见
            btnFix.Visible = false;
            btnFixUpdata.Visible = false;
            labNowUser.Text = "当前用户：" + Cname;
            StringBuilder strShowMsg = new StringBuilder();
            if (Csex == "男")
            {
                listBoxMsg.Items.Add("尊敬的 " + Cname + " 先生");
            }
            else
            {
                listBoxMsg.Items.Add("尊敬的 " + Cname + " 女士");
            }
            listBoxMsg.Items.Add("您的联系方式是：" + Ctellphone);
            listBoxMsg.Items.Add("您常点的菜有：");

            int i = 0;
            for (; i < 3; i++)
            {
                if (CfavouritFoodName[i] != "")
                {
                    listBoxMsg.Items.Add(string.Format("\t{0}" + CfavouritFoodName[i], i + 1));
                }
                else
                {
                    break; // 若第i条记录为空，则i之后的记录也为空，所以可以直接退出循环
                }
            }
            if (i == 0)
            {
                listBoxMsg.Items.Add("\t   尚无记录！");
            }

            btnCome.Visible = true;
            btnBook.Visible = true;
        }

        /// <summary>
        /// 初次输入信息，检查信息
        /// 并连接数据库，查看并打印顾客信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFix_Click(object sender, EventArgs e)
        {
            // 合理性检查并对三个参数赋值
            if (ReasonableCheck() == false)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd0 = new SqlCommand();
            cmd0.CommandText = string.Format("select * from Customer where Ctellphone = '{0}'", Ctellphone);
            cmd0.Connection = conn;
            SqlDataReader reader0 = cmd0.ExecuteReader();

            if (reader0.Read()) // 存在该顾客
            {
                string tempName = reader0["Cname"].ToString(); // 第0个数据是联系方式，第一个才是姓名
                Ccometimes = reader0.GetInt16(3);
                reader0.Dispose();
                if (tempName != Cname) // 姓名不同，则重新填写或联系管理员
                {
                    MessageBox.Show("该联系方式已经有顾客注册。\n请联系饭店管理员或点击“修改信息”进行修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    conn.Close();
                    return;
                }
                
            }
            else //不存在该顾客，则插入
            {
                reader0.Dispose();
                string strInsert = string.Format
                    ("insert into Customer(Ctellphone, Cname, Csex, Ccometimes) values('{0}', '{1}', '{2}', {3})",
                        Ctellphone, Cname, Csex, 0);
                SqlCommand cmd2 = new SqlCommand(strInsert, conn);
                cmd2.ExecuteNonQuery();
            }

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;

            reader0 = cmd0.ExecuteReader();
            int i = 0;
            if (reader0.Read())
            {
                for (; i < 3; i++)
                {
                    CfavouritFoodId[i] = reader0[4 + i].ToString();
                    cmd1.CommandText = string.Format("select Fname from Menu where Fid = '{0}'", CfavouritFoodId[i]);
                    if (cmd1.ExecuteScalar() == null)//不能直接就赋值，对象为空是无法转化为字符串的
                    {
                        break; // 若第i条记录为空，则i之后的记录也为空，所以可以直接退出循环
                    }
                    else
                    { 
                        CfavouritFoodName[i] = cmd1.ExecuteScalar().ToString();
                    }
                }
            }
            reader0.Dispose();
            ShowMsg();//将信息显示在listbox中

            // 来的次数+1
            CcomingTimes++;
            string strUpdate = string.Format
                ("update Customer set Ccometimes = Ccometimes + 1 where Ctellphone = '{0}'",
                    Ctellphone);
            cmd1.CommandText = strUpdate;
            cmd1.ExecuteNonQuery();

            cmd0.Dispose();
            cmd1.Dispose();
            conn.Close();            
        }

        private void btnUpdateMsg_Click(object sender, EventArgs e)
        {
            telTextBox.ReadOnly = false; //允许输入
            nameTextBox.ReadOnly = false;
            btnFixUpdata.Visible = true;
            btnCome.Visible = false; //不允许点击预定和点菜，即隐藏
            btnBook.Visible = false;
        }

        /// <summary>
        /// 先删除原有的信息，再插入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFixUpdata_Click(object sender, EventArgs e)
        {
            string tempTelphone = Ctellphone;//记录原信息的主键，因为用户可能修改主键。

            if (ReasonableCheck() == false)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            StringBuilder sqlUpdate = new StringBuilder();
            sqlUpdate.Append("update Customer ");
            sqlUpdate.Append(string.Format("set Ctellphone = '{0}', Cname = '{1}', Csex = '{2}' ", Ctellphone, Cname, Csex));
            sqlUpdate.Append(string.Format("where Ctellphone = '{0}';", tempTelphone));
            cmd.CommandText = sqlUpdate.ToString();
            int ifOk = cmd.ExecuteNonQuery();
            //更新客人-菜表
            sqlUpdate.Clear();
            sqlUpdate.Append("update CustomerMenu ");
            sqlUpdate.Append(string.Format("set Ctellphone = '{0}' ", Ctellphone));
            sqlUpdate.Append(string.Format("where Ctellphone = '{0}';", tempTelphone));
            cmd.CommandText = sqlUpdate.ToString();
            cmd.ExecuteNonQuery();
            //更新客人-餐桌表
            sqlUpdate.Clear();
            sqlUpdate.Append("update CustomerDesk ");
            sqlUpdate.Append(string.Format("set Ctellphone = '{0}' ", Ctellphone));
            sqlUpdate.Append(string.Format("where Ctellphone = '{0}';", tempTelphone));
            cmd.CommandText = sqlUpdate.ToString();
            cmd.ExecuteNonQuery();
            
            if(ifOk > 0)
            {
                MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmd.Dispose();
            conn.Close();
            
            ShowMsg();
        }

        private void btnCome_Click(object sender, EventArgs e)
        {
            顾客选桌并点菜Form cusComeForm = new 顾客选桌并点菜Form();
            cusComeForm.nowOrderDishCustomerID = Ctellphone;
            cusComeForm.nowOrderDishCustomerName = Cname;
            cusComeForm.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            预定Form cusComeForm = new 预定Form();
            cusComeForm.nowOrderDishCustomerID = Ctellphone;
            cusComeForm.Show();
        }
    }
    
}
