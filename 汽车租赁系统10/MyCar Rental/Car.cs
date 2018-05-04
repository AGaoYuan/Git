using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar_Rental
{
   public class Car:Vehicle
    {
       public Car() { }

       public Car(string color,double dailyRent,string LicenseNo,string name,int Rentdate)
           :base(color,dailyRent,LicenseNo,name,Rentdate)
       {
            
       }
       // Car car = new Car(licenseNo, name, cbColor, rentDate, dailyRent);
       public Car(string lincenseNo,string name, string Color,int RentDate,double dailyRent)
           : base(Color,dailyRent,lincenseNo,name,RentDate)
       {
            
       }



       public override double Price()
       {
           double count = 0;
           count = this.YearsOfService * base.DailyRent;
           return count;

       }




      

    }
}
