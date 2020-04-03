using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word (to search): ");
            string woord = Console.ReadLine();
            string bestandsNaam = "trump.txt";
            StreamReader reader = new StreamReader(bestandsNaam);

            int aantalRegels = ZoekWoordInBestand(bestandsNaam, woord);
            Console.WriteLine($"Number of lines containing the word: {aantalRegels}");

            reader.Close();
            Console.ReadKey();
        }

        static bool ZitWoordInRegel(string regel, string woord)
        {
            if (regel.Contains(woord))
            {
                return true;
            }               
            return false;
        }

        static int ZoekWoordInBestand(string bestandsnaam, string woord)
        {
            StreamReader reader = new StreamReader(bestandsnaam);
            int aantalRegels = 0;

            while (!reader.EndOfStream)
            {
                string regel = reader.ReadLine();

                if (ZitWoordInRegel(regel, woord))
                {
                    aantalRegels++;
                    ToonWoordInRegel(regel, woord);
                }
            }
            Console.WriteLine("");
            reader.Close();
            return aantalRegels;
        }

        static void ToonWoordInRegel(string regel, string woord)
        {
            var positieNummer = regel.IndexOf(woord);
            Console.Write(regel.Substring(0, positieNummer));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(regel.Substring(positieNummer, woord.Length));
            Console.ResetColor();
            Console.Write(regel.Substring(positieNummer + woord.Length));
        }
    }
}
