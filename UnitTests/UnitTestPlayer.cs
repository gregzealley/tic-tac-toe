using NUnit.Framework;
using tic_tac_toe;

namespace UnitTests
{
    [TestFixture]
    class UnitTestPlayer
    {
        [Test]
        public void WhenICreateAPlayer_ThenParametersAreStored()
        {
            var expectedName = "TestName";
            var expectedMark = 'X';
            var expectedPlayerType = PlayerType.Human;

            Player testPlayer = new Player(expectedName, expectedMark, expectedPlayerType);

            Assert.AreEqual(expectedName, testPlayer.Name);
            Assert.AreEqual(expectedMark, testPlayer.Mark);
            Assert.AreEqual(expectedPlayerType, testPlayer.Type);
        }
    }
}
