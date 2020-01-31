using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Business_Scheduler.Exceptions;
using Business_Scheduler.Forms;
using System.Text.RegularExpressions;

namespace Business_Scheduler.Data
{
    static class DataManager
    {
        public static int UserID;
        public static string Username;

        private static string ConnectionString = "Server=3.227.166.251;Database=U05HpJ;User ID=U05HpJ;Password=53688502876;convert zero datetime=True";

        //Lambda expression to convert DataTime into valid input for MySQL
        public static string ConvertDateTime(DateTime dt) => dt.ToString("yyyy-MM-dd HH:mm:ss");

        //
        public static bool CheckValidPhoneNumber(string number) => Regex.Match(number, @"^[1-9]\d{2}-\d{3}-\d{4}$").Success;

        /// <summary>
        /// Search customer by name
        /// </summary>
        /// <param name="name">Name of customer</param>
        /// <returns></returns>
        public static void SearchForCustomer(string name)
        {
            List<string[]> customerInfo = QueryDatabase($"SELECT * FROM customer WHERE customerName LIKE \'%{name}%\'");

            //Check if the information is in the correct format and there is only one record
            if (customerInfo.Count > 0 && customerInfo[0].Length == 9)
            {
                if(customerInfo.Count == 1)
                {
                    EditDeleteCustomerForm.Results = BuildCustomer(customerInfo[0]);
                }
                else
                {
                    List<Customer> customerList = new List<Customer>();
                    for(int i = 0; i < customerInfo.Count; i++)
                    {
                        customerList.Add(BuildCustomer(customerInfo[i]));
                    }

                    new MultipleUsersForm(customerList).Show();
                }
            }
            else
            {
                MessageBox.Show("No customers were found!", "Error!");
                EditDeleteCustomerForm.Results = null;
            }
        }

        /// <summary>
        /// Search customer by ID
        /// </summary>
        /// <param name="id">ID of customer</param>
        /// <returns></returns>
        public static void SearchForCustomer(int id)
        {
            List<string[]> customerInfo = QueryDatabase("SELECT * FROM customer WHERE customerId = " + id);
            EditDeleteCustomerForm.Results = BuildCustomer(customerInfo[0]);
        }

        private static Customer BuildCustomer(string[] customerInfo)
        {
            List<string[]> addressInfo = QueryDatabase($"SELECT * FROM address WHERE addressId = {customerInfo[2]}");
            List<string[]> cityInfo = QueryDatabase($"SELECT * FROM city WHERE cityId = {addressInfo[0][3]}");
            List<string[]> countryInfo = QueryDatabase($"SELECT * FROM country WHERE countryId = {cityInfo[0][2]}");
            Country country = new Country(Int32.Parse(countryInfo[0][0]), countryInfo[0][1], Convert.ToDateTime(countryInfo[0][2]), countryInfo[0][3], Convert.ToDateTime(countryInfo[0][4]), countryInfo[0][5]);
            City city = new City(Int32.Parse(cityInfo[0][0]), cityInfo[0][1], country, Convert.ToDateTime(cityInfo[0][3]), cityInfo[0][4], Convert.ToDateTime(cityInfo[0][5]), cityInfo[0][6]);
            Address address = new Address(Int32.Parse(addressInfo[0][0]), addressInfo[0][1], addressInfo[0][2], addressInfo[0][4], city, addressInfo[0][5], Convert.ToDateTime(addressInfo[0][6]), addressInfo[0][7], Convert.ToDateTime(addressInfo[0][8]), addressInfo[0][9]);
            Customer customer = new Customer(Int32.Parse(customerInfo[0]), customerInfo[1], address, bool.Parse(customerInfo[3]) ? 1 : 0, Convert.ToDateTime(customerInfo[4]), customerInfo[5], Convert.ToDateTime(customerInfo[6]), customerInfo[7]);
            return customer;
        }

        /// <summary>
        /// Search for appointment by ID
        /// </summary>
        /// <param name="id">ID of appointment</param>
        /// <returns></returns>
        public static List<string> SearchForAppointment(int id)
        {
            return null; //QueryDatabase("SELECT * FROM customer WHERE appointmentId = " + id);
        }

        /// <summary>
        /// Creates a new customer an object with the customer object
        /// </summary>
        /// <param name="customer"></param>
        public static void CreateNewCustomer(Customer customer)
        {
            try
            {
                Execute($"INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (" +
                        $"\"{customer.Address.City.Country.CountryName}\"," +
                        $"'{ConvertDateTime(customer.Address.City.Country.CreateDate)}'," +
                        $"\"{customer.Address.City.Country.CreatedBy}\"," +
                        $"'{ConvertDateTime(customer.Address.City.Country.LastUpdate)}'," +
                        $"\"{customer.Address.City.Country.LastUpdatedBy}\")");

                int countryID = Int32.Parse(QueryDatabase($"SELECT countryId FROM country WHERE createDate = '{ConvertDateTime(customer.Address.City.Country.CreateDate)}'")[0][0]);
                customer.Address.City.Country.CountryID = countryID;

                Execute($"INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (" +
                        $"\"{customer.Address.City.CityName}\"," +
                        $"{customer.Address.City.Country.CountryID}," +
                        $"'{ConvertDateTime(customer.Address.City.CreateDate)}'," +
                        $"\"{customer.Address.City.CreatedBy}\"," +
                        $"'{ConvertDateTime(customer.Address.City.LastUpdate)}'," +
                        $"\"{customer.Address.City.LastUpdateBy}\")");

                int cityID = Int32.Parse(QueryDatabase($"SELECT cityId FROM city WHERE createDate = '{ConvertDateTime(customer.Address.City.CreateDate)}'")[0][0]);
                customer.Address.City.CityID = cityID;

                Execute($"INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (" +
                        $"\"{customer.Address.AddressLineOne}\"," +
                        $"\"{customer.Address.AddressLineTwo}\"," +
                        $"{customer.Address.City.CityID}," +
                        $"\"{customer.Address.PostalCode}\"," +
                        $"\"{customer.Address.Phone}\"," +
                        $"'{ConvertDateTime(customer.Address.CreateDate)}'," +
                        $"\"{customer.Address.CreatedBy}\"," +
                        $"'{ConvertDateTime(customer.Address.LastUpdate)}'," +
                        $"\"{customer.Address.LastUpdateBy}\")");

                int addressID = Int32.Parse(QueryDatabase($"SELECT addressId FROM address WHERE createDate = '{ConvertDateTime(customer.Address.CreateDate)}'")[0][0]);
                customer.Address.AddressID = addressID;

                Execute($"INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (" +
                        $"\"{customer.CustomerName}\"," +
                        $"{customer.Address.AddressID}," +
                        $"{customer.Active}," +
                        $"'{ConvertDateTime(customer.Address.City.CreateDate)}'," +
                        $"\"{customer.Address.City.CreatedBy}\"," +
                        $"'{ConvertDateTime(customer.Address.City.LastUpdate)}'," +
                        $"\"{customer.Address.City.LastUpdateBy}\")");

                MessageBox.Show("New customer successfully created!", "Success!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }
        }

        public static void CreateNewAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public static void UpdateCustomerInfo(Customer customer)
        {
            throw new NotImplementedException();
        }

        public static void UpdateAppointmentInfo(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public static void DeleteCustomer(Customer customer)
        {
            var verify = MessageBox.Show("Are you sure you want to delete this customer?", "Notice", MessageBoxButtons.YesNo);
            if(verify == DialogResult.Yes)
            {
                Execute($"DELETE FROM customer WHERE customerId = {customer.CustomerID}"); 
            }
        }

        public static void DeleteCustomer(int customerId)
        {
            var verify = MessageBox.Show("Are you sure you want to delete this customer?", "Notice", MessageBoxButtons.YesNo);
            if (verify == DialogResult.Yes)
            {
                Execute($"DELETE FROM customer WHERE customerId = {customerId}");
            }
        }

        public static void DeleteAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries database to see if any user match the user/pass combo
        /// Sets the currently logged in user information if passes
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Boolean</returns>
        public static bool LoginUser(string username, string password)
        {
            try
            {
                List<string[]> user = QueryDatabase("SELECT * FROM user WHERE userName=\"" + username + "\"AND password=\"" + password + "\"");
                if (user != null && user.Count == 1)
                {
                    //Set currently logged in user information for easy access
                    UserID = Int32.Parse(user[0][0]);
                    Username = user[0][1];

                    //Log user login to log file
                    LogManager.Log(Username + ":" + UserID + " has logged in at " + DateTime.Now.ToString() + "\n");

                    return true;
                }

                throw new IncorrectLoginException();
            }
            catch (IncorrectLoginException ex)
            {
                MessageBox.Show(ex.Message, "Incorrect Login!");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return false;
            }
        }

        /// <summary>
        /// Queries database with provided SQL string
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>String List</returns>
        private static List<string[]> QueryDatabase(string sql)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                string value = "";
                List<string[]> values = new List<string[]>();

                while(reader.Read())
                {
                    value = "";
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader[i].ToString() != null)
                        {
                            value += reader[i].ToString() + "~";
                        }
                    }
                    string[] split = value.Split('~');
                    values.Add(split);
                }

                reader.Close();
                command.Dispose();
                connection.Close();

                return values;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
                return null;
            }
        }

        private static void Execute(string sql)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                int i = command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }
        }
    }
}
