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
    public partial class 职工信息Form : Form
    {
        public 职工信息Form()
        {
            InitializeComponent();

            #region 初始化waiterDataView
            //禁止自动生成列
            waiterDataView.AutoGenerateColumns = false;
            //创建网格控件列
            DataGridViewTextBoxColumn colWid = new DataGridViewTextBoxColumn();
            colWid.HeaderText = "工号";
            colWid.DataPropertyName = "Wid";
            waiterDataView.Columns.Add(colWid);

            DataGridViewTextBoxColumn colWname = new DataGridViewTextBoxColumn();
            colWname.HeaderText = "姓名";
            colWname.DataPropertyName = "Wname";
            waiterDataView.Columns.Add(colWname);

            DataGridViewTextBoxColumn colWsex = new DataGridViewTextBoxColumn();
            colWsex.HeaderText = "性别";
            colWsex.DataPropertyName = "Wsex";
            waiterDataView.Columns.Add(colWsex);

            DataGridViewTextBoxColumn colWifwork = new DataGridViewTextBoxColumn();
            colWifwork.HeaderText = "工作状态";
            colWifwork.DataPropertyName = "Wifwork";
            waiterDataView.Columns.Add(colWifwork);
            #endregion

            #region 初始化chrefDataView
            //禁止自动生成列
            chrefDataView.AutoGenerateColumns = false;
            //创建网格控件列
            DataGridViewTextBoxColumn colCOid = new DataGridViewTextBoxColumn();
            colCOid.HeaderText = "工号";
            colCOid.DataPropertyName = "COid";
            chrefDataView.Columns.Add(colCOid);

            DataGridViewTextBoxColumn colCOname = new DataGridViewTextBoxColumn();
            colCOname.HeaderText = "姓名";
            colCOname.DataPropertyName = "COname";
            chrefDataView.Columns.Add(colCOname);

            DataGridViewTextBoxColumn colCOsex = new DataGridViewTextBoxColumn();
            colCOsex.HeaderText = "性别";
            colCOsex.DataPropertyName = "COsex";
            chrefDataView.Columns.Add(colCOsex);

            DataGridViewTextBoxColumn colCOjob = new DataGridViewTextBoxColumn();
            colCOjob.HeaderText = "分工";
            colCOjob.DataPropertyName = "COjob";
            chrefDataView.Columns.Add(colCOjob);

            DataGridViewTextBoxColumn colCOifwork = new DataGridViewTextBoxColumn();
            colCOifwork.HeaderText = "工作状态";
            colCOifwork.DataPropertyName = "COifwork";
            chrefDataView.Columns.Add(colCOifwork);

            DataGridViewTextBoxColumn colCObethumbup = new DataGridViewTextBoxColumn();
            colCObethumbup.HeaderText = "被点赞次数";
            colCObethumbup.DataPropertyName = "CObethumbup";
            chrefDataView.Columns.Add(colCObethumbup);

            #endregion
        }
        

        private void 职工信息Form_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlDataAdapter adtWaiter = new SqlDataAdapter("select * from Waiter;", conn);
            DataTable dtWaiter = new DataTable();
            adtWaiter.Fill(dtWaiter);
            waiterDataView.DataSource = dtWaiter;
            dtWaiter.Dispose();
            adtWaiter.Dispose();

            SqlDataAdapter adtChref = new SqlDataAdapter("select * from Chref order by CObethumbup desc;", conn);
            DataTable dtChref = new DataTable();
            adtChref.Fill(dtChref);
            chrefDataView.DataSource = dtChref;
            dtChref.Dispose();
            adtChref.Dispose();

            conn.Close();
        }

        private void 解雇服务员btn_Click(object sender, EventArgs e)
        {
            if (waiterDataView.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择要删除的服务员！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            int count = 0;//记录成功删除的数量
            DialogResult result = MessageBox.Show("确定要解雇这些服务员？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow r in waiterDataView.SelectedRows)
                {
                    string strDelWid = r.Cells[0].Value.ToString();//获取要删除的餐桌号
                    if (r.Cells[3].Value.ToString() == "繁忙")
                    {
                        DialogResult res =
                            MessageBox.Show
                            ("工号为：" + strDelWid + "的服务员正在工作。\n请问是否让其停工并解雇？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(res == DialogResult.Yes)
                        {
                            continue;
                        }   
                    }
                    string SqlDel = string.Format("delete from Waiter where Wid = '{0}';", strDelWid);//sql删除语句

                    //在数据库中移除
                    SqlCommand cmd1 = new SqlCommand(SqlDel, conn);
                    if(cmd1.ExecuteNonQuery() > 0)
                    {
                        waiterDataView.Rows.Remove(r);//在表中移除
                        count++;
                        //MessageBox.Show("餐桌" + strDelDid + "已删除！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cmd1.Dispose();
                }//END foreach
                MessageBox.Show("已解雇" + count.ToString() + "名服务员", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Dispose();
            conn.Close();
        }

        private void 雇佣服务员btn_Click(object sender, EventArgs e)
        {
            雇佣厨师或服务员Form addForm = new 雇佣厨师或服务员Form();
            addForm.flat = 0;
            addForm.Show();
        }

        private void btn雇佣厨师_Click(object sender, EventArgs e)
        {
            雇佣厨师或服务员Form addForm = new 雇佣厨师或服务员Form();
            addForm.flat = 1;
            addForm.Show();
        }

        private void 编辑服务员btn_Click(object sender, EventArgs e)
        {
            int selectCount = 0;
            foreach (DataGridViewRow r in waiterDataView.SelectedRows)
            {
                selectCount++;
            }
            if (selectCount > 1)
            {
                MessageBox.Show("一次只能编辑一位职工！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (selectCount == 0)
            {
                MessageBox.Show("请选择要编辑的职工！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            修改职工信息Form updateWaiterForm = new 修改职工信息Form();
            updateWaiterForm.ID = waiterDataView.SelectedCells[0].Value.ToString();
            updateWaiterForm.oldName = waiterDataView.SelectedCells[1].Value.ToString();
            updateWaiterForm.sex = waiterDataView.SelectedCells[2].Value.ToString();
            updateWaiterForm.flat = 0;
            updateWaiterForm.Show();
        }

        private void 编辑厨师btn_Click(object sender, EventArgs e)
        {
            if (chrefDataView.SelectedRows.Count > 1)
            {
                MessageBox.Show("一次只能编辑一位职工！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (chrefDataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要编辑的职工！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            修改职工信息Form updateChrefForm = new 修改职工信息Form();
            updateChrefForm.ID = chrefDataView.SelectedCells[0].Value.ToString();
            updateChrefForm.oldName = chrefDataView.SelectedCells[1].Value.ToString();
            updateChrefForm.sex = chrefDataView.SelectedCells[2].Value.ToString();
            updateChrefForm.oldJob = chrefDataView.SelectedCells[3].Value.ToString();
            updateChrefForm.flat = 1;
            updateChrefForm.Show();
        }

        private void 解雇厨师btn_Click(object sender, EventArgs e)
        {
            if (chrefDataView.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择要删除的厨师！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            DialogResult result = 
                MessageBox.Show("确定要解雇该厨师？\n删除后会删除其做菜历史记录！", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                string strDelCOid = chrefDataView.SelectedRows[0].Cells[0].Value.ToString();//获取要删除的厨师号
                if (chrefDataView.SelectedCells[3].Value.ToString() == "繁忙")
                {
                    MessageBox.Show
                        ("该厨师正在工作。\n拒绝删除！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }
                string SqlDel = string.Format("delete from Chref where COid = '{0}';", strDelCOid);//sql删除语句

                //在数据库中移除，注意要移除ChrefMenu表相应的数据
                SqlCommand cmd1 = new SqlCommand(SqlDel, conn);
                cmd1.ExecuteNonQuery();
                cmd1.CommandText = string.Format("delete from ChrefMenu where COid = '{0}';", strDelCOid);
                if (cmd1.ExecuteNonQuery() > 0)
                {
                     chrefDataView.Rows.Remove(chrefDataView.SelectedRows[0]);//在表中移除
                }
                cmd1.Dispose();  
            }
            conn.Dispose();
            conn.Close();
        }

        private void ChooseChrefToSeeHisWorkRecord(object sender, DataGridViewCellEventArgs e)
        {
            //不需要判断是否选择多行，因为这是单击某行才会发生的，选择多行不属于单击
            string chrefID = chrefDataView.SelectedCells[0].Value.ToString();

            StringBuilder sqlSelectCherfMenu = new StringBuilder();
            sqlSelectCherfMenu.Append("select COid, ChrefMenu.Fid, Fname, Ordernum, Ifthumbup ");
            sqlSelectCherfMenu.Append("from ChrefMenu, Menu ");
            sqlSelectCherfMenu.Append(string.Format("where COid = '{0}' and ChrefMenu.Fid = Menu.Fid;", chrefID));

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlSelectCherfMenu.ToString(), conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            chrefMenuDataView.DataSource = dt;

            sda.Dispose();
            dt.Dispose();
            conn.Dispose();
            conn.Close();
        }
    }
}
