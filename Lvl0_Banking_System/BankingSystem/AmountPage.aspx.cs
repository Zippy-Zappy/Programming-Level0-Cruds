using model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingSystem
{
    public partial class AmountPage : System.Web.UI.Page
    {
        public bool ConfirmAmount { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace((string)Session["action"]))
                Session.Add("error", "You didn't arrive to this page from the default page.");
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            ConfirmAmount = true;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            User user = (User)Session["userSession"];

            try
            {
                if ((string)Session["action"] == "deposit")
                    service.Deposit(user, float.Parse(txtAmount.Text));
                else if ((string)Session["action"] == "withdraw")
                    service.Withdraw(user, float.Parse(txtAmount.Text));

                Response.Redirect("Default.aspx");

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }
    }
}