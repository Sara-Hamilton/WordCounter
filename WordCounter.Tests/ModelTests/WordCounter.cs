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
        Assert.AreEqual("the", resultWord);
        Assert.AreEqual("the girl likes the food", resultString);
      }

      [TestMethod]
      public void WordIsValid_InputWordNotEmptyString_False()
      {
        //arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("", "the girl likes the food");
        //action
        string resultWord = newRepeatCounter.GetInputWord();
        //assert
        Assert.AreEqual("", resultWord);
      }

      [TestMethod]
      public void StringIsValid_InputStringNotEmptyString_True()
      {
        //arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("the", "the girl likes the food");
        //action
        string resultString = newRepeatCounter.GetInputString();
        //assert
        Assert.AreEqual("the girl likes the food", resultString);
      }

      [TestMethod]
      public void WordCount_ReturnWordCount_Int()
      {
        //arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("the", "the girl likes the food");
        //action
        int result = newRepeatCounter.WordCount("the", "the girl likes the food");
        //assert
        Assert.AreEqual(1, result);
      }
  }
}
