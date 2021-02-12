using System;
using System.Globalization;
using System.Collections.Generic;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeesQuantity, searchId;
            Employee employee;

            Console.Write("How many employees will be registered? ");
            employeesQuantity = int.Parse(Console.ReadLine());

            List<Employee> employeesList = new List<Employee>();

            for (int i = 1; i <= employeesQuantity; i++)
            {
                int id;
                string name;
                double salary;

                Console.WriteLine($"Employee # {i}:");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employeesList.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            searchId = int.Parse(Console.ReadLine());

            employee = employeesList.Find(x => x.Id == searchId);

            if (employee != null)
            {
                double percentage;

                Console.Write("Enter the percentage: ");
                percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(percentage);
            } else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee employees in employeesList)
            {
                Console.WriteLine(employees);
            }

        }
    }
}
