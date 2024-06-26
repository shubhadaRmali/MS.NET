using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2019;
            if (year % 400 == 0)
            {
                Console.Write(year + " is a leap year.");
            }
            else if (year % 100 == 0)
            {
                Console.Write(year + " is not a leap year.");
            }
            else if (year % 4 == 0)
            {
                Console.Write(year + " is a leap year.");
            }
            else
            {
                Console.Write(year + " is not a leap year.");
            }
            Console.ReadKey();
        }
    }
 }

