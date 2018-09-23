using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3__
{
    struct HangmanGame
    {
        public string secretWord;
        public string guessedWord;

        public void Init()
        {   
            for(int i = 0; i < secretWord.Length; i++)
            {
                guessedWord += ".";
            }
        }
    }
}
