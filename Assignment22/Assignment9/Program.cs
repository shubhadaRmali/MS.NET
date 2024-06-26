using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Console.WriteLine("please enter num1");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("please enter num2");
            float num2 = float.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("please choice the option");
                Console.WriteLine("1.addition");
                Console.WriteLine("2.substraction");
                Console.WriteLine("3.multiplication");
                Console.WriteLine("4.division");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine($"addition of two numbers is:{num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"substraction of two numbers is:{num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"multiplication of two numbers is:{num1 * num2}");
                        break;
                    case 4:
                        Console.WriteLine($"division of two numbers is:{num1 / num2}");
                        break;
                }

            } while (ch <= 4);
        }
    }
}
