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
using Business_Scheduler.Controllers;

namespace Business_Scheduler.Forms
{
    public partial class MainForm : Form
    {
        public static TableController MonthlyTable;
        public static TableController WeeklyTable;

        public MainForm()
        {
            InitializeComponent();
            MonthlyTable = new TableController(Month_Table);
            WeeklyTable = new TableController(Week_Table);
            AppointmentManager.AlertAppointment();
            AppointmentManager.PopulateTables();
        }

        private void NewCustomer_Button_Click(object sender, EventArgs e)
        {
            new UserForm().Show();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void DeleteCustomer_Button_Click(object sender, EventArgs e)
        {
            new EditDeleteCustomerForm().Show();
        }

        private void UpdateCustomer_Button_Click(object sender, EventArgs e)
        {
            new EditDeleteCustomerForm().Show();
        }

        private void NewAppointment_Button_Click(object sender, EventArgs e)
        {
            new AppointmentForm().Show();
        }

        private void View_Button_Click(object sender, EventArgs e)
        {
            new ViewAppointmentForm().Show();
        }

        private void Reports_Button_Click(object sender, EventArgs e)
        {
            new ReportsForm().Show();
        }
    }
}
