using System;
using model;
using Service;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingSystem
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userSession"] != null)
            {
                try
                {
                    ShowAmount((User)Session["userSession"]);
                }
                catch (Exception ex)
                {
                    Session.Add("error", ex.ToString());

                }
            }
        }

        protected void btnWithdraw_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            User user = (User)Session["userSession"];
            try
            {
                service.Withdraw(user, 2000);
                //service.Withdraw(user, (float)Session["amount"]);
                //ShowAmount(user);
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            User user = (User)Session["userSession"];

            try
            {
                service.Deposit(user, 2000);
                //service.Deposit(user, (float)Session["amount"]);
                //ShowAmount(user);
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }
        protected void ShowAmount(User user)
        {
            UserService service = new UserService();
            try
            {
                lblBalance.Text = $"${service.GetBalance(user)}";
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }
    }
}