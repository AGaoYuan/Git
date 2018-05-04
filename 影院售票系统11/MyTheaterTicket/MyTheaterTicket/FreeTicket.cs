using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTheaterTicket
{
    [Serializable]
    /// <summary>
    /// 增票子类
    /// </summary>
   public class FreeTicket:Ticket
    {
        public FreeTicket(){}
       //调用父类无参构造
        public FreeTicket(ScheduleItem scheduleItem,Seat seat,string customerName)
            :base(seat,scheduleItem)
        {
            this.CustomerName = customerName;
        }

       //增票者的名称
       public string CustomerName { get; set; }

       /// <summary>
       /// 计算票价的方法
       /// </summary>
       public override void CalcPrice()
       {
           this.Price = 0;
       }

       /// <summary>
       /// 打印票价的方法
       /// </summary>
       public override void Print()
       {
           string fileName = this.ScheduleItem.Time.Replace(":", "-") + " " + this.Seat.SeatNum + ".txt";
           FileStream fs = new FileStream(fileName, FileMode.Create);
           StreamWriter sw = new StreamWriter(fs);
           sw.WriteLine("**********************************");
           sw.WriteLine("          青鸟影院");
           sw.WriteLine("----------------------------------");
           sw.WriteLine("电影名：\t{0}", this.ScheduleItem.Movie.MovieName);
           sw.WriteLine("时间：\t{0}", this.ScheduleItem.Time);
           sw.WriteLine("座位号：\t{0}", this.Seat.SeatNum);
           sw.WriteLine("姓名：\t{0}");
           sw.WriteLine("价格：\t{0}", this.Price.ToString());
           sw.Close();
           fs.Close();
       }

       /// <summary>
       /// 显示售出信息
       /// </summary>
       public override void Show()
       {
           MessageBox.Show("已售出！\n\n增送者"+CustomerName,"提示");
       }

    }
}
