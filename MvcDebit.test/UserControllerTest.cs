using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcDebit.Controllers;
using System.Web.Mvc;

namespace MvcDebit.test
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void Login_EmptyUser() // There will where testing does user is empty # user != empty; 
        {
            var controller = new UserController();
            var result = controller.Login(string.Empty, "123");
            Assert.IsNotNull((ViewResult)result);
            Assert.IsNotNull(result);
            //Assert.Equals(result
        }

        [TestMethod]
        public void Login_EmptyUserPass() // # pass != empty;
        {
            var controller = new UserController();
            var passResult = controller.Login("Dude", string.Empty);
            Assert.IsNotNull((ViewResult)passResult);
            Assert.IsNotNull(passResult);
        }

        // if user != empty then
        // user then quarry user from db
        // if user = quarry
        // then pass = from db 
        // if else then

        // re direct to home page
        // fail msg if not correct log in information

        [TestMethod]
        public void Login_ValidateUser()
        {
            var controller = new UserController();
            var userFromQuerry = controller.readQuarry();
            if (userFromQuerry != null)
            {
                Assert.AreEqual(userFromQuerry.Name, "Bob");
                Assert.AreEqual(userFromQuerry.pass, "easyName"); // "easypass"
            }
            else
            {
                Assert.Fail("You failed!");
            }
        }
    }
}
