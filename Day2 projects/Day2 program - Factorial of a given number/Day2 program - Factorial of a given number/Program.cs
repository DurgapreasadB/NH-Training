using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_program___Factorial_of_a_given_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, product = 1;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                product = product * i;

            }
            Console.WriteLine(product);


            Console.ReadLine();
        }
    }
}
