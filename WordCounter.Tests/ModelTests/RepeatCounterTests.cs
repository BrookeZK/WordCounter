using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System.Collections.Generic;
using System;

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
      List<char> alphaList = newRepeatCounter.GetAlphabet();
      //Assert
      Assert.AreEqual('a', alphaList[0]);
    }

    [TestMethod]
    public void ToCharArray_TurnsUserInputIntoAnArrayOfChars_CharArray()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("b12", "test sentence");
      string wordInput = newRepeatCounter.GetWordInput();
      //Act
      char[] result = newRepeatCounter.ToCharArray(wordInput);
      //Assert
      Assert.AreEqual(result[2], '2');
    }

    [TestMethod]
    public void MakeSentenceArray_MakeASentenceStringIntoAnArrayOfStrings_StringArray()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "this is a test sentence");
      string sentenceInput = newRepeatCounter.GetSentenceInput();
      string[] compareArray = { "this", "is", "a", "test", "sentence" };
      Console.WriteLine(compareArray[1]);
      //Act
      string[] sentenceArray = newRepeatCounter.MakeSentenceArray(sentenceInput);
      Console.WriteLine(sentenceArray[1]);
      //Assert
      Assert.AreEqual(sentenceArray[0], compareArray[0]);
    }

    [TestMethod]
    public void CheckIfWordMatchSentence_ChecksIfWordMatchesAWordInSentence_int()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("of", "of of of of");
      string wordInput = newRepeatCounter.GetWordInput();
      string sentenceInput = newRepeatCounter.GetSentenceInput();
      string[] sentenceArray = newRepeatCounter.MakeSentenceArray(sentenceInput);
      //Act
      int result = newRepeatCounter.CheckIfWordMatchSentence(wordInput, sentenceArray);
      //Assert
      Assert.AreEqual(result, 4);
    }

    // [TestMethod]
    // public void IsAlphabetChar_ChecksIfWordInputIsAnAlphabetCharacter_charArray()
    // {
    //   //Arrange
    //   RepeatCounter newRepeatCounter = new RepeatCounter("dezzi", "test sentence");
    //   string testString = newRepeatCounter.GetWordInput();
    //   char[] testArray = newRepeatCounter.ToCharArray(testString);
    //   //Act
    //   char[] result = newRepeatCounter.IsAlphabetChar(testArray);
    //     // Console.WriteLine("Output from second GetAll test: " result);
    //
    //   //Assert
    //   Assert.AreEqual('i', result[4]);
    // }

    // [TestMethod]
    // public void IsInputValid_ChecksIfWordInputIsAnAlphabetCharacter_bool()
    // {
    //   //Arrange
    //   RepeatCounter newRepeatCounter = new RepeatCounter("x", "test sentence");
    //   string testString = newRepeatCounter.GetWordInput();
    //   char[] testArray = newRepeatCounter.ToCharArray(testString);
    //   //Act
    //   bool result = newRepeatCounter.IsInputValid(testArray);
    //   //Assert
    //   Assert.AreEqual(true, result);
    // }

    // [TestMethod]
    // public void IsInputValid_ChecksIfSentenceInputIsAlphabetCharacters_bool()
    // {
    //   //Arrange
    //   RepeatCounter newRepeatCounter = new RepeatCounter("abc", "xha");
    //   string testString = newRepeatCounter.GetSentenceInput();
    //   char[] testArray = newRepeatCounter.ToCharArray(testString);
    //   //Act
    //   bool result = newRepeatCounter.IsInputValid(testArray);
    //   //Assert
    //   Assert.AreEqual(true, result);
    // }

    //Arrange
    //Act
    //Assert
  }
}
