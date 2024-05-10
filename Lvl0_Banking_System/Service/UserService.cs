using AccesoDatos;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService
    {
        public float ShowBalance(User user)
        {
            DatabaseAccess data = new DatabaseAccess();

            try
            {
                data.SetStoredProcedure("showBalanceSP");
                data.SetParameters("@id", user.Id);

                data.ExecuteReader();

                if (data.Reader.Read())
                {
                    user.Balance = Convert.ToSingle(data.Reader["Balance"]);

                    return user.Balance; 
                }

                return 0.00f;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { data.CloseConnection(); }
        }
    }
}
