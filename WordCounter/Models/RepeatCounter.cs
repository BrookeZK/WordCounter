using System.Collections.Generic;
using System;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _wordInput;
        private string _sentenceInput;
        private static List<char> _alphabet = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 't', 'r', 's', 'u', 'v', 'w', 'x', 'y', 'z', ' '};
        private static List<char> _numbers = new List<char> {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

        public RepeatCounter(string wordInput, string sentenceInput)
        {
            _wordInput = wordInput.ToLower();
            _sentenceInput = sentenceInput;
        }

        public string WordInput{ get => _wordInput; set => _wordInput = value; }
        public string SentenceInput{ get => _sentenceInput; set => _sentenceInput = value; }
        public List<char> Alphabet{ get => _alphabet; set => _alphabet = value; }
        public List<char> Numbers{ get => _numbers; set => _numbers = value; }

        public char[] ReplaceSpecialCharacters(char[] userInputArray)
        {
            // List<char> alphabet = RepeatCounter.Alphabet;
            for (int i = 0; i < userInputArray.Length; i++)
            {
                for (int j = 0; j < _alphabet.Count; j++)
                {
                    if (userInputArray[i] != _alphabet[j])
                    {
                        userInputArray[i] = ' ';
                    }
                }
            }
            return userInputArray;
        }

        // public bool IsInputValid(char[] userInputArray)
        // {
        //     List<char> numbers = GetNumbers();
        //     for (int i = 0; i < userInputArray.Length; i++)
        //     {
        //         for (int j = 0; j < numbers.Count; j++)
        //         {
        //             if (userInputArray[i] == numbers[j])
        //             {
        //                 return false;
        //             }
        //             else
        //             {
        //                 i++;
        //             }
        //         }
        //     }
        //     return true;
        // }

        public char[] ToCharArray(string userInput)
        {
            char[] userInputCharArray = userInput.ToCharArray();
            return userInputCharArray;
        }

        public string[] MakeSentenceArray(string sentenceInput)
        {
            string[] sentenceInputArray = sentenceInput.Split(' ');
            return sentenceInputArray;
        }

        public int CheckIfWordMatchSentence(string word, string[] sentence)
        {
            int instancesOfMatch = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (word == sentence[i])
                {
                    instancesOfMatch++;
                }
            }
            return instancesOfMatch;
        }

    }

}
