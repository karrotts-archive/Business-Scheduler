using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Scheduler
{
    public class Address
    {
        public int AddressID;
        public string AddressLineOne;
        public string AddressLineTwo;
        public string PostalCode;
        public string Phone;
        public City City;
        public DateTime CreateDate;
        public DateTime LastUpdate;
        public string LastUpdateBy;
        public string CreatedBy;

        public Address(int addressId,
                string address1,
                string address2,
                string postalCode,
                City city,
                string phone,
                DateTime createDate,
                string createdBy,
                DateTime lastUpdate,
                string lastUpdateBy)
        {
            AddressID = addressId;
            AddressLineOne = address1;
            AddressLineTwo = address2;
            PostalCode = postalCode;
            City = city;
            Phone = phone;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        public Address(string address1,
        string address2,
        string postalCode,
        City city,
        string phone,
        DateTime createDate,
        string createdBy,
        DateTime lastUpdate,
        string lastUpdateBy)
        {
            AddressLineOne = address1;
            AddressLineTwo = address2;
            PostalCode = postalCode;
            City = city;
            Phone = phone;
            CreatedBy = createdBy;
            CreateDate = createDate;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
    }
}
