namespace P01_CompanyRoster
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
            var departments = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < lines; i++)
            {
                var currentEmployee = Console.ReadLine().Split();
                string name = currentEmployee[0];
                decimal salary = decimal.Parse(currentEmployee[1]);
                string department = currentEmployee[2];

                var employee = new Employee(name, salary, department);
                employees.Add(employee);

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new List<decimal>();
                }

                departments[department].Add(salary);
            }

            var bestDepartment = departments.OrderByDescending(x => x.Value.Average()).First();
            Console.WriteLine($"Highest Average Salary: {bestDepartment.Key}");

            var result = employees
                .Where(x => x.Department == bestDepartment.Key)
                .OrderByDescending(x => x.Salary);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} {person.Salary:F2}");
            }
        }
    }

    public class Employee
    {
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }

        public Employee(string name, decimal salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
    }
}
