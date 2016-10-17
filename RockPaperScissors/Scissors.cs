namespace RockPaperScissors
{
    public class Scissors : Move
    {
        public override bool Beats(Move move)
        {
            return move.GetType() == typeof(Paper);
        }
    }
}