
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
    }
}