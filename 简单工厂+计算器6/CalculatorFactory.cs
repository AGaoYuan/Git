using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂_计算器
{
   public class CalculatorFactory
    {

       public static Calcuator getInstance(string oper)
       {
           Calcuator cal = null;
           switch (oper)
           {
               case "+":
                   cal = new Jia(); 
                   break;
               case "-":
                   cal = new Jian();
                   break;
               case "*":
                   cal = new Cheng();
                   break;
               case "/":
                   cal = new Chucs();
                   break;
           }
           return cal;
       }


    }
}
