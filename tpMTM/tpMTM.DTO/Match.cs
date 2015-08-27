using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpMTM.DTO
{
    public class Match
    {
        public Player Player1 { get; set; }

        public Player Player2 { get; set; }

        public string Score { get; set; }
        public Player Winner { get; set; }
        public Match()
        {
        }
    }
}
