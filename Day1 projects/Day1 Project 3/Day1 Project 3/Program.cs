using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, sum = 0;
            int p = 1;
            Console.WriteLine("First Number:");
            fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number:");
            sn = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sn; i++)
                p = p * fn;
            Console.WriteLine("power ="+p);
            Console.ReadLine();

        }
    }
}
