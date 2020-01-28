using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Business_Scheduler.Exceptions;

namespace Business_Scheduler.Data
{
    static class DataManager
    {
        public static string connectionString = "Server=3.227.166.251;Database=U05HpJ;User ID=U05HpJ;Password=53688502876;convert zero datetime=True";
        public static string username;
        public static int userID;

        /// <summary>
        /// Search customer by name
        /// </summary>
        /// <param name="name">Name of customer</param>
        /// <returns></returns>
        public static List<string> SearchForCustomer(string name)
        {
            return QueryDatabase("SELECT * FROM customer WHERE customerName LIKE " + name);
        }

        /// <summary>
        /// Search customer by ID
        /// </summary>
        /// <param name="id">ID of customer</param>
        /// <returns></returns>
        public static List<string> SearchForCustomer(int id)
        {
            return QueryDatabase("SELECT * FROM customer WHERE customerId = " + id);
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
                List<string> user = QueryDatabase("SELECT * FROM user WHERE userName=\"" + username + "\"AND password=\"" + password + "\"");
                if (user != null && user.Count == 1)
                {
                    //Set currently logged in user information for easy access
                    string[] userinfo = user[0].Split(' ');
                    userID = Int32.Parse(userinfo[0]);
                    username = userinfo[1];

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
        private static List<string> QueryDatabase(string sql)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                string value = "";
                List<string> values = new List<string>();

                while(reader.Read())
                {
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader[i].ToString() != null)
                        {
                            value += reader[i].ToString() + " ";
                        }
                    }
                    values.Add(value);
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
    }
}
