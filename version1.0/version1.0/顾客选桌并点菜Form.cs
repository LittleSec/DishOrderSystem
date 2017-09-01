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
    public partial class 顾客选桌并点菜Form : Form
    {
        public 顾客选桌并点菜Form()
        {
            InitializeComponent();

            #region 初始化桌子列表
            //禁止自动生成列
            deskDataView.AutoGenerateColumns = false;
            //创建网格控件列
            DataGridViewTextBoxColumn colDid = new DataGridViewTextBoxColumn();
            colDid.HeaderText = "桌号";
            colDid.ReadOnly = true;
            colDid.DataPropertyName = "Did";
            deskDataView.Columns.Add(colDid);

            DataGridViewTextBoxColumn colDpersoncount = new DataGridViewTextBoxColumn();
            colDpersoncount.HeaderText = "可坐人数";
            colDpersoncount.ReadOnly = true;
            colDpersoncount.DataPropertyName = "Dpersoncount";
            deskDataView.Columns.Add(colDpersoncount);

            DataGridViewCheckBoxColumn colTick = new DataGridViewCheckBoxColumn();
            colTick.HeaderText = "选择";
            colTick.ReadOnly = false;
            deskDataView.Columns.Add(colTick);
            #endregion

            #region 初始化menuDateView
            //禁止自动生成列
            menuDataView.AutoGenerateColumns = false;
            //创建网格控件列
            DataGridViewTextBoxColumn colFid = new DataGridViewTextBoxColumn();
            colFid.HeaderText = "菜编号";
            colFid.DataPropertyName = "Fid";
            menuDataView.Columns.Add(colFid);

            DataGridViewTextBoxColumn colFtype = new DataGridViewTextBoxColumn();
            colFtype.HeaderText = "菜的种类";
            colFtype.DataPropertyName = "Ftype";
            menuDataView.Columns.Add(colFtype);

            DataGridViewTextBoxColumn colFname = new DataGridViewTextBoxColumn();
            colFname.HeaderText = "菜名";
            colFname.DataPropertyName = "Fname";
            menuDataView.Columns.Add(colFname);

            DataGridViewTextBoxColumn colFprice = new DataGridViewTextBoxColumn();
            colFprice.HeaderText = "菜价";
            colFprice.DataPropertyName = "Fprice";
            menuDataView.Columns.Add(colFprice);

            DataGridViewTextBoxColumn colFthumbup = new DataGridViewTextBoxColumn();
            colFthumbup.HeaderText = "被点赞的次数";
            colFthumbup.DataPropertyName = "Fthumbup";
            menuDataView.Columns.Add(colFthumbup);
            #endregion
        }

        private void 顾客选桌并点菜Form_Load(object sender, EventArgs e)
        {
            ifChooseDesk = false;//默认没选择餐桌
            roomComboBox.Items.Clear();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Room", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string Rid = sdr["Rid"].ToString();
                string Rname = sdr["Rname"].ToString();
                string Rdeskcount = sdr["Rdeskcount"].ToString();
                string Rpersoncount = sdr["Rpersoncount"].ToString();
                string Rusedesks = sdr["Rusedesks"].ToString();
                roomComboBox.Items.Add(string.Format("{0} {1,2} 总餐桌数：{2,2}，最大可容纳：{3,3}人，已经使用{4}张桌子。", Rid, Rname, Rdeskcount, Rpersoncount, Rusedesks));
            }
            sdr.Dispose();

            typeList.Items.Clear();
            typeList.Items.Add("全部");

            cmd.CommandText = "select distinct Ftype from Menu;";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                typeList.Items.Add(sdr["Ftype"].ToString());
            }
            sdr.Dispose();

            string strSqlFoodInFtype = "select Fid, Ftype, Fname, Fprice, Fthumbup from Menu order by Fthumbup desc;";
            SqlDataAdapter adt = new SqlDataAdapter(strSqlFoodInFtype, conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            menuDataView.DataSource = dt;

            adt.Dispose();
            dt.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void SelectRoomToSeeUseableDesks(object sender, EventArgs e)
        {
            deskGroupBox.Enabled = true;
            string tempRoom = roomComboBox.SelectedItem.ToString();
            string Fid = tempRoom.Substring(0, 4);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            string sqlSelect = string.Format
                ("select Did, Dpersoncount from Desk where Droomid = '{0}' and Difuse = '否';", Fid);
            SqlDataAdapter adtDesk = new SqlDataAdapter(sqlSelect, conn);
            DataTable dtDesk = new DataTable();
            adtDesk.Fill(dtDesk);
            deskDataView.DataSource = dtDesk;
            dtDesk.Dispose();
            adtDesk.Dispose();
            conn.Dispose();
            conn.Close();
        }

        //勾选全选
        private void allDesksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allDesksCheckBox.Checked)
            {
                for (int i = 0; i < deskDataView.Rows.Count; i++)
                {
                    deskDataView.Rows[i].Cells[2].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < deskDataView.Rows.Count; i++)
                {
                    deskDataView.Rows[i].Cells[2].Value = false;
                }
            }
            panel1.Enabled = true;
            typeGroupBox.Enabled = true;
            foodGroupBox.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void SearchFoodInThisType(object sender, EventArgs e)
        {
            menuDataView.ClearSelection();
            string strSelectFtype = typeList.SelectedItem.ToString();
            string strSqlFoodInFtype;
            if (strSelectFtype == "全部")
            {
                strSqlFoodInFtype = "select Fid, Ftype, Fname, Fprice, Fcooktime, Fthumbup from Menu order by Fthumbup desc;";
            }
            else
            {
                strSqlFoodInFtype =
                    string.Format("select * from Menu where Ftype = '{0}' order by Fthumbup desc;", strSelectFtype);
            }

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlDataAdapter adt = new SqlDataAdapter(strSqlFoodInFtype, conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            menuDataView.DataSource = dt;

            adt.Dispose();
            dt.Dispose();
            conn.Close();
        }

        private void 快速查找btn_Click(object sender, EventArgs e)
        {
            string quickSearchStr = 查找TextBox.Text.ToString().Trim();
            bool flat = false;
            foreach (DataGridViewRow r in menuDataView.Rows)
            {
                if (r.Cells[2].Value.ToString() == quickSearchStr)//通过名字查询
                {
                    menuDataView.CurrentCell = r.Cells[0];
                    flat = true;
                    break;
                }
                else if (r.Cells[0].Value.ToString() == quickSearchStr)//通过菜编号
                {
                    menuDataView.CurrentCell = r.Cells[0];
                    flat = true;
                    break;
                }
            }
            if (!flat)
            {
                int index = 0;
                foreach (string str in typeList.Items)
                {
                    if (str == quickSearchStr)
                    {
                        typeList.SelectedIndex = index;
                        flat = true;
                        break;
                    }
                    index++;
                }
            }
            if (!flat)
            {
                MessageBox.Show("找不到对象！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<Dish> tempDish = new List<Dish>();//记录已经点了的菜
        public int count { get; set; }//记录选了多少道菜
        public float orderMoney { get; set; }//记录当前的价格
        public string orderNum { get; set; }
        public string deskNum { get; set; }
        public string roodNum { get; set; }
        public string nowOrderDishCustomerID { get; set; }
        public string nowOrderDishCustomerName { get; set; }
        public string sqlDate { get; set; }

        public bool ifChooseDesk { get; set; }
        private void AddFoodToList(object sender, DataGridViewCellEventArgs e)
        {
            if (ifChooseDesk == false)
            {
                for (int i = 0; i < deskDataView.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)deskDataView.Rows[i].Cells[2];
                    Boolean flag = Convert.ToBoolean(checkCell.Value);
                    if (flag == true)
                    {
                        deskNum = deskDataView.Rows[i].Cells[0].Value.ToString();//先记录第一张勾选的桌子号码
                        ifChooseDesk = true;
                        break;
                    }
                }
            }
            if (ifChooseDesk == false)//还没选桌子
            {
                MessageBox.Show("请选择餐桌！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Dish selDish = new Dish { };
            selDish.foodID = menuDataView.SelectedCells[0].Value.ToString();
            selDish.foodType = menuDataView.SelectedCells[1].Value.ToString();

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            string sqlSelectFcooktime =
                string.Format("select Fcooktime from Menu where Fid = '{0}'", selDish.foodID);
            SqlCommand cmd = new SqlCommand(sqlSelectFcooktime, conn);
            selDish.cookTime = int.Parse(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            conn.Close();
            selDish.orderNum = orderNum;
            selDish.deskID = deskNum;
            string strSelFname = menuDataView.SelectedCells[2].Value.ToString();
            float selFmoney = float.Parse(menuDataView.SelectedCells[3].Value.ToString());
            if (selDish.foodID == "")
            {
                MessageBox.Show("请选择（双击）菜！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tempDish.Contains(selDish))
            {
                MessageBox.Show("目前不支持重复点菜功能！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            orderDishListBox.Items.Add(string.Format("{0,6} {1,-10}\t{2,5:f2}", selDish.foodID, strSelFname, selFmoney));
            tempDish.Add(selDish);
            count++;
            orderMoney += selFmoney;
            summaryLabel.Text = string.Format("已选{0}道菜，共计：{1}元", count, orderMoney);
        }

        private void RemoveFoodFromList(object sender, EventArgs e)
        {
            if (orderDishListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("请双击要移除的菜！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (orderDishListBox.SelectedIndex == 0)//双击目录有毒
            {
                return;
            }
            string strSel = orderDishListBox.SelectedItem.ToString();
            string[] strSelInPieces = strSel.Split();
            for (int i = 0; i < tempDish.Count; i++)
            {
                if (tempDish[i].foodID == strSelInPieces[0])
                {
                    tempDish.Remove(tempDish[i]);
                    break;
                }
            }
            orderDishListBox.Items.Remove(orderDishListBox.SelectedItem);
            count--;
            orderMoney -= float.Parse(strSelInPieces[strSelInPieces.Length - 1]);
            summaryLabel.Text = string.Format("已选{0}道菜，共计：{1}元", count, orderMoney);
        }

        private bool ReasonableCheck()
        {
            if (roomComboBox.SelectedItem.ToString() == "")
            {
                MessageBox.Show("请选择房间和餐桌！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            roodNum = roomComboBox.SelectedItem.ToString().Substring(0, 4);

            if (tempDish.Count == 0)
            {
                MessageBox.Show("请点菜！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            if (ReasonableCheck() == false)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            DialogResult result = DialogResult.Cancel;
            int successOrderCount = 0;

            for (int j = 0; j < deskDataView.Rows.Count; j++)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)deskDataView.Rows[j].Cells[2];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    List<Dish> dish = new List<Dish>();
                    deskNum = deskDataView.Rows[j].Cells[0].Value.ToString();
                    orderNum = ControlOrderClass.GetNowOrderNum();
                    for (int k = 0; k < tempDish.Count; k++)
                    {
                        Dish temp = tempDish[k];
                        temp.deskID = deskNum;
                        temp.orderNum = orderNum;
                        dish.Add(temp);
                    }
                    
                    //orderMsg是订单信息，构造这个订单信息的字符串并打印，用于确认订单信息。
                    StringBuilder orderMsg = new StringBuilder();
                    orderMsg.Append("\t\t请确认订单信息\n\n");
                    orderMsg.Append("订单号：" + orderNum + "\t" + "单位：人民币（元）\n");
                    orderMsg.Append("---------------------------------------------------------------\n");
                    orderMsg.Append("顾客：" + nowOrderDishCustomerName + "\t\t" + "联系方式：" + nowOrderDishCustomerID + "\n");
                    orderMsg.Append("---------------------------------------------------------------\n");
                    cmd.CommandText = string.Format("select Rname from Room where Rid in (select Droomid from Desk where Did = '{0}');", deskNum);
                    string roomName = cmd.ExecuteScalar().ToString();
                    orderMsg.Append("房间：" + roomName + "\t\t" + "餐桌：" + deskNum + "\n");
                    orderMsg.Append("===================================\n");
                    orderMsg.Append("菜的编号\t菜的种类 \t    菜名\t\t菜价\n");

                    //以下是菜的具体信息
                    for (int i = 0; i < tempDish.Count; i++)
                    {
                        cmd.CommandText = string.Format("select Fname, Fprice from Menu where Fid = '{0}';", tempDish[i].foodID);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        string tempFoodNname = "";
                        float tempFoodPrice = 0;
                        if (sdr.Read())
                        {
                            tempFoodNname = sdr["Fname"].ToString();
                            tempFoodPrice = float.Parse(sdr["Fprice"].ToString());
                        }
                        orderMsg.Append("---------------------------------------------------------------\n");
                        orderMsg.Append(string.Format("{0}\t  {1}\t{2,-10}\t{3:f2}\n", tempDish[i].foodID, tempDish[i].foodType, tempFoodNname, tempFoodPrice));
                        sdr.Dispose();
                        sdr.Close();
                    }

                    orderMsg.Append("===================================\n");
                    orderMsg.Append(string.Format("\t\t\t已选{0}道菜，总计{1:f2}元\n", count, orderMoney));

                    DateTime now = DateTime.Now;
                    sqlDate = now.ToString("yyyy-MM-dd");//当天的
                    result =
                        MessageBox.Show(orderMsg.ToString(), "确认提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        StringBuilder strSQLinsert = new StringBuilder();
                        strSQLinsert.Append("insert ");
                        strSQLinsert.Append("into CustomerDesk(Ctellphone, Did, Ordernum, Orderdate, Ifcheckout, Ordermoney) ");
                        strSQLinsert.Append(
                            string.Format
                            ("values('{0}','{1}','{2}','{3}','否',{4});", nowOrderDishCustomerID, deskNum, orderNum, sqlDate, orderMoney));
                        cmd.CommandText = strSQLinsert.ToString();
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = string.Format("update Desk set Difuse = '是' where Did = '{0}';", deskNum);
                        cmd.ExecuteNonQuery();

                        StringBuilder strUpdateRoom = new StringBuilder();
                        strUpdateRoom.Append("update Room ");
                        strUpdateRoom.Append("set Rusedesks = Rusedesks + 1 ");
                        strUpdateRoom.Append("where Rid in ");
                        strUpdateRoom.Append(" (select Droomid ");
                        strUpdateRoom.Append("  from Desk ");
                        strUpdateRoom.Append(string.Format("  where Did = '{0}');", deskNum));
                        cmd.CommandText = strUpdateRoom.ToString();
                        cmd.ExecuteNonQuery();

                        for (int i = 0; i < dish.Count; i++)
                        {
                            ControlOrderClass.GetDish(dish[i]);
                            StringBuilder strSQLinsertDeskMenu = new StringBuilder();
                            strSQLinsertDeskMenu.Append("insert ");
                            strSQLinsertDeskMenu.Append("into DeskMenu(Did, Fid, Ordernum, Ifservedish) ");
                            strSQLinsertDeskMenu.Append(
                                string.Format("values('{0}', '{1}', '{2}', '否')"
                                    , dish[i].deskID, dish[i].foodID, dish[i].orderNum));
                            cmd.CommandText = strSQLinsertDeskMenu.ToString();
                            cmd.ExecuteNonQuery();
                        }
                        successOrderCount++;
                    }//END if 点击确认正式下单并更新后台数据库 
                }//END if 桌子为勾选状态
            }//END for 每张桌子


            MessageBox.Show("成功提交" + successOrderCount + "个订单，请耐心等候！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            orderDishListBox.Items.Clear();
            orderDishListBox.Items.Add("菜编号    菜名        菜价");
            count = 0;
            orderMoney = 0;
            summaryLabel.Text = string.Format("已选{0}道菜，共计：{1}元", count, orderMoney);
            cmd.Dispose();
            conn.Dispose();
            conn.Close();
            tempDish.Clear();
            this.Close();
        }

        private void OtherToolEnable(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel1.Enabled = true;
            typeGroupBox.Enabled = true;
            foodGroupBox.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void btn模糊查询_Click(object sender, EventArgs e)
        {
            string tempFname = 查找TextBox.Text.ToString().Trim();
            if (tempFname == "")
            {
                MessageBox.Show("找不到对象！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string sqlFname = "%" + tempFname + "%";
            menuDataView.ClearSelection();

            string sqlSelect =
                string.Format("select * from Menu where Fname like '{0}' order by Fthumbup desc;", sqlFname);

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlDataAdapter adt = new SqlDataAdapter(sqlSelect, conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            menuDataView.DataSource = dt;

            adt.Dispose();
            dt.Dispose();
            conn.Close(); 
        }
    }
}