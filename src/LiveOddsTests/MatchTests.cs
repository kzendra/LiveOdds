
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
        public void MatchTest_CreateMatch(string homeTeam, string awayTeam)
        {
            var match = new Match(homeTeam, awayTeam);

            Assert.AreEqual(homeTeam, match.HomeTeam);
            Assert.AreEqual(awayTeam, match.AwayTeam);
        }

        [TestMethod()]
        [DataRow("", "Canada")]
        [DataRow("Spain", "")]
        [DataRow("", "")]
        [DataRow(null, null)]
        public void MatchTest_ThrowsException(string homeTeam, string awayTeam)
        {
            Assert.ThrowsException<ArgumentException>(() => new Match(homeTeam, awayTeam));
        }
    }
}