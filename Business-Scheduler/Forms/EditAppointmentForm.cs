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
    public partial class EditAppointmentForm : Form
    {
        public static Appointment EditAppointment;
        public EditAppointmentForm(Appointment appointment)
        {
            InitializeComponent();
            EditAppointment = appointment;
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
