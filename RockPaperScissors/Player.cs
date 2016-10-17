using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors
{
    public class Player
    {
        private readonly List<Move> _moves = new List<Move>();

        public int Score { get; set; }

        public Player()
        {
            _moves.Add(new Rock());
            _moves.Add(new Paper());
            _moves.Add(new Scissors());
        }

        public Move Move()
        {
            return _moves.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
        }
    }
}