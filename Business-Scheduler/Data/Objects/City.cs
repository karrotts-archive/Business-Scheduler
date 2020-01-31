using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Scheduler
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public Country Country { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        public City(int cityId,
             string cityName,
             Country country,
             DateTime createDate,
             string createdBy,
             DateTime lastUpdate,
             string lastUpdateBy)
        {
            CityID = cityId;
            CityName = cityName;
            Country = country;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        public City(string cityName,
             Country country,
             DateTime createDate,
             string createdBy,
             DateTime lastUpdate,
             string lastUpdateBy)
        {
            CityName = cityName;
            Country = country;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
    }
}
