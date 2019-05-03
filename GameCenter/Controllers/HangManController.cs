using Microsoft.AspNetCore.Mvc;
using GameCenter.Models;
using System.Collections.Generic;
using System;

namespace GameCenter.Controllers
{
    public class HangManController : Controller
    {
        [HttpGet("/hangman")]
        public ActionResult Index()
        {
            HangMan newGame = new HangMan();
            HangMan thisGame = HangMan.FindGame();
            // Game newGame = new Game();
            return View(thisGame);
        }

        // [HttpPost("/hangman")]
        // public ActionResult Update(string userLetter)
        // {
        //     // char converted;
        //     // bool userChar = Char.TryParse(userLetter, out converted);
        //
        //     char newChar = userLetter[0];
        //     HangMan thisGame = HangMan.FindGame();
        //     thisGame.DoesContainChar(newChar);
        //     return View("Index", thisGame);
        // }

    }
}
