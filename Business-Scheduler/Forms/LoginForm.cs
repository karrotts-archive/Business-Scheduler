using System;
using System.Windows.Forms;
using Business_Scheduler.Data;
using System.Globalization;
using System.Threading;

namespace Business_Scheduler.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture;
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("FR-fr");
            Company_Label.Text = Properties.strings.Company_Name;
            Login_Label.Text = Properties.strings.Login;
            Username_Label.Text = Properties.strings.Username;
            Password_Label.Text = Properties.strings.Password;
            Login_Button.Text = Properties.strings.Login;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Username_Box.Enabled = false;
            Password_Box.Enabled = false;
            Login_Button.Enabled = false;
            if(DataManager.LoginUser(Username_Box.Text, Password_Box.Text))
            {
                CustomerManager.GetAllCustomers();
                AppointmentManager.GetAllAppointments();
                new MainForm().Show();
                Hide();
            }
            else
            {
                Error_Message.Text = Properties.strings.Invalid_Credentials;
                Username_Box.Enabled = true;
                Password_Box.Enabled = true;
                Login_Button.Enabled = true;
            }
        }
    }
}
