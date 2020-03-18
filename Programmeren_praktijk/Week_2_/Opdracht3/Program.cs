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
            Regularcandies[,] speelveld = new Regularcandies[5, 5];
            CandyPlayerLogic methods = new CandyPlayerLogic();
            methods.InitCandies(speelveld);
            methods.PrintMatrix(speelveld);
        
            if (methods.ScoreKolomAanwezig(speelveld))
                Console.WriteLine("Score kolom");
            else
                Console.WriteLine("Geen score kolom");

            if (methods.ScoreRijAanwezig(speelveld))
                Console.WriteLine("Score rij");
            else
                Console.WriteLine("Geen score rij");

            Console.ReadKey();
        }

       
    } 
}
