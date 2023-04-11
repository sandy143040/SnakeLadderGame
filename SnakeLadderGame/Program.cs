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
            using System;

class Program
        {
            static void Main(string[] args)
            {
                const int WinPosition = 100;
                int position = 0;
                int numRolls = 0;

                Random random = new Random();

                while (position < WinPosition)
                {
                    int dieRoll = random.Next(1, 7);
                    int option = random.Next(0, 3); 

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

                    numRolls++;

                    Console.WriteLine($"Roll #{numRolls}: Rolled a {dieRoll}, landed on {position}");
                }

                Console.WriteLine($"Congratulations, you won in {numRolls} rolls!");
                Console.ReadLine();
            }
        }

    }
}
}
