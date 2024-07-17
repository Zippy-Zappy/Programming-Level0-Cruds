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
        }
    }
}