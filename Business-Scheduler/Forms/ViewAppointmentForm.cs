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
using Business_Scheduler.Controllers;

namespace Business_Scheduler.Forms
{
    public partial class ViewAppointmentForm : Form
    {
        public static TableController AppointmentTable;
        public ViewAppointmentForm()
        {
            InitializeComponent();
            AppointmentTable = new TableController(Appointments_Table);
            for(int i = 0; i <  AppointmentManager.AllAppointments.Count; i++)
            {
                Customer customer = CustomerManager.Customers.First(c => c.CustomerID == AppointmentManager.AllAppointments[i].CustomerID);
                string[] data = {AppointmentManager.AllAppointments[i].AppointmentID.ToString(),
                                 AppointmentManager.AllAppointments[i].Title,
                                 AppointmentManager.AllAppointments[i].Type,
                                 AppointmentManager.AllAppointments[i].Start.ToString(),
                                 AppointmentManager.AllAppointments[i].End.ToString(),
                                 customer.CustomerName};
                AppointmentTable.Add(data);
            }
        }

        private void Appointments_Table_SelectionChanged(object sender, EventArgs e)
        {
            if (Appointments_Table.Rows[Appointments_Table.CurrentCell.RowIndex].Cells[0].Value != null)
            {
                Update_Button.Enabled = true;
                Delete_Button.Enabled = true;
            }
            else
            {
                Update_Button.Enabled = false;
                Delete_Button.Enabled = false;
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Appointments_Table.Rows[Appointments_Table.CurrentCell.RowIndex].Cells[0].Value.ToString());
            if (Appointments_Table.Rows[Appointments_Table.CurrentCell.RowIndex].Cells[0].Value != null)
            {
                Appointment appointment = AppointmentManager.AllAppointments.First(a => a.AppointmentID == id);
                if(DataManager.DeleteAppointment(appointment))
                {
                    AppointmentManager.AllAppointments.Remove(appointment);
                    AppointmentTable.Remove(appointment.AppointmentID);
                }
            }
            else
            {
                MessageBox.Show("No rows selected!", "Error!");
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Appointments_Table.Rows[Appointments_Table.CurrentCell.RowIndex].Cells[0].Value.ToString());
            if (Appointments_Table.Rows[Appointments_Table.CurrentCell.RowIndex].Cells[0].Value != null)
            {
                Appointment appointment = AppointmentManager.AllAppointments.First(a => a.AppointmentID == id);
                new EditAppointmentForm(appointment).Show();
            }
            else
            {
                MessageBox.Show("No rows selected!", "Error!");
            }
        }
    }
}
