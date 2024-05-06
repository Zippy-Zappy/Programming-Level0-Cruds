using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DatabaseAccess
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public DatabaseAccess()
        {
            connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
            command = new SqlCommand();
        }

        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public void SetStoredProcedure(string sp)
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = sp;
        }

        public void SetParameters(string name, object value)
        {
            command.Parameters.AddWithValue(name, value);
        }

        public void ExecuteReader()
        {
            command.Connection = connection;
        }

        public void CloseConnection()
        {
            if (reader != null)
                reader.Close();

            connection.Close();
        }

        public void ExecuteProcess()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
