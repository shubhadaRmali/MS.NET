using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listExpConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (Customer customer in GetAllCustomers())
            {
                Console.WriteLine($"Customer {customer.CustomerName} lives in city {customer.City}!");
            }

            LinkedList<Customer> customers = GetAllCustomers();

            var cityGroups = customers.GroupBy(c => c.City);

            foreach (var group in cityGroups)
            {
                Console.WriteLine($"City: {group.Key}, Number of Customers: {group.Count()}");
            }

            Console.ReadKey();
        }
        private static LinkedList<Customer> GetAllCustomers()
        {
            LinkedList<Customer> customers = new LinkedList<Customer>();
            customers.AddLast(new Customer() { CustomerId = 100, CustomerName = "Alisha C.", City = "Mumbai" });
            customers.AddLast(new Customer() { CustomerId = 101, CustomerName = "Manisha K.", City = "Mumbai" });
            customers.AddLast(new Customer() { CustomerId = 102, CustomerName = "Pravinkumar R. D.", City = "Pune" });
            customers.AddLast(new Customer() { CustomerId = 103, CustomerName = "Manish Kaushik", City = "Bangalore" });
            return customers;

        }
    }
}
