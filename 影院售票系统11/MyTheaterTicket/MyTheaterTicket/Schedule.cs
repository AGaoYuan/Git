using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyTheaterTicket
{
    //放映计划类
    public class Schedule
    {
        //放映计划中的放映列表 key 时间  value：放映场次

        //定义一个当前放映计划对应的 [放映场次集合]
        private Dictionary<string,ScheduleItem> items = new Dictionary<string, ScheduleItem>();

        internal Dictionary<string, ScheduleItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        //从XML文件读取放映列表数据
        public void LoadItems()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load("ShowList.xml");
            XmlNode root = myXml.DocumentElement;
            foreach (XmlNode item in root.ChildNodes)
            {
                Movie movie = new Movie();
                movie.MovieName = item["Name"].InnerText;
                movie.Poster = item["Poster"].InnerText;
                movie.Director = item["Director"].InnerText;
                movie.Actor = item["Actor"].InnerText;
                movie.MovieType = (MovieType) Enum.Parse(typeof (MovieType), item["Type"].InnerText);
                movie.Price = Convert.ToInt32(item["Price"].InnerText);

                foreach (XmlNode xmlNode in item["Schedule"].ChildNodes)
                {
                    ScheduleItem sItem = new ScheduleItem();
                    sItem.Time = xmlNode.InnerText;
                    sItem.Movie = movie;
                    
                    items.Add(sItem.Time,sItem);
                }
            }


        }

        public Schedule()
        {

        }


    }
}
