using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyTheaterTicket
{
    [Serializable]
    /// <summary>
    /// 保存影院座位信息类
    /// </summary>
   public class Seat
    {
        public Seat()
        {
        }

        public Seat(string searNum,Color color)
        {
            this.SeatNum = searNum;
            this.Color = color;
        }
       //座位颜色
       public Color Color { get; set; }
       //座位号
       public string SeatNum { get; set; }

       

    }
}
