using System;
using Accessory;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingSystem
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Security.ActiveSession(Session["userSession"])))
            {
                if (!(Page is Login || Page is Register))
                    Response.Redirect("Login.aspx", false);
            }
        }
    }
}