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

        [TestMethod()]
        [DataRow(0, 1)]
        [DataRow(1, 0)]
        [DataRow(1, 1)]
        public void UpdateScoreTest_Success(uint home, uint away)
        {
            Score score = new();
            score.UpdateScore(home, away);
            Assert.AreEqual(home, score.HomeScore);
            Assert.AreEqual(away, score.AwayScore); 
        }

        [TestMethod()]
        [DataRow(0, 1)]
        [DataRow(1, 0)]
        [DataRow(1, 1)]
        public void UpdateScoreTest_ThrowsArgumentException(uint home, uint away)
        {
            Score score = new();
            score.UpdateScore(2, 2);
            Assert.ThrowsException<ArgumentException>(() => score.UpdateScore(home, away));
        }
    }
}