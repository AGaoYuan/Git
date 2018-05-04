using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTheaterTicket
{
    [Serializable]
    /// <summary>
    /// 电影票父类
    /// </summary>
    public class Ticket
    {
        public Ticket(){}

        public Ticket(Seat seat,ScheduleItem scheduleItem)
        {
            this.Seat = seat;
            this.ScheduleItem = scheduleItem;
        }

        //座位号
        public Seat Seat { get; set; }
        //票价
        public int Price { get; set; }
        //播放场次
        public ScheduleItem ScheduleItem { get; set; }

        /// <summary>
        /// 计算票价的方法
        /// </summary>
        public virtual void CalcPrice()
        {
            this.Price = this.ScheduleItem.Movie.Price;
        }

        /// <summary>
        /// 打印票价的方法
        /// </summary>
        public virtual void Print()
        {
            string fileName = this.ScheduleItem.Time.Replace(":", "-") + " " + this.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName,FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("**********************************");
            sw.WriteLine("          青鸟影院");
            sw.WriteLine("----------------------------------");
            sw.WriteLine("电影名：\t{0}",this.ScheduleItem.Movie.MovieName);
            sw.WriteLine("时间：\t{0}",this.ScheduleItem.Time);
            sw.WriteLine("座位号：\t{0}",this.Seat.SeatNum);
            sw.WriteLine("价格：\t{0}",this.Price.ToString());
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 显示售出信息
        /// </summary>
        public virtual void Show()
        {
            MessageBox.Show("已售出");
        }

        

    }
}
