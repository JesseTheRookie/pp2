using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3__
{
    class Program
    {
        static void Main(string[] args)
        {
            HangmanGame hangman;

            hangman.secretWord = "spoon";
            hangman.guessedWord = "";
            hangman.Init();
            Console.WriteLine("The secret word is: " + hangman.secretWord);
            Console.WriteLine("The guessed word is: " + hangman.guessedWord);

            string word = SelectWord(WordList());
            Console.WriteLine(word);
            Console.ReadKey();
        }

        static List<string> WordList()
        {
            List<string> x = new List<string>();
            x.AddRange(new string[] {"Antiparticle", "Atom", "Duality", "Electron", "Cosmology", "Geodesic", "Mass", "Neutrino", "Neutron",
                                     "Nucleus", "Photon", "Positron", "Proton", "Pulsar", "Quantum", "Quark", "Radar", "Radioactivity", "Singularity", "Spectrum"});

            return x;
        }
        static string SelectWord(List<string> x)
        {
            Random rnd = new Random();
            int r = rnd.Next(x.Count);
            string selectedWord = (string)x[r];

            return selectedWord;
        }
    }
}
