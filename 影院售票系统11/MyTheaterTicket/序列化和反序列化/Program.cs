using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 序列化
            //List<Person> list = new List<Person>();
            //Person p1 = new Person("张三", 20, new Car());
            //Person p2 = new Person("李四", 22, new Car());
            //Person p3 = new Person("王五", 26, new Car());

            //list.Add(p1);
            //list.Add(p2);
            //list.Add(p3);

            //BinaryFormatter bf = new BinaryFormatter();
            //FileStream fs = new FileStream("save.txt", FileMode.Create);

            //bf.Serialize(fs, list);
            //fs.Close();
            //Console.WriteLine("序列化存储成功！"); 
            #endregion



            #region 反序列化
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs =new FileStream("save.txt",FileMode.Open);
            List<Person> list =(List<Person>) bf.Deserialize(fs);
            foreach (Person person in list)
            {
                Console.WriteLine(person.Name);
            }
            
            #endregion



            Console.ReadKey();
        }
    }
}
