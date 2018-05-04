using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MyTheaterTicket
{
    [Serializable]
    /// <summary>
    /// 影院类
    /// </summary>
    public class Cinema
    {
        //实例化
        public Cinema()
        {
            Schedule = new Schedule();
            Seats = new Dictionary<string, Seat>();
            SoldTickets = new List<Ticket>();
        }

        //Schedule放映计划场次变量
        public Schedule Schedule { get; set; }
        //定义保存影院座位信息集合
        public Dictionary<string,Seat> Seats { get; set; }
        //定义电影票父类集合，存储不同子类的票价信息和打印票单
        public List<Ticket> SoldTickets { get; set; }

        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("售票记录.bin", FileMode.Create);
            bf.Serialize(fs, this.SoldTickets);
            fs.Close();
        }

        public void Load()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("售票记录.bin",FileMode.Open);
            bf.Deserialize(fs);
            fs.Close();

        }


    }
}
