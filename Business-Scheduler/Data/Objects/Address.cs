using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Scheduler
{
    class Address
    {
        public int AddressID;
        public string AddressLineOne;
        public string AddressLineTwo;
        public int PostalCode;
        public City City;
        public DateTime CreateDate;
        public string CreatedBy;
        public DateTime LastUpdate;
        public string LastUpdateBy;

        Address(int addressId,
                string address1,
                string address2,
                int postalCode,
                City city,
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
            CreateDate = createDate;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        Address(string address1,
        string address2,
        int postalCode,
        City city,
        DateTime createDate,
        string createdBy,
        DateTime lastUpdate,
        string lastUpdateBy)
        {
            AddressLineOne = address1;
            AddressLineTwo = address2;
            PostalCode = postalCode;
            City = city;
            CreateDate = createDate;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
    }
}
