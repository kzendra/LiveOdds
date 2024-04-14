

namespace LiveOdds
{
    public class LiveMatches
    {
        private readonly List<Match> _matches;

        public IEnumerable<Match> Matches => _matches;

        internal void StartMatch(string homeTeam, string awayTeam)
        {
            throw new NotImplementedException();
        }
    }
}
