using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mars!");
            Thread.Sleep(3000);
            Console.Write("Do you wish to begin onboarding? Please enter yes or no! ");
            string init = Console.ReadLine();
            Thread.Sleep(1000);
            if (init != "yes" || init != "Yes")
            {
                Console.WriteLine("Then lets begin!");
                Thread.Sleep(2000);
                Console.Write("What is your name? ");
                string playerName = Console.ReadLine();
                Console.WriteLine("Actually..");
                Thread.Sleep(1500);
                Console.WriteLine("How much money are you willing to wager on a quick game?");
                Thread.Sleep(750);
                Console.Write("Please enter a whole number value!");
                int bank = Convert.ToInt32(Console.ReadLine());
                Thread.Sleep(1000);
                Console.WriteLine("Alright " + playerName + ", I hope you're ready to lose all $" + bank + " dollars!");
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying == true && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Seeyah!");
            }
            else
            {
                Console.WriteLine("Well, there is nothing else to do! Goodbye!");
            }

        }
    }
}
