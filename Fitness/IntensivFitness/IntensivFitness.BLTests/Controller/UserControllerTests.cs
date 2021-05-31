using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IntensivFitness.BL.Model;

namespace IntensivFitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests : BaseController
    {
        [TestMethod()]
        public void LoadTest()
        {
            //Arrange
            
            //Act
            var users = Load<User>();
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