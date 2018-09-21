 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> temperaturen = new List<double>();

            temperaturen = MeetTemperaturen();
            PrintTemperaturen(temperaturen);
           
            Console.WriteLine("De gemiddelde temperatuur is: " + BerekenGemiddelde(temperaturen));

            int koudsteMinuut = ZoekKoudsteMinuut(temperaturen);
            Console.WriteLine("Koudste: " + koudsteMinuut + " -> " + temperaturen[koudsteMinuut]);
            

            Console.ReadKey();
        }

        static List<double> MeetTemperaturen()
        {
            Random rnd = new Random();
            List<double> metingen = new List<double>();

            // van nacht tot nacht (24 uur)
            int aantalMinInDag = 24 * 60;
            double f = (2 * Math.PI) / aantalMinInDag;
            for(int i = 0; i < aantalMinInDag; i++)
            {
                double x = 1.5 * Math.PI + i * f;
                double temperatuur = 18 + 6 * Math.Sin(x) + rnd.Next(10) / 10.0f;

                metingen.Add(temperatuur);
            }
            // sommige metingen zijn niet geldig
            for (int r = 0; r < 10; r++)
                metingen[rnd.Next(aantalMinInDag)] = -999;
            return metingen;
        }

        static void PrintTemperaturen(List<double> metingen)
        {
            for(int i = 0; i < metingen.Count; i++)
            {           
                if ((i % 60) != 0)
                  continue;
                Console.WriteLine(i + ". " + metingen[i]);
            }
        }

        static double BerekenGemiddelde(List<double> metingen)
        {
            double totaal = 0;
            int i;

            for (i = 0; i < metingen.Count; i++)
            {
                if ((metingen[i] > 100) || (metingen[i] < -50))
                {
                    continue;
                }

                 totaal += metingen[i];
            }

            double gemiddelde = totaal / i;
            return gemiddelde;
        }

        static int ZoekKoudsteMinuut(List<double> metingen)
        {
            double[] x = metingen.ToArray();
            int koudsteMinuut = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if ((x[i] > 100) || (x[i] < -50))
                {
                    continue;
                }

                 koudsteMinuut = Array.IndexOf(x, x.Min());
            }


            return koudsteMinuut;
        }
    }
}
