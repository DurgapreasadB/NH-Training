using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_program___Array_program_to_print_5_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, avg = 0;
            int[] data = new int[5];

            Console.WriteLine("Enter first number:");
            data[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number:");
            data[1] =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third number:");
            data[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fourth number:");
            data[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fifth number:");
            data[4] = Convert.ToInt32(Console.ReadLine());

            sum = data[0] + data[1] + data[2] + data[3] + data[4];
            Console.WriteLine("sum is" + sum);
            
            avg = sum / 5;
            Console.WriteLine("avg" + avg);

            Console.ReadLine(); 

           

        }
    }
}
