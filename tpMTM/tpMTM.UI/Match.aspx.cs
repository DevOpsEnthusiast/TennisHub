using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using tpMTM.BO;

namespace tpMTM
{
    public partial class Match : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvMatches.DataSource = new MatchBO().GetAllMatches();
                gvMatches.DataBind();
            }
        }
    }
}