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
        public float GetBalance(User user)
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
        public void Withdraw(User user, float amount)
        {
            DatabaseAccess data = new DatabaseAccess();

            try
            {
                data.SetStoredProcedure("withdrawSP");
                data.SetParameters("@id", user.Id);
                data.SetParameters("@amount", amount);

                if (GetBalance(user) < amount)
                    return;

                data.ExecuteProcess();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { data.CloseConnection(); }
        }
        public void Deposit(User user, float amount)
        {
            DatabaseAccess data = new DatabaseAccess();

            try
            {
                data.SetStoredProcedure("depositSP");
                data.SetParameters("@Id", user.Id);
                data.SetParameters("@amount", amount);

                data.ExecuteProcess();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { data.CloseConnection(); }
        }
    }

}
