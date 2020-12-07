using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Seven
{
    class Professor
    {
   
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public Professor ()
        {
            Console.WriteLine("Input name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Input Middle name: ");
            MiddleName = Console.ReadLine();
            Console.WriteLine("Input Last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Input age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input position: ");
            Position = Console.ReadLine();
        }

        public Professor(string name, string middlename, string lastname, int age, string position)
        {

            Name = name;
            MiddleName = middlename;
            LastName = lastname;
            Age = age;
            Position = position;
        }

    }
}
