using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTheaterTicket
{
    /// <summary>
    /// 工具类，也可以说工厂类
    /// </summary>
    public class TicketUtil
    {

       public static Ticket CreateTicket(ScheduleItem scheduleItem,Seat seat, 
           int discount,string customerName,string type)
       {
           Ticket tickey = null;
           switch (type)
           {
               case "student":
                   tickey = new StudentTicket(scheduleItem,seat,discount);
                   break;
               case "free":
                   tickey = new FreeTicket(scheduleItem,seat,customerName);
                   break;
               case "":
                   tickey = new Ticket(seat,scheduleItem);
                   break;
           }
           return tickey;
       }



    }
}
