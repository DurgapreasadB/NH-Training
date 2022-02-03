using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Program1_for_foreach_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 26, 55, 47,28,88,257,388,750};

            // EvenNumber using for loop 
            for (int i = 0; i < data.Count; i++) 
            {
                if(data[i]%2==0)
                    Console.WriteLine(data[i]);
            }

            // EvenNumber using foreach loop
            foreach(int d in data)
            {
                if(d%2==0)
                    Console.WriteLine(d);
            }

            // Lambda Expression
            data.Where(d=>d%2==0).ToList().ForEach(d=>Console.WriteLine(d));

            // LINQ Query
                var result = from d in data
                             where d % 2 == 0
                             select d;
                result.ToList().ForEach(d => Console.WriteLine(d));
            

            Console.ReadLine();

        }
    }
}
