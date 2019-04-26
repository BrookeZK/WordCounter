using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _wordInput;
    private string _sentenceInput;
    private List<char> _alphabet = new List<char> {};

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
