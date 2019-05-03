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
      List<RepeatCounter> allRepeatCounters = RepeatCounter.GetAll();
      return View(allRepeatCounters);
    }

    [HttpGet("/repeat-counter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/repeat-counter")]
    public ActionResult Create(string wordInput, string sentenceInput)
    {
      RepeatCounter newRepeatCounter = new RepeatCounter(wordInput, sentenceInput);
      // newRepeatCounter.ReplaceSpecialCharacters(word);
      // newRepeatCounter.ReplaceSpecialCharacters(sentence);
      // newRepeatCounter.IsInputValid(word);
      // newRepeatCounter.IsInputValid(sentence);
      newRepeatCounter.CheckIfWordMatchSentence();
      List<RepeatCounter> allRepeatCounters = RepeatCounter.GetAll();
      return RedirectToAction("Index", allRepeatCounters);
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
