using NUnit.Framework;
using tic_tac_toe;

namespace UnitTests
{
    [TestFixture]
    public class UnitTestBoard
    {
        Board testBoard;

        [Test]
        public void WhenIMakeAMoveToAnEmptySpace_ThenMoveIsAccepted()
        {
            testBoard = new Board(3);
            char expectedMark = 'X';

            bool result = testBoard.MakeMove(expectedMark, 0, 0);

            Assert.IsTrue(result);
        }

        [Test]
        public void WhenIMakeAMoveToAnEmptySpace_ThenMoveIsStored()
        {
            testBoard = new Board(3);
            char expectedMark = 'X';

            testBoard.MakeMove(expectedMark, 0, 0);

            Assert.AreEqual(expectedMark, testBoard.GetMarkAtLocation(0, 0));
        }

        [Test]
        public void WhenIMakeAMoveToAnOccupiedSpace_ThenMoveIsRejected()
        {
            testBoard = new Board(3);
            char mark = 'X';

            testBoard.MakeMove(mark, 0, 0);
            bool result = testBoard.MakeMove(mark, 0, 0);

            Assert.IsFalse(result);
        }

        [Test]
        public void WhenIMakeAMoveToAnOccupiedSpace_ThenMoveIsNotStored()
        {
            testBoard = new Board(3);
            char previousMark = 'X';
            char newMark = 'O';

            testBoard.MakeMove(previousMark, 0, 0);
            bool result = testBoard.MakeMove(newMark, 0, 0);

            Assert.AreEqual(previousMark, testBoard.GetMarkAtLocation(0, 0));
        }

        [Test]
        public void WhenIMakeAHorizontalWinningMove_ThenWinIsReturned()
        {
            testBoard = new Board(3);

            testBoard.MakeMove('X', 0, 0);
            testBoard.MakeMove('X', 0, 1);
            testBoard.MakeMove('X', 0, 2);

            bool hasWon = testBoard.CheckForWinState('X');

            Assert.IsTrue(hasWon);
        }

        [Test]
        public void WhenIMakeAVerticalWinningMove_ThenWinIsReturned()
        {
            testBoard = new Board(3);

            testBoard.MakeMove('X', 0, 1);
            testBoard.MakeMove('X', 1, 1);
            testBoard.MakeMove('X', 2, 1);

            bool hasWon = testBoard.CheckForWinState('X');

            Assert.IsTrue(hasWon);
        }

        [Test]
        public void WhenIMakeADiagonalWinningMove_ThenWinIsReturned()
        {
            testBoard = new Board(3);

            testBoard.MakeMove('X', 0, 2);
            testBoard.MakeMove('X', 1, 1);
            testBoard.MakeMove('X', 2, 0);

            bool hasWon = testBoard.CheckForWinState('X');

            Assert.IsTrue(hasWon);
        }
    }
}