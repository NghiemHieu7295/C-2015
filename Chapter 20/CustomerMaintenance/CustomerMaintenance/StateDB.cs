using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public static class StateDB
    {
        /// <summary>
        /// Get all states in DB
        /// </summary>
        /// <returns>A list contains all state</returns>
        public static List<State> GetStates()
        {
            List<State> states = new List<State>();

            SqlConnection connection = MMABooksDB.GetConnection();
            string statement = @"SELECT StateCode, StateName FROM States";
            SqlCommand command = new SqlCommand(statement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    State state = new State();
                    state.StateCode = reader["StateCode"].ToString();
                    state.StateName = reader["StateName"].ToString();
                    states.Add(state);
                }
                return states;
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
