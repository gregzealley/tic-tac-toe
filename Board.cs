using System;

namespace tic_tac_toe
{
    public class Board
    {
        private char[,] grid;
        private int boardSize;

        public Board(int size)
        {
            grid = new char[size, size];
            boardSize = size;
        }

        public bool MakeMove(char mark, int xPos, int yPos)
        {
            if (grid[xPos, yPos] == '\0')
            {
                grid[xPos, yPos] = mark;
                return true;
            }
            else
            {
                return false;
            }
    }

            

        public char GetMarkAtLocation(int xPos, int yPos)
        {
            return grid[xPos, yPos];
        }

        public bool CheckForWinState(char mark)
        {
            //horizontal win states
            if (grid[0, 0] == mark && grid[0, 1] == mark && grid[0, 2] == mark) { return true; }
            if (grid[1, 0] == mark && grid[1, 1] == mark && grid[1, 2] == mark) { return true; }
            if (grid[2, 0] == mark && grid[2, 1] == mark && grid[2, 2] == mark) { return true; }

            //vertical win states
            if (grid[0, 0] == mark && grid[1, 0] == mark && grid[2, 0] == mark) { return true; }
            if (grid[0, 1] == mark && grid[1, 1] == mark && grid[2, 1] == mark) { return true; }
            if (grid[0, 2] == mark && grid[1, 2] == mark && grid[2, 2] == mark) { return true; }

            //diagonal win states
            if (grid[0, 0] == mark && grid[1, 1] == mark && grid[2, 2] == mark) { return true; }
            if (grid[0, 2] == mark && grid[1, 1] == mark && grid[2, 0] == mark) { return true; }

            return false;
        }
    }
}