using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_program___Switch_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = 'D';
            switch (input)
            {
                case 'D':
                case 'U':
                case 'R':
                case 'G':
                case 'A':
                    Console.WriteLine("the input is DURGA");
                    break;
                default:
                    Console.WriteLine("consonent");
                    break;
            }
            Console.ReadLine();
        }
    }
}
