using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalgjeLogica;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            HangmanGame hangman = new HangmanGame();

            hangman.secretWord = hangman.SelectWord();
            hangman.guessedWord = "";
            hangman.Init();
            Console.WriteLine("The secret word is: " + hangman.secretWord);
            Console.WriteLine("The guessed word is: " + hangman.guessedWord + "\n");

            //   ShowWord(hangman.secretWord);
            //   ShowWord(hangman.guessedWord);

            hangman.PlayHangman(hangman);

            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
