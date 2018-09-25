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

            hangman.secretWord = SelectWord(WordList());
            hangman.guessedWord = "";
            hangman.Init();
            Console.WriteLine("The secret word is: " + hangman.secretWord);
            Console.WriteLine("The guessed word is: " + hangman.guessedWord + "\n");

            //   ShowWord(hangman.secretWord);
            //   ShowWord(hangman.guessedWord);

            PlayHangman(hangman);

            Console.ReadKey();
        }

        static List<string> WordList()
        {
            List<string> x = new List<string>();
            x.AddRange(new string[] {"antiparticle", "atom", "duality", "electron", "cosmology", "geodesic", "mass", "neutrino", "neutron",
                                     "nucleus", "photon", "positron", "proton", "pulsar", "quantum", "quark", "radar", "radioactivity", "singularity", "spectrum"});

            return x;
        }
        static string SelectWord(List<string> x)
        {
            Random rnd = new Random();
            int r = rnd.Next(x.Count);
            string selectedWord = x[r];

            return selectedWord;
        }
        static bool PlayHangman(HangmanGame hangman)
        {
            List<char> enteredLetters = new List<char>();
            //enteredLetters.AddRange();

            for (int i = hangman.guessedWord.Length; i > 0;)
            {
                char x = ReadLetter(enteredLetters);

                enteredLetters.Add(x);
                hangman.GuessLetter(x);

                ShowWord(hangman.guessedWord);

                if (!hangman.secretWord.Contains(x))
                {
                    i--;
                }

                ToonLetters(enteredLetters);

                if (hangman.IsGeraden())
                {
                    Console.WriteLine("Je hebt het woord " + hangman.guessedWord + " geraden");
                    break;
                }

                Console.WriteLine("Pogingen over: " + i);
            }
            return true;
        }
        static void ShowWord(string word)
        {
            char[] cArray = word.ToCharArray();
            string wordToShow = String.Join(" ", cArray);
            Console.WriteLine(wordToShow + "\n");
        }
        static void ToonLetters(List<char> letters)
        {
            Console.Write("Ingevoerde letters: ");
            for (int i = 0; i < letters.Count; i++)
            {
                Console.Write(letters[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static char ReadLetter(List<char> verbodenLetters)
        {
            char letter = '?';

            bool goodLetter = false;
            while (!goodLetter)
            {
                Console.Write("Enter a letter: ");
                letter = char.Parse(Console.ReadLine());

                goodLetter = !verbodenLetters.Contains(letter);
            }

            return letter;
        }
    }
}
