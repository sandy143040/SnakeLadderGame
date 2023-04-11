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
            Console.WriteLine("Welcom to Snake Ladder Game");
            int position = 0;
            int diceRolls = 0;
            Random rand = new Random();

            while (position != 100)
            {
                int dice = rand.Next(1, 7);
                int option = rand.Next(0, 3);
                diceRolls++;

                switch (option)
                {
                    case 0:
                        // No Play
                        break;
                    case 1:
                        // Ladder
                        if (position + dice <= 100)
                        {
                            position += dice;
                        }
                        break;
                    case 2:
                        // Snake
                        position -= dice;
                        if (position < 0)
                        {
                            position = 0;
                        }
                        break;
                }

                Console.WriteLine("Dice Roll: " + dice + " | Option: " + option + " | Position: " + position);
            }

            Console.WriteLine("Congratulations! You won the game in " + diceRolls + " dice rolls.");
            Console.ReadLine();
        }
    }
}
