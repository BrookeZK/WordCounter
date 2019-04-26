using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _wordInput;
    private string _sentenceInput;
    private char[] _alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 't', 'r', 's', 'u', 'v', 'w', 'x', 'y', 'z'};

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

    public char[] GetAlphabet()
    {
      return _alphabet;
    }

    // public bool IsAlphabetChar(string userInput)
    // {
    //   if (userInput == userInput)
    //   {
    //     return true;
    //   }
    //   else
    //   {
    //   return false;
    //   }
    // }
  }
}
