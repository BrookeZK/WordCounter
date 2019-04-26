namespace WordCounter
{
  public class RepeatCounter
  {
    public bool IsAlphabetChar(string userInput)
    {
      if (userInput == userInput)
      {
        return true;
      }
      else
      {
      return false;
      }
    }
  }
}
