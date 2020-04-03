using System;
using System.Collections.Generic;
using LingoDal;
using LingoModel;

namespace LingoLogic
{
    public class GameLogic
    {
        public string lingoWord;
        public string playerWord;
        public LetterStateEnum[] letterResults;
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

        public void SetLingoWord(string lingoWord)
        {
            this.lingoWord = lingoWord;
            letterResults = new LetterStateEnum[lingoWord.Length];
        }

        public bool GuessedWord()
        {
            return this.lingoWord == this.playerWord;
        }

        public void CheckWord(string playerWord)
        {
            this.playerWord = playerWord;

            char[] playerWordChars = this.playerWord.ToCharArray();
            char[] lingoWordChars = this.lingoWord.ToCharArray();

            List<char> refLetters = new List<char>();
            for (int i = 0; i < lingoWord.Length; i++)
            {
                if (lingoWordChars[i] != playerWordChars[i])
                {
                    refLetters.Add(lingoWordChars[i]);
                }
            }

            for (int i = 0; i < playerWord.Length; i++)
            {
                if (lingoWordChars[i] == playerWordChars[i])
                {
                    letterResults[i] = LetterStateEnum.Correct;
                }
                else if (refLetters.Contains(playerWord[i]))
                {
                    letterResults[i] = LetterStateEnum.WrongPosition;
                }
                else
                {
                    letterResults[i] = LetterStateEnum.Incorrect;
                }
            }
        }
        public void PlayLingo(GameLogic lingoGame)
        {
            int attemptsLeft = 5;
            int wordLength = lingoGame.lingoWord.Length;

            lingoGame.CheckWord(Console.ReadLine());

            while (attemptsLeft > 0 && !lingoGame.GuessedWord())
            {
                Console.WriteLine(this.lingoWord);
                Console.Write("enter word: ");
                lingoGame.playerWord = ReadPlayerWord(wordLength);
                DisplayResults(lingoGame);
                attemptsLeft--;
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
