using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tpMTM.DTO;

namespace tpMTM.DAL
{
    public class MatchDAL
    {
        private static MatchDAL _instance;

        public static MatchDAL GetInstance()
        {
            if(_instance == null)
                _instance = new MatchDAL();

            return _instance;
        }

        public List<Match> Matches { get; set; }

        private MatchDAL()
        {
            Matches = new List<Match>();
            PopulateMatches();
        }

        public List<Match> GetAllMatches()
        {
            return this.Matches;
        }

        public void Add(Match match)
        {
            Matches.Add(match);
        }

        private void PopulateMatches()
        {
            Matches.Clear();

            Player Roger = PlayerDAL.GetInstance().GetByName("Roger Federer");
            Player Rafa = PlayerDAL.GetInstance().GetByName("Rafael Nadal");
            Player Nole = PlayerDAL.GetInstance().GetByName("Novak Djokovic");
            Player Andy = PlayerDAL.GetInstance().GetByName("Andy Murray"); 
            
            Matches.Add(new Match{ Player1 = Roger, Player2 = Rafa, Score = "7-5,4-6,2-6", Winner = Rafa });
            Matches.Add(new Match { Player1 = Roger, Player2 = Nole, Score = "7-6,6-7,6-4", Winner = Roger });
            Matches.Add(new Match { Player1 = Nole, Player2 = Andy, Score = "7-6,4-6,6-0", Winner = Nole
            });
        }
    }
}