using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakkajaiGameOfLife.ConsoleUI
{
    public class GameOfLife
    {
        public int[,] Grid { get; set; }
        private int[,] NextGrid { get; set; }
        public string PatternName { get; set; }

        public GameOfLife(int choice)
        {
            Grid = PopulationGenerator.PopulateGrid(Grid, choice);
        }

        public void Tick()
        {
            UpdateGrid();
            DisplayGrid();
        }

        private void UpdateGrid()
        {
            int cols = Grid.GetLength(0);
            int rows = Grid.GetLength(1);
            int[,] NextGrid = new int[cols, rows];
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    int state = Grid[i, j];
                    int neighbours = Grid.CountNeighbour(i, j);
                    if (state == 0 && neighbours == 3)
                    {
                        NextGrid[i, j] = 1;
                    }
                    else if (state == 1 && (neighbours < 2 || neighbours > 3))
                    {
                        NextGrid[i, j] = 0;
                    }
                    else
                    {
                        NextGrid[i, j] = state;
                    }
                }
            }
            Grid = NextGrid;
        }

        public void DisplayGrid()
        {
            int cols = Grid.GetLength(0);
            int rows = Grid.GetLength(1);
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (Grid[i, j] == 1)
                    {
                        Console.Write("██");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
