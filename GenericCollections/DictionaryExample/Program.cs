using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> employees = new Dictionary<int,string>();
            employees.Add(1000, "A");
            employees.Add(1001, "B");
            employees.Add(1002, "C");
            employees.Add(1003, "D");
            foreach (int key in employees.Keys)
            {
                Console.WriteLine($"Employee Id - {key} - Employee Name {employees[key]}!");
            }
        }
    }
}
