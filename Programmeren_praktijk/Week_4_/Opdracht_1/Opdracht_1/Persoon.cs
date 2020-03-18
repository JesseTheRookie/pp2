using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1___
{
    class Persoon
    {
        private string naam;
        private string woonplaats;
        private int leeftijd;

        public void LeesPersoon(string bestandsNaam)
        {
            if (File.Exists(bestandsNaam))
            {
                Console.WriteLine("Wat leuk om u hier weer te zien!");
                Console.WriteLine("We hebben de volgen de informatie over u:");

                this.naam = File.ReadLines(bestandsNaam).Take(1).First();
                this.woonplaats = File.ReadLines(bestandsNaam).Skip(1).Take(1).First();
                this.leeftijd = int.Parse(File.ReadLines(bestandsNaam).Skip(2).Take(1).First());

                this.ToonPersoon(this);
            }
            else
            {
                Console.WriteLine($"Welkom {bestandsNaam}");
                Console.Write("Waar woont u? ");
                string woonplaats = Console.ReadLine();
                Console.Write("Hoe oud bent u? ");
                int leeftijd = int.Parse(Console.ReadLine());

                Persoon p =  LeesPersoon(bestandsNaam, woonplaats, leeftijd);

                SchrijfPersoon(p, bestandsNaam);
            }
        }

        public Persoon LeesPersoon(string naam, string woonplaats, int leeftijd)
        {
            this.naam = naam;
            this.woonplaats = woonplaats;
            this.leeftijd = leeftijd;

            return this;
        }

        public void ToonPersoon(Persoon p)
        {
            Console.WriteLine($"Naam: {p.naam}");
            Console.WriteLine($"Woonplaats: {p.woonplaats}");
            Console.WriteLine($"Leeftijd: {p.leeftijd}");
        }

        public void SchrijfPersoon(Persoon p, string bestandsNaam)
        {
            StreamWriter writer = new StreamWriter(bestandsNaam);

            writer.WriteLine($"{p.naam}");
            writer.WriteLine($"{p.woonplaats}");
            writer.WriteLine($"{p.leeftijd}");

            writer.Close();
        }
    }
}
