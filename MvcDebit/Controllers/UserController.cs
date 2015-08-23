using MvcDebit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDebit.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult Login(string user, string pass)
        {
            if (true == String.IsNullOrEmpty(user) || true == String.IsNullOrEmpty(pass))
                return View("Loginerror");

            // user != empty;
            // pass != empty;
            // if user != empty then
            // user they quarry user from db
            // if user = quarry
            // then pass = from db 
            // if else then
            // re direct to home page
            // fail msg if not correct log in information
            return new RedirectResult("Index", false); // redirect to "Home" page
        }

        public ActionResult Index()
        {

            return View();
        }

        public User readQuarry()
        {
            var user = new User("Bob", 20);
            return user;
        }

    }
}

