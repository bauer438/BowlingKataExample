using System;

namespace BowlingKataExample
{
    //Generic Comment to cause merge conflict
    public class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();

            string rolls;
            string[] pins = new string[21];

            Console.WriteLine("Welcome to the Bowling Calculator");
            Console.Write("Enter your rolls separated by spaces: ");

            rolls = Console.ReadLine();
            pins = rolls.Split(' ');

            foreach (var count in pins)
            {
                myGame.roll(Convert.ToInt32(count));
            }

            Console.WriteLine($"Your score was {myGame.score()}");
            Console.Read();
        }
    }
}
