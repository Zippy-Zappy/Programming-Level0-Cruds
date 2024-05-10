using model;
using Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingSystem
{
    public partial class Login : System.Web.UI.Page
    {
        private int loginAttempts;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (IsPostBack)
            {

                if (Session["loginAttempts"] != null)
                    loginAttempts = (int)Session["loginAttempts"];
                else
                    loginAttempts = 0;
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            Authentication auth = new Authentication();

            try
            {
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;

                if (auth.Login(user))
                {
                    Session.Add("userSession", user);
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    loginAttempts++;
                    lblError.Visible = true;
                    lblError.Text = "Incorrect Username or Password.";

                    Session["loginAttempts"] = loginAttempts;

                    if (loginAttempts == 3)
                        lblError.Text = "You have failed to log in three times. You have been temporarily locked out... " +
                            "however that functionality does not exist so you can still try.";

                }

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }

    }
}