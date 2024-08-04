using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator.Entities
{
    public class Programmer : Employee
    {
        public Programmer(double baseSalary = 20000.0) : base(baseSalary) { }

        public override double Salary => BaseSalary * 2;

        //public override double Salary => base.Salary * 2;
    }
}
