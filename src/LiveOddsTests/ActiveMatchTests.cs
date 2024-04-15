
namespace LiveOdds.Tests
{
    [TestClass()]
    public class ActiveMatchTests
    {
        [TestMethod()]
        public void ActiveMatchTest_Create()
        {
            Match match = new("Mexico", "Canada");
            ActiveMatch activeMatch = new(match);
            Assert.IsNotNull(activeMatch);
            Assert.IsNotNull(activeMatch.Score);
            Assert.AreEqual(match, activeMatch.Match);
            Assert.IsFalse(activeMatch.TimeStarted == DateTime.MinValue);
        }

        [TestMethod()]
        public void ActiveMatchTest_Throws()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new ActiveMatch(null));
        }
    }
}