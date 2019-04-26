using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void IsAlphabetChar_ChecksIfInputIsAnAlphabetCharacter_bool()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      string testString = "1%";
      //Act
      bool result = newRepeatCounter.IsWord(testString);
      //Assert
      Assert.AreEqual(true, result);
    }
  }
}
