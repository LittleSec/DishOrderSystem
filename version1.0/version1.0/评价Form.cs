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
    public partial class 评价Form : Form
    {
        public 评价Form()
        {
            InitializeComponent();

            #region 初始化点赞表
            //禁止自动生成列
            dataViewDish.AutoGenerateColumns = false;
            //创建网格控件列
            DataGridViewTextBoxColumn colFid = new DataGridViewTextBoxColumn();
            colFid.HeaderText = "菜编号";
            colFid.DataPropertyName = "Fid";
            colFid.ReadOnly = true;
            dataViewDish.Columns.Add(colFid);

            DataGridViewTextBoxColumn colFname = new DataGridViewTextBoxColumn();
            colFname.HeaderText = "菜名";
            colFname.DataPropertyName = "Fname";
            colFname.ReadOnly = true;
            dataViewDish.Columns.Add(colFname);

            DataGridViewCheckBoxColumn colTick = new DataGridViewCheckBoxColumn();
            colTick.HeaderText = "点赞";
            colTick.ReadOnly = false;
            dataViewDish.Columns.Add(colTick);
            #endregion

            label1.Text = "订单号：" + orderNum;
        }
        public string orderNum { get; set; }
        public string Ctellphone { get; set; }
        private void 评价Form_Load(object sender, EventArgs e)
        {
            StringBuilder strSqlSelect = new StringBuilder();
            strSqlSelect.Append("select DeskMenu.Fid, Fname ");
            strSqlSelect.Append("from Menu, DeskMenu ");
            strSqlSelect.Append(string.Format("where Ordernum = '{0}' and DeskMenu.Fid = Menu.Fid;", orderNum));

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlDataAdapter adt = new SqlDataAdapter(strSqlSelect.ToString(), conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataViewDish.DataSource = dt;

            adt.Dispose();
            dt.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void allDishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allDesksCheckBox.Checked)
            {
                for (int i = 0; i < dataViewDish.Rows.Count; i++)
                {
                    dataViewDish.Rows[i].Cells[2].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dataViewDish.Rows.Count; i++)
                {
                    dataViewDish.Rows[i].Cells[2].Value = false;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            for (int j = 0; j < dataViewDish.Rows.Count; j++)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataViewDish.Rows[j].Cells[2];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    string Fid = dataViewDish.Rows[j].Cells[0].Value.ToString();
                    StringBuilder sqlUpdateCusMenu = new StringBuilder();
                    sqlUpdateCusMenu.Append("update CustomerMenu ");
                    sqlUpdateCusMenu.Append("set Ifthumbup = '是' ");
                    sqlUpdateCusMenu.Append(string.Format("where Ctellphone = '{0}' and Fid = '{1}';", Ctellphone, Fid));
                    cmd.CommandText = sqlUpdateCusMenu.ToString();
                    cmd.ExecuteNonQuery();

                    StringBuilder sqlUpdateChrefMenu = new StringBuilder();
                    sqlUpdateChrefMenu.Append("update ChrefMenu ");
                    sqlUpdateChrefMenu.Append("set Ifthumbup = '是' ");
                    sqlUpdateChrefMenu.Append(string.Format("where Fid = '{0}' and Ordernum = '{1}';", Fid, orderNum));
                    cmd.CommandText = sqlUpdateChrefMenu.ToString();
                    cmd.ExecuteNonQuery();

                    StringBuilder sqlUpdateMenu = new StringBuilder();
                    sqlUpdateMenu.Append("update Menu ");
                    sqlUpdateMenu.Append("set Fthumbup = Fthumbup + 1 ");
                    sqlUpdateMenu.Append(string.Format("where Fid = '{0}';", Fid));
                    cmd.CommandText = sqlUpdateMenu.ToString();
                    cmd.ExecuteNonQuery();
                }//END if 菜为勾选状态
            }//END for 每道菜

            cmd.Dispose();
            conn.Dispose();
            conn.Close();
            MessageBox.Show("感谢您的评价，欢迎下次光临！", "感谢", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
