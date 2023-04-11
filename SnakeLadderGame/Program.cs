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
                // UC1: Player rolls the die to get a number between 1 to 6
                int dieRoll = random.Next(1, 7);

                // UC2: Player checks for an option
                int option = random.Next(0, 3); // 0: No Play, 1: Ladder, 2: Snake

                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        position += dieRoll;
                        break;
                    case 2:
                        position -= dieRoll;
                        break;
                }
                position = Math.Max(0, position);
                position = Math.Min(WinPosition, position);

                Console.WriteLine($"Rolled a {dieRoll}, landed on {position}");
            }

            Console.WriteLine("You won!");
            Console.ReadLine();
        }
    }
}
