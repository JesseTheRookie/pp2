using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalgjeDal;

namespace GalgjeLogica
{
    public struct HangmanGame
    {
        public string secretWord;
        public string guessedWord;

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

        public static string SelectWord()
        {
            List<string> x = WoordenDal.GetAll();

            Random rnd = new Random();
            int r = rnd.Next(x.Count);
            string selectedWord = x[r];

            return selectedWord;
        }
    }
}
