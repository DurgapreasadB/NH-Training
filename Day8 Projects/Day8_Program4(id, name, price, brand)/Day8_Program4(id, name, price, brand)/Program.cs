using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Program4_id__name__price__brand_
{
    class Product
    {
        public int Id;
        public string Name;
        public int price;
        public String Brand;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>()
            {
                new Product(){ Id = 1011, Name = "Sandils", price = 450, Brand="Bata"},
                new Product(){ Id = 1012, Name = "Ricecoocker", price = 1300, Brand="Prastage"},
                new Product(){ Id = 1013, Name = "TV", price = 22000, Brand="MI"},
                new Product(){ Id = 1014, Name = "Short", price = 350, Brand="Polo"}

            };

            // for loop
            for (int i = 0; i < product.Count; i++)
            {
                if(product[i].price>600)
                    Console.WriteLine($"{product[i].Name},{product[i].Brand}");
                
            }
           
             //foreach loop
            foreach (var f in product)
            {
                if(f.price>600)
                    Console.WriteLine($"{f.Name}, {f.Brand}");

            }

            //Lambda Expression
            product.Where(f=>f.price>600).ToList().ForEach(f => Console.WriteLine($"{f.Name}, {f.Brand}"));

            //LINQ Query
            var result = from f in product
                         where f.price>600
                         select f;

            result.ToList().ForEach(f => Console.WriteLine($"{f.Name}, {f.Brand}"));

            Console.ReadLine();
            

        }
    }
}
