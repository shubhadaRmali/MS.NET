using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectedArchitectureExamples.Models;
using System.ComponentModel;

namespace ConnectedArchitectureExamples.Dal
{
    internal class CustomerDal
    {
        private string _ConStr = ConfigurationManager.ConnectionStrings["InfoWayConStr"].ConnectionString;
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customersCollection = new List<Customer>();
            using (MySqlConnection CN=new MySqlConnection(_ConStr))
            {
                CN.Open();
                using (MySqlCommand CMD=new MySqlCommand())
                {
                    CMD.Connection= CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllCustomers";
                    MySqlDataReader DR =CMD.ExecuteReader(CommandBehavior.SequentialAccess);
                    while (DR.Read())
                    {
                        Customer customer = new Customer()
                        {
                            CustomerId=Convert.ToInt32(DR["CustomerId"]),
                            ContactName = DR["ContactName"].ToString(),
                            City = DR["City"].ToString(),
                        };
                        customersCollection.Add(customer);
                    }
                    DR.Close();
                }
                CN.Close();
            }
            return customersCollection;
        }
        public int InsertCustomerProfile(Customer customer)
        {
            int result = -1;
            using (MySqlConnection CN = new MySqlConnection(_ConStr))
            {
                CN.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerId", customer.CustomerId);
                    CMD.Parameters.AddWithValue("p_ContactName", customer.ContactName);
                    CMD.Parameters.AddWithValue("p_City", customer.City);
                    result = CMD.ExecuteNonQuery();
                }
                CN.Close();
            }
            return result;
        }
        public int UpdateCustomerProfile(Customer customer)
        {
            int result = -1;
            using (MySqlConnection CN = new MySqlConnection(_ConStr))
            {
                CN.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "UpdateCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerId", customer.CustomerId);
                    CMD.Parameters.AddWithValue("p_ContactName", customer.ContactName);
                    CMD.Parameters.AddWithValue("p_City", customer.City);
                    result = CMD.ExecuteNonQuery();
                }
                CN.Close();
            }
            return result;
        }
        public int DeleteCustomerProfile(int customerId)
        {
            int result = -1;
            using (MySqlConnection CN = new MySqlConnection(_ConStr))
            {
                CN.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "DeleteCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerId", customerId);
                   
                    result = CMD.ExecuteNonQuery();
                }
                CN.Close();
            }
            return result;
        }
    }
}
