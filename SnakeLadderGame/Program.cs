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
            int position = 0;
            Console.WriteLine("Welcome to Snake Ladder Game");
            Console.WriteLine("You are currently at position {0}.", position);

            while (position < 100)
            {
                Console.WriteLine("Press enter to roll the die.");
                Console.ReadLine();

                int roll = (new Random()).Next(1, 7);
                Console.WriteLine("You rolled a {0}.", roll);

                switch (roll)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        position += roll;
                        Console.WriteLine("You moved forward {0} steps to position {1}.", roll, position);
                        break;
                    case 6:
                        position += roll;
                        Console.WriteLine("You moved forward {0} steps to position {1}.", roll, position);
                        Console.WriteLine("Congratulations, you get to roll again!");
                        break;
                }

                if (position == 14 || position == 27 || position == 42 || position == 50 || position == 71 || position == 89 || position == 95)
                {
                    Console.WriteLine("Oops, you landed on a snake! You slide down to position 7.");
                    position = 7;
                }
                else if (position == 17 || position == 19 || position == 21 || position == 39 || position == 61 || position == 76 || position == 78 || position == 84 || position == 88 || position == 99)
                {
                    Console.WriteLine("Congratulations, you landed on a ladder! You climb up to position 90.");
                    position = 90;
                }

                Console.WriteLine("You are now at position {0}.", position);
            }

            Console.WriteLine("Congratulations, you won!");
            Console.ReadLine();
        }
    }
}
