using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ContosoUniversity.Controllers;
using ContosoUniversity.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContosoUniversity.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void AboutPageRuturnsFiveRowsOfEnrollments()
        {
            // Arrange
            var homeController = new HomeController();
            var expectedCount = 5;
            int actualCount = 0;

            // Act
            var actionResult = homeController.About() as ViewResult;
            var model = actionResult.ViewData.Model as IEnumerable<EnrollmentDateGroup>;
            actualCount = model.Count();

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
