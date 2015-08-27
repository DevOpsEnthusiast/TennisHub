using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tpMTM.DTO;
using tpMTM.DAL;

namespace tpMTM.BO
{
    public class MatchBO
    {
        public List<Match> GetAllMatches()
        {
            return MatchDAL.GetInstance().GetAllMatches();
        }

        public void AddMatch(string player1Name, string player2Name, string score)
        {
            PlayerBO playerbo = new PlayerBO();
            Player player1 = playerbo.GetPlayerByName(player1Name);
            Player player2 = playerbo.GetPlayerByName(player2Name);

            Match match = new Match();
            match.Player1 = player1;
            match.Player2 = player2;
            match.Score = score;

            match.Winner = FindWinner(score, player1, player2);

            MatchDAL.GetInstance().Add(match);
        }

        public Player FindWinner(string score, Player player1, Player player2)
        {
            return player1;
        }
    }
}
