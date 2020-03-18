using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4
{
    class LingoPlayerLogic
    {
        public void Start()
        {
            string[] words = ReadWords();
            string lingoWord = ChooseWord(words);
            LingoGameLogic lingoGame = new LingoGameLogic();
            lingoGame.SetLingoWord(lingoWord);
            PlayLingo(lingoGame);
        }

        public string[] ReadWords()
        {
            return new string[] { "green", "class", "school" };
        }

        public string ChooseWord(string[] words)
        {
            Random rnd = new Random();
            string word = words[rnd.Next(0, words.Length)];

            return word;
        }

        public void PlayLingo(LingoGameLogic lingoGame)
        {
            int attemptsLeft = 5;
            int wordLength = lingoGame.lingoWord.Length;

            lingoGame.CheckWord(Console.ReadLine());

            while(attemptsLeft > 0 && !lingoGame.GuessedWord())
            {
                lingoGame.playerWord = ReadPlayerWord(wordLength);
                attemptsLeft--;
                DisplayResults(lingoGame);
            }
        }

        public string ReadPlayerWord(int lingoWordLength)
        {
            string playerWord;

            do
            {
                playerWord = this.ReadString();
            }
            while (playerWord.Length != lingoWordLength);

            return playerWord;
        }

        public string ReadString()
        {
            string answer = Console.ReadLine();
            return answer;
        }

        public void DisplayResults(LingoGameLogic lingoGame)
        {
            for(int i = 0; i < lingoGame.playerWord.Length - 1; i++ )
            {
                if(lingoGame.letterResults[i] == LetterStateEnum.Correct)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if(lingoGame.letterResults[i] == LetterStateEnum.WrongPosition)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                Console.Write(lingoGame.playerWord[i]);

                Console.ResetColor();
            }
        }

    }
}
