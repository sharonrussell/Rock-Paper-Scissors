namespace RockPaperScissors
{
    public abstract class Move
    {
        public abstract bool Beats(Move move);
    }
}