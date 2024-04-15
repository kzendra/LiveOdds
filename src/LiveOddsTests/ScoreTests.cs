using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiveOdds;

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
        [DataRow((uint)0, (uint)1)]
        [DataRow((uint)1, (uint)0)]
        [DataRow((uint)1, (uint)1)]
        public void UpdateScoreTest_Success(uint home, uint away)
        {
            Score score = new();
            score.UpdateScore(home, away);
            Assert.AreEqual(home, score.HomeScore);
            Assert.AreEqual(away, score.AwayScore);
        }

        [TestMethod()]
        [DataRow((uint)0, (uint)1)]
        [DataRow((uint)1, (uint)0)]
        [DataRow((uint)1, (uint)1)]
        public void UpdateScoreTest_ThrowsArgumentException(uint home, uint away)
        {
            Score score = new();
            score.UpdateScore(2, 2);
            Assert.ThrowsException<ArgumentException>(() => score.UpdateScore(home, away));
        }

        [TestMethod()]
        [DataRow((uint)0, (uint)0, (uint)0)]
        [DataRow((uint)0, (uint)1, (uint)1)]
        [DataRow((uint)1, (uint)0, (uint)1))]
        [DataRow((uint)1, (uint)1, (uint)2))]
        [DataRow((uint)1, (uint)2, (uint)3))]
        public void TotalScoreTest(uint home, uint away, uint total)
        {
            Score score = new();
            score.UpdateScore(home, away);
            Assert.AreEqual(total, score.TotalScore());
        }
    }
}