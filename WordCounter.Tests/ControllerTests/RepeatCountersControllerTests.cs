using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCountersControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            RepeatCountersController controller = new RepeatCountersController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void New_ReturnsCorrectView_True()
        {
            //Arrange
            RepeatCountersController controller = new RepeatCountersController();

            //Act
            ActionResult newView = controller.New();

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        // [TestMethod]
        // public void Create_RedirectsToCorrectAction_Index()
        // {
        //     //Arrange
        //     ItemsController controller = new ItemsController();
        //     RedirectToActionResult actionResult = controller.Create("Walk the dog") as RedirectToActionResult;
        //
        //     //Act
        //     string result = actionResult.ActionName;
        //
        //     //Assert
        //     Assert.AreEqual(result, "Index");
        // }
    }
}
