using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _wordInput;
        private string _sentenceInput;
        private int _instancesOfMatch = 0;
        // private string _comparisonString;
        private static List<char> _alphabet = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 't', 'r', 's', 'u', 'v', 'w', 'x', 'y', 'z', ' '};
        private static List<char> _numbers = new List<char> {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
        private static List<RepeatCounter> _instances = new List<RepeatCounter> { };

        public RepeatCounter(string wordInput, string sentenceInput)
        {
            _wordInput = wordInput;
            _sentenceInput = sentenceInput;
            _instances.Add(this);
        }

        public string WordInput{ get => _wordInput; set => _wordInput = value; }
        public string SentenceInput{ get => _sentenceInput; set => _sentenceInput = value; }
        public int InstancesOfMatch{ get => _instancesOfMatch; set => _instancesOfMatch = value;}
        // public string ComparisonString{ get => _comparisonString; set => _comparisonString = value;}
        public List<char> Alphabet{ get => _alphabet; set => _alphabet = value; }
        public List<char> Numbers{ get => _numbers; set => _numbers = value; }
        public List<RepeatCounter> Instances { get => _instances; }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<RepeatCounter> GetAll()
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
            string userSentence = _sentenceInput;
            string[] sentenceArray = userSentence.Split(' ');
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                if (_wordInput == sentenceArray[i])
                {
                    _instancesOfMatch += 1;
                }
            }
            return _instancesOfMatch;
        }

    }

}
