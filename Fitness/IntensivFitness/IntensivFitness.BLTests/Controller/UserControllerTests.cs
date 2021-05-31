using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntensivFitness.BL.Controller;
using System;
using IntensivFitness.BL.Model;

namespace IntensivFitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void LoadTest()
        {
            //Arrange
            
            //Act
            var users = UserController.Load<User>();
            //Assert
            Assert.IsNotNull(users);
        }

        [TestMethod()]
        public void SaveTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();

            //Act
            var controller = new UserController(userName);

            //Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}