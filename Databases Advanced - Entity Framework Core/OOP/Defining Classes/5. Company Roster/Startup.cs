namespace _5.Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var employees = GetEmployeesFromConsole();
            PrintHighestAverrageSalaryDepartment(employees);
        }

        private static void PrintHighestAverrageSalaryDepartment(List<Employee> employees)
        {
            var grouped = employees
                .GroupBy(e => e.Department)
                .OrderByDescending(g => g.Select(e => e.Salary).Average())
                .First();

            Console.WriteLine($"Highest Average Salary: {grouped.Key}");
            Console.WriteLine(string.Join(Environment.NewLine, grouped
                .OrderByDescending(e => e.Salary)));
        }

        private static List<Employee> GetEmployeesFromConsole()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var employees = new List<Employee>(numberOfLines);

            while (numberOfLines > 0)
            {
                var empData = Console.ReadLine().Split();

                var name = empData[0];
                var salary = decimal.Parse(empData[1]);
                var position = empData[2];
                var department = empData[3];

                if (empData.Length == 4)
                {
                    employees.Add(new Employee(name, salary, position, department));
                }
                else if (empData.Length == 6)
                {
                    var email = empData[4];
                    var age = int.Parse(empData[5]);
                    employees.Add(new Employee(name, salary, position, department, email, age));
                }
                else if (empData.Length == 5)
                {
                    int age;
                    if (int.TryParse(empData[4], out age))
                    {
                        employees.Add(new Employee(name, salary, position, department, age));
                    }
                    else
                    {
                        employees.Add(new Employee(name, salary, position, department, empData[4]));
                    }
                }

                numberOfLines--;
            }

            return employees;
        }
    }
}
