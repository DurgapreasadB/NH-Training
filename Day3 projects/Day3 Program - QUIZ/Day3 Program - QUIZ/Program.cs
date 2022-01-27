using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Program___QUIZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("hi {0}, welcome to quiz by arun", name);
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Q1. who is the hero in Simha:");
            Console.WriteLine("1.Charan  2.Sai  3.Balakrishna  4.Prabhas");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;

            Console.WriteLine("Q2. who is the hero in Maharshi:");
            Console.WriteLine("1.Charan  2.Sai  3.Vinay  4.Mahesh Babu");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;

            Console.WriteLine("Q3. who is the C# Triner:");
            Console.WriteLine("1.Meganadh Reddy  2.Sai  3.Vinay  4.Prabhas");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;


            Console.WriteLine("Q4. who is the NB HR:");
            Console.WriteLine("1.Charan  2.Usha  3.Vinay  4.Prabhas");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;

            Console.WriteLine("Q1. what is the AP Capital:");
            Console.WriteLine("1.Charan  2.Sai  3.Ammaravathi  4.Prabhas");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;

            if (score >= 60)
                Console.WriteLine("congratulations {0}, you got {1}% in the exam", name, score);
            else
                Console.WriteLine("Better luck next time");
            Console.ReadLine();
        }
    }
}
