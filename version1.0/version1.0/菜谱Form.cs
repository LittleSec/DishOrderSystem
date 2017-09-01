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
    public partial class 菜谱Form : Form
    {
        public 菜谱Form()
        {
            InitializeComponent();

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

            DataGridViewTextBoxColumn colFcooktime = new DataGridViewTextBoxColumn();
            colFcooktime.HeaderText = "烹饪时长";
            colFcooktime.DataPropertyName = "Fcooktime";
            menuDataView.Columns.Add(colFcooktime);

            DataGridViewTextBoxColumn colFthumbup = new DataGridViewTextBoxColumn();
            colFthumbup.HeaderText = "被点赞的次数";
            colFthumbup.DataPropertyName = "Fthumbup";
            menuDataView.Columns.Add(colFthumbup);
            #endregion

            #region 初始化点过这道菜的客人CusMenuDataView
            //禁止自动生成列
            CusMenuDataView.AutoGenerateColumns = false;
            //创建网格控件列
            DataGridViewTextBoxColumn colCname = new DataGridViewTextBoxColumn();
            colCname.HeaderText = "客人信息";
            colCname.DataPropertyName = "Cname";
            CusMenuDataView.Columns.Add(colCname);

            DataGridViewTextBoxColumn colLastordertime = new DataGridViewTextBoxColumn();
            colLastordertime.HeaderText = "最后一次点的日期";
            colLastordertime.DataPropertyName = "Lastordertime";
            CusMenuDataView.Columns.Add(colLastordertime);

            DataGridViewTextBoxColumn colOrdercount = new DataGridViewTextBoxColumn();
            colOrdercount.HeaderText = "点的次数";
            colOrdercount.DataPropertyName = "Ordercount";
            CusMenuDataView.Columns.Add(colOrdercount);

            DataGridViewTextBoxColumn colIfthumbup = new DataGridViewTextBoxColumn();
            colIfthumbup.HeaderText = "是否已点赞";
            colIfthumbup.DataPropertyName = "Ifthumbup";
            CusMenuDataView.Columns.Add(colIfthumbup);

            #endregion

            groupBox3.Enabled = false;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            typeList.Items.Clear();
            typeList.Items.Add("全部");
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select distinct Ftype from Menu;", conn);

            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                typeList.Items.Add(sdr["Ftype"].ToString());
            }
            sdr.Dispose();

            string strSqlFoodInFtype = "select Fid, Ftype, Fname, Fprice, Fcooktime, Fthumbup from Menu order by Fthumbup desc;";
            SqlDataAdapter adt = new SqlDataAdapter(strSqlFoodInFtype, conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            menuDataView.DataSource = dt;

            adt.Dispose();
            dt.Dispose();
            conn.Close();
        }

        /// <summary>
        /// 选择菜的种类后，会自动显示该种类下有什么具体的菜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 选择菜后，会自动显示该点过该菜的顾客即相关信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectMenuShowCustomer(object sender, DataGridViewCellEventArgs e)
        {
            string Fid = menuDataView.SelectedCells[0].Value.ToString();
            string strSqlCustomerMenu =
                string.Format("select Cname, Lastordertime, Ordercount, Ifthumbup from CustomerMenu, Customer where Fid = '{0}' and CustomerMenu.Ctellphone = Customer.Ctellphone;", Fid);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlDataAdapter adt = new SqlDataAdapter(strSqlCustomerMenu, conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            CusMenuDataView.DataSource = dt;
            conn.Dispose();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new 增加菜谱Form().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectCount = 0;
            foreach (DataGridViewRow r in menuDataView.SelectedRows)
            {
                selectCount++;
            }
            if (selectCount > 1)
            {
                MessageBox.Show("一次只能修改一道菜的信息！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (selectCount == 0)
            {
                MessageBox.Show("请选择要编辑的菜！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            修改菜谱Form updateMenuForm = new 修改菜谱Form();
            updateMenuForm.Fid = menuDataView.SelectedCells[0].Value.ToString();
            updateMenuForm.Ftype = menuDataView.SelectedCells[1].Value.ToString();
            updateMenuForm.Fname = menuDataView.SelectedCells[2].Value.ToString();
            updateMenuForm.Fprice = float.Parse(menuDataView.SelectedCells[3].Value.ToString());
            updateMenuForm.Fcooktime = int.Parse(menuDataView.SelectedCells[4].Value.ToString());
            updateMenuForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (menuDataView.SelectedCells.Count == 0)
            {
                MessageBox.Show("请选择要删除的菜！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            DialogResult result = MessageBox.Show("确定要删除这道菜？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                string strDelFid = menuDataView.SelectedCells[0].Value.ToString();//获取要删除的餐桌号
                string SqlDel = string.Format("delete from Menu where Fid = '{0}';", strDelFid);//sql删除语句

                //在数据库中移除
                SqlCommand cmd1 = new SqlCommand(SqlDel, conn);
                if (cmd1.ExecuteNonQuery() > 0)
                {
                    menuDataView.Rows.Remove(menuDataView.SelectedRows[0]);//在表中移除
                    MessageBox.Show("成功删除！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cmd1.Dispose();
            }
            conn.Dispose();
            conn.Close();
        }

        private void 快速查找btn_Click(object sender, EventArgs e)
        {
            string quickSearchStr = 快速查找TextBox.Text.ToString().Trim();
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

        public List<Dish> dish = new List<Dish>();//记录已经点了的菜的菜编号
        public int count { get; set; }//记录选了多少道菜
        public float orderMoney { get; set; }//记录当前的价格
        public string orderNum { get; set; }
        public string deskNum { get; set; }
        public string nowOrderDishCustomerID { get; set; }
        public string nowOrderDishCustomerName { get; set; }
        public string sqlDate { get; set; }

        /// <summary>
        /// 这里应该生成订单，及插入到两个表中！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

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
            for (int i = 0; i < dish.Count; i++)
            {
                cmd.CommandText = string.Format("select Fname, Fprice from Menu where Fid = '{0}';", dish[i].foodID);
                SqlDataReader sdr = cmd.ExecuteReader();
                string tempFoodNname = "";
                float tempFoodPrice = 0;
                if (sdr.Read())
                {
                    tempFoodNname = sdr["Fname"].ToString();
                    tempFoodPrice = float.Parse(sdr["Fprice"].ToString());
                }
                orderMsg.Append("---------------------------------------------------------------\n");
                orderMsg.Append(string.Format("{0}\t  {1}\t{2,-10}\t{3:f2}\n", dish[i].foodID, dish[i].foodType, tempFoodNname, tempFoodPrice));
                sdr.Dispose();
                sdr.Close();
            }

            orderMsg.Append("===================================\n");
            orderMsg.Append(string.Format("\t\t\t已选{0}道菜，总计{1:f2}元\n", count, orderMoney));

            DateTime now = DateTime.Now;
            sqlDate = now.ToString("yyyy-MM-dd");//当天的
            DialogResult result =
                MessageBox.Show(orderMsg.ToString(), "确认提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                StringBuilder strSQLinsert = new StringBuilder();
                strSQLinsert.Append("insert ");
                strSQLinsert.Append("into CustomerDesk(Ctellphone, Did, Ordernum, Orderdate, Ifcheckout, Ordermoney) ");
                strSQLinsert.Append(
                    string.Format
                    ("values('{0}','{1}','{2}','{3}','否',{4});",nowOrderDishCustomerID,deskNum,orderNum,sqlDate,orderMoney));
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

                MessageBox.Show("提交成功，请耐心等候！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            orderDishListBox.Items.Clear();
            orderDishListBox.Items.Add("菜编号    菜名        菜价");
            count = 0;
            orderMoney = 0;
            summaryLabel.Text = string.Format("已选{0}道菜，共计：{1}元", count, orderMoney);
            conn.Dispose();
            conn.Close();
            dish.Clear();
            groupBox3.Enabled = false;
        }

        //点击后才允许他们点菜
        private void btn点菜_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            StringBuilder strSQL = new StringBuilder();
            DateTime now = DateTime.Now;
            sqlDate = now.ToString("yyyy-MM-dd");//当天的
            strSQL.Append("select Ctellphone, Cname ");
            strSQL.Append("from Customer ");
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd0 = new SqlCommand(strSQL.ToString(), conn);
            SqlDataReader sdr = cmd0.ExecuteReader();
            while (sdr.Read())
            {
                string tempTel = sdr["Ctellphone"].ToString();
                string tempName = sdr["Cname"].ToString();
                comboBox1.Items.Add(tempTel + "\t" + tempName);
            }
            sdr.Dispose();

            cmd0.CommandText = "select Did from Desk where Difuse = '否';";
            sdr = cmd0.ExecuteReader();
            while (sdr.Read())
            {
                string tempDid = sdr["Did"].ToString();
                comboBox2.Items.Add(tempDid);
            }
            sdr.Dispose();
            sdr.Close();
            conn.Dispose();
            conn.Close();

            groupBox3.Enabled = true;
            btnSubmitOrder.Enabled = false;
            foodGroupBox.Enabled = false;
        }

        /// <summary>
        /// 选择了客人后才允许添加菜，并给当前顾客的id和姓名赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCustomerDoneShowBtn(object sender, EventArgs e)
        {
            string temp0 = comboBox1.SelectedItem.ToString();
            string[] temp1 = temp0.Split();
            nowOrderDishCustomerID = temp1[0];
            nowOrderDishCustomerName = temp1[1];    
        }

        private void SelectDeskDoneShowBtn(object sender, EventArgs e)
        {
            deskNum = comboBox2.SelectedItem.ToString();
            orderNum = ControlOrderClass.GetNowOrderNum();
            btnSubmitOrder.Enabled = true;
            foodGroupBox.Enabled = true;
        }

        private void AddFoodToList(object sender, DataGridViewCellEventArgs e)
        {
            Dish selDish = new Dish { };
            selDish.foodID = menuDataView.SelectedCells[0].Value.ToString();
            selDish.foodType = menuDataView.SelectedCells[1].Value.ToString();
            selDish.cookTime = int.Parse(menuDataView.SelectedCells[4].Value.ToString());
            selDish.orderNum = orderNum;
            selDish.deskID = deskNum;
            string strSelFname = menuDataView.SelectedCells[2].Value.ToString();
            float selFmoney = float.Parse(menuDataView.SelectedCells[3].Value.ToString());
            if (selDish.foodID == "")
            {
                MessageBox.Show("请选择（双击）菜！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dish.Contains(selDish))
            {
                MessageBox.Show("目前不支持重复点菜功能！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            orderDishListBox.Items.Add(string.Format("{0,6} {1,-10}\t{2,5:f2}", selDish.foodID, strSelFname, selFmoney));
            dish.Add(selDish);
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
            for (int i = 0; i < dish.Count; i++)
            {
                if (dish[i].foodID == strSelInPieces[0])
                {
                    dish.Remove(dish[i]);
                    break;
                }
            }
            orderDishListBox.Items.Remove(orderDishListBox.SelectedItem);
            count--;
            orderMoney -= float.Parse(strSelInPieces[strSelInPieces.Length - 1]);
            summaryLabel.Text = string.Format("已选{0}道菜，共计：{1}元", count, orderMoney);
        }

        private void btn模糊查询_Click(object sender, EventArgs e)
        {
            string tempFname = textBox模糊搜索.Text.ToString().Trim();
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
