using Microsoft.AspNetCore.Mvc;
using GameCenter.Models;
using System.Collections.Generic;
using System;

namespace GameCenter.Controllers
{
    public class WordCountersController : Controller
    {
        [HttpGet("/word-counter")]
        public ActionResult Index()
        {
            List<WordCounter> allWordCounters = WordCounter.GetAll();
            return View(allWordCounters);
        }

        [HttpGet("/word-counter/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/word-counter")]
        public ActionResult Create(string wordInput, string sentenceInput)
        {
            WordCounter newWordCounter = new WordCounter(wordInput, sentenceInput);
            newWordCounter.CheckIfWordMatchSentence();
            List<WordCounter> allWordCounters = WordCounter.GetAll();
            return RedirectToAction("Index", allWordCounters);
        }

        [HttpPost("/word-counter/delete")]
        public ActionResult DeleteAll()
        {

            WordCounter.ClearAll();
            return View();
        }

    }
}
