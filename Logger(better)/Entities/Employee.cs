using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_better_.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public Employee(int id, string name, decimal salary = 20000)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
        }

        public string GetEmployeeInfo()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
        }


    }
}
