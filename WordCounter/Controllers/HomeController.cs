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
      return View();
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      string inputWord = Request.Form["input-word"];
      string inputString = Request.Form["input-string"];
      RepeatCounter newRepeatCounter = new RepeatCounter(inputWord, inputString);
      if (newRepeatCounter.GetInputWord() == "" || newRepeatCounter.GetInputString() == "")
      {
          string message = "Fill in all fields";
          return View("Index", message);
      }
      else
      {
        return View("Result", newRepeatCounter);
      }
    }

  }
}
