using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int WinPosition = 100;
            int position = 0;

            Random random = new Random();

            while (position < WinPosition)
            {
                //Player rolls the die to get a number between 1 to 6
                int dieRoll = random.Next(1, 7);

                //Player checks for an option
                int option = random.Next(0, 3); // 0: No Play, 1: Ladder, 2: Snake

                switch (option)
                {
                    case 0:
                        // No Play
                        break;
                    case 1:
                        // Ladder
                        position += dieRoll;
                        break;
                    case 2:
                        // Snake
                        position -= dieRoll;
                        break;
                }

                // Ensure position is within bounds
                position = Math.Max(0, position);
                position = Math.Min(WinPosition, position);

                Console.WriteLine($"Rolled a {dieRoll}, landed on {position}");
            }

            Console.WriteLine("You won!");

            // Reset game if player wants to play again
            Console.WriteLine("Do you want to play again? (y/n)");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                Main(args); // Recursive call to start a new game
            }
            Console.ReadLine();
        }    
    }
}
