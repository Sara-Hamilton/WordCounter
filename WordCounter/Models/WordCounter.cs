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

    public bool WordIsValid()
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

    public bool StringIsValid()
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

    public int WordCount(string inputWord, string inputString)
    {
      int counter = 0;
      List<string> stringList = RemoveTrailingPunctuation();
      foreach(string word in stringList)
      {
        if (word.ToLower() == inputWord.ToLower())
        {
          counter++;
        }
      }
      return counter;
    }

    public List<string> RemoveTrailingPunctuation()
    {
      string[] stringArray = _inputString.Split();
      char[] charsToTrim = {',', '.'};
      List<string> newStringList = new List<string>();
      foreach(string word in stringArray)
      {
        newStringList.Add(word.TrimEnd(charsToTrim));
      }
      return newStringList;
    }


  }
}
