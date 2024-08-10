using Logger_better__.Entities;
using Logger_better__.Logging;
using Logger_better__.Logging.Loggers;
using Logger_better__.Logging.Loggers.Database;
using Logger_better__.Logging.Loggers.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_better__.Services
{
    public class EmployeeService
    {
        private readonly ILogger _salaryLogger;
        private readonly ILogger _leaveLogger;

        public EmployeeService()
        {
            // Maaş ödeme için JSON ve XML loglayıcıları yapılandırılıyor
            var jsonLogger = new JsonLogger();
            var xmlLogger = new XmlLogger();
            _salaryLogger = new CompositeLogger();
            ((CompositeLogger)_salaryLogger).AddLogger(jsonLogger);
            ((CompositeLogger)_salaryLogger).AddLogger(xmlLogger);

            // İzin alma için MySQL ve SQL Server loglayıcıları yapılandırılıyor
            var mySQLLogger = new MySQLLogger();
            var sqlServerLogger = new SQLServerLogger();
            _leaveLogger = new CompositeLogger();
            ((CompositeLogger)_leaveLogger).AddLogger(mySQLLogger);
            ((CompositeLogger)_leaveLogger).AddLogger(sqlServerLogger);
        }

        public void PaySalary(Employee emp)
        {
            _salaryLogger.Log($"Maaş ödendi:{emp.Salary} {emp.Name}");
            // Maaş ödeme işlemleri
        }

        public void TakeLeave(Employee emp)
        {
            _leaveLogger.Log($"İzin alındı:{emp.Salary} {emp.Name}");
            // İzin alma işlemleri
        }
    }
}
