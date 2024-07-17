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
            try
            {
                hdnAction.Value = "withdraw";
                Session.Add("action", hdnAction.Value);
                Response.Redirect("AmountPage.aspx");
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
            }
        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                hdnAction.Value = "deposit";
                Session.Add("action", hdnAction.Value);
                Response.Redirect("AmountPage.aspx");

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