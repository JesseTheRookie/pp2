using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingoTest
{
    class PlayerLogic
    {
        public void Start()
        {
            string[] words = ReadWords();
            string word = ChooseWord(words);
            GameLogic lingoGame = new GameLogic();
            lingoGame.SetLingoWord(word);
            PlayLingo(lingoGame);
        }

        public string[] ReadWords()
        {
            return new string[] { "green", "class", "misty", "visor", "visit" };
        }
        public string ChooseWord(string[] words)
        {
            Random rnd = new Random();
            string word = words[rnd.Next(0, words.Length - 1)];

            return word;
        }
        public void DisplayResults(GameLogic lingoGame)
        {
            for (int i = 0; i < lingoGame.playerWord.Length; i++)
            {
                if (lingoGame.letterResults[i] == LetterStateEnum.Correct)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (lingoGame.letterResults[i] == LetterStateEnum.WrongPosition)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                Console.Write(lingoGame.playerWord[i]);

                Console.ResetColor();
            }
        }
        public void PlayLingo(GameLogic lingoGame)
        {
            int attemptsLeft = 5;
            int wordLength = lingoGame.lingoWord.Length;

            while (attemptsLeft > 0 && !lingoGame.GuessedWord())
            {
                Console.WriteLine(lingoGame.lingoWord);
                Console.Write($"Enter a (5-letter) word, attempts left {attemptsLeft}: ");
                string playerWord = ReadPlayerWord(wordLength);
                lingoGame.CheckWord(playerWord);
                DisplayResults(lingoGame);
                attemptsLeft--;
            }
        }

        public string ReadPlayerWord(int lingoWordLength)
        {
            string playerWord;

            do
            {
                playerWord = Console.ReadLine();
            }
            while (playerWord.Length != lingoWordLength);

            return playerWord;
        }
    }
}
