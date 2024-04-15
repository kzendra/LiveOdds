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
            Assert.IsTrue(liveMatches.ActiveMatches.Any());
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
            Assert.ThrowsException<ArgumentException>(() =>  liveMatches.AddActiveMatch(activeMatch));
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

    }
}

