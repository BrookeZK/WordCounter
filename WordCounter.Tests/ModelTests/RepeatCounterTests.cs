using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void RepeatCounterConstructor_MakeANewInstanceOfRepeatCounterClass_RepeatCounter()
    {
      //Arrange
      //Act
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "test sentence");
      //Assert
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
    }

    // [TestMethod]
    // public void IsAlphabetChar_ChecksIfInputIsAnAlphabetCharacter_bool()
    // {
    //   //Arrange
    //   RepeatCounter newRepeatCounter = new RepeatCounter();
    //   string testString = "1%";
    //   //Act
    //   bool result = newRepeatCounter.IsWord(testString);
    //   //Assert
    //   Assert.AreEqual(true, result);
    // }

    //Arrange
    //Act
    //Assert

    //Arrange
    //Act
    //Assert
  }
}
