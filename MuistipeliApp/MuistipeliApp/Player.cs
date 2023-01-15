using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuistipeliApp
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int Index { get; set; }
        public int TotalMatches { get; set; }
    }
}
