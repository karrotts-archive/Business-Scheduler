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

        //Lambda expression to check if phone number is in the correct format
        public static bool CheckValidPhoneNumber(string number) => Regex.Match(number, @"^[1-9]\d{2}-\d{3}-\d{4}$").Success;

        //Lambda to convert time from UTC to local
        public static DateTime ConvertFromUTC(DateTime time) => TimeZoneInfo.ConvertTimeFromUtc(DateTime.SpecifyKind(time, DateTimeKind.Utc), TimeZoneInfo.Local);

        #region Customer
        public static List<Customer> AllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            List<string[]> data = QueryDatabase("SELECT * FROM customer");
            for(int i = 0; i < data.Count; i++)
            {
                customers.Add(BuildCustomer(data[i]));   
            }
            return customers;
        }
        /// <summary>
        /// Search customer by name
        /// </summary>
        /// <param name="name">Name of customer</param>
        /// <returns></returns>
        public static List<Customer> SearchForCustomer(string name)
        {
            List<Customer> customers = new List<Customer>();
            List<string[]> customerInfo = QueryDatabase($"SELECT * FROM customer WHERE customerName LIKE \'%{name}%\'");

            //Check if the information is in the correct format and there is more than one record
            if (customerInfo.Count > 0 && customerInfo[0].Length == 9)
            {
                if(customerInfo.Count == 1)
                {
                    //Build customer and return single element list
                     customers.Add(BuildCustomer(customerInfo[0]));
                    return customers;
                }
                else
                {
                    //Build all customers and return all customers that match the search
                    for(int i = 0; i < customerInfo.Count; i++)
                    {
                        customers.Add(BuildCustomer(customerInfo[i]));
                    }
                    return customers;
                }
            }
            else
            {
                MessageBox.Show("No customers were found!", "Error!");
                return null;
            }
        }

        /// <summary>
        /// Search customer by ID
        /// </summary>
        /// <param name="id">ID of customer</param>
        /// <returns></returns>
        public static List<Customer> SearchForCustomer(int id)
        {
            List<Customer> customer = new List<Customer>();
            List<string[]> customerInfo = QueryDatabase("SELECT * FROM customer WHERE customerId = " + id);
            if (customerInfo.Count == 1 && customerInfo[0].Length == 9)
            {
                customer.Add(BuildCustomer(customerInfo[0])); ;
                return customer;
            }
            else
            {
                MessageBox.Show("No customers were found!", "Error!");
                return null;
            }
        }

        /// <summary>
        /// Creates a new customer an object with the customer object
        /// </summary>
        /// <param name="customer"></param>
        public static void CreateNewCustomer(Customer customer)
        {
            try
            {
                //Reverse build customers to generate a new id for each customer table element
                //Build country entry
                Execute($"INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (" +
                        $"\"{customer.Address.City.Country.CountryName}\"," +
                        $"'{ConvertDateTime(customer.Address.City.Country.CreateDate.ToUniversalTime())}'," +
                        $"\"{customer.Address.City.Country.CreatedBy}\"," +
                        $"'{ConvertDateTime(customer.Address.City.Country.LastUpdate.ToUniversalTime())}'," +
                        $"\"{customer.Address.City.Country.LastUpdatedBy}\")");

                //Update customer object with new countryID
                int countryID = Int32.Parse(QueryDatabase($"SELECT countryId FROM country WHERE createDate = '{ConvertDateTime(customer.Address.City.Country.CreateDate.ToUniversalTime())}'")[0][0]);
                customer.Address.City.Country.CountryID = countryID;

                //Build new city entry
                Execute($"INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (" +
                        $"\"{customer.Address.City.CityName}\"," +
                        $"{customer.Address.City.Country.CountryID}," +
                        $"'{ConvertDateTime(customer.Address.City.CreateDate.ToUniversalTime())}'," +
                        $"\"{customer.Address.City.CreatedBy}\"," +
                        $"'{ConvertDateTime(customer.Address.City.LastUpdate.ToUniversalTime())}'," +
                        $"\"{customer.Address.City.LastUpdateBy}\")");

                //Update customer object with new cityID
                int cityID = Int32.Parse(QueryDatabase($"SELECT cityId FROM city WHERE createDate = '{ConvertDateTime(customer.Address.City.CreateDate.ToUniversalTime())}'")[0][0]);
                customer.Address.City.CityID = cityID;

                //Build new address entry
                Execute($"INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (" +
                        $"\"{customer.Address.AddressLineOne}\"," +
                        $"\"{customer.Address.AddressLineTwo}\"," +
                        $"{customer.Address.City.CityID}," +
                        $"\"{customer.Address.PostalCode}\"," +
                        $"\"{customer.Address.Phone}\"," +
                        $"'{ConvertDateTime(customer.Address.CreateDate.ToUniversalTime())}'," +
                        $"\"{customer.Address.CreatedBy}\"," +
                        $"'{ConvertDateTime(customer.Address.LastUpdate.ToUniversalTime())}'," +
                        $"\"{customer.Address.LastUpdateBy}\")");

                //Update customer object with new addressID
                int addressID = Int32.Parse(QueryDatabase($"SELECT addressId FROM address WHERE createDate = '{ConvertDateTime(customer.Address.CreateDate.ToUniversalTime())}'")[0][0]);
                customer.Address.AddressID = addressID;

                //Build the entire customer with forign keys
                Execute($"INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (" +
                        $"\"{customer.CustomerName}\"," +
                        $"{customer.Address.AddressID}," +
                        $"{customer.Active}," +
                        $"'{ConvertDateTime(customer.Address.City.CreateDate.ToUniversalTime())}'," +
                        $"\"{customer.Address.City.CreatedBy}\"," +
                        $"'{ConvertDateTime(customer.Address.City.LastUpdate.ToUniversalTime())}'," +
                        $"\"{customer.Address.City.LastUpdateBy}\")");

                int customerID = Int32.Parse(QueryDatabase($"SELECT customerId FROM customer WHERE createDate = '{ConvertDateTime(customer.CreateDate.ToUniversalTime())}'")[0][0]);
                customer.CustomerID = customerID;
                CustomerManager.Customers.Add(customer);

                MessageBox.Show("New customer successfully created!", "Success!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }
        }

        /// <summary>
        /// Updates customer information
        /// </summary>
        /// <param name="customer"></param>
        public static bool UpdateCustomerInfo(Customer customer)
        {
            try
            {
                //Update customer table
                Execute($"UPDATE customer SET " +
                        $"customerName = '{customer.CustomerName}'," +
                        $" active = '{customer.Active}'," +
                        $" lastUpdate = '{ConvertDateTime(DateTime.Now.ToUniversalTime())}'," +
                        $" lastUpdateBy = '{Username}'" +
                        $" WHERE customerId = '{customer.CustomerID}'");

                //Update address table
                Execute($"UPDATE address SET " +
                        $"address = '{customer.Address.AddressLineOne}'," +
                        $" address2 = '{customer.Address.AddressLineTwo}'," +
                        $" postalCode = '{customer.Address.PostalCode}'," +
                        $" phone = '{customer.Address.Phone}'," +
                        $" lastUpdate = '{ConvertDateTime(DateTime.Now.ToUniversalTime())}'," +
                        $" lastUpdateBy = '{Username}'" +
                        $" WHERE addressId = '{customer.Address.AddressID}'");

                //Update city table
                Execute($"UPDATE city SET " +
                        $"city = '{customer.Address.City.CityName}'," +
                        $"lastUpdate = '{ConvertDateTime(DateTime.Now.ToUniversalTime())}'," +
                        $"lastUpdateBy = '{Username}'" +
                        $" WHERE cityId = '{customer.Address.City.CityID}'");

                //Update country table
                Execute($"UPDATE country SET " +
                        $"country = '{customer.Address.City.Country.CountryName}'," +
                        $"lastUpdate = '{ConvertDateTime(DateTime.Now.ToUniversalTime())}'," +
                        $"lastUpdateBy = '{Username}'" +
                        $" WHERE countryId = '{customer.Address.City.Country.CountryID}'");

                CustomerManager.UpdateCustomer(customer);
                return true; //Update success!
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return false;
            }
        }

        /// <summary>
        /// Deletes customer from database
        /// </summary>
        /// <param name="customer">Customer object</param>
        /// <returns>True if customer is deleted</returns>
        public static bool DeleteCustomer(Customer customer)
        {
            var verify = MessageBox.Show("Are you sure you want to delete this customer?", "Notice", MessageBoxButtons.YesNo);
            if(verify == DialogResult.Yes)
            {
                try
                {
                    CustomerManager.Customers.Remove(customer);
                    Execute($"DELETE FROM appointment WHERE customerId = {customer.CustomerID}");
                    Execute($"DELETE FROM customer WHERE customerId = {customer.CustomerID}");
                    MessageBox.Show("Customer successfully deleted!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                    return false;
                }
            }
            MessageBox.Show("Customer was not deleted!");
            return false;
        }


        #endregion

        #region Appointments
        /// <summary>
        /// Gets all appointments
        /// </summary>
        /// <returns></returns>
        public static List<string[]> AllAppointments()
        {
            return QueryDatabase("SELECT * FROM appointment");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appointment"></param>
        public static void CreateNewAppointment(Appointment appointment)
        {
            //Appointment should be fully validated when passed into data manager
            try
            {
                Execute($"INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (" +
                    $"'{appointment.CustomerID}'," +
                    $"'{appointment.UserID}'," +
                    $"'{appointment.Title}'," +
                    $"'{appointment.Description}'," +
                    $"'{appointment.Location}'," +
                    $"'{appointment.Contact}'," +
                    $"'{appointment.Type}'," +
                    $"'{appointment.URL}'," +
                    $"'{ConvertDateTime(appointment.Start.ToUniversalTime())}'," +
                    $"'{ConvertDateTime(appointment.End.ToUniversalTime())}'," +
                    $"'{ConvertDateTime(appointment.CreateDate.ToUniversalTime())}'," +
                    $"'{appointment.CreatedBy}'," +
                    $"'{ConvertDateTime(appointment.LastUpdate.ToUniversalTime())}'," +
                    $"'{appointment.LastUpdateBy}')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public static bool UpdateAppointmentInfo(Appointment appointment)
        {
            try
            {
                Execute($"UPDATE appointment SET " +
                        $"customerId = '{appointment.CustomerID}'," +
                        $" userId = '{appointment.UserID}'," +
                        $" title = '{appointment.Title}'," +
                        $" description = '{appointment.Description}'," +
                        $" location = '{appointment.Location}'," +
                        $" contact = '{appointment.Contact}'," +
                        $" type = '{appointment.Type}'," +
                        $" url = '{appointment.URL}'," +
                        $" start = '{ConvertDateTime(appointment.Start)}'," +
                        $" end = '{ConvertDateTime(appointment.End)}'," +
                        $" createDate = '{ConvertDateTime(appointment.CreateDate)}'," +
                        $" createdBy = '{appointment.CreatedBy}'," +
                        $" lastUpdate = '{ConvertDateTime(DateTime.Now.ToUniversalTime())}'," +
                        $" lastUpdateBy = '{appointment.LastUpdateBy}'" +
                        $" WHERE appointmentId = {appointment.AppointmentID}");
                return true; //Update success!
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public static bool DeleteAppointment(Appointment appointment)
        {
            var verify = MessageBox.Show("Are you sure you want to delete this appointment?", "Notice", MessageBoxButtons.YesNo);
            if (verify == DialogResult.Yes)
            {
                try
                {
                    Execute($"DELETE FROM appointment WHERE appointmentId = {appointment.AppointmentID}");
                    AppointmentManager.AllAppointments.Remove(appointment);
                    MainForm.MonthlyTable.Remove(appointment.AppointmentID);
                    MainForm.WeeklyTable.Remove(appointment.AppointmentID);
                    MessageBox.Show("Appointment successfully deleted!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                    return false;
                }
            }
            MessageBox.Show("Appointment was not deleted!");
            return false;
        }
        #endregion

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
                    LogManager.Log(Username + ":" + UserID + " has logged in at " + DateTime.Now.ToUniversalTime().ToString() + " UTC\n");

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
    }
}
