using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_program__Employees_Details
{
    class Employee
    {
        public int Id;
        public string Name;
        public int Salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 101, Name = "Sai", Salary = 75000},
                new Employee(){ Id = 102, Name = "Nani", Salary = 86000 },
                new Employee(){ Id = 103, Name = "Koti", Salary = 55000 },
                new Employee(){ Id = 104, Name = "Mahi", Salary = 95000 }

            };

            // for loop
            for(int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"id={employees[i].Id},Name={employees[i].Name},Salary={employees[i].Salary}");
            }

            //foreach loop
            foreach (var o in employees)
            {
                Console.WriteLine($"id={o.Id},Name={o.Name},Salary={o.Salary}");
            }

            //Lambda Expression
            employees.ForEach(o => Console.WriteLine($"id={o.Id},Name={o.Name},Salary={o.Salary}"));

            //LINQ Query
            var result = from o in employees
                         select o; 

            result.ToList().ForEach(o => Console.WriteLine($"id={o.Id},Name={o.Name},Salary={o.Salary}"));

            Console.ReadLine();

        }
    }
}
