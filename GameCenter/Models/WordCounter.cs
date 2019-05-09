using System.Collections.Generic;
using System;
using System.Text;

namespace GameCenter.Models
{
    public class WordCounter
    {
        private string _wordInput;
        private string _sentenceInput;
        // private int _instancesOfMatch = 0;
        private string _errorMessage = "";
        // private string _comparisonString;
        private static List<char> _alphabet = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 't', 'r', 's', 'u', 'v', 'w', 'x', 'y', 'z', ' '};
        private static List<char> _numbers = new List<char> {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
        private static List<WordCounter> _instances = new List<WordCounter> { };

        public WordCounter(string wordInput, string sentenceInput)
        {
            _wordInput = wordInput.ToLower();
            _sentenceInput = sentenceInput.ToLower();
            _instances.Add(this);
        }

        public string WordInput{ get => _wordInput; set => _wordInput = value; }
        public string SentenceInput{ get => _sentenceInput; set => _sentenceInput = value; }
        // public int InstancesOfMatch{ get => _instancesOfMatch; set => _instancesOfMatch = value;}
        public string ErrorMessage{ get => _errorMessage; set => _errorMessage = value;}
        // public string ComparisonString{ get => _comparisonString; set => _comparisonString = value;}
        public List<char> Alphabet{ get => _alphabet; set => _alphabet = value; }
        public List<char> Numbers{ get => _numbers; set => _numbers = value; }
        public List<WordCounter> Instances { get => _instances; }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<WordCounter> GetAll()
        {
            return _instances;
        }

        // public char[] ReplaceSpecialCharacters(string userInput)
        // {
        //     char[] userInputArray = userInput.ToCharArray();
        //     for (int i = 0; i < userInputArray.Length; i++)
        //     {
        //         for (int j = 0; j < _alphabet.Count; j++)
        //         {
        //             if (userInputArray[i] != _alphabet[j])
        //             {
        //                 userInputArray[i] = ' ';
        //             }
        //         }
        //     }
        //
        //     string joinedstring = new string(userInputArray);
        //     _comparisonString = joinedstring;
        //     return userInputArray;
        //     // return _comparisonString;
        // }

        public string RemovesPunctuation() {
            char[] characterArray = _sentenceInput.ToCharArray();
            StringBuilder builder = new StringBuilder();
            foreach (char letter in characterArray)
            {
                if (Char.IsLetter(letter))
                {
                    builder.Append(letter);
                }
            }
            return builder.ToString();
        }

        public bool IsInputValid(string userInput)
        {
            char[] userInputArray = userInput.ToCharArray();
            for (int i = 0; i < userInputArray.Length; i++)
            {
                for (int j = 0; j < _numbers.Count; j++)
                {
                    if (userInputArray[i] == _numbers[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int CheckIfWordMatchSentence()
        {
            int count = 0;
            // string userSentence = _sentenceInput;
            string[] sentenceArray = RemovesPunctuation().Split(' ');
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                if (_wordInput == sentenceArray[i])
                {
                    count += 1;
                }
            }
            return count;
        }

    }

}
