using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using tpMTM.BO;

namespace tpMTM
{
    public partial class AddPlayer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            PlayerBO player = new PlayerBO();
            player.AddPlayer(txtName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text);
            Server.Transfer("~/Player.aspx");
        }
    }
}