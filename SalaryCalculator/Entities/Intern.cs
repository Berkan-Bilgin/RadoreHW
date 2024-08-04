using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator.Entities
{
    public class Intern : Employee
    {
        public Intern(double baseSalary = 20000.0) : base(baseSalary) { }

        public override double Salary => BaseSalary * 0.25;

        //public override double Salary => base.Salary * 0.25;
    }
}
