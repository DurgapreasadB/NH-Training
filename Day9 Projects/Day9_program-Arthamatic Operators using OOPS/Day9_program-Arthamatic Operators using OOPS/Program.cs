using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_program_Arthamatic_Operators_using_OOPS
{
    class MathTask
    {
        private int f;
        private int g;

        public void Readinput()
        {
            Console.WriteLine("Enter first number");
            f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            g = Convert.ToInt32(Console.ReadLine());

        }
        public int Addnumbers()
        {
            return f + g;
        }
        public int Subtractnumbers()
        {
            return f - g;
        }
        public int Multiplynumbers()
        {
            return f * g;
        }
        public int Dividenumbers()
        {
            return f / g;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathTask mt = new MathTask();
            mt.Readinput();
            Console.WriteLine(mt.Addnumbers());
            Console.WriteLine(mt.Subtractnumbers());
            Console.WriteLine(mt.Multiplynumbers());
            Console.WriteLine(mt.Dividenumbers());

            Console.ReadLine();
        }
    }
}
