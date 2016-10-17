using System;

namespace Hangman
{
     class Function1
    {
        public bool isCharInWord(char x, char[] wordInArray, char[] wordWithAnswersInArray)
        {
            for (int i = 0; i < wordInArray.Length; i++)
            {
                if (wordInArray[i] == x && wordWithAnswersInArray[i] != x)
                {
                    return true;
                }
            }
            return false;
        }
        public char[] addCharToArrayWithAnswers(char x, char[] wordInArray, char[] wordWithAnswersInArray)
        {
            for (int i = 0; i < wordInArray.Length; i++)
            {
                if (wordInArray[i] == x && wordWithAnswersInArray[i] != x)
                {
                    wordWithAnswersInArray[i] = x;
                }
            }
            return wordWithAnswersInArray;
        }
        public string writeAnAnswer(char[] wordWithAnswersInArray)
        {
            string answer = new string(wordWithAnswersInArray);

            return answer;
        }
        public string writeAnWord(char[] wordInArray)
        {
            string word = new string(wordInArray);
            return word;
        }

    }
}
