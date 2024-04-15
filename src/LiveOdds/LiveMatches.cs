

namespace LiveOdds
{
    public class LiveMatches
    {
        public LiveMatches() 
        {
            _activeMatches = new List<ActiveMatch>();
        }
        private readonly List<ActiveMatch> _activeMatches;

        public IEnumerable<ActiveMatch> ActiveMatches => _activeMatches;

        public void AddActiveMatch(ActiveMatch activeMatch) 
        {
            ArgumentNullException.ThrowIfNull(activeMatch);

            if (_activeMatches.Any(x => x == activeMatch))
                throw new ArgumentException(nameof(activeMatch));

            _activeMatches.Add(activeMatch);
        }

        public void FinishActiveMatch(ActiveMatch activeMatch) 
        {
            ArgumentNullException.ThrowIfNull(activeMatch);

            if (_activeMatches.Any(x => x == activeMatch))
                _activeMatches.Remove(activeMatch);
            else
                throw new ArgumentException("Entity not found", nameof(activeMatch));

            
        }

        public IEnumerable<ActiveMatch> GetSummary()
        {
            return _activeMatches
                .OrderByDescending(x => x.Score.TotalScore())
                .ThenByDescending(x => x.TimeStarted);
        }
    }
}
