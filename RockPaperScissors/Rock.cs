namespace RockPaperScissors
{
    public class Rock : Move
    {
        public override bool Beats(Move move)
        {
            return move.GetType() == typeof(Scissors);
        }
    }
}