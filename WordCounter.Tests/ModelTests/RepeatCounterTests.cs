using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void IsWord_ChecksIfInputIsAnAlphabetCharacter_bool()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      string testString = "1%";
      //Act
      bool result = newRepeatCounter.IsWord(testString);
      //Assert
      Assert.AreEqual(false, result);
    }
  }
}
