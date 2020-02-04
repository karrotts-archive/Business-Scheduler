using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Scheduler.Data
{
    public static class CustomerManager
    {
        public static List<Customer> Customers;

        /// <summary>
        /// Populates the customer list
        /// </summary>
        public static void GetAllCustomers()
        {
            Customers = DataManager.AllCustomers();
        }

        /// <summary>
        /// Updates a specific customer in the customer list
        /// </summary>
        /// <param name="customer"></param>
        public static void UpdateCustomer(Customer customer)
        {
            for(int i = 0; i < Customers.Count; i++)
            {
                if (Customers[i].CustomerID == customer.CustomerID)
                {
                    Customers[i] = customer;
                }
            }
        }
    }
}
