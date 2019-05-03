using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
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
            char[] comparison = {'b', 'o', 'y', ' ', 'd', 'o', 'g', ' '};
            //Act
            char[] result = newRepeatCounter.ReplaceSpecialCharacters();
            //Assert
            Assert.AreEqual(result[3], comparison[7]);
        }

        [TestMethod]
        public void IsInputValid_ChecksIfWordInputIsAnAlphabetCharacter_False()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("xjxsd", "test sentence");
            //Act
            bool result = newRepeatCounter.IsInputValid();
            //Assert
            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void CheckIfWordMatchSentence_ChecksIfWordMatchesAWordInSentence_int()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("the", "the cat and the dog");
            //Act
            int result = newRepeatCounter.CheckIfWordMatchSentence();
            //Assert
            Assert.AreEqual(2, result);
        }

    }
}
