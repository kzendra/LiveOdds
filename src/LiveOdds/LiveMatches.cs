

namespace LiveOdds
{
    public class LiveMatches
    {
        public LiveMatches() 
        {
        }
        private readonly List<ActiveMatch> _activeMatches;

        public IEnumerable<ActiveMatch> ActiveMatches => _activeMatches;

        public void AddActiveMatch(ActiveMatch activeMatch) { }

        public void FinishActiveMatch(ActiveMatch activeMatch) { }



    }
}
