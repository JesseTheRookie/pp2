using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Program
    {

        static void Main(string[] args)
        {
            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            yahtzeeGame.dice = new Dice[5];

            PlayYahtzee(yahtzeeGame);

            Console.ReadKey();
        }

        static void PlayYahtzee(YahtzeeGame game)
        {
            int tries = 0;

            do
            {
                game.Throw();
                game.ShowValue();
                tries++;
            } while (! game.FourOfAKind() );

            Console.WriteLine("Aantal pogingen nodig: " + tries);
        }
    }
}
