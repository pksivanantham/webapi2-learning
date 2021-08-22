using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using WebAPI2.Learning;
using WebAPI2.Learning.Controllers;

namespace WebAPI2.Learning.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
