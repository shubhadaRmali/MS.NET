using System;
using System.Collections.Generic;
using System.Linq;//OLINQ
using System.Xml.Linq;//XLINQ
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var allCustomers=from customer in GetAllCustomers() 
            //                 select customer;
            //var allCustomers = from customer in GetAllCustomers()
            //                       //where customer.City == "Pune"
            //                   where customer.City.Contains("u")
            //                   select customer;
            /*var allCustomers = from customer in GetAllCustomers()
                               orderby customer.ContactName ,customer.City
                               select customer;
            foreach (var customer in allCustomers)
            {
                Console.WriteLine($"Customer {customer.ContactName} lives in city {customer.City}!");
            }*/
            var CustomerOrders = from customer in GetAllCustomers()
                                 join
                                 order in GetAllOrders()
                                 on customer.CustomerId equals order.CustomerId
                                 join
                                 product in GetAllProducts()
                                 on order.ProductId equals product.ProductId
                                 select new { CustomerId = customer.CustomerId, OrderId = order.OrderId, ODate = order.OrderDate, DeliveryDate = order.RequiredDate, Qty = order.Quantity, CustomerName = customer.ContactName, ProductName=product.ProductName, TotalPrice=order.Quantity*product.UnitPrice };
            foreach (var customerOrder in CustomerOrders)
            {
                Console.WriteLine($"Customer {customerOrder.CustomerName} has placed the order on {customerOrder.ODate} with the order Id {customerOrder.OrderId}. Delivery date is {customerOrder.DeliveryDate} with the quantity {customerOrder.Qty}! Product Name is {customerOrder.ProductName} and total payable amount is INR {customerOrder.TotalPrice}/-");
            }
        }
        private static List<Customer> GetAllCustomers()
        {
            return new List<Customer>()
            {
                new Customer(){ CustomerId=100,ContactName="Alisha C.",City="Mumbai" },
                new Customer(){ CustomerId=101,ContactName="Manisha K.",City="Pune" },
                new Customer(){ CustomerId=102,ContactName="Pravinkumar R. D.",City="Pune" },
                new Customer(){ CustomerId=103,ContactName="Manish Kaushik",City="Bangalore" },
            };
        }
        private static List<Order> GetAllOrders()
        {
            return new List<Order>()
            {
                new Order(){OrderId=1,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(1),Quantity=10,CustomerId=100,ProductId=1000},
                new Order(){OrderId=2,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(2),Quantity=23,CustomerId=100,ProductId=1001},
                new Order(){OrderId=3,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(1),Quantity=20,CustomerId=103,ProductId=1000},
            };
        }
        private static List<Product> GetAllProducts() 
        {
            var products = from product in XElement.Load(@"C:\DotNet-Jun-2024\LinqExamples\LinqExamples\Products.xml").Elements()
                           select new Product 
                           {
                               ProductId=int.Parse(product.Attribute("ProductId").Value),
                               ProductName= product.Attribute("ProductName").Value,
                               UnitPrice = decimal.Parse(product.Attribute("UnitPrice").Value),
                           };
            return products.ToList();
        }
    }
}
