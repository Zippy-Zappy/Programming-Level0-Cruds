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
        private readonly SqlConnection connection;
        private readonly SqlCommand command;
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
            try
            {
                connection.Open();
                reader = command.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CloseConnection()
        {
            if (Reader != null)
                Reader.Close();

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
