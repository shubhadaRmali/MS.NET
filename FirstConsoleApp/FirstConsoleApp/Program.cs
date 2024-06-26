using System;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome Back!!");
                Console.WriteLine("Please enter your name-");
                String name = Console.ReadLine();
                /* Console.WriteLine( $"{name}! I am ready to adventure");*/
                Console.WriteLine("Please enter your age:");
                int age = int.Parse(Console.ReadLine());
                if (age > 18 && age<50)
                {
                    Console.WriteLine($"{name}you are ready to adventure {age} is allowed");
                } else {
                    Console.WriteLine($"{name} you are not allowed to adventure!!");

                        }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
