using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiveOdds;

namespace LiveOdds.Tests
{
    [TestClass()]
    public class LiveMatchesTests
    {
        [TestMethod]
        public void LiveMatches_Create()
        {
            var liveMatches = new LiveMatches();
            Assert.IsNotNull(liveMatches.ActiveMatches);
            Assert.IsFalse(liveMatches.ActiveMatches.Any());
        }

        [TestMethod()]
        public void AddActiveMatchTest_Success()
        {
            var liveMatches = new LiveMatches();
            Match match = new("Mexico", "Canada");
            ActiveMatch activeMatch = new(match);
            liveMatches.AddActiveMatch(activeMatch);
            Assert.IsTrue(liveMatches.ActiveMatches.Any(x => x == activeMatch));
        }

        [TestMethod]
        public void AddActiveMatchTest_ThrowsArgumentNullException()
        {
            var liveMatches = new LiveMatches();
            Assert.ThrowsException<ArgumentNullException>(() => liveMatches.AddActiveMatch(null));
        }

        [TestMethod]
        public void AddActiveMatchTest_ThrowsArgumentException()
        {
            var liveMatches = new LiveMatches();
            Match match = new("Mexico", "Canada");
            ActiveMatch activeMatch = new(match);
            liveMatches.AddActiveMatch(activeMatch);
            Assert.ThrowsException<ArgumentException>(() => liveMatches.AddActiveMatch(activeMatch));
        }


        [TestMethod()]
        public void FinishActiveMatchTest_Sucess()
        {
            var liveMatches = new LiveMatches();
            Match match = new("Mexico", "Canada");
            ActiveMatch activeMatch = new(match);
            liveMatches.AddActiveMatch(activeMatch);
            liveMatches.FinishActiveMatch(activeMatch);
            Assert.IsFalse(liveMatches.ActiveMatches.Any(x => x == activeMatch));
        }

        [TestMethod()]
        public void FinishActiveMatchTest_ThrowsArgumentNullException()
        {
            var liveMatches = new LiveMatches();
            Match match = new("Mexico", "Canada");
            ActiveMatch activeMatch = new(match);
            liveMatches.AddActiveMatch(activeMatch);
            Assert.ThrowsException<ArgumentNullException>(() => liveMatches.FinishActiveMatch(null));
        }

        [TestMethod()]
        public void FinishActiveMatchTest_ThrowsArgumentException()
        {
            var liveMatches = new LiveMatches();
            Match match = new("Mexico", "Canada");
            ActiveMatch activeMatch = new(match);
            Assert.ThrowsException<ArgumentException>(() => liveMatches.FinishActiveMatch(activeMatch));
        }

        [TestMethod()]
        public void GetSummaryTest()
        {
            var liveMatches = new LiveMatches();

            Match match = new("Mexico", "Canada");
            ActiveMatch activeMatch1 = new(match);
            activeMatch1.Score.UpdateScore(0, 5);
            liveMatches.AddActiveMatch(activeMatch1);

            match = new("Spain", "Brazil");
            ActiveMatch activeMatch2 = new(match);
            activeMatch2.Score.UpdateScore(10, 2);
            liveMatches.AddActiveMatch(activeMatch2);

            match = new("Germany", "France");
            ActiveMatch activeMatch3 = new(match);
            activeMatch3.Score.UpdateScore(2, 2);
            liveMatches.AddActiveMatch(activeMatch3);

            match = new("Uruguay", "Italy");
            ActiveMatch activeMatch4 = new(match);
            activeMatch4.Score.UpdateScore(6, 6);
            liveMatches.AddActiveMatch(activeMatch4);

            match = new("Argentina", "Australia");
            ActiveMatch activeMatch5 = new(match);
            activeMatch5.Score.UpdateScore(3, 1);
            liveMatches.AddActiveMatch(activeMatch5);

            var summary = liveMatches.GetSummary();

            Assert.AreEqual(activeMatch4, summary.ElementAt(0));
            Assert.AreEqual(activeMatch2, summary.ElementAt(1));
            Assert.AreEqual(activeMatch1, summary.ElementAt(2));
            Assert.AreEqual(activeMatch5, summary.ElementAt(3));
            Assert.AreEqual(activeMatch3, summary.ElementAt(4));
        }
    }
}

