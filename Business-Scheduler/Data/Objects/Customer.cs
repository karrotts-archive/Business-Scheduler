using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Scheduler
{
    class Customer
    {
        private int customerID;
        private string customerName;
        private Address address;
        private int active;
        private DateTime createDate;
        private string createdBy;
        private DateTime lastUpdate;
        private string lastUpdateBy;
        
        Customer(int customerID,
                 string customerName, 
                 Address address,
                 int active,
                 DateTime createDate, 
                 string createdBy,
                 DateTime lastUpdate,
                 string lastUpdateBy)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.address = address;
            this.active = active;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;
        }

        public int GetCustomerID() => customerID;
        public string GetCustomerName() => customerName;
        public Address GetCustomerAddress() => address;
        public int GetCustomerActive() => active;
        public DateTime GetCustomerCreateDate() => createDate;
        public string GetCustomerCreatedBy() => createdBy;
        public DateTime GetCustomerLastUpdate() => lastUpdate;
        public string GetCustomerLastUpdateBy() => lastUpdateBy;

        public void SetCustomerID(int id) => customerID = id;
        public void SetCustomerName(string name) => customerName = name;
        public void SetCustomerAddress(Address address) => this.address = address;
        public void SetCustomerActive(int active) => this.active = active;
        public void SetCustomerCreateDate(DateTime createDate) => this.createDate = createDate;
        public void SetCustomerCreatedBy(string user) => createdBy = user;
        public void SetCustomerLastUpdate(DateTime lastUpdate) => this.lastUpdate = lastUpdate;
        public void SetCustomerLastUpdateBy(string user) => lastUpdateBy = user;
    }
}
