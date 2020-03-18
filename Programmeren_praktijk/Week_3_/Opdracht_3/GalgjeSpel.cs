using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3__
{
    class HangmanGame
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
                for(int i = 0; i < sArray.Length; i++)
                {
                    if(sArray[i] == letter)
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
    }
}
