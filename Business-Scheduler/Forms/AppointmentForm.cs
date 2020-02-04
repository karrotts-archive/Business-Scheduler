using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Scheduler.Data;
using Business_Scheduler.Exceptions;

namespace Business_Scheduler.Forms
{
    public partial class AppointmentForm : Form
    {
        public static TextBox CustomerName;
        public static List<Customer> Customers;

        public AppointmentForm()
        {
            InitializeComponent();
            CustomerName = CustomerName_Box;
            StartDate_Date.Value = DateTime.Now;
            EndDate_Date.Value = DateTime.Now;
            StartDate_Time.Value = DateTime.Now;
            EndDate_Time.Value = DateTime.Now.AddHours(1);
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            //EnableInput(false)
            try
            {
                int customerId = Int32.Parse(CustomerSearch_Box.Text);
                Customers = DataManager.SearchForCustomer(customerId);
            }
            catch (Exception ex)
            {
                Customers = DataManager.SearchForCustomer(CustomerSearch_Box.Text);
            }

            if (Customers != null)
            {
                if (Customers.Count > 1)
                {
                    new MultipleUsersForm(Customers).Show();
                }
                else
                {
                    CustomerName.Text = Customers[0].CustomerName;
                }
            }
            else
            {
                //EnableInput(true);
            }
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            try
            {
                //build datetimes
                TimeSpan startTs = StartDate_Time.Value.TimeOfDay;
                DateTime start = StartDate_Date.Value.Date + startTs;
                TimeSpan endTs = EndDate_Time.Value.TimeOfDay;
                DateTime end = EndDate_Date.Value.Date + endTs;

                //check datetime
                if(!AppointmentManager.CheckStartEndTimes(start, end) || !AppointmentManager.CheckStartEndDates(start, end))
                {
                    throw new Exception("Start date or time is greater than or equal to end date or time.");
                }

                if(!AppointmentManager.CheckBusinessHours(start, end))
                {
                    throw new OutsideBusinessHoursException("Start or End time is outside business hours. Business hours are between 6 AM and 6 PM");
                }

                appointment.Start = start;
                appointment.End = end;

                //check overlap
                if(AppointmentManager.CheckOverlappingAppointments(appointment))
                {
                    throw new OverlapAppointmentException("Unable to create appointment! Appointment overlaps with another appointment!");
                }

                //check required fields
                if(CustomerName.Text == "" ||
                   Type_Box.Text     == "")
                {
                    throw new Exception("All required fields must be filled out!");
                }

                //build appointment
                appointment.CustomerID = Customers[0].CustomerID;
                appointment.UserID = DataManager.UserID;
                appointment.Title = Title_Box.Text;
                appointment.Description = Description_Box.Text;
                appointment.Location = Location_Box.Text;
                appointment.Contact = Contact_Box.Text;
                appointment.URL = URL_Box.Text;
                appointment.Type = Type_Box.Text;
                appointment.CreateDate = DateTime.Now;
                appointment.CreatedBy = DataManager.Username;
                appointment.LastUpdate = DateTime.Now;
                appointment.LastUpdateBy = DataManager.Username;

                DataManager.CreateNewAppointment(appointment);
                AppointmentManager.AllAppointments.Add(appointment);
                MessageBox.Show("Appointment successfully created!", "Success!");
                AppointmentManager.PopulateTables();
                Close();
            }
            catch (OutsideBusinessHoursException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            catch (OverlapAppointmentException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
