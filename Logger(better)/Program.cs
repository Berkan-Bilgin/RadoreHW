// See https://aka.ms/new-console-template for more information
using Logger_better_;
using Logger_better_.Entities;
using Logger_better_.Services;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");


ILogger dbLogger = new DbLog();
XmlLog xmlLogger = new XmlLog();
ILogger jsonLogger = new JsonLog();


xmlLogger.Log("xml log mesajı");

Logger logger = new Logger(dbLogger);
logger.Log("Veritabanı log mesajı");



Employee emp1 = new Employee(1, "Alice");
Employee emp2 = new Employee(2, "Bob", 10000);


Console.WriteLine(emp1.ToString());

Console.WriteLine(emp1);


Console.WriteLine(emp1.GetEmployeeInfo());


// EmployeeService ile loglama işlemleri
EmployeeService employeeServiceDb = new EmployeeService(dbLogger);
employeeServiceDb.PaySalary(emp1); // DB loglama kullanarak

EmployeeService employeeServiceXml = new EmployeeService(xmlLogger);
employeeServiceXml.PaySalary(emp2); // XML loglama kullanarak


var compositeLogger = new CompositeLogger(new ILogger[] { dbLogger, xmlLogger, jsonLogger });

var employeeService = new EmployeeService(compositeLogger);
employeeService.PaySalary(emp1);


