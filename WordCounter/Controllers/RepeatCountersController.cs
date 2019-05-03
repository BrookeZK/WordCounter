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
            newRepeatCounter.CheckIfWordMatchSentence();
            List<RepeatCounter> allRepeatCounters = RepeatCounter.GetAll();
            return RedirectToAction("Index", allRepeatCounters);
        }

        [HttpPost("/repeat-counter/delete")]
        public ActionResult DeleteAll()
        {

            RepeatCounter.ClearAll();
            return View();
        }

    }
}
