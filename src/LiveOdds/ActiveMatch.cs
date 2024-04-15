
namespace LiveOdds
{
    public class ActiveMatch
    {
        public ActiveMatch(Match match) 
        {
        }

        public Match Match { get; private set; }

        public Score Score { get; private set; }

        public DateTime TimeStarted { get; private set; }

    }
}
