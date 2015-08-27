using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tpMTM.DTO;

namespace tpMTM.DAL
{
    public class PlayerDAL
    {
        private static PlayerDAL _instance;

        public static PlayerDAL GetInstance()
        {
            if(_instance == null)
                _instance = new PlayerDAL();

            return _instance;
        }

        public List<Player> Players { get; set; }

        private PlayerDAL()
        {
            Players = new List<Player>();
            PopulatePlayers();
        }

        public List<Player> GetAllPlayers()
        {
            return this.Players;
        }

        public Player GetByName(string name)
        {
            var players = from Player player in Players where player.Name == name select player;
            if (players.Count() == 1)
                return players.ElementAt(0);
            else
                return null;
        }

        public void Add(Player player)
        {
            Player existingPlayer = GetByName(player.Name);
            if (existingPlayer != null)
                throw new Exception("Player already exists");
            
            Players.Add(player);
        }

        public void Delete(string playerName)
        {
            Player player = GetByName(playerName);
            Players.Remove(player);
        }

        private void PopulatePlayers()
        {
            Players.Clear();
            Players.Add(new Player() { id=1, Name = "Roger Federer", Address = "Earth's Heaven", Email = "roger@federers.com" });
            Players.Add(new Player() { id = 2, Name = "Rafael Nadal", Address = "Mallorca, Spain", Email = "rafa@rafanadal.com" });
            Players.Add(new Player() { id = 3, Name = "Novak Djokovic", Address = "Serbia", Email = "nole@novakdjokovic.com" });
            Players.Add(new Player() { id = 4, Name = "Andy Murray", Address = "Scottland", Email = "andy@murray.com" });
            Players.Add(new Player() { id = 5, Name = "Ernest Gulbis", Address = "Latvia", Email = "i.am@gulbis.com" });
        }
    }
}
