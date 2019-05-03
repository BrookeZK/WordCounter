using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameCenter.Models;
using System.Collections.Generic;
using System;

namespace GameCenter.Tests
{
    [TestClass]
    public class RepeatCounterTest : IDisposable
    {
        public void Dispose()
        {
            RepeatCounter.ClearAll();
        }

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

        // [TestMethod]
        // public void ReplaceSpecialCharacters_RemoveSpecialCharacterFromArrayOfChar_charArray()
        // {
        //     RepeatCounter newRepeatCounter = new RepeatCounter("boy.do.g", "test sentence");
        //     char[] comparison = {'b', 'o', 'y', ' ', 'd', 'o', ' ', 'g'};
        //     string comparison2 = newRepeatCounter.ComparisonString;
        //     string testString = "boy do g";
        //     //Act
        //     char[] result = newRepeatCounter.ReplaceSpecialCharacters(testString);
        //     //Assert
        //     Console.WriteLine(comparison2);
        //     Assert.AreEqual(comparison[6], result[4]);
        // }



        [TestMethod]
        public void IsInputValid_ChecksIfWordInputIsAnAlphabetCharacter_False()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("xjxsd", "test sentence");
            string testString = "xjxsd";
            //Act
            bool result = newRepeatCounter.IsInputValid(testString);
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

        [TestMethod]
        public void GetAll_ReturnsAllRepeatCounterObjects_RepeatCounterList()
        {
            //Arrange
            string word1 = "Work";
            string sentence1 = "I love my Work";
            string word2 = "Happy";
            string sentence2 = "Happy days";
            RepeatCounter newRepeatCounter1 = new RepeatCounter(word1, sentence1);
            RepeatCounter newRepeatCounter2 = new RepeatCounter(word2, sentence2);
            List<RepeatCounter> newList = new List<RepeatCounter> { newRepeatCounter1, newRepeatCounter2 };

            //Act
            List<RepeatCounter> result = RepeatCounter.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

    }
}
