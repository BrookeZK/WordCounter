using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameCenter.Models;
using System.Collections.Generic;
using System;

namespace GameCenter.Tests
{
    [TestClass]
    public class WordCounterTest : IDisposable
    {
        public void Dispose()
        {
            WordCounter.ClearAll();
        }

        [TestMethod]
        public void WordCounterConstructor_MakeANewInstanceOfWordCounterClass_WordCounter()
        {
            //Arrange
            //Act
            WordCounter newWordCounter = new WordCounter("test", "test sentence");
            //Assert
            Assert.AreEqual(typeof(WordCounter), newWordCounter.GetType());
        }

        [TestMethod]
        public void GetWordInput_GetPrivatePropertyWordInput_stringWordInput()
        {
            //Arrange
            WordCounter newWordCounter = new WordCounter("test", "test sentence");
            //Act
            string wordInput = newWordCounter.WordInput;
            //Assert
            Assert.AreEqual("test", wordInput);
        }

        [TestMethod]
        public void GetSentenceInput_GetPrivatePropertyWordInput_stringSentenceInput()
        {
            //Arrange
            WordCounter newWordCounter = new WordCounter("test", "test sentence");
            //Act
            string sentenceInput = newWordCounter.SentenceInput;
            //Assert
            Assert.AreEqual("test sentence", sentenceInput);
        }

        [TestMethod]
        public void GetAlphabet_GetListOfAlphabetChar_CharList()
        {
            //Arrange
            WordCounter newWordCounter = new WordCounter("test", "test sentence");
            //Act
            List<char> alphaList = newWordCounter.Alphabet;
            //Assert
            Assert.AreEqual('a', alphaList[0]);
        }

        [TestMethod]
        public void GetNumbers_GetListOfNumbers_CharList()
        {
            //Arrange
            WordCounter newWordCounter = new WordCounter("test", "test sentence");
            List<char> comparisonList = new List<char> {'0', '2', '3', '4', '5', '6', '7', '8', '9', '1'};
            //Act
            List<char> numList = newWordCounter.Numbers;
            //Assert
            CollectionAssert.AreEquivalent(numList, comparisonList);
        }

        // [TestMethod]
        // public void ReplaceSpecialCharacters_RemoveSpecialCharacterFromArrayOfChar_charArray()
        // {
        //     WordCounter newWordCounter = new WordCounter("boy.do.g", "test sentence");
        //     char[] comparison = {'b', 'o', 'y', ' ', 'd', 'o', ' ', 'g'};
        //     string comparison2 = newWordCounter.ComparisonString;
        //     string testString = "boy do g";
        //     //Act
        //     char[] result = newWordCounter.ReplaceSpecialCharacters(testString);
        //     //Assert
        //     Console.WriteLine(comparison2);
        //     Assert.AreEqual(comparison[6], result[4]);
        // }



        [TestMethod]
        public void IsInputValid_ChecksIfWordInputIsAnAlphabetCharacter_False()
        {
            //Arrange
            WordCounter newWordCounter = new WordCounter("xjxsd", "test sentence");
            string testString = "xjxsd";
            //Act
            bool result = newWordCounter.IsInputValid(testString);
            //Assert
            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void CheckIfWordMatchSentence_ChecksIfWordMatchesAWordInSentence_int()
        {
            //Arrange
            WordCounter newWordCounter = new WordCounter("the", "the cat and the dog");
            //Act
            int result = newWordCounter.CheckIfWordMatchSentence();
            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllWordCounterObjects_WordCounterList()
        {
            //Arrange
            string word1 = "Work";
            string sentence1 = "I love my Work";
            string word2 = "Happy";
            string sentence2 = "Happy days";
            WordCounter newWordCounter1 = new WordCounter(word1, sentence1);
            WordCounter newWordCounter2 = new WordCounter(word2, sentence2);
            List<WordCounter> newList = new List<WordCounter> { newWordCounter1, newWordCounter2 };

            //Act
            List<WordCounter> result = WordCounter.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

    }
}
