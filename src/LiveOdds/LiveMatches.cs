

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
            if (activeMatch == null)
                throw new ArgumentNullException(nameof(activeMatch));

            if (_activeMatches.Any(x => x == activeMatch))
                throw new ArgumentException(nameof(activeMatch));

            _activeMatches.Add(activeMatch);
        }

        public void FinishActiveMatch(ActiveMatch activeMatch) 
        {
            if (activeMatch == null)
                throw new ArgumentNullException(nameof(activeMatch));

            if (!_activeMatches.Any(x => x == activeMatch))
                throw new ArgumentException("Entity not found", nameof(activeMatch));

            _activeMatches.Remove(activeMatch);
        }



    }
}
