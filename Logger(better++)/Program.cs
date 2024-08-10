// See https://aka.ms/new-console-template for more information


using Logger_better___.Entities;
using Logger_better___.Services;



var loggerService = new LoggerService();

var salaryLogger = loggerService.CreateSalaryLogger();
var leaveLogger = loggerService.CreateLeaveLogger();
var baseLogger = loggerService.CreateBaseLogger();

var employeeService = new EmployeeService(baseLogger, leaveLogger, salaryLogger);

Employee emp1 = new Employee(2, "Ahmet Bilgin");

Employee emp2 = new Employee(2, "Berkan Bilgin");


// Maaş ödeme işlemi
Console.WriteLine("Maas Ödeme");
employeeService.PaySalary(emp1);
Console.WriteLine("----------------------------");

// İzin alma işlemi
Console.WriteLine("İzin Alma");
employeeService.TakeLeave(emp2);
Console.WriteLine("----------------------------");

Console.WriteLine("İsten Cıkarılma");
employeeService.TerminateEmployee(emp1);
Console.WriteLine("----------------------------");
