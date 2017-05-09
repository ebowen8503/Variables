using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTIYFallbackend
{
    class Program
    {
        static void Main(string[] args)
        {
             Class1 construtorclass = new Class1();

            string Name="";
            Name = Console.ReadLine();
            string Address;
            Address = Console.ReadLine();

            Console.WriteLine("What is your fullname?");
                Name = Console.ReadLine();
            Console.WriteLine("What is your complete mailing address?");
            Address = Console.ReadLine();
            Console.WriteLine("Your name is {0} and address is {1},", Name, Address);
            Console.ReadKey();



        }
    }
}
