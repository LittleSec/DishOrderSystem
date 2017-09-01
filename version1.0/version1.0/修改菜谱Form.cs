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
    public partial class 修改菜谱Form : Form
    {
        public 修改菜谱Form()
        {
            InitializeComponent();
        }

        public string Fid { get; set; }
        public string Ftype { get; set; }
        public string Fname { get; set; }
        public float Fprice { get; set; }
        public int Fcooktime { get; set; }

        private string newFtype { get; set; }
        private string newFname { get; set; }
        private float newFprice { get; set; }
        private int newFcooktime { get; set; }

        private void 修改菜谱Form_Load(object sender, EventArgs e)
        {
            选定菜ListBox.Items.Clear();
            选定菜ListBox.Items.Add("\t选定菜的信息");
            选定菜ListBox.Items.Add("菜的编号：" + Fid);
            选定菜ListBox.Items.Add("菜的种类：" + Ftype);
            选定菜ListBox.Items.Add("菜名：" + Fname);
            选定菜ListBox.Items.Add("菜价：" + Fprice.ToString() + "元/份");
            选定菜ListBox.Items.Add("大概烹饪时长：" + Fcooktime.ToString() + "秒");

            菜名TextBox.Text = Fname;
            菜价TextBox.Text = Fprice.ToString();
            烹饪时长TextBox.Text = Fcooktime.ToString();
            菜种类ComboBox.Text = Ftype;
            菜种类TextBox.Text = Ftype;

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
            #region 确定没有漏填或漏选并赋值

            newFtype = 菜种类ComboBox.SelectedItem.ToString();
            if (newFtype == "")
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

            newFname = 菜名TextBox.Text.Trim();
            newFprice = float.Parse(菜价TextBox.Text.ToString().Trim());//默认用户不傻逼
            newFcooktime = int.Parse(烹饪时长TextBox.Text.ToString().Trim());
            if (newFtype == "其他")
            {
                newFtype = 菜种类TextBox.Text.ToString();
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
            cmd0.CommandText = 
                string.Format("update Menu set Ftype = '{0}', Fname = '{1}', Fprice = {2}, Fcooktime = {3} where Fid = '{4}';"
                    , newFtype, newFname, newFprice, newFcooktime, Fid);
            
            cmd0.Connection = conn;
            int n = cmd0.ExecuteNonQuery();
            if (n > 0)
            {
                result = MessageBox.Show
                    ("成功菜谱信息！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
