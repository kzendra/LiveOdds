using System.Security.Cryptography.X509Certificates;

namespace LiveOdds
{
    public class Match
    {
        public Match(string homeTeam, string awayTeam)
        {
            
        }

        public string HomeTeam {  get; private set; }

        public string AwayTeam { get; private set; }

        public int HomeScore { get; private set; }

        public int AwayScore { get; private set; }
    }
}
