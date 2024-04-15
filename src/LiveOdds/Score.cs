using System.Runtime.InteropServices.Marshalling;

namespace LiveOdds
{
    public class Score
    {
        internal Score() { }

        public Score(uint home, uint away) { }

        public uint HomeScore { get; private set; }

        public uint AwayScore { get; private set; }
    }
}
