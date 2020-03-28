using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalgjeDal;

namespace GalgjeLogica
{
    public class HangmanGame
    {
        public string secretWord;
        public string guessedWord;
        private WoordenDal woordenDal = new WoordenDal();

        public void Init()
        {
            guessedWord = "";
            for (int i = 0; i < secretWord.Length; i++)
            {
                guessedWord += ".";
            }
        }
        public bool GuessLetter(char letter)
        {
            char[] sArray = secretWord.ToCharArray();
            char[] gArray = guessedWord.ToCharArray();

            if (sArray.Contains(letter))
            {
                for (int i = 0; i < sArray.Length; i++)
                {
                    if (sArray[i] == letter)
                        gArray[i] = letter;
                }
                string x = new string(gArray);
                guessedWord = x;

                return true;
            }

            return false;
        }
        public bool IsGeraden()
        {
            return secretWord == guessedWord;
        }

        public string SelectWord()
        {
            List<string> x = this.GetWordList();

            Random rnd = new Random();
            int r = rnd.Next(x.Count);
            string selectedWord = x[r];

            return selectedWord;
        }
        public bool PlayHangman(HangmanGame hangman)
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
        public void ShowWord(string word)
        {
            char[] cArray = word.ToCharArray();
            string wordToShow = String.Join(" ", cArray);
            Console.WriteLine(wordToShow + "\n");
        }
        public void ToonLetters(List<char> letters)
        {
            Console.Write("Ingevoerde letters: ");
            for (int i = 0; i < letters.Count; i++)
            {
                Console.Write(letters[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public char ReadLetter(List<char> verbodenLetters)
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
        public List<string> GetWordList()
        {
            return this.woordenDal.GetAll();
        }
    }
}
