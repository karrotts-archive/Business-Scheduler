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
    public partial class EditAppointmentForm : Form
    {
        public static Appointment EditAppointment;
        public EditAppointmentForm(Appointment appointment)
        {
            InitializeComponent();
            EditAppointment = appointment;
            CustomerName_Box.Text = CustomerManager.Customers.First(c => c.CustomerID == appointment.CustomerID).CustomerName;
            Title_Box.Text = appointment.Title;
            Description_Box.Text = appointment.Description;
            Location_Box.Text = appointment.Location;
            Contact_Box.Text = appointment.Contact;
            Type_Box.Text = appointment.Type;
            URL_Box.Text = appointment.URL;
            StartDate_Date.Value = appointment.Start;
            StartDate_Time.Value = appointment.Start;
            EndDate_Date.Value = appointment.End;
            EndDate_Time.Value = appointment.End;
        }

        private void Update_Button_Click(object sender, EventArgs e)
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
                if (!AppointmentManager.CheckStartEndTimes(start, end) || !AppointmentManager.CheckStartEndDates(start, end))
                {
                    throw new Exception("Start date or time is greater than or equal to end date or time.");
                }

                if (!AppointmentManager.CheckBusinessHours(start, end))
                {
                    throw new OutsideBusinessHoursException("Start or End time is outside business hours. Business hours are between 6 AM and 6 PM");
                }

                //Subtract a bunch of years so it wont detect itself as an overlap appointment
                EditAppointment.Start.AddYears(-1000);
                EditAppointment.End.AddYears(-1000);
                AppointmentManager.UpdateAppointment(EditAppointment);

                EditAppointment.Start = start;
                EditAppointment.End = end;

                //check overlap
                if (AppointmentManager.CheckOverlappingAppointments(appointment))
                {
                    throw new OverlapAppointmentException("Unable to create appointment! Appointment overlaps with another appointment!");
                }

                //check required fields
                if (CustomerName_Box.Text == "" ||
                   Type_Box.Text == "")
                {
                    throw new Exception("All required fields must be filled out!");
                }

                //build appointment
                EditAppointment.UserID = DataManager.UserID;
                EditAppointment .Title = Title_Box.Text;
                EditAppointment.Description = Description_Box.Text;
                EditAppointment.Location = Location_Box.Text;
                EditAppointment.Contact = Contact_Box.Text;
                EditAppointment.URL = URL_Box.Text;
                EditAppointment.Type = Type_Box.Text;
                EditAppointment.LastUpdate = DateTime.Now;
                EditAppointment.LastUpdateBy = DataManager.Username;

                DataManager.UpdateAppointmentInfo(EditAppointment);
                AppointmentManager.UpdateAppointment(EditAppointment);
                MessageBox.Show("Appointment successfully updated!", "Success!");
                //AppointmentManager.GetAllAppointments();
                //AppointmentManager.PopulateTables();
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
