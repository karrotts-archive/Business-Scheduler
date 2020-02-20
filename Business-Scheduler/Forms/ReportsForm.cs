using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Business_Scheduler.Data;

namespace Business_Scheduler.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReportOne_Button_Click(object sender, EventArgs e)
        {
            //clear table
            Reports_Table.Columns.Clear();
            Reports_Table.Rows.Clear();

            //set up table
            Reports_Table.Columns.Add("month", "Month");
            Reports_Table.Columns.Add("type", "Type");
            Reports_Table.Columns.Add("amount", "Amount");

            //get distinct appointments by type
            var DistinctTypes = AppointmentManager.AllAppointments.Select(x => x.Type).Distinct();
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            for (int i = 0; i < 12; i++)
            {
                foreach (var type in DistinctTypes)
                {
                    //get a list of appointments equal to the type by month
                    IEnumerable<Appointment> QueryType =
                    from appointment in AppointmentManager.AllAppointments
                    where appointment.Type == type &&
                    DataManager.ConvertFromUTC(appointment.Start).Month == i
                    select appointment;

                    if (QueryType.ToList().Count > 0)
                    {
                        string[] data = { months[i - 1], QueryType.ToList()[0].Type, QueryType.ToList().Count.ToString() };
                        Reports_Table.Rows.Add(data);
                    }
                }
            }
        }

        private void ReportTwo_Button_Click(object sender, EventArgs e)
        {
            //clear table
            Reports_Table.Columns.Clear();
            Reports_Table.Rows.Clear();

            //set up table
            Reports_Table.Columns.Add("consultant", "Consultant");
            Reports_Table.Columns.Add("customer", "Customer");
            Reports_Table.Columns.Add("startTime", "Start Time");
            Reports_Table.Columns.Add("endTime", "End Time");

            var DistinctUsers = AppointmentManager.AllAppointments.Select(x => x.UserID).Distinct();
            
            foreach(int user in DistinctUsers)
            {
                //Get appointments for user
                IEnumerable<Appointment> QuerySchedule =
                from appointment in AppointmentManager.AllAppointments
                where appointment.UserID == user
                select appointment;

                foreach (Appointment appointment in QuerySchedule.ToList())
                {
                    string[] data = { DataManager.AllUsers.FirstOrDefault(x => x.ID == appointment.UserID).Username,
                                  CustomerManager.Customers.First(x => x.CustomerID == appointment.CustomerID).CustomerName,
                                  DataManager.ConvertFromUTC(appointment.Start).ToString(),
                                  DataManager.ConvertFromUTC(appointment.End).ToString() };
                    Reports_Table.Rows.Add(data);
                }
            }
        }

        private void ReportThree_Button_Click(object sender, EventArgs e)
        {
            //clear table
            Reports_Table.Columns.Clear();
            Reports_Table.Rows.Clear();

            //set up table
            Reports_Table.Columns.Add("customer", "Customer");
            Reports_Table.Columns.Add("amount", "Amount");

            //get distinct customer ids
            var DistinctCustomers = AppointmentManager.AllAppointments.Select(x => x.CustomerID).Distinct();

            foreach(int customer in DistinctCustomers)
            {
                //select all appointments for each customers
                IEnumerable<Appointment> QueryCustomers =
                from appointment in AppointmentManager.AllAppointments
                where appointment.CustomerID == customer
                select appointment;

                string[] data = { CustomerManager.Customers.First(x => x.CustomerID == customer).CustomerName, QueryCustomers.ToList().Count.ToString() };
                Reports_Table.Rows.Add(data);
            }
        }
    }
}
