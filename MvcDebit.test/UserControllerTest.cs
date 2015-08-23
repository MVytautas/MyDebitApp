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
        public void Login_EmptyUser() // There will where testing does user is empty
        {
            var controller = new UserController();
            var result = controller.Login(string.Empty, "123");
            Assert.IsNotNull((ViewResult)result);
            Assert.IsNotNull(result);
            //Assert.Equals(result
        }
    }
}
