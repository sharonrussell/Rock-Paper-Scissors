namespace RockPaperScissors
{
    public class Paper : Move
    {
        public override bool Beats(Move move)
        {
            return move.GetType() == typeof(Rock);
        }
    }
}