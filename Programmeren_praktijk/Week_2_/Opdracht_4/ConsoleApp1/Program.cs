using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regularcandies[,] speelveld = new Regularcandies[5, 5];
            CandyPlayerLogic candyPlayerLogic = new CandyPlayerLogic();

            candyPlayerLogic.InitCandies(speelveld, "candy_01");
            //candyPlayerLogic.PrintMatrix(speelveld);

            if (candyPlayerLogic.ScoreKolomAanwezig(speelveld))
                Console.WriteLine("Score kolom");
            else
                Console.WriteLine("Geen score kolom");

            if (candyPlayerLogic.ScoreRijAanwezig(speelveld))
                Console.WriteLine("Score rij");
            else
                Console.WriteLine("Geen score rij");

            Console.ReadKey();
        }
    }
}
