using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void GetsAndSets_AllGettersAndSetters_String()
    {
        //arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("the", "the girl likes the food");
        //action
        string resultWord = newRepeatCounter.GetInputWord();
        string resultString = newRepeatCounter.GetInputString();
        //assert
        Assert.AreEqual("they", resultWord);
        Assert.AreEqual("girl likes the food", resultString);
      }
  }
}
