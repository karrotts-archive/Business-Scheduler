using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business_Scheduler.Data;
using Business_Scheduler.Exceptions;

namespace Business_Scheduler.Forms
{
    public partial class EditDeleteCustomerForm : Form
    {
        public static List<Customer> Results;
        public static TextBox NameBox, AddressOne, AddressTwo, PostalCode, CityBox, CountryBox, PhoneNumberBox;
        public static RadioButton Active, Disabled;
        public static Button SearchButton, DeleteButton, UpdateButton;

        public EditDeleteCustomerForm()
        {
            InitializeComponent();
            NameBox = Name_Box;
            AddressOne = AddressOne_Box;
            AddressTwo = AddressTwo_Box;
            PostalCode = PostalCode_Box;
            CityBox = City_Box;
            CountryBox = Country_Box;
            PhoneNumberBox = PhoneNumber_Box;
            Active = Active_Radio;
            Disabled = Disabled_Radio;
            SearchButton = Search_Button;
            DeleteButton = Delete_Button;
            UpdateButton = Update_Button;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            EnableInput(false);
            try
            {
                int customerId = Int32.Parse(Search_Box.Text);
                Results = DataManager.SearchForCustomer(customerId);
            }
            catch(Exception)
            {
                Results = DataManager.SearchForCustomer(Search_Box.Text);
            }

            if(Results != null)
            {
                if (Results.Count > 1)
                {
                    new MultipleUsersForm(Results).Show();
                }
                else
                {
                    Update(Results[0]);
                }
            }
            else
            {
                EnableInput(true);
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            EnableInput(false);
            try
            {
                //Validate user inputed information in required inputs
                if (Name_Box.Text == "" ||
                   AddressOne_Box.Text == "" ||
                   PostalCode_Box.Text == "" ||
                   City_Box.Text == "" ||
                   Country_Box.Text == "" ||
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

                //Gather and update all the information
                Results[0].CustomerName = NameBox.Text;
                Results[0].Address.AddressLineOne = AddressOne.Text;
                Results[0].Address.AddressLineTwo = AddressTwo.Text;
                Results[0].Address.PostalCode = PostalCode.Text;
                Results[0].Address.City.CityName = CityBox.Text;
                Results[0].Address.City.Country.CountryName = CountryBox.Text;
                Results[0].Address.Phone = PhoneNumberBox.Text;
                Results[0].Active = Active.Checked ? 1 : 0;

                if (DataManager.UpdateCustomerInfo(Results[0]))
                {
                    MessageBox.Show("Customer information updated!");
                    Close();
                }
                else
                {
                    EnableInput(true);
                    MessageBox.Show("Information could not be updated!");
                }
            }
            catch(InvalidCustomerDataException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (Results != null)
            {
                EnableInput(false);
                if (DataManager.DeleteCustomer(Results[0]))
                {
                    Close();
                }
                EnableInput(true);
            }
        }

        /// <summary>
        /// Updates all the information fields to the first customer of Results
        /// </summary>
        /// <param name="customer"></param>
        public static void Update(Customer customer)
        {
            NameBox.Text = customer.CustomerName;
            AddressOne.Text = customer.Address.AddressLineOne;
            AddressTwo.Text = customer.Address.AddressLineTwo;
            PostalCode.Text = customer.Address.PostalCode;
            CityBox.Text = customer.Address.City.CityName;
            CountryBox.Text = customer.Address.City.Country.CountryName;
            PhoneNumberBox.Text = customer.Address.Phone;

            if(customer.Active == 1)
            {
                Active.Checked = true;
            }
            else
            {
                Disabled.Checked = true;
            }
            EnableInput(true);
        }

        /// <summary>
        /// Enables or disables all input fields
        /// </summary>
        /// <param name="val"></param>
        public static void EnableInput(bool val)
        {
            NameBox.Enabled = val;
            AddressOne.Enabled = val;
            AddressTwo.Enabled = val;
            PostalCode.Enabled = val;
            CityBox.Enabled = val;
            CountryBox.Enabled = val;
            PhoneNumberBox.Enabled = val;
            Active.Enabled = val;
            Disabled.Enabled = val;
            SearchButton.Enabled = val;
            DeleteButton.Enabled = val;
            UpdateButton.Enabled = val;
        }
    }
}
