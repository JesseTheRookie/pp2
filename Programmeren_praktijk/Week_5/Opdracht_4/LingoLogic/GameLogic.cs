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
}
