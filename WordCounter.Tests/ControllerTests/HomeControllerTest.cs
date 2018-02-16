using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //arrange
      HomeController controller = new HomeController();
      //act
      IActionResult indexView = controller.Index();
      ViewResult result = indexView as ViewResult;
      //assert
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_RepeatCounter()
    {
      //arrange
      ViewResult indexView = new HomeController().Index() as ViewResult;
      //act
      var result = indexView.ViewData.Model;
      //assert
      Assert.IsInstanceOfType(result, typeof(RepeatCounter));
    }
  }
}
