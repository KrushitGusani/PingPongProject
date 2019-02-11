using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongProject;
using PingPongProject.Controllers;
using PingPongProject.Models;

namespace PingPongProject.Tests.Controllers
{
    [TestClass]
    public class PlayersControllerTest
    {
        //This test method will check if the database has any player in it when it starts application to check PlayerDBSeeder's Seed() works
        [TestMethod]
        public void Test_Index()
        {
            // Arrange
            PlayersController controller = new PlayersController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
