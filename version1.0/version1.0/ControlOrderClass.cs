using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Data.SqlClient;

namespace version0._1
{
    public struct Dish
    {
        public string foodID;
        public string foodType;
        public string orderNum;
        public string deskID;
        public int cookTime;
        public Timer countDown;
        public Dish(Dish temp)
        {
            foodID = temp.foodID;
            foodType = temp.foodType;
            orderNum = temp.orderNum;
            deskID = temp.deskID;
            cookTime = temp.cookTime;
            countDown = new Timer();
            countDown.Interval = cookTime * 1000;
            countDown.Enabled = false;
            countDown.AutoReset = false;//执行一次就好
        }
    }

    public class Chref
    {
        public string chrefID { get; set; }
        public string chrefIfWorking { get; set; }
        public int cookQueueIndex { get; set; }//记录该厨师能从哪个队列中取材并做菜
        Dish nowCookingDish;

        public Chref(string chrefID, string chrefIfWorking, int cookQueueIndex)
        {
            this.chrefID = chrefID;
            this.chrefIfWorking = chrefIfWorking;
            this.cookQueueIndex = cookQueueIndex;
        }

        public void Cooking(Queue<Dish>[] waitingCookQueue)
        {
            if (waitingCookQueue[cookQueueIndex].Count == 0)
            {
                return;
            }
            if (chrefIfWorking == "繁忙")
            {
                return;
            }
            chrefIfWorking = "繁忙";
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            string sqlUp = string.Format("update Chref set COifwork = '繁忙' where COid = '{0}'", chrefID);
            SqlCommand cmd = new SqlCommand(sqlUp, conn);
            cmd.ExecuteNonQuery();
            nowCookingDish = (Dish)waitingCookQueue[cookQueueIndex].Dequeue();
            nowCookingDish.countDown.Interval = 500 * nowCookingDish.cookTime;
            nowCookingDish.countDown.Enabled = true;
            nowCookingDish.countDown.AutoReset = false;
            nowCookingDish.countDown.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            nowCookingDish.countDown.Start();
            chrefIfWorking = "空闲";
            cmd.CommandText = string.Format("update Chref set COifwork = '空闲' where COid = '{0}'", chrefID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();//打开连接

            #region sql操作
            StringBuilder strSQL0 = new StringBuilder();
            strSQL0.Append("update DeskMenu ");
            strSQL0.Append("set Ifservedish = '是' ");
            strSQL0.Append(string.Format("where Did = '{0}' ", nowCookingDish.deskID));
            strSQL0.Append(string.Format("and Fid = '{0}' ", nowCookingDish.foodID));
            strSQL0.Append(string.Format("and Ordernum = '{0}';", nowCookingDish.orderNum));
            SqlCommand cmd0 = new SqlCommand(strSQL0.ToString(), conn);
            cmd0.ExecuteNonQuery();
            cmd0.Dispose();

            StringBuilder strSQL1 = new StringBuilder();
            strSQL1.Append("insert ");
            strSQL1.Append("into ChrefMenu(COid, Fid, Ordernum, Ifthumbup) ");
            strSQL1.Append(string.Format("values('{0}', '{1}', '{2}', '否');", chrefID, nowCookingDish.foodID, nowCookingDish.orderNum));
            SqlCommand cmd1 = new SqlCommand(strSQL1.ToString(), conn);
            cmd1.ExecuteNonQuery();
            cmd1.Dispose();
            #endregion

            conn.Dispose();//释放该连接占用的资源
            conn.Close();//关闭该连接
        }
    }
    //如果申明为静态类，要注意允许有一个默认构造函数，前世是该构造函数也是静态的，其他类型的构造函数都是非法的。
    public class ControlOrderClass 
    {
        public static int chrefCount { set; get; }
        public static int foodTypeCount { set; get; }

        public static string nowOrderNum { set; get; }

        public static Timer autoAskCookRegularlyTimer = new Timer(10000);

        private static Queue<Dish>[] waitingCookQueue = new Queue<Dish>[10];//给种类菜的待做队列
        
        //为了便于通过菜的种类来找出相应的队列
        private static Dictionary<string, int> foodTypeNameToNumber = new Dictionary<string, int>();

        private static Chref[] chrefs = new Chref[20];

        //分配订单号，但不插入数据库。
        public static string GetNowOrderNum()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();

            DateTime now = DateTime.Now;
            string sqlDate = now.ToString("yyyy-MM-dd");//当天的
            string orderNumDatePart = now.ToString("yyyyMMdd");
            StringBuilder strSQL0 = new StringBuilder();
            strSQL0.Append("select Ordernum ");
            strSQL0.Append("from CustomerDesk ");
            strSQL0.Append(string.Format("where Orderdate = '{0}'  ", sqlDate));
            strSQL0.Append("order by Ordernum desc;");

            SqlCommand cmd0 = new SqlCommand(strSQL0.ToString(), conn);

            SqlDataReader sdr = cmd0.ExecuteReader();
            if (sdr.Read())//当天已经有订单了
            {
                string strOrderNumTemp = sdr["Ordernum"].ToString();
                string orderNumLast4Bit = strOrderNumTemp.Substring(8, 4);
                int tempOrderNum = int.Parse(orderNumLast4Bit);
                tempOrderNum++;
                nowOrderNum = orderNumDatePart + string.Format("{0:0000}", tempOrderNum);
            }
            else//当前是当天的第一个订单
            {
                nowOrderNum = orderNumDatePart + "0001";
            }

            sdr.Dispose();
            sdr.Close();
            conn.Close();
            return nowOrderNum;
        }

        //重载，用于非配预定订单的
        public static string GetNowOrderNum(DateTime future)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();

            string sqlDate = future.ToString("yyyy-MM-dd");//当天的
            string orderNumDatePart = future.ToString("yyyyMMdd");
            StringBuilder strSQL0 = new StringBuilder();
            strSQL0.Append("select Ordernum ");
            strSQL0.Append("from CustomerDesk ");
            strSQL0.Append(string.Format("where Orderdate = '{0}'  ", sqlDate));
            strSQL0.Append("order by Ordernum desc;");

            SqlCommand cmd0 = new SqlCommand(strSQL0.ToString(), conn);

            SqlDataReader sdr = cmd0.ExecuteReader();
            if (sdr.Read())//当天已经有订单了
            {
                string strOrderNumTemp = sdr["Ordernum"].ToString();
                string orderNumLast4Bit = strOrderNumTemp.Substring(8, 4);
                int tempOrderNum = int.Parse(orderNumLast4Bit);
                tempOrderNum++;
                nowOrderNum = orderNumDatePart + string.Format("{0:0000}", tempOrderNum);
            }
            else//当前是当天的第一个订单
            {
                nowOrderNum = orderNumDatePart + "0001";
            }

            sdr.Dispose();
            sdr.Close();
            conn.Close();
            return nowOrderNum;
        }

        //初始化队列
        public static void InitAll()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();

            //获取菜种类数量、对哈希表进行填充、初始化队列
            int i = 0;//初始化哈希值，自行递增
            SqlCommand cmd1 = new SqlCommand("select distinct Ftype from Menu;", conn);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            while (sdr1.Read())
            {
                foodTypeNameToNumber.Add(sdr1["Ftype"].ToString(), i);
                i++;
            }
            foodTypeNameToNumber.Add("其他", i);
            sdr1.Dispose();

            cmd1.CommandText = "select count(distinct Ftype) from Menu;";
            foodTypeCount = int.Parse(cmd1.ExecuteScalar().ToString()) + 1;
            for (int j = 0; j < foodTypeCount; j++)
            {
                waitingCookQueue[j] = new Queue<Dish>();
            }

            //获取厨师数量并初始化厨师
            SqlCommand cmd0 = new SqlCommand("select count(*) from Chref;", conn);
            chrefCount = int.Parse(cmd0.ExecuteScalar().ToString());
            int k = 0;
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("select COid, COjob, COifwork ");
            strSQL.Append("from Chref;");
            cmd0.CommandText = strSQL.ToString();
            SqlDataReader sdr0 = cmd0.ExecuteReader();
            while (sdr0.Read())
            {
                string temp0 = sdr0["COid"].ToString();
                string temp1 = sdr0["COjob"].ToString();
                string temp2 = sdr0["COifwork"].ToString();
                chrefs[k] = new Chref(temp0, temp1, foodTypeNameToNumber[temp1]);
                k++;
            }

            conn.Dispose();
            conn.Close();

            autoAskCookRegularlyTimer.AutoReset = true;
            autoAskCookRegularlyTimer.Enabled = true;
            autoAskCookRegularlyTimer.Elapsed += new ElapsedEventHandler(AskCookingEvent);
        }

        //查找没做完的菜，且置服务员为忙碌
        public static void SearchNoServerdish()
        {
            //检查DeskMenu表
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();
            StringBuilder sqlSearchNoServerdish = new StringBuilder();
            sqlSearchNoServerdish.Append("select Did, Fid, Ordernum ");
            sqlSearchNoServerdish.Append("from DeskMenu ");
            sqlSearchNoServerdish.Append("where Ifservedish = '否';");
            SqlCommand cmd = new SqlCommand(sqlSearchNoServerdish.ToString(), conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            //联合Menu表构成结构体
            while (sdr.Read())
            {
                string Did = sdr["Did"].ToString();
                string Fid = sdr["Fid"].ToString();
                string Ordernum = sdr["Ordernum"].ToString();
                string sqlFoodType = string.Format("select Ftype from Menu where Fid = '{0}';", Fid);
                SqlCommand cmd1 = new SqlCommand(sqlFoodType, conn);
                string Ftype = cmd1.ExecuteScalar().ToString();
                string sqlFoodCooktime = string.Format("select Fcooktime from Menu where Fid = '{0}';", Fid);
                cmd1.CommandText = sqlFoodCooktime;
                int Fcooktime = int.Parse(cmd1.ExecuteScalar().ToString());
                Dish temp = new Dish { };
                temp.foodID = Fid;
                temp.deskID = Did;
                temp.orderNum = Ordernum;
                temp.foodType = Ftype;
                temp.cookTime = Fcooktime;
                //调用GetDish
                ControlOrderClass.GetDish(temp);
                cmd1.Dispose();
            }
            sdr.Dispose();

            cmd.CommandText = "update Waiter set Wifwork = '繁忙';";
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public static void AskCookingEvent(object source, ElapsedEventArgs e)
        {
            for (int i = 0; i < chrefCount; i++)
            {
                chrefs[i].Cooking(waitingCookQueue);
            }
        }

        public static void GetDish(Dish sendDish)
        {
            Dish temp = new Dish(sendDish);
            waitingCookQueue[foodTypeNameToNumber[sendDish.foodType]].Enqueue(temp); //进队等待
        }


        public static void UpdateCusAndChrefThumbUp()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connDateString);
            conn.Open();

            //更新厨师被点赞次数
            SqlCommand cmd = new SqlCommand("select COid from Chref", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string COid = sdr["COid"].ToString();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = string.Format
                    ("select count(*) from ChrefMenu where COid = '{0}' and Ifthumbup = '是'", COid);
                int CObethumbup = int.Parse(cmd1.ExecuteScalar().ToString());
                cmd1.CommandText = string.Format
                    ("update Chref set CObethumbup = {0} where COid = '{1}';", CObethumbup, COid);
                cmd1.ExecuteNonQuery();
            }
            cmd.Dispose();
            sdr.Dispose();
            //更新顾客常点的菜
            cmd.CommandText = "select Ctellphone from Customer;";
            sdr = cmd.ExecuteReader();
            List<string> Ctellphone = new List<string>();
            while (sdr.Read())
            {
                Ctellphone.Add(sdr["Ctellphone"].ToString());
            }
            cmd.Dispose();
            sdr.Dispose();
            //对每个顾客更新
            foreach (string ct in Ctellphone)
            {
                StringBuilder sqlSelectTop3Dish = new StringBuilder();
                sqlSelectTop3Dish.Append("select top 3 Fid ");
                sqlSelectTop3Dish.Append("from CustomerMenu ");
                sqlSelectTop3Dish.Append("where Ordercount > 1 ");
                sqlSelectTop3Dish.Append(string.Format("and Ctellphone = '{0}' ",ct));
                sqlSelectTop3Dish.Append("order by Ordercount desc;");
                cmd.CommandText = sqlSelectTop3Dish.ToString();
                sdr = cmd.ExecuteReader();
                int i = 1;
                //写入最多三道菜
                while (sdr.Read())
                {
                    string updateRegularfood = "Cregularfood" + i.ToString();
                    string sqlUpdateRefood = string.Format
                        ("update Customer set {0} = '{1}' where Ctellphone = '{2}';", updateRegularfood, sdr["Fid"].ToString(), ct);
                    SqlCommand cmd1 = new SqlCommand(sqlUpdateRefood,conn);
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    i++;
                }
                sdr.Dispose();
            }

            cmd.CommandText = "update Waiter set Wifwork = '空闲';";
            cmd.ExecuteNonQuery();

            conn.Dispose();
            conn.Close();
        }
    }
}
