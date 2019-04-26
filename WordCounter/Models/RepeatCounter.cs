using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _wordInput;
    private string _sentenceInput;
    private static List<char> _alphabet = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 't', 'r', 's', 'u', 'v', 'w', 'x', 'y', 'z', ' '};

    public RepeatCounter(string wordInput, string sentenceInput)
    {
      _wordInput = wordInput;
      _sentenceInput = sentenceInput;
    }

    public string GetWordInput()
    {
      return _wordInput;
    }

    public string GetSentenceInput()
    {
      return _sentenceInput;
    }

    public List<char> GetAlphabet()
    {
      return _alphabet;
    }

    public string MakeLowerCase(string userInput)
    {
      string lowerUserInput = userInput.ToLower();
      return lowerUserInput;
    }

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

    // public char[] IsAlphabetChar(char[] userInput)
    // {
    //   // char[] userInput = {'1'};
    //   List<char> alphabet = GetAlphabet();
    //   for (int i = 0; i < userInput.Length; i++)
    //   {
    //     for (int j = 0; j < alphabet.Count; j++)
    //     {
    //       if (userInput[i] == alphabet[j])
    //       {
    //         char newChar = alphabet[j];
    //         userInput[i] = newChar;
    //       }
    //       else if (userInput[i] != alphabet[j])
    //       {
    //         userInput[i] = '0';
    //       }
    //       // if (userInput[i] != _alphabet[j])
    //       // {
    //       //   userInput[i] = '0';
    //       // }
    //       // return userInput;
    //     }
    //   }
    //   return userInput;
    // }

    // public bool IsInputValid(char[] userInput)
    // {
    //   // char [] comparisonUserInput = userInput;
    //   for (int i = 0; i < userInput.Length; i++)
    //   {
    //     for (int j = 0; j < _alphabet.Length; j++)
    //     {
    //       if (userInput[i] != _alphabet[j])
    //       {
    //         return false;
    //       }
    //       else if (userInput[i] == _alphabet[j])
    //       {
    //         userInput[i] = _alphabet[j];
    //         return true;
    //       }
    //     }
    //   }
    //   if (userInput == userInput)
    //   {
    //     return true;
    //   }
    // }

  }
}
