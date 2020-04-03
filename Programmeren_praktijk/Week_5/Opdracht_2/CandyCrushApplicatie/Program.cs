using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyCrushLogica;
using CandyCrushModel;

namespace CandyCrushApplicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            Regularcandies[,] speelveld = new Regularcandies[5, 5];
            CandyCrusher logic = new CandyCrusher();
            logic.InitCandies(speelveld, "candy_04");
            logic.PrintSpeelveld(speelveld);


            if (logic.ScoreKolomAanwezig(speelveld))
                Console.WriteLine("Score kolom");
            else
                Console.WriteLine("Geen score kolom");

            if (logic.ScoreRijAanwezig(speelveld))
                Console.WriteLine("Score rij");
            else
                Console.WriteLine("Geen score rij");

            Console.ReadKey();
        }
    }
}
