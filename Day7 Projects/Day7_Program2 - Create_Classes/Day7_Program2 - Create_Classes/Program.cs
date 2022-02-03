using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Program2___Create_Classes
{
    class Customer_class
    {
        private string Classname;
        private string Classid;
        private int Roomnumner;
        public void ReadCustomers()
        {
            Console.WriteLine("Enter Classname");
            Classname = Console.ReadLine();

            Console.WriteLine("Enter Classid");
            Classid = Console.ReadLine();

            Console.WriteLine("Enter Roomnumner");
            Roomnumner = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintCustomers()
        {
            Console.WriteLine($"Cstname ={Classname},Cstid ={Classid},Cstmbno ={Roomnumner}");
        }
    }

    class Product
    {
        private string Productname;
        private int mftyear;
        private string type;

        public void ReadProduct()
        {
            Console.WriteLine("enter name");
            Productname = Console.ReadLine();

            Console.WriteLine("enter mftyear");
            mftyear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter type");
            type = Console.ReadLine();
        }

        public void PrintProduct()
        {
            Console.WriteLine($"Productname ={Productname},mftyear ={ mftyear},type ={ type}");
        }
    }

    class Seller
    {
        private string id;
        private string name;
        private string location;

        public void ReadSeller()
        {
            Console.WriteLine("enter id");
            id = Console.ReadLine();
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter location");
            location = Console.ReadLine();
        }
        public void PrintSeller()
        {
            Console.WriteLine($"id={id},name={name},location={location}");
        }
    }
    class Department
    {
        private string name;
        private string id;
        private int code;
        public void ReadDepartment()
        {
            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Console.WriteLine("enter id");
            id = Console.ReadLine();

            Console.WriteLine("enter code");
            code = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintDepartment()
        {
            Console.WriteLine($"name ={ name},id ={ id},code ={ code}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer_class Cst = new Customer_class();
            Cst.ReadCustomers();
            Cst.PrintCustomers();

            Product Pdt = new Product();
            Pdt.ReadProduct();
            Pdt.PrintProduct();

            Seller Sell = new Seller();
            Sell.ReadSeller();
            Sell.PrintSeller();

            Department Dpt = new Department();
            Dpt.ReadDepartment();
            Dpt.PrintDepartment();

            Console.ReadLine();
        }
    }
}
    
