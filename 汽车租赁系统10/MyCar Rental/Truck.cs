using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar_Rental
{
    public class Truck:Vehicle
    {
        private int load;//卡车载重

        public Truck() { }

        public Truck(string color,double dailyRent,string LicenseNo,
            string name,int Rentdate,int load)
           :base(color,dailyRent,LicenseNo,name,Rentdate)
       {
           this.Load = load;
       }

        //Truck tk = new Truck(licenseNo, name, cbColor, rentDate, dailyRent, load);
        public Truck(string lincenseNo,string name, string Color,int RentDate,double dailyRent,int load)
           : base(Color,dailyRent,lincenseNo,name,RentDate)
       {
           this.Load = load;
       }




        public int Load
        {
            get { return load; }
            set { load = value; }
        }

        public override double Price()
        {
            double Count = 0;
            Count = base.YearsOfService * base.DailyRent;
            return Count;
        }


    }
}
