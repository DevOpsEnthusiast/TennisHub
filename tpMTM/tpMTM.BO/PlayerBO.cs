using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tpMTM.DTO;
using tpMTM.DAL;

namespace tpMTM.BO
{
    public class PlayerBO
    {
        public List<Player> GetAllPlayers()
        {
            return PlayerDAL.GetInstance().GetAllPlayers();
        }

        public Player GetPlayerByName(string name)
        {
            return PlayerDAL.GetInstance().GetByName(name);
        }

        public void AddPlayer(string name, string address, string phone, string email)
        {
            Player player = new Player { Name = name, Address = address, Phone = phone, Email = email };
            //next version, check for player's existence before adding
            PlayerDAL.GetInstance().Add(player);
        }
    }
}
