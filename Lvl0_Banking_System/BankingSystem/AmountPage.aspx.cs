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

        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            ConfirmAmount = true;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Session.Add("amount", float.Parse(txtAmount.Text));
            Response.Redirect("Default.aspx");
        }
    }
}