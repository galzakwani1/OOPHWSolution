using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW
{
    public class Person
    {
        public string Name{ get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        public void Print(int times)
        {
            if (times > 0)
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine($"Name: {Name}, Age: {Age}");
                }
            }
        }
    }
}






