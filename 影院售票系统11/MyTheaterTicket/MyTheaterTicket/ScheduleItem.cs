using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTheaterTicket
{
    /// <summary>
    /// 放映计划的场次
    /// </summary>
    [Serializable]

   public class ScheduleItem
    {
       public ScheduleItem()
       {
           Movie = new Movie();
       }


       //要放映的电影对象
       public Movie Movie { get; set; }
       //放映时间
       public string Time { get; set; }
       

    }
}
