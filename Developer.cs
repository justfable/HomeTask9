using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9
{
    public class Developer : Employee
    {
        public int LinesOfCodePerDay { get; set; }
        private const int ratePerLine = 1;
        public Developer(string name, int age, int salary, int linesOfCodePerDay) : base(name, age, salary)
        {
            LinesOfCodePerDay = linesOfCodePerDay;
        }
        public virtual int CalculateAnnualSalary()
        {
            int additionalPayment = LinesOfCodePerDay * ratePerLine * 260;
            return base.CalculateAnnualSalary() + additionalPayment;
        }
    }


}
