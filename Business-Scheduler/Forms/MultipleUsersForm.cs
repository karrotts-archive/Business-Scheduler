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
    public partial class MultipleUsersForm : Form
    {
        public MultipleUsersForm(List<Customer> customers)
        {
            InitializeComponent();
            TableController tableController = new TableController(MultipleUsers_Table);
            for (int i = 0; i < customers.Count; i++)
            {
                tableController.Add(convertToStringArray(customers[i]));
            }
        }

        private string[] convertToStringArray(Customer customer)
        {
            string address = $"{customer.Address.AddressLineOne} {customer.Address.AddressLineTwo}, {customer.Address.City.CityName}, {customer.Address.City.Country.CountryName} {customer.Address.PostalCode}";
            string[] arr = {customer.CustomerID.ToString(), customer.CustomerName, address, customer.Address.Phone, customer.Active == 1 ? "True" : "False"};
            return arr;
        }

        private void MultipleUsers_Table_SelectionChanged(object sender, EventArgs e)
        {
            if (MultipleUsers_Table.Rows[MultipleUsers_Table.CurrentCell.RowIndex].Cells[0].Value != null)
            {
                Select_Button.Enabled = true;
            } else
            {
                Select_Button.Enabled = false;
            }
        }

        private void Select_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (MultipleUsers_Table.Rows[MultipleUsers_Table.CurrentCell.RowIndex].Cells[0].Value != null)
                {
                    List<Customer> customers = DataManager.SearchForCustomer(Int32.Parse(MultipleUsers_Table.Rows[MultipleUsers_Table.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                    FormCollection formCollection = Application.OpenForms;
                    foreach (Form form in formCollection)
                    {
                        if (form.Name == "EditDeleteCustomerForm")
                        {
                            EditDeleteCustomerForm.Results = customers;
                            EditDeleteCustomerForm.Update(customers[0]);
                        }
                        if(form.Name == "AppointmentForm")
                        {
                            AppointmentForm.Customers = customers;
                            AppointmentForm.CustomerName.Text = customers[0].CustomerName;
                        }
                    }
                    Close();
                }
                else
                {
                    throw new Exception("No rows were selected!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
