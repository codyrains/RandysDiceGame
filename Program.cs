using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int randyRandomNum;

            int playerPoints = 0;
            int randyPoints = 0;

            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                randyRandomNum = random.Next(1, 7);
                Console.WriteLine("Randy rolled a " + randyRandomNum);

                if(playerRandomNum > randyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("You win this round...");
                }
                else if(playerRandomNum < randyRandomNum)
                {
                    randyPoints++;
                    Console.WriteLine("oooo looks like Randy gotcha this time :)");
                }
                else
                {
                    Console.WriteLine("It's a draw... Randy doesn't look too happy about that... don't look him in the eyes for too long.");
                }

                Console.WriteLine("The score is now - You : " + playerPoints + ". Randy : " + randyPoints + ".");
                Console.WriteLine();
            }

            if(playerPoints > randyPoints)
            {
                Console.WriteLine("You won against Randy!! Enjoy your sweet sweet victory!");
            }
            else if(playerPoints < randyPoints)
            {
                Console.WriteLine("Uh oh...looks like Randy won the game! He'll never let you live this one down.");
            }
            else
            {
                Console.WriteLine("It's a draw!! Randy reaches his hand out for a good ol shake, but pulls it away at the last second.");
            }

            Console.ReadKey();
        }
    }
}
