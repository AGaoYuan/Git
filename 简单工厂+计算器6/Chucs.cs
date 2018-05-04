using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂_计算器
{
   public class Chucs:Calcuator
    {


        public override double Calc()
        {
            if (NumBer2 == 0)
            {
                throw new Exception("除数不能为0");
            }
            return NumBer1 / NumBer2;
        }

    }
}
