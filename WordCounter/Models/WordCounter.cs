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
      _inputWord = inputWord.Trim();
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

    public int WordCount()
    {
      int counter = 0;
      List<string> stringList = RemovePunctuation();
      foreach(string word in stringList)
      {
        if (word.ToLower() == _inputWord.ToLower())
        {
          counter++;
        }
      }
      return counter;
    }

    public List<string> RemovePunctuation()
    {
      string[] stringArray = _inputString.Split();
      char[] charsToTrim = {',', '.','!','?',':',';','@','%','&','(',')','{','}','[',']','/','\\','*','<','>'};
      List<string> newStringList = new List<string>();
      foreach(string word in stringArray)
      {
        newStringList.Add(word.Trim(charsToTrim));
      }
      return newStringList;
    }

  }
}
