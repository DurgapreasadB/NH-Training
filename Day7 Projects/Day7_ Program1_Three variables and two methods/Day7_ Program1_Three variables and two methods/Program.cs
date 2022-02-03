using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7__Program1_Three_variables_and_two_methods
{

    class Employees
    {
        public int Id;
        public string name;
        private String designation;
        public void ReadEmployee()
        {
            Console.WriteLine("enter Id");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Console.WriteLine("enter designation");
            designation =Console.ReadLine();
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Id ={ Id},Name ={ name},salary ={designation}");
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employees emp1 = new Employees();
            emp1.ReadEmployee();
            emp1.PrintEmployee();
            Console.ReadLine();
        }
    }
}   
    
