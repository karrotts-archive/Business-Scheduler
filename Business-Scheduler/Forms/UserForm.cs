using System;
using System.Windows.Forms;
using Business_Scheduler.Data;
using Business_Scheduler.Exceptions;

namespace Business_Scheduler.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void setEnabled(bool val)
        {
            Name_Box.Enabled = val;
            AddressOne_Box.Enabled = val;
            AddressTwo_Box.Enabled = val;
            PostalCode_Box.Enabled = val;
            City_Box.Enabled = val;
            Country_Box.Enabled = val;
            PhoneNumber_Box.Enabled = val;
            Active_Radio.Enabled = val;
            Disabled_Radio.Enabled = val;
            Create_Button.Enabled = val;
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            setEnabled(false);
            try
            {
                //Validate user inputed information in required inputs
                if (Name_Box.Text       == "" ||
                   AddressOne_Box.Text  == "" ||
                   PostalCode_Box.Text  == "" ||
                   City_Box.Text        == "" ||
                   Country_Box.Text     == "" ||
                   PhoneNumber_Box.Text == "")
                {
                    throw new InvalidCustomerDataException("All required inputs must contain data.");
                }

                //Validate user selected one of the radio button options
                if (!Active_Radio.Checked && !Disabled_Radio.Checked)
                {
                    throw new InvalidCustomerDataException("Active or disabled radio must be selected!");
                }

                //Validate phone number is in the correct format
                if (!DataManager.CheckValidPhoneNumber(PhoneNumber_Box.Text))
                {
                    throw new InvalidCustomerDataException("Phone number must be in the following format: ###-###-####");
                }

                int addressValue = Active_Radio.Checked ? 1 : 0;

                Country country = new Country(Country_Box.Text, DateTime.Now, DataManager.CurrentUser.Username, DateTime.Now, DataManager.CurrentUser.Username);
                City city = new City(City_Box.Text, country, DateTime.Now, DataManager.CurrentUser.Username, DateTime.Now, DataManager.CurrentUser.Username);
                Address address = new Address(AddressOne_Box.Text, AddressTwo_Box.Text, PostalCode_Box.Text, city, PhoneNumber_Box.Text, DateTime.Now, DataManager.CurrentUser.Username, DateTime.Now, DataManager.CurrentUser.Username);
                Customer customer = new Customer(Name_Box.Text, address, addressValue, DateTime.Now, DataManager.CurrentUser.Username, DateTime.Now, DataManager.CurrentUser.Username);
                DataManager.CreateNewCustomer(customer);

                Close();
            }
            catch(InvalidCustomerDataException ex)
            {
                setEnabled(true);
                MessageBox.Show(ex.Message, "Invalid Customer Data!");
            }
            catch(Exception ex)
            {
                setEnabled(true);
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
