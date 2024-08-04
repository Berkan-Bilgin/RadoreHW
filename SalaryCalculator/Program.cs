using SalaryCalculator.Entities;

//Employee employee = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
CEO ceo = new CEO { Id = 2, FirstName = "Jane", LastName = "Smith" };
Programmer programmer = new Programmer { Id = 3, FirstName = "Bob", LastName = "Brown" };
Intern intern = new Intern { Id = 4, FirstName = "Alice", LastName = "Johnson" };
Programmer programmer2 = new Programmer { Id = 5, FirstName = "Anna", LastName = "Grace" };



//Console.WriteLine(employee.Salary);
Console.WriteLine(ceo.Salary);


List<Employee> employees = new List<Employee> { ceo, programmer, intern, programmer2 };


foreach (var e in employees)
{
    Console.WriteLine($"{e.FirstName} {e.LastName}: {e.Salary} TL");
}


double totalSalary = 0;


foreach (var e in employees)
{
    totalSalary += e.Salary;
}

Console.WriteLine($"Çalışanların toplam maaşı: {totalSalary} TL");