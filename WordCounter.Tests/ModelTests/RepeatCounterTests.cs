using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System.Collections.Generic;

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
            string wordInput = newRepeatCounter.WordInput;
            //Assert
            Assert.AreEqual("test", wordInput);
        }

        [TestMethod]
        public void GetSentenceInput_GetPrivatePropertyWordInput_stringSentenceInput()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("test", "test sentence");
            //Act
            string sentenceInput = newRepeatCounter.SentenceInput;
            //Assert
            Assert.AreEqual("test sentence", sentenceInput);
        }

        [TestMethod]
        public void GetAlphabet_GetListOfAlphabetChar_CharList()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("test", "test sentence");
            //Act
            List<char> alphaList = newRepeatCounter.Alphabet;
            //Assert
            Assert.AreEqual('a', alphaList[0]);
        }

        [TestMethod]
        public void GetNumbers_GetListOfNumbers_CharList()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("test", "test sentence");
            List<char> comparisonList = new List<char> {'0', '2', '3', '4', '5', '6', '7', '8', '9', '1'};
            //Act
            List<char> numList = newRepeatCounter.Numbers;
            //Assert
            CollectionAssert.AreEquivalent(numList, comparisonList);
        }

        [TestMethod]
        public void ReplaceSpecialCharacters_RemoveSpecialCharacterFromArrayOfChar_CharArray()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("boy.dog.", "test sentence");
            string wordInput = newRepeatCounter.WordInput;
            char[] wordInputArray = newRepeatCounter.ToCharArray(wordInput);
            char[] comparison = {'b', 'o', 'y', ' ', 'd', 'o', 'g', ' '};
            //Act
            char[] result = newRepeatCounter.ReplaceSpecialCharacters(wordInputArray);
            //Assert
            Assert.AreEqual(result[3], comparison[7]);
        }

        // [TestMethod]
        // public void IsInputValid_ChecksIfWordInputIsAnAlphabetCharacter_CharArray()
        // {
        //     //Arrange
        //     RepeatCounter newRepeatCounter = new RepeatCounter("xab", "test sentence");
        //     string testString = newRepeatCounter.GetWordInput();
        //     char[] testArray = newRepeatCounter.ToCharArray(testString);
        //     char[] testArray2 = {'x', 'a', 'b'};
        //     //Act
        //     bool result = newRepeatCounter.IsInputValid(testArray);
        //     //Assert
        //     Assert.AreEqual(true, result);
        // }

        [TestMethod]
        public void ToCharArray_TurnsUserInputIntoAnArrayOfChars_CharArray()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("b12", "test sentence");
            string wordInput = newRepeatCounter.WordInput;
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
            string sentenceInput = newRepeatCounter.SentenceInput;
            string[] compareArray = { "this", "is", "a", "test", "sentence" };
            //Act
            string[] sentenceArray = newRepeatCounter.MakeSentenceArray(sentenceInput);
            //Assert
            Assert.AreEqual(sentenceArray[0], compareArray[0]);
        }

        [TestMethod]
        public void CheckIfWordMatchSentence_ChecksIfWordMatchesAWordInSentence_int()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("the", "the cat and the dog");
            string wordInput = newRepeatCounter.WordInput;
            string sentenceInput = newRepeatCounter.SentenceInput;
            string[] sentenceArray = newRepeatCounter.MakeSentenceArray(sentenceInput);
            //Act
            int result = newRepeatCounter.CheckIfWordMatchSentence(wordInput, sentenceArray);
            //Assert
            Assert.AreEqual(2, result);
        }

    }
}
