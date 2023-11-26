using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9
{
    public class Manager : Employee
    {
        public int Bonus { get; set; }

        public Manager(string name, int age, int salary, int bonus) : base(name, age, salary)
        {
            Bonus = bonus;
        }

        public virtual int CalculateAnnualSalary()
        {
            return base.CalculateAnnualSalary() + Bonus;
        }
    }

}
