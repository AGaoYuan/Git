using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar_Rental
{
    public abstract class Vehicle
    {

        //无参构造
        public Vehicle() { }
        //带参构造
        public Vehicle(string color,double dailyrent,string licenseNo,
            string name,int rentdate) 
        {
            this.Color = color;
            this.DailyRent = dailyrent;
            this.LicenseNO = licenseNo;
            this.Name = name;
            this.RentDate = rentdate;
           
        }


        public  string Color { get; set; }//车颜色
        public  double DailyRent { get; set; }//日租金
        public  string LicenseNO { get; set; }//车牌号
        public  string Name { get; set; }//车名
        public  int RentDate { get; set; }//使用时间

        public  string RentUser { get; set; }//租用用户
        public  int YearsOfService { get; set; }//租用天数

        public abstract double Price();
       

    }
}
