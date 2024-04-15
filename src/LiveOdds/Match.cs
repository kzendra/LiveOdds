
namespace LiveOdds
{
    public class Match
    {
        internal Match(string homeTeam, string awayTeam)
        {
            if (string.IsNullOrWhiteSpace(homeTeam))
                throw new ArgumentNullException(nameof(homeTeam));
            if (string.IsNullOrWhiteSpace(awayTeam))
                throw new ArgumentNullException(nameof(awayTeam));
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }

        public string HomeTeam {  get; private set; }

        public string AwayTeam { get; private set; }
    }
}
