
namespace LiveOdds
{
    public class ActiveMatch
    {
        public ActiveMatch(Match match) 
        {
            Match = match ?? throw new ArgumentNullException(nameof(match));
            Score = new();
            TimeStarted = DateTime.UtcNow;
        }

        public Match Match { get; private set; }

        public Score Score { get; private set; }

        public DateTime TimeStarted { get; private set; }

    }
}
