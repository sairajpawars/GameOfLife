using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MakkajaiGameOfLife.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool inPlayMode = false;
                Console.Clear();
                Console.WriteLine("Game of Life Paterns: \n1: Block Pattern\n2: Boat Pattern\n3: Blinker Pattern\n4: Toad Pattern\n9: Exit");
                Console.Write("Enter the Type of Pattern: ");
                string getInput = Console.ReadLine();
                if (Regex.IsMatch(getInput, @"^\d+$"))
                {
                    int input = Convert.ToInt32(getInput);
                    if (input == 9)
                    {
                        break;
                    }
                    if(input<=0 || input>4 || input > 9)
                    {
                        Console.WriteLine("Wrong Input");
                        Thread.Sleep(1000);
                        continue;
                    }
                    GameOfLife game = new GameOfLife(input);
                    Console.Clear();
                    inPlayMode = true;
                    Console.WriteLine("Press Escape to go back.");
                    Console.WriteLine("Press Spacebar to Tick.");
                    game.DisplayGrid();
                    while (inPlayMode)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        switch (key.Key)
                        {
                            case ConsoleKey.Spacebar:
                                Console.Clear();
                                Console.WriteLine("Press Escape to go back.");
                                Console.WriteLine("Press Spacebar to Tick.");
                                game.Tick();
                                break;

                            case ConsoleKey.Escape:
                                inPlayMode = false;
                                break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                    Thread.Sleep(1000);
                    continue;
                }
            }

        }
    }
}
        