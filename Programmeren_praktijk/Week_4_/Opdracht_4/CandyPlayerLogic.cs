using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4
{
    class CandyPlayerLogic
    {
        public void InitCandies(Regularcandies[,] speelveld, string bestandsnaam)
        {
            if (File.Exists(bestandsnaam))
            {
                speelveld = this.LeesSpeelveld(bestandsnaam, speelveld);
            }
            else
            {
                Random rnd = new Random();
                for (int r = 0; r < speelveld.GetLength(0); r++)
                {
                    for (int k = 0; k < speelveld.GetLength(1); k++)
                    {
                        speelveld[r, k] = (Regularcandies)rnd.Next(0, 5);
                    }
                }
                this.SchrijfSpeelveld(speelveld, bestandsnaam);
            }

        }
        public void SchrijfSpeelveld(Regularcandies[,] speelveld, string bestandsnaam)
        {
            StreamWriter writer = new StreamWriter(bestandsnaam);

            for (int r = 0; r < speelveld.GetLength(0); r++)
            {
                for (int k = 0; k < speelveld.GetLength(1); k++)
                {
                    writer.Write($"{(int)speelveld[r, k]}");
                }
                writer.WriteLine();
            }
            writer.Close();
        }
        public Regularcandies[,] LeesSpeelveld(string bestandsnaam, Regularcandies[,] speelveld)
         {
            StreamReader reader = new StreamReader(bestandsnaam);

            for (int r = 0; r < speelveld.GetLength(0); r++)
            {
                string regel = reader.ReadLine();
                for (int k = 0; k < speelveld.GetLength(1); k++)
                {
                    int x = int.Parse(regel[k].ToString());
                    speelveld[r, k] = (Regularcandies)x;
                }
            }

            reader.Close();
            return speelveld;
         }

        public void PrintSpeelveld(Regularcandies[,] speelveld)
        {
            for (int r = 0; r < speelveld.GetLength(0); r++)
            {
                for (int k = 0; k < speelveld.GetLength(1); k++)
                {
                    switch (speelveld[r, k])
                    {
                        case (Regularcandies)0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(" # ");
                            break;
                        case (Regularcandies)1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" # ");
                            break;
                        case (Regularcandies)2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(" # ");
                            break;
                        case (Regularcandies)3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" # ");
                            break;
                        case (Regularcandies)4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(" # ");
                            break;
                        case (Regularcandies)5:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(" # ");
                            break;

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(Environment.NewLine);
            }
        }
        public bool ScoreRijAanwezig(Regularcandies[,] speelveld)
        {
            for (int r = 0; r < speelveld.GetLength(0); r++)
            {
                int teller = 1;
                Regularcandies candy = speelveld[r, 0];

                for (int k = 1; k < speelveld.GetLength(1); k++)
                {
                    if (speelveld[r, k] == candy)
                    {
                        teller++;
                    }
                    else
                    {
                        candy = speelveld[r, k];
                        teller = 1;
                    }
                    if (teller >= 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool ScoreKolomAanwezig(Regularcandies[,] speelveld)
        {
            for (int k = 0; k < speelveld.GetLength(1); k++)
            {
                int teller = 1;
                Regularcandies candy = speelveld[0, k];

                for (int r = 1; r < speelveld.GetLength(0); r++)
                {
                    if (speelveld[r, k] == candy)
                    {
                        teller++;
                    }
                    else
                    {
                        candy = speelveld[r, k];
                        teller = 1;
                    }

                    if (teller >= 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
