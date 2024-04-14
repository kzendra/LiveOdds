

namespace LiveOdds
{
    public class LiveMatches
    {
        public LiveMatches() 
        {
            _matches = new List<Match>();
        }
        private readonly List<Match> _matches;

        public IEnumerable<Match> Matches => _matches;

        internal void StartMatch(string homeTeam, string awayTeam)
        {
            var match = new Match(homeTeam, awayTeam);
            _matches.Add(match);
        }
    }
}
