using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board gameBoard = new Board(3);
            Player playerOne = new Player("Bob", 'X', PlayerType.Human);
            Player playerTwo = new Player("Jim", 'O', PlayerType.Human);

            bool gameHasBeenWon = false;

            do
            {
                Console.Write("Enter your X position: ");
                int playerXMove = Int32.Parse(Console.ReadLine());

                Console.Write("Enter your Y position: ");
                int playerYMove = Int32.Parse(Console.ReadLine());

                if (gameBoard.MakeMove(playerOne.Mark, (int)playerXMove, playerYMove) == false)
                {

                }

            } while (!gameHasBeenWon);

            //get move from player
            //check if valid move
            //if so, place, if not, re-prompt
            //check for win

        }
    }
}
