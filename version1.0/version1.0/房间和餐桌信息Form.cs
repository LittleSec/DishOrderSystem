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
    public partial class 房间和餐桌信息Form : Form
    {
        public 房间和餐桌信息Form()
        {
            InitializeComponent();

            #region 初始化roomDateView
            //禁止自动生成列
            roomDataView.AutoGenerateColumns = false;
            //创建网格控件列
            DataGridViewTextBoxColumn colRid = new DataGridViewTextBoxColumn();
            colRid.HeaderText = "房间号";
            colRid.DataPropertyName = "Rid";
            roomDataView.Columns.Add(colRid);

            DataGridViewTextBoxColumn colRname = new DataGridViewTextBoxColumn();
            colRname.HeaderText = "房间名";
            colRname.DataPropertyName = "Rname";
            roomDataView.Columns.Add(colRname);

            DataGridViewTextBoxColumn colRdeskcount = new DataGridViewTextBoxColumn();
            colRdeskcount.HeaderText = "餐桌数";
            colRdeskcount.DataPropertyName = "Rdeskcount";
            colRdeskcount.ReadOnly = true;//餐桌数只能通过增删桌子信息修改。
            roomDataView.Columns.Add(colRdeskcount);

            DataGridViewTextBoxColumn colRpersoncount = new DataGridViewTextBoxColumn();
            colRpersoncount.HeaderText = "最大容纳人数";
            colRpersoncount.DataPropertyName = "Rpersoncount";
            colRpersoncount.ReadOnly = true;//系统自行设置。
            roomDataView.Columns.Add(colRpersoncount);

            DataGridViewTextBoxColumn colRusedesks = new DataGridViewTextBoxColumn();
            colRusedesks.HeaderText = "已使用餐桌数";
            colRusedesks.DataPropertyName = "Rusedesks";
            colRusedesks.ReadOnly = true;//已经使用的餐桌数不允许管理员修改，而是系统自行设置。
            roomDataView.Columns.Add(colRusedesks);
            #endregion

            #region 初始化deskDateView
            //禁止自动生成列
            deskDataView.AutoGenerateColumns = false;
            //创建网格控件列
            DataGridViewTextBoxColumn colDid = new DataGridViewTextBoxColumn();
            colDid.HeaderText = "餐桌号";
            colDid.DataPropertyName = "Did";
            deskDataView.Columns.Add(colDid);

            //不显示房间号，显示房间名
            DataGridViewTextBoxColumn colRname1 = new DataGridViewTextBoxColumn();
            colRname1.HeaderText = "所在房间";
            colRname1.DataPropertyName = "Rname";
            colRname1.ReadOnly = true;//系统自动设置，不能修改
            deskDataView.Columns.Add(colRname1);

            DataGridViewTextBoxColumn colDpersoncount = new DataGridViewTextBoxColumn();
            colDpersoncount.HeaderText = "容纳人数";
            colDpersoncount.DataPropertyName = "Dpersoncount";
            deskDataView.Columns.Add(colDpersoncount);

            DataGridViewTextBoxColumn colDifuse = new DataGridViewTextBoxColumn();
            colDifuse.HeaderText = "是否在用";
            colDifuse.DataPropertyName = "Difuse";
            colDifuse.ReadOnly = true;//系统自行设置。
            deskDataView.Columns.Add(colDifuse);

            #endregion
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlDataAdapter adtRoom = new SqlDataAdapter("select * from Room", conn);
            DataTable dtRoom = new DataTable();
            adtRoom.Fill(dtRoom);
            roomDataView.DataSource = dtRoom;
            dtRoom.Dispose();
            adtRoom.Dispose();

            SqlDataAdapter adtDesk = new SqlDataAdapter
                ("select Did, Rname, Dpersoncount, Difuse from Desk, Room where Droomid = Rid;",conn);
            DataTable dtDesk = new DataTable();
            adtDesk.Fill(dtDesk);
            deskDataView.DataSource = dtDesk;
            dtDesk.Dispose();
            adtDesk.Dispose();

            conn.Close();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            
            if (roomDataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的房间！", "操作提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Rid = roomDataView.SelectedCells[0].Value.ToString();

            // 如果该房间有人就餐，则拒绝删除
            int Rusedesks = int.Parse(roomDataView.SelectedCells[4].Value.ToString());
            if (Rusedesks > 0)
            {
                MessageBox.Show("房间在使用，拒绝删除！", "操作提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string Rdeskcount = roomDataView.SelectedCells[2].Value.ToString();
            string msgRoom = "该房间下有" + Rdeskcount + "张餐桌。\n";
            string msgTips = "删除房间会将该房间下所有餐桌信息删除。\n";
            string msgConfirmation = "是否需要删除？\n";
            DialogResult result = MessageBox.Show(msgRoom + msgTips + msgConfirmation, "警告", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
                conn.Open();
                //删除该房间下的所有餐桌
                string sqlDelDesk = string.Format("delete from Desk where Droomid = '{0}';", Rid);
                SqlCommand cmd = new SqlCommand(sqlDelDesk, conn);
                cmd.ExecuteNonQuery();

                //删除该房间
                cmd.CommandText = string.Format("delete from Room where Rid = '{0}';", Rid);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    roomDataView.Rows.Remove(roomDataView.SelectedRows[0]);
                }
            }  
        }

        private void btnDeleteDesk_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            int count = 0;//记录成功删除的数量
            DialogResult result = MessageBox.Show("确定要删除这些餐桌？\n删除后会自动更新对应房间信息！", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            foreach (DataGridViewRow r in deskDataView.SelectedRows)
            {
                string strDelDid = deskDataView.SelectedCells[0].Value.ToString();//获取要删除的餐桌号
                if(deskDataView.SelectedCells[3].Value.ToString() == "是")
                {
                    MessageBox.Show(strDelDid + "餐桌有客人，不允许删除", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    continue;
                }
                string SqlDel = string.Format("delete from Desk where Did = '{0}';", strDelDid);//sql删除语句
                //获取对应房间号的sql语句
                string SqlSelRid = string.Format("select Droomid from Desk where Did = '{0}';", strDelDid);
                
                //获取对应的房间号
                string strRid = "";
                SqlCommand cmd0 = new SqlCommand(SqlSelRid, conn);
                SqlDataReader sdr0 = cmd0.ExecuteReader();
                if (sdr0.Read())
                {
                    strRid = sdr0.ToString();
                }
                cmd0.Dispose();
                sdr0.Dispose();

                //更新对应房间的餐桌数和容纳人数的语句
                string SqlUpdRoomDeskCount = string.Format
                    ("update Room set Rdeskcount = (select count(*) from Desk where Droomid = '{0}') where Rid = '{0}';", strRid);
                string SqlUpdRoomPersonCount = string.Format
                    ("update Room set Rpersoncount = (select sum(Dpersoncount) from Desk where Droomid = '{0}') where Rid = '{0}';", strRid);

                if(result == DialogResult.OK)
                {
                    //在数据库中移除
                    SqlCommand cmd1 = new SqlCommand(SqlDel, conn);
                    SqlCommand cmd2 = new SqlCommand(SqlUpdRoomDeskCount, conn);
                    SqlCommand cmd3 = new SqlCommand(SqlUpdRoomPersonCount, conn);
                    //在表中移除
                    deskDataView.Rows.Remove(r);
                    count++;
                    //MessageBox.Show("餐桌" + strDelDid + "已删除！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd1.Dispose();
                    cmd2.Dispose();
                    cmd3.Dispose();
                } 
            }//END foreach
            MessageBox.Show("成功删除" + count.ToString() + "张餐桌", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Dispose();
            conn.Close();

            //应当更新Room表的dataview
        }

        private void btnAddDesk_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Rname from Room", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                房间选择ComboBox.Items.Add(sdr["Rname"].ToString());
            }
            cmd.Dispose();
            sdr.Dispose();
            conn.Dispose();
            conn.Close();
        }

        /// <summary>
        /// 当鼠标移到删除按钮时，给出删除操作的提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelDeskTips(object sender, EventArgs e)
        {
            delBtnToolTip.SetToolTip(btnDeleteDesk, "请选择要删除的餐桌的\n一整行信息，并点击我！");
        }

        private void DelRoomTips(object sender, EventArgs e)
        {
            delBtnToolTip.SetToolTip(btnDeleteRoom, "请选择要删除的房间的\n一整行信息，并点击我！");
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            flag = 1;
        }

        private void ChooseRoomToSeeDesk(object sender, DataGridViewCellEventArgs e)
        {
            string roomID = roomDataView.SelectedCells[0].Value.ToString();
            string sqlSelectDesk = string.Format
                ("select Did, Rname, Dpersoncount, Difuse from Desk, Room where Droomid = '{0}' and Droomid = Rid;",roomID);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlDataAdapter adtDesk = new SqlDataAdapter(sqlSelectDesk, conn);
            DataTable dtDesk = new DataTable();
            adtDesk.Fill(dtDesk);
            deskDataView.DataSource = dtDesk;

            dtDesk.Dispose();
            adtDesk.Dispose();
            conn.Close();
        }


        private int flag { get; set; }//0表示修改，1表示新增
        private void btnRoomUpdate_Click(object sender, EventArgs e)
        {
            if (roomDataView.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择要修改的房间！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            groupBox1.Enabled = true;
            四位房间号TextBox.Text = roomDataView.SelectedRows[0].Cells[0].Value.ToString();
            房间名TextBox.Text = roomDataView.SelectedRows[0].Cells[1].Value.ToString();
            四位房间号TextBox.Enabled = false;//不允许修改房间号
            flag = 0;
        }

        public string Rid { get; set; }
        public string Rname { get; set; }
        public bool RoomReasonableCheck()
        {
            #region 确定没有漏填或漏选
            if (四位房间号TextBox.Text == "")
            {
                MessageBox.Show("餐桌号为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (房间名TextBox.Text == "")
            {
                MessageBox.Show("请选择房间号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            #endregion

            #region 赋值对用户输入内容合法性检查
            Rid = 四位房间号TextBox.Text.Trim();
            Rname = 房间名TextBox.Text.Trim();
            if (Rid.Length > 4)
            {
                MessageBox.Show("抱歉！\n房间编号长度不正确！\n请重新输入四位编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (Rname.Length > 10)
            {
                MessageBox.Show("抱歉！\n房间名不得超过5个汉字！\n请重新输入房间名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            // 检查是否为数字
            try
            {
                Int16 temp = Convert.ToInt16(Rid);
            }
            catch
            {
                MessageBox.Show("房间编号不应当含有非数字！\n请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            #endregion

            return true;
        }
        private void 房间信息确认btn_Click(object sender, EventArgs e)
        {
            if (RoomReasonableCheck() == false)
            {
                return;
            }

            DialogResult result = DialogResult.No;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            int ifOk = 0;
            if (flag == 0)//更新
            {
                string sqlUpdate = string.Format("update Room set Rname = '{0}' where Rid = '{1}';", Rname, Rid);
                cmd.CommandText = sqlUpdate;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("操作成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string strInsert = string.Format
                    ("insert into Room(Rid, Rname, Rdeskcount, Rpersoncount, Rusedesks) values('{0}', '{1}', 0, 0, 0)",
                        Rid, Rname);
                cmd.CommandText = strInsert;
                try
                {
                    ifOk = cmd.ExecuteNonQuery();
                }
                catch(SqlException se)
                {
                    MessageBox.Show("房间号重复，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if(ifOk > 0)
                {
                    result = MessageBox.Show
                        ("添加并更新房间信息成功！\n是否需要立刻添加房间？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    groupBox1.Enabled = false;
                }
            }
            cmd.Dispose();
            conn.Dispose();
            conn.Close();
            if (result == DialogResult.Yes)
            {
                groupBox2.Enabled = true;
            }
        }

        public string Did { get; set; }
        public string Droomid { get; set; }
        public int Dpersoncount { get; set; }
        private bool DeskReasonableCheck()
        {
            #region 确定没有漏填或漏选并赋值
            if (三位餐桌号TextBox.Text == "")
            {
                MessageBox.Show("餐桌号为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            Droomid = 房间选择ComboBox.SelectedItem.ToString();
            if (Droomid == "")
            {
                MessageBox.Show("请选择房间号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (容纳人数TextBox.Text == "")
            {
                MessageBox.Show("容纳人数不能为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            Did = 三位餐桌号TextBox.Text.Trim();
            Dpersoncount = int.Parse(容纳人数TextBox.Text.ToString().Trim());
            #endregion

            #region 对用户输入内容合法性检查
            if (Did.Length > 3)
            {
                MessageBox.Show("抱歉！\n餐桌编号长度不正确！\n请重新输入三位编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            // 检查是否为数字，不对容纳人数做是否为数字的检查
            try
            {
                Int16 temp = Convert.ToInt16(Did);
            }
            catch
            {
                MessageBox.Show("餐桌编号不应当含有非数字！\n请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            #endregion

            Did = Droomid + Did;
            return true;
        }
        private void btn餐桌信息确认_Click(object sender, EventArgs e)
        {
            if (DeskReasonableCheck() == false)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd0 = new SqlCommand(string.Format("select * from Desk where Did = '{0}'", Did), conn);
            SqlDataReader sdr0 = cmd0.ExecuteReader();
            if (sdr0.Read())
            {
                MessageBox.Show("房间号重复，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sdr0.Dispose();
            }
            else
            {
                sdr0.Dispose();
                string strInsert = string.Format
                    ("insert into Desk(Did, Droomid, Dpersoncount, Difuse) values('{0}', '{1}', '{2}', '否')",
                        Did, Droomid, Dpersoncount);
                SqlCommand cmd1 = new SqlCommand(strInsert, conn);
                cmd1.ExecuteNonQuery();

                string SqlUpdRoomDeskCount = string.Format
                    ("update Room set Rdeskcount = (select count(*) from Desk where Droomid = '{0}') where Rid = '{0}';", Droomid);
                string SqlUpdRoomPersonCount = string.Format
                    ("update Room set Rpersoncount = (select sum(Dpersoncount) from Desk where Droomid = '{0}') where Rid = '{0}';", Droomid);
                SqlCommand cmd2 = new SqlCommand(SqlUpdRoomDeskCount, conn);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand(SqlUpdRoomPersonCount, conn);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("添加并更新房间信息成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd1.Dispose();
                cmd2.Dispose();
                cmd3.Dispose();
            }
            groupBox2.Enabled = false;
            cmd0.Dispose();
            conn.Dispose();
            conn.Close();
        }
    }
}
