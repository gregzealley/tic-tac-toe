using NUnit.Framework;
using tic_tac_toe;

namespace UnitTests
{
    [TestFixture]
    public class UnitTestBoard
    {
        Board testBoard;

        [SetUp]
        public void SetUp()
        {
            testBoard = new Board(3);
        }

        [Test]
        public void WhenICheckASquareThatIsEmpty_ThenIAmToldItsFree()
        {
            bool result = testBoard.IsSquareFree(0, 0);

            Assert.IsTrue(result);
        }

        [Test]
        public void WhenICheckASquareThatIsOccupied_ThenIAmToldItsNotFree()
        {
            testBoard.MakeMove('X', 0, 0);
            bool result = testBoard.IsSquareFree(0, 0);

            Assert.IsFalse(result);
        }

        [Test]
        public void WhenIMakeAMoveToASquare_ThenMoveIsStored()
        {
            char expectedMark = 'X';

            testBoard.MakeMove(expectedMark, 0, 0);

            Assert.AreEqual(expectedMark, testBoard.GetMarkAtLocation(0, 0));
        }

        [Test]
        public void WhenIMakeAWinningHorizontalMove_ThenWinIsReturned()
        {
            testBoard.MakeMove('X', 0, 0);
            testBoard.MakeMove('X', 0, 1);
            testBoard.MakeMove('X', 0, 2);

            bool hasWon = testBoard.CheckForWinState('X');

            Assert.IsTrue(hasWon);
        }

        [Test]
        public void WhenIMakeAWinningVerticalMove_ThenWinIsReturned()
        {
            testBoard.MakeMove('X', 0, 1);
            testBoard.MakeMove('X', 1, 1);
            testBoard.MakeMove('X', 2, 1);

            bool hasWon = testBoard.CheckForWinState('X');

            Assert.IsTrue(hasWon);
        }

        [Test]
        public void WhenIMakeAWinningDiagonalMove_ThenWinIsReturned()
        {
            testBoard.MakeMove('X', 0, 2);
            testBoard.MakeMove('X', 1, 1);
            testBoard.MakeMove('X', 2, 0);

            bool hasWon = testBoard.CheckForWinState('X');

            Assert.IsTrue(hasWon);
        }
    }
}