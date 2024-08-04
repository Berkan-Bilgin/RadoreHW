using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator.Entities
{
    public class CEO : Employee
    {
        public CEO(double baseSalary = 20000.0) : base(baseSalary) { }

        public override double Salary => BaseSalary * 4;

        //public override double Salary => base.Salary * 4;
    }
}
