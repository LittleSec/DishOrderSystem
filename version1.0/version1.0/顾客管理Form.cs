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
    public partial class 顾客管理Form : Form
    {
        public 顾客管理Form()
        {
            InitializeComponent();

            #region 初始化全部顾客信息表
            //禁止自动生成列
            cusMsgDataView.AutoGenerateColumns = false;
            //创建网格控件列
            DataGridViewTextBoxColumn colCtellphone = new DataGridViewTextBoxColumn();
            colCtellphone.HeaderText = "联系方式";
            colCtellphone.DataPropertyName = "Ctellphone";
            cusMsgDataView.Columns.Add(colCtellphone);

            DataGridViewTextBoxColumn colCname = new DataGridViewTextBoxColumn();
            colCname.HeaderText = "顾客姓名";
            colCname.DataPropertyName = "Cname";
            cusMsgDataView.Columns.Add(colCname);

            DataGridViewTextBoxColumn colCsex = new DataGridViewTextBoxColumn();
            colCsex.HeaderText = "性别";
            colCsex.DataPropertyName = "Csex";
            cusMsgDataView.Columns.Add(colCsex);

            DataGridViewTextBoxColumn colCcometimes = new DataGridViewTextBoxColumn();
            colCcometimes.HeaderText = "光临次数";
            colCcometimes.DataPropertyName = "Ccometimes";
            cusMsgDataView.Columns.Add(colCcometimes);

            DataGridViewTextBoxColumn colCregularfood1 = new DataGridViewTextBoxColumn();
            colCregularfood1.HeaderText = "常点的菜1";
            colCregularfood1.DataPropertyName = "Cregularfood1";
            cusMsgDataView.Columns.Add(colCregularfood1);

            DataGridViewTextBoxColumn colCregularfood2 = new DataGridViewTextBoxColumn();
            colCregularfood2.HeaderText = "常点的菜2";
            colCregularfood2.DataPropertyName = "Cregularfood2";
            cusMsgDataView.Columns.Add(colCregularfood2);

            DataGridViewTextBoxColumn colCregularfood3 = new DataGridViewTextBoxColumn();
            colCregularfood3.HeaderText = "常点的菜3";
            colCregularfood3.DataPropertyName = "Cregularfood3";
            cusMsgDataView.Columns.Add(colCregularfood3);
            #endregion

            #region 初始化光顾记录表
            //禁止自动生成列
            dataGridView1.AutoGenerateColumns = false;
            //创建网格控件列
            DataGridViewTextBoxColumn colCname1 = new DataGridViewTextBoxColumn();
            colCname1.HeaderText = "顾客姓名";
            colCname1.DataPropertyName = "Cname";
            dataGridView1.Columns.Add(colCname1);

            DataGridViewTextBoxColumn colOrderdate = new DataGridViewTextBoxColumn();
            colOrderdate.HeaderText = "订单日期";
            colOrderdate.DataPropertyName = "Orderdate";
            dataGridView1.Columns.Add(colOrderdate);

            DataGridViewTextBoxColumn colOrdernum = new DataGridViewTextBoxColumn();
            colOrdernum.HeaderText = "订单号";
            colOrdernum.DataPropertyName = "Ordernum";
            dataGridView1.Columns.Add(colOrdernum);

            DataGridViewTextBoxColumn colOrdermoney = new DataGridViewTextBoxColumn();
            colOrdermoney.HeaderText = "订单价格";
            colOrdermoney.DataPropertyName = "Ordermoney";
            dataGridView1.Columns.Add(colOrdermoney);
            #endregion

            #region 初始化点菜记录表
            //禁止自动生成列
            dataGridView1.AutoGenerateColumns = false;
            //创建网格控件列
            //DataGridViewTextBoxColumn colCname2 = new DataGridViewTextBoxColumn();
            //colCname2.HeaderText = "顾客姓名";
            //colCname2.DataPropertyName = "Cname";
            //dataGridView2.Columns.Add(colCname2);

            DataGridViewTextBoxColumn colFname = new DataGridViewTextBoxColumn();
            colFname.HeaderText = "菜名";
            colFname.DataPropertyName = "Fname";
            dataGridView2.Columns.Add(colFname);

            DataGridViewTextBoxColumn colLastordertime = new DataGridViewTextBoxColumn();
            colLastordertime.HeaderText = "最后一次点的日期";
            colLastordertime.DataPropertyName = "Lastordertime";
            dataGridView2.Columns.Add(colLastordertime);

            DataGridViewTextBoxColumn colOrdercount = new DataGridViewTextBoxColumn();
            colOrdercount.HeaderText = "点的次数";
            colOrdercount.DataPropertyName = "Ordercount";
            dataGridView2.Columns.Add(colOrdercount);

            DataGridViewTextBoxColumn colIfthumbup = new DataGridViewTextBoxColumn();
            colIfthumbup.HeaderText = "是否已点赞";
            colIfthumbup.DataPropertyName = "Ifthumbup";
            dataGridView2.Columns.Add(colIfthumbup);
            #endregion
        }

        private void 顾客管理Form_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            string strSQL = "select Ctellphone, Cname, Csex, Ccometimes, Cregularfood1, Cregularfood2, Cregularfood3 from Customer;";
            SqlDataAdapter adtCustomer = new SqlDataAdapter(strSQL, conn);
            DataTable dtCustomer = new DataTable();
            adtCustomer.Fill(dtCustomer);
            cusMsgDataView.DataSource = dtCustomer;
            dtCustomer.Dispose();
            adtCustomer.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void SelectCustomerToSeeHistory(object sender, DataGridViewCellEventArgs e)
        {
            string Ctellphone = cusMsgDataView.SelectedCells[0].Value.ToString();
            string Cname = cusMsgDataView.SelectedCells[1].Value.ToString();
            string Csex = cusMsgDataView.SelectedCells[2].Value.ToString();

            SqlConnection conn =new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            StringBuilder sqlSelectCustomerDesk = new StringBuilder();
            sqlSelectCustomerDesk.Append("select Cname, Orderdate, Ordernum, Ordermoney ");
            sqlSelectCustomerDesk.Append("from Customer, CustomerDesk ");
            sqlSelectCustomerDesk.Append("where Ifcheckout = '是' ");
            sqlSelectCustomerDesk.Append(string.Format(" and CustomerDesk.Ctellphone = '{0}' ", Ctellphone));
            sqlSelectCustomerDesk.Append(" and Customer.Ctellphone = CustomerDesk.Ctellphone;");

            SqlDataAdapter adt = new SqlDataAdapter(sqlSelectCustomerDesk.ToString(), conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            dt.Dispose();
            adt.Dispose();

            StringBuilder sqlSelectCustomerMenu = new StringBuilder();
            sqlSelectCustomerMenu.Append("select Fname, Lastordertime, Ordercount, Ifthumbup ");
            sqlSelectCustomerMenu.Append("from CustomerMenu, Menu ");
            sqlSelectCustomerMenu.Append(string.Format("where CustomerMenu.Ctellphone = '{0}' ", Ctellphone));
            sqlSelectCustomerMenu.Append(" and Menu.Fid = CustomerMenu.Fid;");

            SqlDataAdapter adt1 = new SqlDataAdapter(sqlSelectCustomerMenu.ToString(), conn);
            DataTable dt1 = new DataTable();
            adt1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            dt1.Dispose();
            conn.Dispose();
            conn.Close();

            //GroupBox
            radioBtnMale.Checked = false;
            radioBtnFemale.Checked = false;
            nameTextBox.Text = Cname;
            telTextBox.Text = Ctellphone;
            if (Csex == "男")
            {
                radioBtnMale.Checked = true;
            }
            else
            {
                radioBtnFemale.Checked = true;
            }
        }

        private int flag { set; get; }//记录是修改还是新增顾客。修改为0，新增为1
        private void btn新增顾客_Click(object sender, EventArgs e)
        {
            flag = 1;
            nameTextBox.ReadOnly = false;
            nameTextBox.Text = "";
            telTextBox.ReadOnly = false;
            telTextBox.Text = "";
            btn确定.Enabled = true;
        }

        public string newCtellphone { get; set; }
        public string newCname { get; set; }
        public string newCsex { get; set; }
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
            newCname = nameTextBox.Text.Trim();
            if (newCname.Length > 20)
            {
                MessageBox.Show("抱歉！\n称呼长度不得长于10个汉字！\n若您的名字较长，则输入姓氏即可！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            // 性别
            if (radioBtnMale.Checked)
            {
                newCsex = "男";
            }
            if (radioBtnFemale.Checked)
            {
                newCsex = "女";
            }

            // 联系方式，检查长度和是否全为数字
            newCtellphone = telTextBox.Text.Trim();
            if (newCtellphone.Length > 12 || newCtellphone.Length < 8)
            {
                MessageBox.Show("联系方式长度不正确！\n请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            try
            {
                Int64 temp = Convert.ToInt64(newCtellphone);
            }
            catch
            {
                MessageBox.Show("联系方式不应当含有非数字！\n请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }


            #endregion

            return true;
        }

        private void btn确定_Click(object sender, EventArgs e)
        {
            if (ReasonableCheck() == false)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            int ifOk = 0;
            if (flag == 0)//修改顾客
            {
                string oldCid = cusMsgDataView.SelectedRows[0].Cells[0].Value.ToString();
                StringBuilder sqlUpdate = new StringBuilder();
                sqlUpdate.Append("update Customer ");
                sqlUpdate.Append(string.Format("set Ctellphone = '{0}', Cname = '{1}', Csex = '{2}' ", newCtellphone, newCname, newCsex));
                sqlUpdate.Append(string.Format("where Ctellphone = '{0}';", oldCid));
                cmd.CommandText = sqlUpdate.ToString();
                ifOk = cmd.ExecuteNonQuery();
                //更新客人-菜表
                sqlUpdate.Clear();
                sqlUpdate.Append("update CustomerMenu ");
                sqlUpdate.Append(string.Format("set Ctellphone = '{0}' ", newCtellphone));
                sqlUpdate.Append(string.Format("where Ctellphone = '{0}';", oldCid));
                cmd.CommandText = sqlUpdate.ToString();
                cmd.ExecuteNonQuery();
                //更新客人-餐桌表
                sqlUpdate.Clear();
                sqlUpdate.Append("update CustomerDesk ");
                sqlUpdate.Append(string.Format("set Ctellphone = '{0}' ", newCtellphone));
                sqlUpdate.Append(string.Format("where Ctellphone = '{0}';", oldCid));
                cmd.CommandText = sqlUpdate.ToString();
                cmd.ExecuteNonQuery();
            }
            else//新增顾客
            {
                string strInsert = string.Format
                ("insert into Customer(Ctellphone, Cname, Csex, Ccometimes) values('{0}', '{1}', '{2}', {3})",
                    newCtellphone, newCname, newCsex, 0);
                cmd.CommandText = strInsert;
                try
                {
                    ifOk = cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    MessageBox.Show("顾客联系方式重复，请再次确认！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (ifOk > 0)
            {
                MessageBox.Show("操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cmd.Dispose();
            conn.Dispose();
            conn.Close();
            nameTextBox.ReadOnly = true;
            telTextBox.ReadOnly = true;
            btn确定.Enabled = false;
        }

        private void btn修改信息_Click(object sender, EventArgs e)
        {
            flag = 0;
            nameTextBox.ReadOnly = false;
            telTextBox.ReadOnly = false;
            btn确定.Enabled = true;
        }

        private void btn删除顾客_Click(object sender, EventArgs e)
        {
            if (cusMsgDataView.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择要删除的顾客！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            DialogResult result = 
                MessageBox.Show("确定要删除该顾客？\n删除后会删除该顾客点菜记录。", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {   
                string strDelCid = cusMsgDataView.SelectedRows[0].Cells[0].Value.ToString();//获取要删除的顾客联系方式
                //先查看是否还有没结的帐或者预定订单
                string sqlSearchCustomerDesk = string.Format
                    ("select top 1 Ifcheckout from CustomerDesk where Ctellphone = '{0}' order by Orderdate desc;", strDelCid);
                SqlCommand cmd = new SqlCommand(sqlSearchCustomerDesk,conn);
                string tempIfcheckout = cmd.ExecuteScalar().ToString();
                if (tempIfcheckout == "否")
                {
                    MessageBox.Show("该顾客还有订单尚未结账，拒绝删除。", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmd.Dispose();
                    conn.Dispose();
                    conn.Close();
                    return;
                }

                string sqlDelCus = string.Format("delete from Customer where Ctellphone = '{0}';", strDelCid);//sql删除语句
                string sqlDelCusMenu = string.Format("delete from CustomerMenu where Ctellphone = '{0}';", strDelCid);

                //在数据库中移除，注意要移除ChrefMenu表相应的数据，注意次序
                cmd.CommandText = sqlDelCusMenu;
                cmd.ExecuteNonQuery();
                cmd.CommandText = sqlDelCus;
                cmd.ExecuteNonQuery();

                cusMsgDataView.Rows.Remove(cusMsgDataView.SelectedRows[0]);//在表中移除
                cmd.Dispose();
                MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nameTextBox.Text = "";
                telTextBox.Text = "";
            }
            conn.Dispose();
            conn.Close();
        }

        private void btn光顾_Click(object sender, EventArgs e)
        {
            if (cusMsgDataView.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择要删除的顾客！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            顾客选桌并点菜Form cusComeForm = new 顾客选桌并点菜Form();
            cusComeForm.nowOrderDishCustomerID = cusMsgDataView.SelectedRows[0].Cells[0].Value.ToString();
            cusComeForm.nowOrderDishCustomerName = cusMsgDataView.SelectedRows[0].Cells[1].Value.ToString();
            cusComeForm.Show();
        }
    }
}
