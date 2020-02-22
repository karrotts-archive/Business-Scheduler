using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Business_Scheduler.Forms;

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
                    valid = appointment.Start.ToUniversalTime() >= AllAppointments[i].End || appointment.End.ToUniversalTime() <= AllAppointments[i].Start ? false : true;

                    //ignore appointments with the same ID as itself to prevent it from detecting itself as an overlap
                    if(appointment.AppointmentID == AllAppointments[i].AppointmentID)
                    {
                        valid = false;
                    }

                    if (valid)
                        break;
                }
            }
            return valid;
        }

        /// <summary>
        /// Searches through all appointments and finds any appointments within 15 minutes and displays an alert
        /// </summary>
        public static void AlertAppointment()
        {
            //Search for any appointments in 15 minutes
            IEnumerable<Appointment> AppointmentQuery =
            from appointment in AllAppointments
            where appointment.Start.Date == DateTime.Now.Date
            && appointment.Start.TimeOfDay.Subtract(DateTime.Now.ToUniversalTime().TimeOfDay) <= new TimeSpan(0, 0, 15, 0)
            && appointment.Start.TimeOfDay.Subtract(DateTime.Now.ToUniversalTime().TimeOfDay) > new TimeSpan(0, 0, 0, 0)
            select appointment;

            //Display all appointments within 15 minutes
            if(AppointmentQuery.Count() > 0)
            {
                foreach (Appointment appointment in AppointmentQuery)
                {
                    List<Customer> customer = DataManager.SearchForCustomer(appointment.CustomerID);
                    MessageBox.Show($"{customer[0].CustomerName} has an appointment starting within 15 minutes." +
                        $"\n Appointment Start Time: {DataManager.ConvertFromUTC(appointment.Start).TimeOfDay.ToString()}" +
                        $"\n Appointment End Time: {DataManager.ConvertFromUTC(appointment.End).TimeOfDay.ToString()}", "Alert!");
                }
            }
        }
        
        /// <summary>
        /// Populates MainForms weekly and monthly tables
        /// </summary>
        public static void PopulateTables()
        {
            IEnumerable<Appointment> MonthlyQuery =
            from appointment in AllAppointments
            where DataManager.ConvertFromUTC(appointment.Start.Date) < DateTime.Now.AddMonths(1)
            && DataManager.ConvertFromUTC(appointment.Start.Date) >= DateTime.Now.AddDays(-1)
            select appointment;

            IEnumerable<Appointment> WeeklyQuery =
            from appointment in AllAppointments
            where DataManager.ConvertFromUTC(appointment.Start.Date) < DateTime.Now.AddDays(7)
            && DataManager.ConvertFromUTC(appointment.Start.Date) >= DateTime.Now.AddDays(-1)
            select appointment;

            foreach(Appointment appointment in MonthlyQuery)
            {
                if(MainForm.MonthlyTable.GetRowByID(appointment.AppointmentID) == null)
                {
                    Customer customer = CustomerManager.Customers.FirstOrDefault(c => c.CustomerID == appointment.CustomerID);
                    string[] data = { appointment.AppointmentID.ToString(), appointment.Type, DataManager.ConvertFromUTC(appointment.Start).ToString(), DataManager.ConvertFromUTC(appointment.End).ToString(), customer.CustomerName };
                    MainForm.MonthlyTable.Add(data);
                }
            }

            foreach (Appointment appointment in WeeklyQuery)
            {
                if (MainForm.WeeklyTable.GetRowByID(appointment.AppointmentID) == null)
                {
                    Customer customer = CustomerManager.Customers.FirstOrDefault(c => c.CustomerID == appointment.CustomerID);
                    string[] data = { appointment.AppointmentID.ToString(), appointment.Type, DataManager.ConvertFromUTC(appointment.Start).ToString(), DataManager.ConvertFromUTC(appointment.End).ToString(), customer.CustomerName };
                    MainForm.WeeklyTable.Add(data);
                }
            }
        }

        /// <summary>
        /// Updates a specific appointment in the customer list
        /// </summary>
        /// <param name="appointment"></param>
        public static void UpdateAppointment(Appointment appointment)
        {
            Customer customer = CustomerManager.Customers.FirstOrDefault(c => c.CustomerID == appointment.CustomerID);
            
            //Update list item
            for (int i = 0; i < AllAppointments.Count; i++)
            {
                if (AllAppointments[i].AppointmentID == appointment.AppointmentID)
                {
                    AllAppointments[i] = appointment;
                }
            }

            //Update all tables
            FormCollection formCollection = Application.OpenForms;
            foreach (Form form in formCollection)
            {
                if (form.Name == "MainForm")
                {
                    string[] data = { appointment.AppointmentID.ToString(), appointment.Type, DataManager.ConvertFromUTC(appointment.Start).ToString(), DataManager.ConvertFromUTC(appointment.End).ToString(), customer.CustomerName };
                    MainForm.MonthlyTable.UpdateRow(data);
                    MainForm.WeeklyTable.UpdateRow(data);
                }
                if (form.Name == "ViewAppointmentForm")
                {
                    string[] data = { appointment.AppointmentID.ToString(), appointment.Title, appointment.Type, DataManager.ConvertFromUTC(appointment.Start).ToString(), DataManager.ConvertFromUTC(appointment.End).ToString(), customer.CustomerName };
                    ViewAppointmentForm.AppointmentTable.UpdateRow(data);
                }
            }
        }
    }
}
