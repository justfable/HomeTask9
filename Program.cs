using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Alice", 42, 50000, 10000);
            manager.GetInfo();
            Console.WriteLine($"Annual salary with bonus: {manager.CalculateAnnualSalary()}");


            Developer developer = new Developer("Bob", 29, 80000, 500);
            developer.GetInfo();
            Console.WriteLine($"Annual salary with code bonus: {developer.CalculateAnnualSalary()}");
        }
    }
}
