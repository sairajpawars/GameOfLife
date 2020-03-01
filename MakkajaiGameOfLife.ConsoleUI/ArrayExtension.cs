using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakkajaiGameOfLife.ConsoleUI
{
    public static class ArrayExtension
    {
        public static int CountNeighbour(this int[,] grid,int x, int y)
        {
            int sum = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int cols = (x + i);
                    int rows = (y + j);
                    sum = (cols < 0 || rows < 0 || cols > grid.GetLength(0) - 1 || rows > grid.GetLength(1) - 1) ?
                        sum += 0 :
                        sum += grid[cols, rows];
                }
            }
            sum -= grid[x, y];
            return sum;
        }
    }
}
