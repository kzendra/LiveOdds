
using LiveOdds;
using System.Text.RegularExpressions;

namespace LiveOddsTests
{
    [TestClass()]
    public class LiveMatchesTests
    {
        [TestMethod()]
        [DataRow("Mexico", "Canada")]
        public async void StartMatchTest(string homeTeam, string awayTeam)
        {
            LiveMatches liveMatches = new();
            liveMatches.StartMatch(homeTeam, awayTeam);
            var match = liveMatches.Matches.First();
            Assert.IsTrue(liveMatches.Matches.Count() == 1);
            Assert.AreEqual(homeTeam, match.HomeTeam);
            Assert.AreEqual(awayTeam, match.AwayTeam);
            Assert.IsTrue(match.HomeScore == 0);
            Assert.IsTrue(match.AwayScore == 0);
        }
    }
}
