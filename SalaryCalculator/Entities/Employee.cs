using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator.Entities
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double BaseSalary { get; set; }

        public virtual double Salary => BaseSalary;

        public Employee(double baseSalary = 20000.0)
        {
            BaseSalary = baseSalary;
        }



    }
}
