using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂_计算器
{
   public class Jian:Calcuator
    {

        public override double Calc()
        {
            return NumBer1 - NumBer2;
        }

    }
}
