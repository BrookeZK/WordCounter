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

    [TestMethod]
    public void GetWordInput_GetPrivatePropertyWordInput_stringWordInput()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "test sentence");
      //Act
      string wordInput = newRepeatCounter.GetWordInput();
      //Assert
      Assert.AreEqual("test", wordInput);
    }

    [TestMethod]
    public void GetSentenceInput_GetPrivatePropertyWordInput_stringSentenceInput()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "test sentence");
      //Act
      string sentenceInput = newRepeatCounter.GetSentenceInput();
      //Assert
      Assert.AreEqual("test sentence", sentenceInput);
    }

    [TestMethod]
    public void GetAlphabet_GetArrayOfAlphabetChar_CharArray()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "test sentence");
      //Act
      char[] alphaArray = newRepeatCounter.GetAlphabet();
      //Assert
      Assert.AreEqual('a', alphaArray[0]);
    }

    [TestMethod]
    public void ToCharArray_TurnsUserInputIntoAnArrayOfChars_CharArray()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("1", "test sentence");
      string wordInput = newRepeatCounter.GetWordInput();
      //Act
      char[] result = newRepeatCounter.ToCharArray(wordInput);
      //Assert
      Assert.AreEqual('0', result[0]);
    }

    // [TestMethod]
    // public void IsAlphabetChar_ChecksIfInputIsAnAlphabetCharacter_bool()
    // {
    //   //Arrange
    //   RepeatCounter newRepeatCounter = new RepeatCounter("1", "test sentece");
    //   string testString = newRepeatCounter.GetWordInput();
    //   //Act
    //   bool result = newRepeatCounter.IsAlphabetChar(testString);
    //   //Assert
    //   Assert.AreEqual(true, result);
    // }

    //Arrange
    //Act
    //Assert
  }
}
