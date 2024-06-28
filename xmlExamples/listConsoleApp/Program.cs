using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
        {
            new Customer { Name = "ajay", City = "sangli" },
            new Customer { Name = "kiran", City = "kolhapur" },
            new Customer { Name = "shweta", City = "satara" },
            new Customer { Name = "rajveer", City = "tasgoan" },
            new Customer { Name = "sanket", City = "budhgoan" },
            new Customer { Name = "bhairav", City = "satara" }
        };

           
            Dictionary<string, int> cityCustomerCount = new Dictionary<string, int>();

            foreach (Customer customer in customers)
            {
                if (cityCustomerCount.ContainsKey(customer.City))
                {
                    cityCustomerCount[customer.City]++;
                }
                else
                {
                    cityCustomerCount[customer.City] = 1;
                }
            }

         
            Console.WriteLine("Number of customers in each city:");
            foreach (var kvp in cityCustomerCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
