using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using GameCenter.Models;

namespace GameCenter.Tests
{
    [TestClass]
    public class HangManTest
    {

        // public void Dispose()
        // {
        //     Game.ClearAll();
        // }

        [TestMethod]
        public void HangManConstructor_CreateGameInstance_Game()
        {
            HangMan newHangMan = new HangMan();
            Assert.AreEqual(typeof(HangMan), newHangMan.GetType());
        }

        [TestMethod]
        public void GetGameWord_SetWordForGame_String()
        {
            HangMan newGame = new HangMan();
            string gameWord = newGame.GetGameWord();
            bool doesContain = false;
            List<string> _wordPool = new List<string> {"tamagotchi", "string", "bootygame", "vaporwave", "cheese", "robot", "bobby", "godzilla", "queen", "crispy", "alligator"};

            for(int i = 0; i < _wordPool.Count; i ++)
            {
                if(gameWord == _wordPool[i])
                {
                    doesContain = true;
                }
            }
            Console.WriteLine(gameWord);
            Assert.AreEqual(true, doesContain);
        }

        [TestMethod]
        public void BuildWordBlanks_MakeACharArrayOfWordBlanks_CharArray()
        {
            HangMan newGame = new HangMan();
            // char[] gameWordArray = newGame.GameWord;
            // char[] testArray = {'h', 'a', 'p', 'p', 'y'};
            char[] blanksArray = newGame.BuildWordBlanks();
            char testChar = '_';
            Assert.AreEqual(testChar, blanksArray[3]);
        }

        [TestMethod]
        public void UpdateLettersGuessed_AddCharToListOfGuessedLetters_List()
        {
            HangMan newGame = new HangMan();
            char testChar = 'z';
            List<char> compareList = new List<char> { };
            compareList.Add(testChar);
            List<char> result = newGame.UpdateLettersGuessed(testChar);
            CollectionAssert.AreEqual(result, compareList);
        }

        [TestMethod]
        public void UpdateNumberOfGuesses_IncrementTheNumberOfGuessesProperty_int()
        {
            HangMan newGame = new HangMan();
            int result = newGame.UpdateNumberOfGuesses();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CheckForLose_CheckIfMaxTurnsReached_True()
        {
            HangMan newGame = new HangMan();
            int testGuesses = 7;
            bool result = newGame.CheckForLose(testGuesses);

            Assert.AreEqual(true, result);
        }
        //Test passes all static inputs
        // [TestMethod]
        // public void
        // CheckForWin_CheckIfUserWinsGame_true()
        // {
        //   HangMan newGame = new HangMan();
        //   char[] testGameWord = {'h', 'a', 'p', 'p', 'y'};
        //   char[] testBlanks = {'h', 'a', 'p', 'p', 'y'};
        //   bool result = newGame.CheckForWin(testGameWord, testBlanks);
        //   Assert.AreEqual(true, result);
        // }

        //Test works with static input
        // [TestMethod]
        // public void UpdateBlanks_CompareUserCharToGameWordAndUpdateBlanks_CharArray()
        // {
        //   HangMan newGame = new HangMan();
        //   char userChar = 'a';
        //   char[] testArray = {'h', 'a', 'p', 'p', 'y'};
        //   char[] testBlanks = {'_', 'a', '_', '_', '_'};
        //   char[] result = newGame.UpdateBlanks(userChar, testArray);
        //
        //   Assert.AreEqual(userChar, result[1]);
        // }

        //Test Worked before we switched to random word generation
        // [TestMethod]
        // public void DoesContainChar_CheckGameWordArrayForUserChar_True()
        // {
        //   HangMan newGame = new HangMan();
        //   // newGame.GameWord = {'b', 'c', 'a'};
        //   char testChar = 'a';
        //   bool testBool = newGame.DoesContainChar(testChar);
        //
        //   Assert.AreEqual(true, testBool);
        // }


    }
}
