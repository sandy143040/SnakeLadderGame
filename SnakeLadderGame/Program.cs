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
            int position1 = 0;
            int position2 = 0;
            int diceRolls1 = 0;
            int diceRolls2 = 0;
            int currentPlayer = 1;
            bool ladderRolled = false;
            Random rand = new Random();

            while (position1 < 100 && position2 < 100)
            {
                int dice = rand.Next(1, 7);
                int option = rand.Next(0, 3);

                if (currentPlayer == 1)
                {
                    diceRolls1++;

                    switch (option)
                    {
                        case 0:
                            // No Play
                            break;
                        case 1:
                            // Ladder
                            position1 += dice;
                            ladderRolled = true;
                            break;
                        case 2:
                            // Snake
                            position1 -= dice;
                            if (position1 < 0)
                            {
                                position1 = 0;
                            }
                            break;
                    }

                    Console.WriteLine("Player 1 | Dice Roll: " + dice + " | Option: " + option + " | Position: " + position1);

                    if (!ladderRolled)
                    {
                        currentPlayer = 2;
                    }
                    ladderRolled = false;
                }
                else
                {
                    diceRolls2++;

                    switch (option)
                    {
                        case 0:
                            // No Play
                            break;
                        case 1:
                            // Ladder
                            position2 += dice;
                            ladderRolled = true;
                            break;
                        case 2:
                            // Snake
                            position2 -= dice;
                            if (position2 < 0)
                            {
                                position2 = 0;
                            }
                            break;
                    }

                    Console.WriteLine("Player 2 | Dice Roll: " + dice + " | Option: " + option + " | Position: " + position2);

                    if (!ladderRolled)
                    {
                        currentPlayer = 1;
                    }
                    ladderRolled = false;
                }
            }

            if (position1 >= 100)
            {
                Console.WriteLine("Congratulations! Player 1 won the game in " + diceRolls1 + " dice rolls.");
            }
            else
            {
                Console.WriteLine("Congratulations! Player 2 won the game in " + diceRolls2 + " dice rolls.");
            }
            Console.ReadLine();
        }
    }
}
