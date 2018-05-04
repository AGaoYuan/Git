using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 序列化和反序列化
{
    [Serializable]
    public class Person
    {
        public Person()
        {
        }

        public Person(string name,int age,Car car)
        {
            this.Name = name;
            this.Age = age;
            this.Car = car;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public Car Car { get; set; }

    }
}
