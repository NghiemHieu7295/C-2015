using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public static class CustomerDB
    {
        /// <summary>
        /// Get the customer with the specified customer ID
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns>The customer that has given ID</returns>
        public static Customer GetCustomer(int customerID)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string statement = @"SELECT CustomerID, Name, Address, City, State, ZipCode
                                 FROM Customers
                                 WHERE CustomerID = @CustomerID";
            SqlCommand command = new SqlCommand(statement, connection);
            command.Parameters.AddWithValue("CustomerID", customerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                if(reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = (int)reader["CustomerID"];
                    customer.Name = reader["Name"].ToString();
                    customer.Address = reader["Address"].ToString();
                    customer.City = reader["City"].ToString();
                    customer.State = reader["State"].ToString();
                    customer.ZipCode = reader["ZipCode"].ToString();
                    return customer;
                }
                else
                {
                    return null;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Update a customer to database
        /// </summary>
        /// <param name="oldCustomer"></param>
        /// <param name="newCustomer"></param>
        /// <returns>True if the update operation is success, otherwise retur false</returns>
        public static bool UpdateCustomer(Customer oldCustomer, Customer newCustomer)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string statement = @"UPDATE Customers SET " +
                                "Name = @NewName, " +
                                "Address = @NewAddress, " +
                                "City = @NewCity, " +
                                "State = @NewState, " +
                                "ZipCode = @NewZipCode " +
                                "WHERE CustomerID = @OldCustomerID " + 
                                "AND Name = @OldName " +
                                "AND Address = @OldAddress " +
                                "AND City = @OldCity " +
                                "AND State = @OldState " +
                                "AND ZipCode = @OldZipCode";
            SqlCommand command = new SqlCommand(statement, connection);
            command.Parameters.AddWithValue("NewName", newCustomer.Name);
            command.Parameters.AddWithValue("NewAddress", newCustomer.Address);
            command.Parameters.AddWithValue("NewCity", newCustomer.City);
            command.Parameters.AddWithValue("NewState", newCustomer.State);
            command.Parameters.AddWithValue("NewZipCode", newCustomer.ZipCode);

            command.Parameters.AddWithValue("OldCustomerID", oldCustomer.CustomerID);
            command.Parameters.AddWithValue("OldName", oldCustomer.Name);
            command.Parameters.AddWithValue("OldAddress", oldCustomer.Address);
            command.Parameters.AddWithValue("OldCity", oldCustomer.City);
            command.Parameters.AddWithValue("OldState", oldCustomer.State);
            command.Parameters.AddWithValue("OldZipCode", oldCustomer.ZipCode);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Add a customer to database
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>The ID of customer just be added</returns>
        public static int AddCustomer(Customer customer)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string statement = @"INSERT INTO Customers " +
                               "(Name, Address, City, State, ZipCode) " +
                               "VALUES (" +
                               "@Name, @Address, @City, @State, @ZipCode)";
            SqlCommand command = new SqlCommand(statement, connection);
            command.Parameters.AddWithValue("Name", customer.Name);
            command.Parameters.AddWithValue("Address", customer.Address);
            command.Parameters.AddWithValue("City", customer.City);
            command.Parameters.AddWithValue("State", customer.State);
            command.Parameters.AddWithValue("ZipCode", customer.ZipCode);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                string selectStatement = @"SELECT IDENT_CURRENT('Customers') FROM Customers";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int newCustomerID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return newCustomerID;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Delete the customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>True if the delete operation is success, otherwise retur false</returns>
        public static bool DeleteCustomer(Customer customer)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string statement = @"DELETE FROM Customers " +
                               "WHERE CustomerID = @CustomerID " + 
                               "AND Name = @Name " +
                               "AND Address = @Address " +
                               "AND City = @City " +
                               "AND State = @State " +
                               "AND ZipCode = @ZipCode";
            SqlCommand command = new SqlCommand(statement, connection);
            command.Parameters.AddWithValue("CustomerID", customer.CustomerID);
            command.Parameters.AddWithValue("Name", customer.Name);
            command.Parameters.AddWithValue("Address", customer.Address);
            command.Parameters.AddWithValue("City", customer.City);
            command.Parameters.AddWithValue("State", customer.State);
            command.Parameters.AddWithValue("ZipCode", customer.ZipCode);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
