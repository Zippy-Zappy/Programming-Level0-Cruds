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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            Authentication auth = new Authentication();
            User user = new User();
            try
            {
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;

                auth.Register(user);
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex);
            }
        }
    }
}