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
    public partial class 订单管理Form : Form
    {
        public 订单管理Form()
        {
            InitializeComponent();

            #region 初始化当前订单显示
            //禁止自动生成列
            nowOrderDataView.AutoGenerateColumns = false;
            //创建网格控件列
            DataGridViewTextBoxColumn colCname = new DataGridViewTextBoxColumn();
            colCname.HeaderText = "顾客姓名";
            colCname.DataPropertyName = "Cname";
            nowOrderDataView.Columns.Add(colCname);

            DataGridViewTextBoxColumn colCtellphone = new DataGridViewTextBoxColumn();
            colCtellphone.HeaderText = "联系方式";
            colCtellphone.DataPropertyName = "Ctellphone";
            nowOrderDataView.Columns.Add(colCtellphone);

            DataGridViewTextBoxColumn colDid = new DataGridViewTextBoxColumn();
            colDid.HeaderText = "餐桌号";
            colDid.DataPropertyName = "Did";
            nowOrderDataView.Columns.Add(colDid);

            DataGridViewTextBoxColumn colOrdernum = new DataGridViewTextBoxColumn();
            colOrdernum.HeaderText = "订单号";
            colOrdernum.DataPropertyName = "Ordernum";
            nowOrderDataView.Columns.Add(colOrdernum);

            DataGridViewTextBoxColumn colIfcheckout = new DataGridViewTextBoxColumn();
            colIfcheckout.HeaderText = "是否已结账";
            colIfcheckout.DataPropertyName = "Ifcheckout";
            nowOrderDataView.Columns.Add(colIfcheckout);

            DataGridViewTextBoxColumn colOrdermoney = new DataGridViewTextBoxColumn();
            colOrdermoney.HeaderText = "订单价格";
            colOrdermoney.DataPropertyName = "Ordermoney";
            nowOrderDataView.Columns.Add(colOrdermoney);
            #endregion

            #region 初始化历史订单显示
            //禁止自动生成列
            historyOrderDataView.AutoGenerateColumns = false;
            //创建网格控件列

            DataGridViewTextBoxColumn colCname1 = (DataGridViewTextBoxColumn)colCname.Clone();
            historyOrderDataView.Columns.Add(colCname1);

            DataGridViewTextBoxColumn colCtellphone1 = (DataGridViewTextBoxColumn)colCtellphone.Clone();
            historyOrderDataView.Columns.Add(colCtellphone1);

            DataGridViewTextBoxColumn colOrderdate = new DataGridViewTextBoxColumn();
            colOrderdate.HeaderText = "订单日期";
            colOrderdate.DataPropertyName = "Orderdate";
            historyOrderDataView.Columns.Add(colOrderdate);

            DataGridViewTextBoxColumn colOrdernum1 = (DataGridViewTextBoxColumn)colOrdernum.Clone();
            historyOrderDataView.Columns.Add(colOrdernum1);

            DataGridViewTextBoxColumn colOrdermoney1 = (DataGridViewTextBoxColumn)colOrdermoney.Clone();
            historyOrderDataView.Columns.Add(colOrdermoney1);

            #endregion
        }

        private void 订单管理Form_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            DateTime now = DateTime.Now;
            string sqlDate = now.ToString("yyyy-MM-dd");
            StringBuilder strSQLnow = new StringBuilder();
            strSQLnow.Append("select Cname, Customer.Ctellphone, Did, Ordernum, Ifcheckout, Ordermoney ");
            strSQLnow.Append("from Customer, CustomerDesk ");
            strSQLnow.Append("where Customer.Ctellphone = CustomerDesk.Ctellphone ");
            strSQLnow.Append(" and Ifcheckout = '否' ");
            strSQLnow.Append(string.Format(" and DATEDIFF(day, orderdate, '{0}')<=0;", sqlDate));
            SqlDataAdapter adtNowOrder = new SqlDataAdapter(strSQLnow.ToString(), conn);
            DataTable dtNowOrder = new DataTable();
            adtNowOrder.Fill(dtNowOrder);
            nowOrderDataView.DataSource = dtNowOrder;
            dtNowOrder.Dispose();
            adtNowOrder.Dispose();

            StringBuilder strSQLhistroy = new StringBuilder();
            strSQLhistroy.Append("select Cname, Customer.Ctellphone, Orderdate, Ordernum, Ordermoney ");
            strSQLhistroy.Append("from Customer, CustomerDesk ");
            strSQLhistroy.Append("where Customer.Ctellphone = CustomerDesk.Ctellphone ");
            strSQLhistroy.Append("and Ifcheckout = '是' ");
            strSQLhistroy.Append(string.Format("and DATEDIFF(day, orderdate, '{0}')>=0;", sqlDate));
            SqlDataAdapter adtHistoryOrder = new SqlDataAdapter(strSQLhistroy.ToString(), conn);
            DataTable dtHistoryOrder = new DataTable();
            adtHistoryOrder.Fill(dtHistoryOrder);
            historyOrderDataView.DataSource = dtHistoryOrder;
            dtHistoryOrder.Dispose();
            adtHistoryOrder.Dispose();
            conn.Close();
        }

        //选择日期触发的时间
        private void ChooseDateToSeeOrder(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            string chooseDate = orderDatePicker.Value.ToString("yyyy-MM-dd");
            StringBuilder strSQLhistroy = new StringBuilder();
            strSQLhistroy.Append("select Cname, Customer.Ctellphone, Orderdate, Ordernum, Ordermoney ");
            strSQLhistroy.Append("from Customer, CustomerDesk ");
            strSQLhistroy.Append("where Customer.Ctellphone = CustomerDesk.Ctellphone ");
            strSQLhistroy.Append("and Ifcheckout = '是' ");
            if (beforeCheckBox.Checked)
            {
                strSQLhistroy.Append(string.Format("and DATEDIFF(day, orderdate, '{0}')>=0;", chooseDate));
            }
            else
            {
                strSQLhistroy.Append(string.Format("and DATEDIFF(day, orderdate, '{0}')=0;", chooseDate));
            }
            
            SqlDataAdapter adtHistoryOrder = new SqlDataAdapter(strSQLhistroy.ToString(), conn);
            DataTable dtHistoryOrder = new DataTable();
            adtHistoryOrder.Fill(dtHistoryOrder);
            historyOrderDataView.DataSource = dtHistoryOrder;
            
            dtHistoryOrder.Dispose();
            adtHistoryOrder.Dispose();
            conn.Close();
        }

        //是否勾选了“前的订单”
        private void ChooseDateBeforeOrder(object sender, EventArgs e)
        {
            ChooseDateToSeeOrder(this, null);//激活ChooseDateToSeeOrder事件
        }

        private void ChooseOrderToSeeMenu(object sender, DataGridViewCellEventArgs e)
        {
            historyMenuListBox.Items.Clear();
            historyMenuListBox.Items.Add("该订单点的菜：");
            historyMenuListBox.Items.Add("      菜名\t  菜价");
            string chooseOrderNum = historyOrderDataView.SelectedCells[3].Value.ToString();

            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("select Fname, Fprice ");
            strSQL.Append("from Menu ");
            strSQL.Append("where Fid in ( ");
            strSQL.Append(" select Fid ");
            strSQL.Append("	from DeskMenu ");
            strSQL.Append(string.Format("	where Ordernum = '{0}');",chooseOrderNum));

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL.ToString(), conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string Fname = sdr.GetString(0);
                float Fprice = sdr.GetFloat(1);
                historyMenuListBox.Items.Add(string.Format("   {0,5}\t{1:f2}元/份", Fname, Fprice));
            }
            sdr.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void ChooseNowOrderToSeeMenu(object sender, DataGridViewCellEventArgs e)
        {
            nowMenuListBox.Items.Clear();
            nowMenuListBox.Items.Add("该订单点的菜：");
            nowMenuListBox.Items.Add("    菜名\t菜价\t  是否已上菜");
            string chooseOrderNum = nowOrderDataView.SelectedCells[3].Value.ToString();

            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("select Fname, Fprice, Ifservedish ");
            strSQL.Append("from Menu, DeskMenu ");
            strSQL.Append("where Menu.Fid = DeskMenu.Fid ");
            strSQL.Append(string.Format("and Ordernum = '{0}';", chooseOrderNum));

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL.ToString(), conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string Fname = sdr.GetString(0);
                float Fprice = sdr.GetFloat(1);
                string Ifservedish = sdr.GetString(2);
                nowMenuListBox.Items.Add(string.Format("{0,5}\t{1:f2}元/份\t{2}", Fname, Fprice, Ifservedish));
            }
            sdr.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void 结账btn_Click(object sender, EventArgs e)
        {
            if (nowOrderDataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要结账的订单！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();

            // 获取订单基本信息，后面会使用
            string cusName = nowOrderDataView.SelectedCells[0].Value.ToString();
            string cusTel = nowOrderDataView.SelectedCells[1].Value.ToString();
            string deskId = nowOrderDataView.SelectedCells[2].Value.ToString();
            string orderNum = nowOrderDataView.SelectedCells[3].Value.ToString();
            float orderMoney = float.Parse(nowOrderDataView.SelectedCells[5].Value.ToString());

            // 创建检查是否所有菜都上齐的sql语句
            StringBuilder sqlCheckIfAllServe = new StringBuilder();
            sqlCheckIfAllServe.Append("select Fid, Ifservedish ");
            sqlCheckIfAllServe.Append("from DeskMenu ");
            sqlCheckIfAllServe.Append(string.Format("where Ordernum = '{0}';", orderNum));
            // 通过对DeskMenu表中该订单的所有菜进行检索是否已上菜
            SqlCommand cmd = new SqlCommand(sqlCheckIfAllServe.ToString(), conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            bool flatServeAll = true;//上齐了为true
            StringBuilder noServeDish = new StringBuilder();//记录没上的菜编号
            noServeDish.Append("还有这些菜没上：");
            while (sdr.Read())
            {
                if (sdr["Ifservedish"].ToString() == "否")
                {
                    noServeDish.Append(sdr["Fid"] + "  ");
                    flatServeAll = false;
                }
            }
            sdr.Dispose();//及时释放
            //没上齐不允许结账
            if (flatServeAll == false)
            {
                MessageBox.Show(noServeDish.ToString() + "\n请耐心等候！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //以下是上齐了的情况

            //orderMsg是订单信息，构造这个订单信息的字符串并打印，用于确认订单信息。
            StringBuilder orderMsg = new StringBuilder();
            orderMsg.Append("\t\t请确认订单信息\n\n");
            orderMsg.Append("订单号：" + orderNum + "\t" + "单位：人民币（元）\n");
            orderMsg.Append("---------------------------------------------------------------\n");
            orderMsg.Append("顾客：" + cusName + "\t\t" + "联系方式：" + cusTel + "\n");
            orderMsg.Append("---------------------------------------------------------------\n");
            cmd.CommandText = string.Format("select Rname from Room where Rid in (select Droomid from Desk where Did = '{0}');", deskId);
            string roomName = cmd.ExecuteScalar().ToString();
            orderMsg.Append("房间：" + roomName + "\t\t" + "餐桌：" + deskId + "\n");
            orderMsg.Append("===================================\n");
            orderMsg.Append("菜的编号\t菜的种类 \t    菜名\t\t菜价\n");
            cmd.CommandText = string.Format("select Fid from DeskMenu where Ordernum = '{0}';", orderNum);
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            sdr = cmd.ExecuteReader();
            //使用list的原因是SqlDataReader不方便两个同时使用
            List<string> Fid = new List<string>();
            while (sdr.Read())
            {
                Fid.Add(sdr["Fid"].ToString());
            }
            sdr.Dispose();
            //以下是菜的具体信息
            int foodCount = 0;//记录菜的数量
            //整理每道菜的信息
            foreach (string str in Fid)
            {
                cmd1.CommandText = string.Format("select Ftype, Fname, Fprice from Menu where Fid = '{0}'", str);
                sdr = cmd1.ExecuteReader();
                if(sdr.Read())
                {
                    orderMsg.Append("---------------------------------------------------------------\n");
                    orderMsg.Append(string.Format("{0}\t  {1}\t{2,-10}\t{3:f2}\n", str, sdr["Ftype"].ToString(), sdr["Fname"].ToString(), float.Parse(sdr["Fprice"].ToString())));
                }
                sdr.Dispose();
                foodCount++;
            }
            orderMsg.Append("===================================\n");
            orderMsg.Append(string.Format("\t\t\t共{0}道菜，总计{1:f2}元\n",foodCount,orderMoney));

            //展示确认订单信息点击确认就结账
            DialogResult result =
                MessageBox.Show(orderMsg.ToString(), "确认提示", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                return;
            }

            //以下是确认结账的情况
            //更改订单结账状态
            cmd.CommandText = string.Format("update CustomerDesk set Ifcheckout = '是' where Ordernum = '{0}';", orderNum);
            cmd.ExecuteNonQuery();

            //更新CustomerMenu表，该表用于分析客人和菜的关系
            DateTime now = DateTime.Now;
            string sqlDate = now.ToString("yyyy-MM-dd");
            foreach (string r in Fid)
            {
                StringBuilder sqlInsertCustomerMenu = new StringBuilder();
                sqlInsertCustomerMenu.Append("insert ");
                sqlInsertCustomerMenu.Append("into CustomerMenu(Ctellphone, Fid, Lastordertime, Ordercount, Ifthumbup) ");
                sqlInsertCustomerMenu.Append(string.Format("values('{0}', '{1}', '{2}', 1, '否');", cusTel, r, sqlDate));
                //原理：尝试插入记录，插入不成功则这道菜是这个客人第一次点的
                try
                {
                    cmd.CommandText = sqlInsertCustomerMenu.ToString();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    //点的次数+1，更新最后一次点的时间
                    StringBuilder sqlUpdateCustomerMenu = new StringBuilder();
                    sqlUpdateCustomerMenu.Append("update CustomerMenu ");
                    sqlUpdateCustomerMenu.Append(string.Format("set Lastordertime = '{0}', Ordercount = Ordercount + 1 ",sqlDate));
                    sqlUpdateCustomerMenu.Append(string.Format("where Ctellphone = '{0}' and Fid = '{1}';", cusTel, r));
                    cmd.CommandText = sqlUpdateCustomerMenu.ToString();
                    cmd.ExecuteNonQuery();
                }
            }

            //释放桌子和对应房间信息
            cmd.CommandText = string.Format("update Desk set Difuse = '否' where Did = '{0}';", deskId);
            cmd.ExecuteNonQuery();

            StringBuilder strUpdateRoom = new StringBuilder();
            strUpdateRoom.Append("update Room ");
            strUpdateRoom.Append("set Rusedesks = Rusedesks - 1 ");
            strUpdateRoom.Append("where Rid in ");
            strUpdateRoom.Append(" (select Droomid ");
            strUpdateRoom.Append("  from Desk ");
            strUpdateRoom.Append(string.Format("  where Did = '{0}');", deskId));
            cmd.CommandText = strUpdateRoom.ToString();
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("结账成功，请对您的订单进行评价！", "感谢", MessageBoxButtons.OK, MessageBoxIcon.Information);
            评价Form evaf = new 评价Form();
            evaf.orderNum = orderNum;
            evaf.Ctellphone = cusTel;
            evaf.Show();
            nowOrderDataView.Rows.Remove(nowOrderDataView.SelectedRows[0]);//在表格上移除
            nowMenuListBox.Items.Clear();
            cmd.Dispose();
            cmd1.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void btn点菜_Click(object sender, EventArgs e)
        {
            if (nowOrderDataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要点菜的订单！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (nowMenuListBox.Items.Count > 2)
            {
                MessageBox.Show("目前还没有追加菜单的功能！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            
            管理员点菜Form adminOrderDishForm = new 管理员点菜Form();
            adminOrderDishForm.deskNum = nowOrderDataView.SelectedCells[2].Value.ToString();
            adminOrderDishForm.nowOrderDishCustomerID = nowOrderDataView.SelectedCells[1].Value.ToString();
            adminOrderDishForm.nowOrderDishCustomerName = nowOrderDataView.SelectedCells[0].Value.ToString();
            adminOrderDishForm.Show();
        }
    }
}
