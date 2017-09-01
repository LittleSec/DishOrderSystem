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
    public partial class 增加菜谱Form : Form
    {
        public 增加菜谱Form()
        {
            InitializeComponent();
        }
        private string Fid { get; set; }
        private string Ftype { get; set; }
        private string Fname { get; set; }
        private float Fprice { get; set; }
        private int Fcooktime { get; set; }
        private void 增加菜谱Form_Load(object sender, EventArgs e)
        {
            菜种类TextBox.Visible = false;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select distinct Ftype from Menu;", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                菜种类ComboBox.Items.Add(sdr["Ftype"].ToString());
            }
            菜种类ComboBox.Items.Add("其他");
            cmd.Dispose();
            sdr.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void IfOtherShowTextBoxToInput(object sender, EventArgs e)
        {
            if (菜种类ComboBox.SelectedItem.ToString() == "其他")
            {
                菜种类TextBox.Visible = true;
                菜种类TextBox.Text = "";
            }
            else
            {
                菜种类TextBox.Visible = false;
            }
        }

        private bool ReasonableCheck()
        {
            #region 确定没有漏填或漏选
            if (菜编号TextBox.Text == "")
            {
                MessageBox.Show("菜编号为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            Ftype = 菜种类ComboBox.SelectedItem.ToString();
            if (Ftype == "")
            {
                MessageBox.Show("请选择菜的种类！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (菜名TextBox.Text == "")
            {
                MessageBox.Show("菜名为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (菜价TextBox.Text == "")
            {
                MessageBox.Show("菜价为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (烹饪时长TextBox.Text == "")
            {
                MessageBox.Show("大概烹饪时长为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            Fid = 菜编号TextBox.Text.Trim();
            Fname = 菜名TextBox.Text.Trim();
            Fprice = float.Parse(菜价TextBox.Text.Trim());//默认用户不傻逼
            Fcooktime = int.Parse(烹饪时长TextBox.Text.ToString().Trim());
            if (Ftype == "其他")
            {
                Ftype = 菜种类TextBox.Text.ToString();
            }
            #endregion

            #region 对用户输入内容合法性检查
            if (Fid.Length < 6)//因为已经定义了最大长度，因而只需要看是否达到6位即可。
            {
                MessageBox.Show("抱歉！\n菜编号长度不正确！\n请重新输入6位编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            // 检查是否为数字，不对容纳人数做是否为数字的检查
            try
            {
                Int32 temp = Convert.ToInt32(Fid);
            }
            catch
            {
                MessageBox.Show("菜编号不应当含有非数字！\n请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            string strInsert = string.Format
                ("insert into Menu(Fid, Ftype, Fname, Fprice, Fcooktime, Fthumbup) values('{0}', '{1}', '{2}', {3}, {4}, 0)",
                    Fid, Ftype, Fname, Fprice, Fcooktime);
            SqlCommand cmd1 = new SqlCommand(strInsert, conn);
            try
            {
                cmd1.ExecuteNonQuery();
            }    
            catch(SqlException se)//默认异常就是主键不唯一了
            {
                MessageBox.Show("菜编号重复，请重新输入！","Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Dispose();
                conn.Close();
                return;
            }
            
            MessageBox.Show("添加并更新房间信息成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Dispose();
            conn.Close();
            this.Close();
        }
    }
}
