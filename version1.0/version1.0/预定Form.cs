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
    public partial class 预定Form : Form
    {
        public 预定Form()
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
        }

        private void 预定Form_Load(object sender, EventArgs e)
        {
            roomComboBox.Items.Clear();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Rid, Rname from Room", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string Rid = sdr["Rid"].ToString();
                string Rname = sdr["Rname"].ToString();
                roomComboBox.Items.Add(string.Format("{0}  {1}", Rid, Rname));
            }
            sdr.Dispose();
            conn.Dispose();
            conn.Close();

            DateTime now = DateTime.Now;
            bookDatePicker.MinDate = now.Date;//不允许选之前的日期
        }

        public string nowOrderDishCustomerID { get; set; }

        private void SelectRoomToChooseDesks(object sender, EventArgs e)
        {
            deskGroupBox.Enabled = true;
            string tempRoom = roomComboBox.SelectedItem.ToString();
            string Did = tempRoom.Substring(0, 4);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            string sqlSelect = string.Format
                ("select Did, Dpersoncount from Desk where Droomid = '{0}';", Did);
            SqlDataAdapter adtDesk = new SqlDataAdapter(sqlSelect, conn);
            DataTable dtDesk = new DataTable();
            adtDesk.Fill(dtDesk);
            deskDataView.DataSource = dtDesk;
            dtDesk.Dispose();
            adtDesk.Dispose();
            conn.Dispose();
            conn.Close();
        }

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
        }

        private void bookDatePicker_ValueChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void btn预约_Click(object sender, EventArgs e)
        {
            if (panel1.Enabled == false || roomComboBox.SelectedItem.ToString() == "")
            {
                MessageBox.Show("请选择房间和餐桌！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            for (int j = 0; j < deskDataView.Rows.Count; j++)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)deskDataView.Rows[j].Cells[2];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    List<Dish> dish = new List<Dish>();
                    string deskNum = deskDataView.Rows[j].Cells[0].Value.ToString();
                    string orderNum = ControlOrderClass.GetNowOrderNum(bookDatePicker.Value.Date);
                    
                    string sqlDate = bookDatePicker.Value.Date.ToString("yyyy-MM-dd");//当天的

                    StringBuilder strSQLinsert = new StringBuilder();
                    strSQLinsert.Append("insert ");
                    strSQLinsert.Append("into CustomerDesk(Ctellphone, Did, Ordernum, Orderdate, Ifcheckout, Ordermoney) ");
                    strSQLinsert.Append(
                        string.Format
                        ("values('{0}','{1}','{2}','{3}','否', 0);", nowOrderDishCustomerID, deskNum, orderNum, sqlDate));
                    cmd.CommandText = strSQLinsert.ToString();
                    cmd.ExecuteNonQuery();
                }//END if 桌子为勾选状态
            }//END for 每张桌子

            MessageBox.Show("预定成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Dispose();
            conn.Dispose();
            conn.Close();

            this.Close();
        }
    }
}
