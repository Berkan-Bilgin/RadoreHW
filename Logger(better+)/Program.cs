// See https://aka.ms/new-console-template for more information
using Logger_better__.Entities;
using Logger_better__.Services;

Console.WriteLine("Hello, World!");


Employee emp = new Employee(1, "Berkan Bilgin");

Employee emp2 = new Employee(2, "Ahmet Bilgin");




Console.WriteLine(emp.GetEmployeeInfo());


var employeeService = new EmployeeService();

employeeService.PaySalary(emp);

employeeService.TakeLeave(emp2);


