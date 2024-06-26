using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User.details();
            Console.WriteLine("firstName : ", User.firstname);
            Console.WriteLine("lastName :  ", User.lastName);
            Console.WriteLine("age : ",User.age);
        }
    }
}
