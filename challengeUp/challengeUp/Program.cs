using challengeUp;

Employee employee1 = new Employee("Szczepan", "Adamus", 34);
Employee employee2 = new Employee("Katarzyna", "Niewiadomska", 32);
Employee employee3 = new Employee("Nikola", "Adamus",  18);


employee1.AddScore(26);
employee1.AddScore(24);
employee1.AddScore(32);

employee2.AddScore(19);
employee2.AddScore(33);
employee2.AddScore(20);

employee3.AddScore(24);
employee3.AddScore(17);
employee3.AddScore(31);

var result1 = employee1.Resoult;
var result2 = employee2.Resoult;
var result3 = employee3.Resoult;

Console.WriteLine("Szczepan zdobył " + result1 + " punktów");
Console.WriteLine("Katarzyna zdobyła " + result2 + " punków");
Console.WriteLine("Nikola zdobyła " + result3 + " punktów");

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

var maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Resoult>maxResult)
    {
        maxResult = employee.Resoult;
        employeeWithMaxResult = employee;

    }
}

Console.WriteLine("Zwyciezcą został/a " + employeeWithMaxResult.Name);






