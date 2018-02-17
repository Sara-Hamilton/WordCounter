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
        bool result = newRepeatCounter.WordIsValid();
        //assert
        Assert.AreEqual(false, result);
      }

      [TestMethod]
      public void StringIsValid_InputStringNotEmptyString_True()
      {
        //arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("the", "the girl likes the food");
        //action
        bool result = newRepeatCounter.StringIsValid();
        //assert
        Assert.AreEqual(true, result);
      }

      [TestMethod]
      public void WordCount_ReturnWordCount_Int()
      {
        //arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("the", "the girl likes the food");
        //action
        int result = newRepeatCounter.WordCount();
        //assert
        Assert.AreEqual(2, result);
      }

      [TestMethod]
      public void WordCount_ReturnWordCountCaseInsensitive_Int()
      {
        //arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("the", "The girl likes the food");
        //action
        int result = newRepeatCounter.WordCount();
        //assert
        Assert.AreEqual(2, result);
      }

      [TestMethod]
      public void WordCount_ReturnWordCountIgnorePunctuation_Int()
      {
        //arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("food", "The girl likes the food.");
        //action
        int result = newRepeatCounter.WordCount();
        //assert
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void RemovePunctuation_RemovePunctuation_StringList()
      {
          //arrange
          RepeatCounter newRepeatCounter = new RepeatCounter("food", "The girl, likes the food.");
          //action
          List<string> result = newRepeatCounter.RemovePunctuation();
          List<string> comparisonResult = new List<string>(){"The","girl","likes","the","food"};
          //assert
          CollectionAssert.AreEqual(comparisonResult, result);
      }

      [TestMethod]
      public void NoAdditionalFunctionNeeded_FullWordMatchesOnly_Int()
      {
        //arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("the", "The girl likes the theater.");
        //action
        int result = newRepeatCounter.WordCount();
        //assert
        Assert.AreEqual(2, result);
      }
  }
}
