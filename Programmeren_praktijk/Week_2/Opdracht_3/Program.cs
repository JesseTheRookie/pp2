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
            HangmanGame hangman = new HangmanGame();
            Methods methods = new Methods();

            hangman.secretWord = methods.SelectWord(methods.WordList());
            hangman.guessedWord = "";
            hangman.Init();
            Console.WriteLine("The secret word is: " + hangman.secretWord);
            Console.WriteLine("The guessed word is: " + hangman.guessedWord + "\n");

            //   ShowWord(hangman.secretWord);
            //   ShowWord(hangman.guessedWord);

            methods.PlayHangman(hangman);

            Console.ReadKey();
        }
    }
}
