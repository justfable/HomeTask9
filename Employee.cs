using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
        }
        public int CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }

}
