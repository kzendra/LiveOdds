
using LiveOdds;
using System.Text.RegularExpressions;

namespace LiveOddsTests
{
    [TestClass()]
    public class LiveMatchesTests
    {
        [TestMethod]
        public void LiveMatchesConstructorTest() 
        { 
            var liveMatches = new LiveMatches();
            Assert.IsNotNull(liveMatches.Matches);
            Assert.IsFalse(liveMatches.Matches.Any());
        }

        [TestMethod()]
        [DataRow("Mexico", "Canada")]
        public void StartMatchTest(string homeTeam, string awayTeam)
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
