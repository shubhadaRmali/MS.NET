using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num1");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter num2");
            int num2=int.Parse(Console.ReadLine());
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping of the numbers num1:"+num1+"and num2:"+num2);
            Console.ReadKey();

        }
    }
}
