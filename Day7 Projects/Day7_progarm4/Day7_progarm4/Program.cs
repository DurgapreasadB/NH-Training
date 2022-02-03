using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_progarm4
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[]
            {
                new Employee(){id=1,name="Meghanadh",salary = 1100},
                new Employee() {id=2,name ="Mohan",salary = 22200},
                new Employee() {id=3,name ="Swathi",salary = 14000},
                new Employee() {id= 4,name ="Mounik",salary = 13000},
                new Employee() {id = 5,name ="Usha",salary = 15000}
            };
                
                //for loop
                for (int i = 0; i < emp.Length; i++)
                {
                    if(emp[i].salary>=1600)
                    Console.WriteLine($"id={emp[i].id},name ={ emp[i].name},salary ={ emp[i].salary}");
                }
                    //foreach loop
                    foreach (var e in emp)
                    {
                        if (e.salary >= 1600)
                        Console.WriteLine($"id ={ e.id},name ={ e.name},salary ={ e.salary}");
                    }
                    //Lamda expression
                        emp.ToList().Where(e => e.salary >= 1600).ToList().ForEach(e =>Console.WriteLine($"id ={ e.id},name ={ e.name},salary ={ e.salary}"));
                        Console.ReadLine();
        }
    }
}
