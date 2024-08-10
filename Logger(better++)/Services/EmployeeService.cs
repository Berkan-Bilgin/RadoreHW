using Logger_better___.Entities;
using Logger_better___.Logging;
using Logger_better___.Entities;
using Logger_better___.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_better___.Services
{
    public class EmployeeService
    {
        private readonly ILogger _salaryLogger;
        private readonly ILogger _leaveLogger;

        public EmployeeService(ILogger salaryLogger, ILogger leaveLogger)
        {
            _salaryLogger = salaryLogger;
            _leaveLogger = leaveLogger;
        }

        public void PaySalary(Employee emp)
        {
            _salaryLogger.Log($"Maaş ödendi: {emp.Salary} {emp.Name}");
            // Maaş ödeme işlemleri
        }

        public void TakeLeave(Employee emp)
        {
            _leaveLogger.Log($"İzin alındı: {emp.Name}");
            // İzin alma işlemleri
        }
    }

}
