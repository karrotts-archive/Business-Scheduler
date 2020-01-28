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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if(DataManager.LoginUser(Username_Box.Text, Password_Box.Text))
            {
                new MainForm().Show();
                Hide();
            }
            else
            {
                Error_Message.Text = "Credentials Could Not Be Verified! Please Try Again!";
            }
        }
    }
}
