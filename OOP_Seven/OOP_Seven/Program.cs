using System;
using System.Collections.Generic;

namespace OOP_Seven
{
    class Program
    {
        static void Main(string[] args)
        {
            string Move;
            string Who;
            int WhoInt;

            List<Professor> Professors = new List<Professor>();
            Professors.Add(new Professor("1","midname","lastname",44,"Glava"));
            Professors.Add(new Professor("2", "midname", "lastname", 44, "Glava"));
            Professors.Add(new Professor("3", "midname", "lastname", 44, "Glava"));
            Professors.Add(new Professor("4", "midname", "lastname", 44, "Glava"));
            string name = "3";
            
            

            Console.WriteLine("Choose move Add-A, D-Delete, Find-F, Delete them all - Da");
            Move = Console.ReadLine();

            switch (Move)
            {
                case "D":

                    {   

                        Console.WriteLine("Who do you wanna delete?");
                        WhoInt = Convert.ToInt32(Console.ReadLine());
                        Professors.RemoveAt(WhoInt);
                        Console.WriteLine();
                        break;
                    }
                case "F":

                    {
                        Console.WriteLine("Input name: ");
                        name = Console.ReadLine();

                        Console.WriteLine("Answer" +
                        Professors.Find(x => x.Name.Contains(name)));                        
                        Console.WriteLine();
                        break;
                    }
                case "Da":

                    {
                        Professors.Clear();
                        Console.WriteLine("All professors have been deleted");
                        break;
                    }                                   

                default:
                    {  

                        Console.WriteLine("Try again");
                        break;
                    }
                   
            }

            foreach (var item in Professors)
            {
                 
                Console.WriteLine(item.Name);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.MiddleName);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Position);

            }



            Console.ReadKey();
        }
    }
}
