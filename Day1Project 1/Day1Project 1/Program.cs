using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, Sum = 0;
            Console.WriteLine("First Number:");
            fn = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Secound Number:");
            sn = Convert.ToInt32(Console.ReadLine());
            Sum = fn + sn;
            Console.WriteLine("Sum=" +Sum);
            Console.ReadLine();
        }
    }
}
