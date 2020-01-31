using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Scheduler
{
    class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdatedBy { get; set; }

        public Country(int countryId,
                string countryName,
                DateTime createDate,
                string createdBy,
                DateTime lastUpdate,
                string lastUpdateBy)
        {
            CountryID = countryId;
            CountryName = countryName;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdateBy;
        }

        public Country(string countryName,
        DateTime createDate,
        string createdBy,
        DateTime lastUpdate,
        string lastUpdateBy)
        {
            CountryName = countryName;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdateBy;
        }
    }
}
