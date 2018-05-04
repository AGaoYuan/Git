using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂_计算器
{
   public abstract class Calcuator
    {
        public double NumBer1 { get; set; }
        public double NumBer2 { get; set; }

        public abstract double Calc();

    }
}
