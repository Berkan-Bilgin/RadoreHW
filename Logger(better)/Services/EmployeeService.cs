using Logger_better_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_better_.Services
{
    public class EmployeeService
    {
        private readonly ILogger _logger;

        public EmployeeService(ILogger logger)
        {
            _logger = logger;
        }

        public void PaySalary(Employee employee)
        {
            //Console.WriteLine($"Employee {employee.Name} has been paid {employee.Salary}.");

            _logger.Log($"Salary of {employee.Salary} paid to {employee.Name} (ID: {employee.Id})");
        }
    }
}
