// See https://aka.ms/new-console-template for more information


using Logger_better___.Entities;
using Logger_better___.Services;



var loggerService = new LoggerService();

var salaryLogger = loggerService.CreateSalaryLogger();
var leaveLogger = loggerService.CreateLeaveLogger();

var employeeService = new EmployeeService(salaryLogger, leaveLogger);

Employee emp1 = new Employee(2, "Ahmet Bilgin");

Employee emp2 = new Employee(2, "Berkan Bilgin");


// Maaş ödeme işlemi
employeeService.PaySalary(emp1);

// İzin alma işlemi
employeeService.TakeLeave(emp2);