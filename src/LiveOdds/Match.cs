
namespace LiveOdds
{
    public class Match
    {
        internal Match(string homeTeam, string awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }

        public string HomeTeam {  get; private set; }

        public string AwayTeam { get; private set; }
    }
}
