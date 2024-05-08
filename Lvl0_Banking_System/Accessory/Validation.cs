using model;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessory
{
    public class Validation
    {
        public bool UserExists(User user)
        {
            DatabaseAccess data = new DatabaseAccess();

            try
            {
                data.SetStoredProcedure("userExistsSP");
                data.SetParameters("@username", user.Username);

                data.ExecuteReader();

                if (data.Reader.Read())
                    return true;
                else return false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
