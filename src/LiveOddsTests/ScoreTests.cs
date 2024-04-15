
namespace LiveOdds.Tests
{
    [TestClass()]
    public class ScoreTests
    {
        [TestMethod()]
        public void ScoreTest()
        {
            Score score = new();

            Assert.IsTrue(score.HomeScore == 0);
            Assert.IsTrue(score.AwayScore == 0);
        }
    }
}