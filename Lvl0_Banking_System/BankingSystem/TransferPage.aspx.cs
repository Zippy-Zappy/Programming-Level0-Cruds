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
    public partial class TransferPage : System.Web.UI.Page
    {
        public bool ConfirmTransfer { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            ConfirmTransfer = true;
            chkConfirmTransfer.Text = $" I am sending ${txtAmount.Text} to {txtDestination.Text}";
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            User user = (User)Session["userSession"];

            try
            {
                service.Transfer(user, float.Parse(txtAmount.Text), txtDestination.Text);
                Response.Redirect("Default.aspx");
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }
    }
}