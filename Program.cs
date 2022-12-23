using Battleship.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            bool exit = false;

            Console.WriteLine("BATTLESHIP");
            Console.WriteLine();
            PrintHelp();

            while (!exit)
            {
                Console.WriteLine("Input command:");
                command = Console.ReadLine();
                Console.WriteLine();

                if (command == "p")
                {
                    PlayGame();
                }
                else if (command == "h")
                {
                    PrintHelp();
                }
                else if (command == "x")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("ERROR - Invalid Command");
                }

            }

            Console.WriteLine("Good bye...");
            
        }

        private static void PlayGame()
        {
            string commandPlay;
            bool stop = false;
            Game game = new Game();
            PrintPlayHelp();

            while (!stop)
            {
                Console.WriteLine("Action:");
                commandPlay = Console.ReadLine();
                Console.WriteLine();

                if (commandPlay == "s")
                {
                    game.StartGame();
                }
                else if (commandPlay.Length > 1 && CheckAttackInput(commandPlay))
                {
                    game.PlayerAttack(commandPlay);
                }
                else if (commandPlay == "h")
                {
                    PrintPlayHelp();
                }
                else if (commandPlay == "x")
                {
                    stop = true;
                    Console.WriteLine("Quitting game");
                }
                else
                {
                    Console.WriteLine("ERROR - Invalid Command");
                }

            }

        }

        private static bool CheckAttackInput(string tile)
        {
            Match result = Regex.Match(tile, @"\b[A-J]{1}\d{1}\b");

            return result.Success;
        }

        private static void PrintHelp()
        {
            Console.WriteLine("Battleship Help Menu");
            Console.WriteLine("p - Play the game");
            Console.WriteLine("h - Print this help menu");
            Console.WriteLine("x - Exit the program");
            Console.WriteLine();
        }

        private static void PrintPlayHelp()
        {
            Console.WriteLine("Help Menu");
            Console.WriteLine("s - Start / restart the game");
            Console.WriteLine("Tile - Select the place of attack for example : A5 or F1");
            Console.WriteLine("h - Print this help menu");
            Console.WriteLine("x - Stop and quit the game");
            Console.WriteLine();
        }
    }
}