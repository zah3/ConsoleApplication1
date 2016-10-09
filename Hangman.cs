﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Function
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi man! Give me a word");
            string wordNormal = Console.ReadLine();
            string word = wordNormal.ToLower();
            char[] wordInArray = word.ToCharArray();
            char[] wordWithAnswersInArray = new char[wordInArray.Length];
            for (int i = 0; i < wordInArray.Length; i++)
            {
                wordWithAnswersInArray[i] = '-';
            }
            Function fun = new Function();
            Console.WriteLine("Hi 2nd man, Let's play in hangman.Try to write good char from a word You Can make 7 mistakes.");
            
            int l = 0;
            do
            {
                
                if(l == 7)
                {
                    Console.WriteLine("Man,it's Your last chances to try.Good luck");
                }
                Console.WriteLine("Your word is:");
                Console.WriteLine(fun.writeAnAnswer(wordWithAnswersInArray));
                Console.WriteLine("Give an chararacter, please.");
                char x = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine(" ");
                if (fun.isCharInWord(x, wordInArray, wordWithAnswersInArray) == false)
                {
                    l++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (l == 7)
                    {
                        Console.WriteLine("Sorry, but You lost.");
                        Console.ResetColor();
                        break;
                    }
                    Console.WriteLine("Sorry, try again!");
                    Console.ResetColor();

                    int chances = 7 - l;
                    Console.WriteLine("You have " + chances + " chances to put a wrong char.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    fun.addCharToArrayWithAnswers(x, wordInArray, wordWithAnswersInArray);
                    if (fun.writeAnAnswer(wordWithAnswersInArray) == fun.writeAnWord(wordInArray))
                    {
                        Console.WriteLine("You got it. Congratulations!");
                        break;
                    }
                    int chances = 7 - l;
                    Console.WriteLine("You still have a " + chances + " chance(s) to win this game!");
                    Console.ResetColor();
                }
            } while (l < 7);
        }
    }
}
