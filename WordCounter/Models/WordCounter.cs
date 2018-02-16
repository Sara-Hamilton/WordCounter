using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _inputWord;
    private string _inputString;


    public RepeatCounter(string inputWord, string inputString)
    {
      _inputWord = inputWord;
      _inputString = inputString;
    }

    public string GetInputWord()
    {
      return _inputWord;
    }

    public void SetInputWord(string inputWord)
    {
      _inputWord = inputWord;
    }

    public string GetInputString()
    {
      return _inputString;
    }

    public void SetInputString(string inputString)
    {
      _inputString = inputString;
    }

    public bool WordIsValid(string inputWord)
    {
      if(_inputWord == "")
      {
        return false;
      }
        else
      {
        return true;
      }
    }

    public bool StringIsValid(string inputString)
    {
      if(_inputString == "")
      {
        return false;
      }
        else
      {
        return true;
      }
    }

  }
}
