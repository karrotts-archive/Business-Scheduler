using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Scheduler.Data
{
    public static class AppointmentManager
    {
        public static List<Appointment> AllAppointments;

        //Lambda to quickly check if start time is after end time
        public static bool CheckStartEndTimes(DateTime start, DateTime end) => start.TimeOfDay < end.TimeOfDay;

        //Lambda to quickly check if hours is withing business hours
        public static bool CheckBusinessHours(DateTime start, DateTime end) => start.TimeOfDay.Hours >= 6 && end.TimeOfDay.Hours <= 18;

        //Lambda to quickly check if start date is after end date
        public static bool CheckStartEndDates(DateTime start, DateTime end) => start < end;

        /// <summary>
        /// Makes an appointment out of sting array, data must contain 15 elements
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Appointment MakeAppointment(string[] data)
        {
            try
            {
                if(data.Length > 14)
                {
                    Appointment appointment = new Appointment(Int32.Parse(data[0]),
                          Int32.Parse(data[1]),
                          Int32.Parse(data[2]),
                          data[3], data[4], data[5],
                          data[6], data[7], data[8],
                          DateTime.Parse(data[9]),
                          DateTime.Parse(data[10]),
                          DateTime.Parse(data[11]),
                          data[12],
                          DateTime.Parse(data[13]),
                          data[14]);
                    return appointment;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return null;
            }
            return null;
        }

        /// <summary>
        /// Generates all appoinments and stores them as a list
        /// </summary>
        public static void GetAllAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();
            List<string[]> data = DataManager.AllAppointments();
            for(int i = 0; i < data.Count; i++)
            {
                appointments.Add(MakeAppointment(data[i]));
            }
            AllAppointments = appointments;
        }

        /// <summary>
        /// Returns true if another appointment overlaps with provided appointment
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public static bool CheckOverlappingAppointments(Appointment appointment)
        {
            bool valid = false;
            if(AllAppointments.Count > 0 && AllAppointments[0] != null)
            {
                for (int i = 0; i < AllAppointments.Count; i++)
                {
                    valid = appointment.Start >= AllAppointments[i].End || appointment.End <= AllAppointments[i].Start ? false : true;
                    if (valid)
                        break;
                }
            }
            return valid;
        }

        public static void AlertAppointment()
        {
            IEnumerable<Appointment> AppointmentQuery =
            from appointment in AllAppointments
            where appointment.Start.Date == DateTime.Now.Date
            && appointment.Start.TimeOfDay.Subtract(DateTime.Now.TimeOfDay) <= new TimeSpan(0, 0, 15, 0)
            && appointment.Start.TimeOfDay.Subtract(DateTime.Now.TimeOfDay) > new TimeSpan(0, 0, 0, 0)
            select appointment;

            if(AppointmentQuery.Count() > 0)
            {
                foreach (Appointment appointment in AppointmentQuery)
                {
                    List<Customer> customer = DataManager.SearchForCustomer(appointment.CustomerID);
                    MessageBox.Show($"{customer[0].CustomerName} has an appointment starting within 15 minutes." +
                        $"\n Appointment Start Time: {appointment.Start.TimeOfDay.ToString()}" +
                        $"\n Appointment End Time: {appointment.End.TimeOfDay.ToString()}", "Alert!");
                }
            }
        }
    }
}
