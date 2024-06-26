using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double net_sal;
            double commission;
            Console.WriteLine("please enter basic salary");
            double basic_sal=double.Parse(Console.ReadLine());
            Console.WriteLine("please enter total sales");
            double sales=double.Parse(Console.ReadLine());
            if(sales>5000 && sales < 7500)
            {
               commission = sales * 0.03;
            }
            else if (sales > 7501 && sales < 10500)
            {
                 commission = sales * 0.08;
            }
            else if (sales > 10501 && sales < 15000)
            {
                 commission = sales * 1.1;
            }
            else if( sales < 15500)
            {
                commission = sales * 1.5;
            }
             net_sal = basic_sal + commission;
             Console.WriteLine($"total net_salary is:{net_sal}");
        }
    }
}
