// See https://aka.ms/new-console-template for more information
using System.Globalization;
using EmployeesSystem.Entities;

List<Employee> employees = new List<Employee>();

Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Employee #{i+1} data:");
    Console.Write("Outsourced (y/n)? ");
    char answer = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (answer == 'y' || answer == 'Y')
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else
    {
        employees.Add(new Employee(name, hours, valuePerHour));
    }
}

Console.WriteLine();
foreach(Employee employee in employees)
{
    Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}