using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Controllers
{
  public class RepeatCountersController : Controller
  {
    [HttpGet("/repeat-counter")]
    public ActionResult Index()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("word", "test sentence with word");
      return View(newRepeatCounter);
    }

    // [HttpPost("/game")]
    // public ActionResult Update(string userLetter)
    // {
    //   // char converted;
    //   // bool userChar = Char.TryParse(userLetter, out converted);
    //
    //   char newChar = userLetter[0];
    //   Game thisGame = Game.FindGame();
    //   thisGame.DoesContainChar(newChar);
    //   return View("Index", thisGame);
    // }

  }
}
