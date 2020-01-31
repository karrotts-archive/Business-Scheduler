using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Scheduler
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public Address Address { get; set; }
        public int Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        
        public Customer(int customerID,
                 string customerName, 
                 Address address,
                 int active,
                 DateTime createDate, 
                 string createdBy,
                 DateTime lastUpdate,
                 string lastUpdateBy)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            Address = address;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        public Customer(string customerName,
                 Address address,
                 int active,
                 DateTime createDate,
                 string createdBy,
                 DateTime lastUpdate,
                 string lastUpdateBy)
        {
            CustomerName = customerName;
            Address = address;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
    }
}
