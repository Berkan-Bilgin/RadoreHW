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
        private readonly ILogger _baseLogger;

        public EmployeeService(ILogger baseLogger, ILogger salaryLogger = null, ILogger leaveLogger = null)
        {
            _baseLogger = baseLogger;
            _salaryLogger = salaryLogger ?? _baseLogger;  // SalaryLogger tanımlanmazsa baseLogger kullanılır
            _leaveLogger = leaveLogger ?? _baseLogger;    // LeaveLogger tanımlanmazsa baseLogger kullanılır
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

        public void TerminateEmployee(Employee emp)
        {
            _baseLogger.Log($"Çalışan işten çıkarıldı: {emp.Name}");
            // İşten çıkarma işlemleri burada yapılır
        }


    }

}
