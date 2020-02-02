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
    public partial class EditDeleteCustomerForm : Form
    {
        public static List<Customer> Results;
        public static TextBox NameBox;

        public EditDeleteCustomerForm()
        {
            InitializeComponent();
            NameBox = Name_Box;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = Int32.Parse(Search_Box.Text);
                Results = DataManager.SearchForCustomer(customerId);
            }
            catch(Exception ex)
            {
                Results = DataManager.SearchForCustomer(Search_Box.Text);
            }

            if(Results.Count > 1)
            {
                new MultipleUsersForm(Results).Show();
            }
            else
            {
                Update(Results[0]);
            }
        }

        public static void Update(Customer customer)
        {
            NameBox.Text = customer.CustomerName;
        }
    }
}
