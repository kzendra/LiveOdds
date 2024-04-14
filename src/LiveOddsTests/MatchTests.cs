
using System.Runtime.CompilerServices;
using Xunit;

namespace LiveOdds.Tests
{
    [TestClass()]
    public class MatchTests
    {
        [TestMethod()]
        [DataRow("Mexico", "Canada")]
        [DataRow("Spain", "Brazil")]
        [DataRow("Germany", "France")]
        [DataRow("Uruguay", "Italy")]
        [DataRow("Argentina", "Australia")]
        public void MatchTest(string homeTeam, string awayTeam)
        {
            var match = new Match(homeTeam, awayTeam);
            Assert.AreEqual(homeTeam, match.HomeTeam);
            Assert.AreEqual(awayTeam, match.AwayTeam);
            Assert.IsTrue(match.HomeScore == 0);
            Assert.IsTrue(match.AwayScore == 0);
        }

        [TestMethod()]
        [DataRow(0, 1)]
        [DataRow(1, 0)]
        [DataRow(2, 1)]
        [DataRow(1, 2)]
        public void UpdateScoreTest(int homeScore, int awayScore)
        {
            Match match = new("Mexico", "Canada");

            match.UpdateScore(homeScore, awayScore);
            Assert.AreEqual(homeScore, match.HomeScore);
            Assert.AreEqual(awayScore, match.AwayScore);
        }
    }
}