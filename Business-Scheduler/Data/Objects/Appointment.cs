using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Scheduler
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        public Appointment() { }

        public Appointment(int appointmentId,
                           int customerId,
                           int userId,
                           string title,
                           string description,
                           string location,
                           string contact,
                           string type,
                           string url,
                           DateTime start,
                           DateTime end,
                           DateTime createDate,
                           string createdBy,
                           DateTime lastUpdate,
                           string lastUpdateBy)
        {
            AppointmentID = appointmentId;
            CustomerID = customerId;
            UserID = userId;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            URL = url;
            Start = start;
            End = end;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        public Appointment(int customerId,
                           int userId,
                           string title,
                           string description,
                           string location,
                           string contact,
                           string type,
                           string url,
                           DateTime start,
                           DateTime end,
                           DateTime createDate,
                           string createdBy,
                           DateTime lastUpdate,
                           string lastUpdateBy)
        {
            CustomerID = customerId;
            UserID = userId;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            URL = url;
            Start = start;
            End = end;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
    }
}
