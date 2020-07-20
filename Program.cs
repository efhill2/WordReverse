using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Data_Structures
{
    class Program
    {
        static string ReverseString(string word)
        {           

            Stack<char> charStack = new Stack<char>();
            
            for (int i = 0; i < word.Length; i++)
            {
                if(word[i] != ' ')
                {
                    charStack.Push(word[i]);
                }
                else
                {
                    while (charStack.Count > 0)
                    {
                        Console.Write(charStack.Pop());
                    }

                    Console.Write(" ");
                }
            }

            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }
            Console.WriteLine(" ");

            //char[] charArray = word.ToCharArray();
            //int size = word.Length;

            //Stack characters = new Stack(size);                   
            
            //for (int i = 0; i < size; i++)
            //{
            //    characters.Push(charArray[i]);                
            //}
            //for (int i  = 0; i < size; i++)
            //{
            //    charArray[i] = (char)characters.Pop();                               
            //}

            //Console.WriteLine();

            //Console.WriteLine(charArray);

            return (word);
        }
        static void Main(string[] args)
        {
            bool correct = true;

            while (correct)
            {
                Console.WriteLine("Please enter a word you would like to reverse:");

                string reverseWord = Console.ReadLine();

                if (!Regex.IsMatch(reverseWord, @"([a-zA-Z\s])"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Not valid string.");

                    correct = true;
                }
                else
                {
                    string word = ReverseString(reverseWord);    

                   
                }
            }

            


        }
    }
}
