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
            Regularcandies[,] speelveld = new Regularcandies[4, 4];
            InitCandies(speelveld);
            PrintMatrix(speelveld);

            if (ScoreKolomAanwezig(speelveld))
                Console.WriteLine("Score kolom");
            else
                Console.WriteLine("Geen score kolom");

            if (ScoreRijAanwezig(speelveld))
                Console.WriteLine("Score rij");
            else
                Console.WriteLine("Geen score rij");

            Console.ReadKey();
        }
        enum Regularcandies { JellyBean, Lozenge, LemonDrop, GumSquare, LolipopHead, JujubeCluster}

        static void InitCandies(Regularcandies[,] matrix)
        {
            Random rnd = new Random();
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Array values = Enum.GetValues(typeof(Regularcandies));
                    matrix[r, k] = (Regularcandies)values.GetValue(rnd.Next(values.Length));
                }
            }
        }
        static void PrintMatrix(Regularcandies[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    switch (matrix[r,k])
                    {
                        case (Regularcandies)0:
                            Console.Write(" # ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case (Regularcandies)1:
                            Console.Write(" # ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case (Regularcandies)2:
                            Console.Write(" # ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case (Regularcandies)3:
                            Console.Write(" # ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case (Regularcandies)4:
                            Console.Write(" # ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case (Regularcandies)5:
                            Console.Write(" # ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;

                    }
                }
                Console.Write(Environment.NewLine);
            }
        }
        static bool ScoreRijAanwezig(Regularcandies[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int teller = 0;
                Regularcandies candy = matrix[0,0];

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[r, k] == candy)
                        teller++;
                    else
                    {
                        candy = matrix[r, k];
                        teller = 0;
                    }

                    if (teller > 3)
                        return true;
                }
            }
            return false;
        }
        static bool ScoreKolomAanwezig(Regularcandies[,] matrix)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                int teller = 0;
                Regularcandies candy = matrix[0, 0];

                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    if (matrix[r, k] == candy)
                        teller++;
                    else
                    {
                        candy = matrix[r, k];
                        teller = 0;
                    }

                    if (teller > 3)
                        return true;
                }
            }
            return false;
        }
    } 
}
