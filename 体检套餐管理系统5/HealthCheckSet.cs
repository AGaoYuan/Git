using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueSuite
{
    /// <summary>
    /// 体检套餐类
    /// </summary>
    class HealthCheckSet
    {  
        public List<HealthCheckItem> Items { get; set; }//以泛型集合作为数据类型的检查项目
        public int Price { get; set; }//套餐价格
        public string Name { get; set; }//套餐名称
        //构造函数重载
        public HealthCheckSet(string Name, List<HealthCheckItem> items)
        {
            this.Name= Name;
            this.Items = items;
        }

        //套餐价格计算方法
        public void CalcPrice()
        {
            int totalPrice = 0;//总计价格
            foreach(HealthCheckItem item in this.Items)
            {
                totalPrice += item.Price;
            }
            this.Price = totalPrice;
        }


    }
}
