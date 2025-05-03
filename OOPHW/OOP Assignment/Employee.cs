using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Employee(string name, int age, double salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Salary:{Salary}");
        }
        public void Print(int repeat)
        {
            if (repeat > 0)
            {
                for (int i = 0; i < repeat; i++)
                {
                    Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
                }
            }
        }
    }
}
