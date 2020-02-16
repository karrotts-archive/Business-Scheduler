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
            var DistinctTypes = AppointmentManager.AllAppointments.Select(x => x.Type).Distinct();
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            for (int i = 0; i < 12; i++)
            {
                foreach (var type in DistinctTypes)
                {
                    IEnumerable<Appointment> QueryType =
                    from appointment in AppointmentManager.AllAppointments
                    where appointment.Type == type &&
                    appointment.Start.Month == i
                    select appointment;

                    if (QueryType.ToList().Count > 0)
                    {
                        MessageBox.Show(months[i - 1] + ": " + QueryType.ToList()[0].Type + " " + QueryType.ToList().Count.ToString());
                    }
                }
            }
        }

        private void ReportTwo_Button_Click(object sender, EventArgs e)
        {

        }

        private void ReportThree_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
