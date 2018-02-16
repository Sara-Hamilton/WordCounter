using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("", "");
      return View(newRepeatCounter);
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      string inputWord = Request.Form["input-word"];
      string inputString = Request.Form["input-string"];
      RepeatCounter newRepeatCounter = new RepeatCounter(inputWord, inputString);
      return View("Index", newRepeatCounter);
    }

  }
}
