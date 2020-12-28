using System;
using System.Collections.Generic;
using System.Text;

namespace Tron
{
    class IOTower : IGameFeatures
    {
        private string[,] grid;

        private int rows { get; }
        private int cols { get; }

        public IOTower(string[,] grid) 
        {
            this.grid = grid;

            rows = grid.GetLength(0);
            cols = grid.GetLength(1);
        }

        public void Draw()
        {
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    string gridElements = grid[x, y];
                    Console.SetCursorPosition(x,y);

                    Console.Write(gridElements);
                }
            }
        }

        public bool IsPositionValid(int xCoord, int yCoord)
        {
            if (xCoord < 0 || yCoord < 0 || xCoord >= cols || yCoord >= rows)
                return false;

            return grid[yCoord, xCoord] == " " || 
                grid[yCoord, xCoord] == "X";

        }
    }
}
