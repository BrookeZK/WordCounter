using System.Collections.Generic;
using System;

namespace WordCounter.Models
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

        public char[] ReplaceSpecialCharacters()
        {
            char[] userInputArray = _wordInput.ToCharArray();
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

        public bool IsInputValid()
        {
            char[] userInputArray = _wordInput.ToCharArray();
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
            string[] sentenceArray = _sentenceInput.Split(' ');
            int instancesOfMatch = 0;
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                if (_wordInput == sentenceArray[i])
                {
                    instancesOfMatch++;
                }
            }
            return instancesOfMatch;
        }

    }

}
