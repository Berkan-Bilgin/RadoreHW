using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator.Entities
{
    public class Manager : Employee
    {
        public Manager(double baseSalary = 20000.0) : base(baseSalary) { }

        public override double Salary => BaseSalary * 3;


        //public override double Salary => base.Salary * 3;
    }
}
