using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using model;
using Microsoft.Win32;

namespace Service
{
    public class Authentication
    {
        //public bool Login(string username, string password)
        //{
        //    DatabaseAccess data = new DatabaseAccess();
        //    data.SetStoredProcedure("");
        //    return true;
        //}
        public void Register(User user)
        {
            DatabaseAccess data = new DatabaseAccess();
            try
            {
                data.SetStoredProcedure("registerSP");
                data.SetParameters("@username", user.Username);
                data.SetParameters("@password", user.Password);

                data.ExecuteProcess();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { data.CloseConnection(); }
        }
        public bool Login(User user)
        {
            DatabaseAccess data = new DatabaseAccess();
            try
            {
                data.SetStoredProcedure("loginSP");
                data.SetParameters("@username", user.Username);
                data.SetParameters("@password", user.Password);

                data.ExecuteReader();

                if (data.Reader.Read())
                {
                    user.Id = (int)data.Reader["Id"];
                    user.Username = (string)data.Reader["Username"];
                    user.Password = (string)data.Reader["Password"];

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { data.CloseConnection(); }
        }
    }
}
