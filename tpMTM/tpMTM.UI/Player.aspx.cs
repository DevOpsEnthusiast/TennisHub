using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using tpMTM.DTO;
using tpMTM.BO;

namespace tpMTM
{
    public partial class Player : System.Web.UI.Page
    {
        PlayerBO player = new PlayerBO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvPlayers.DataSource = player.GetAllPlayers();
                gvPlayers.DataBind();
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            List<tpMTM.DTO.Player> players = new List<tpMTM.DTO.Player>();
            players.Add(player.GetPlayerByName(txtName.Value));
            gvPlayers.DataSource = players;
            gvPlayers.DataBind();
        }

        protected void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/AddPlayer.aspx");
        }
    }
}