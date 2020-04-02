using System;
using System.Collections.Generic;
using System.Text;
using LingoModel;

namespace LingoLogic
{
    class PlayerLogic
    {
        public void Start()
        {
            string[] words = ReadWords();
            string lingoWord = ChooseWord(words);
            GameLogic lingoGame = new GameLogic();
            lingoGame.SetLingoWord(lingoWord);
            PlayLingo(lingoGame);
        }

        public string[] ReadWords()
        {
            return new string[] { "green", "class", "misty", "visor", "visit" };
        }

        public string ChooseWord(string[] words)
        {
            Random rnd = new Random();
            string word = words[rnd.Next(0, words.Length)];

            return word;
        }

        public void PlayLingo(GameLogic lingoGame)
        {
            int attemptsLeft = 5;
            int wordLength = lingoGame.lingoWord.Length;

            lingoGame.CheckWord(Console.ReadLine());

            while (attemptsLeft > 0 && !lingoGame.GuessedWord())
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

        public void DisplayResults(GameLogic lingoGame)
        {
            for (int i = 0; i < lingoGame.playerWord.Length - 1; i++)
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
    }
}
