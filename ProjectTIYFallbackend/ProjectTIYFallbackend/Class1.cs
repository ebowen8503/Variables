using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTIYFallbackend
{
    class Class1
    {
        public Class1()
        {
            string Name = "";
            Name = Console.ReadLine();
            int age = 0;
            string College;
            College = Console.ReadLine();
            double StudentId = 0000;
            string Class;
            Class = Console.ReadLine();

            Console.WriteLine("Student's name");
            Name = Console.ReadLine();
            Console.WriteLine("Please provide your age.");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What college do you attend?");
            College = Console.ReadLine();
            Console.WriteLine("Please provide your Student Id.");
            StudentId = double.Parse(Console.ReadLine());
            Console.WriteLine("What class are you in?");
            Class = Console.ReadLine();
            Console.WriteLine("The student's name is {0}. Age is {1} years old. They attend {2} University. Their student id is {3}. They are enrolled in {4}.", Name, age, College, StudentId, Class);
            Console.ReadKey();
        }
    }
}
