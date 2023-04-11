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
            Console.WriteLine("Welcome to Snake Ladder Game");
            int position = 0; // starting position
            Random rand = new Random();

            while (position < 100)
            { // game loop
              // Roll the die and get a random number between 1 and 6
                int roll = rand.Next(1, 7);
                Console.WriteLine("You rolled a " + roll);

                // Check for options (No Play, Ladder, or Snake)
                int option = rand.Next(0, 3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play. You stay at position " + position);
                        break;
                    case 1:
                        Console.WriteLine("You climbed a ladder to position " + (position + roll));
                        position += roll;
                        break;
                    case 2:
                        Console.WriteLine("You slid down a snake to position " + (position - roll));
                        position -= roll;
                        if (position < 0) position = 0; // ensure position doesn't go below 0
                        break;
                }

                Console.WriteLine("Your current position is " + position);
            }

            Console.WriteLine("Congratulations, you won!");
            Console.ReadLine();
        }
    }
}
