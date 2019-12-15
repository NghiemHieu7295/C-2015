using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public static class MMABooksDB
    {
        /// <summary>
        /// Create and return the connection object for connecting to database
        /// </summary>
        /// <returns>The connection string</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\SqlExpress;Initial Catalog=MMABooks;
                Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
