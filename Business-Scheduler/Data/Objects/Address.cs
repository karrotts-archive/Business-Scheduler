using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Scheduler
{
    class Address
    {
        private int addressId;
        private string address1;
        private string address2;
        private int postalCode;
        private City city;
        private DateTime createDate;
        private string createdBy;
        private DateTime lastUpdate;
        private string lastUpdateBy;

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
            this.addressId = addressId;
            this.address1 = address1;
            this.address2 = address2;
            this.postalCode = postalCode;
            this.city = city;
            this.createDate = createDate;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;
        }
    }
}
