using Reporter;

List<Employee> employees = new()
{
    new Employee { Name = "Ivan", Salary = 100 },
    new Employee { Name = "Boris", Salary = 50 },
    new Employee { Name = "Fedor", Salary = 200 }
};

var builder = new EmployeeReportBuilder(employees);



var directorAll = new EmployeeReportDirectorAll(builder);

directorAll.Build();

var report = builder.GetReport();

Console.WriteLine(report + "\n\n\n");


var directorOnlyBody = new EmployeeReportDirectorRandom(builder);

directorOnlyBody.Build();

var reportOnlyBody = builder.GetReport();

Console.WriteLine(reportOnlyBody);