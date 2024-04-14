
using System.Runtime.CompilerServices;
using Xunit;

namespace LiveOdds.Tests
{
    [TestClass()]
    public class MatchTests
    {
        [TestMethod()]
        [InlineData("Mexico", "Canada")]
        [InlineData("Spain", "Brazil")]
        [InlineData("Germany", "France")]
        [InlineData("Uruguay", "Italy")]
        [InlineData("Argentina", "Australia")]
        public void MatchTest(string homeTeam, string awayTeam)
        {
            Assert.Fail();
        }
    }
}