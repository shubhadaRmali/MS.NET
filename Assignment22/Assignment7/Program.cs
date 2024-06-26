using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your basic salary");
            int basic_sal=int.Parse(Console.ReadLine());
            int HRA = basic_sal / 5;
            int DA = basic_sal * 2 / 5;
            int gross_sal = basic_sal + HRA + DA;
            int PF = gross_sal / 10;
            int net_sal = gross_sal - PF;
            Console.WriteLine($"total net salary of employee is {net_sal}");
            Console.ReadKey();
        }
    }
}
