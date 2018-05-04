using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueSuite
{
    /// <summary>
    /// 检查项目类
    /// </summary>
    class HealthCheckItem
    {
        public string Description{ get; set; }//项目描述
        public string Name { get; set; }//项目名称
        public int Price { get; set; }//项目价格
        //构造函数重载
        public HealthCheckItem(string name, int price, string description)
        {
           
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }


    }
}
