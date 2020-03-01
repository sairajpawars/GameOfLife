using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakkajaiGameOfLife.ConsoleUI
{
    public static class PopulationGenerator
    {
        public static int[,] PopulateGrid(int[,] grid, int choice)
        {
            if (choice == 1)
            {
                grid = new int[2, 2];
                grid[0, 0] = 1;
                grid[0, 1] = 1;
                grid[1, 0] = 1;
                grid[1, 1] = 1;
            }
            else if (choice == 2)
            {
                grid = new int[3, 3];
                grid[0, 1] = 1;
                grid[1, 0] = 1;
                grid[2, 1] = 1;
                grid[0, 2] = 1;
                grid[1, 2] = 1;
            }
            else if (choice == 3)
            {
                grid = new int[3, 3];
                grid[1, 1] = 1;
                grid[1, 0] = 1;
                grid[1, 2] = 1;
            }
            else if (choice == 4)
            {
                grid = new int[5, 5];
                grid[1, 1] = 1;
                grid[1, 2] = 1;
                grid[1, 3] = 1;
                grid[2, 2] = 1;
                grid[2, 3] = 1;
                grid[2, 4] = 1;
            }
            return grid;
        }
    }
}
