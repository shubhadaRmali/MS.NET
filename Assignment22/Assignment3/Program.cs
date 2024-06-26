using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter marks of math out of 100");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter marks of science out of 100");
            int science = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter marks of english out of 100");
            int english = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter marks of history out of 100");
            int history = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter marks of geography out of 100");
            int geography = int.Parse(Console.ReadLine());
            int sum = math + science + english + history + geography;
            Console.WriteLine($"Averge of all five marks is:{sum}");
            Console.ReadKey();
        }
    }
}
