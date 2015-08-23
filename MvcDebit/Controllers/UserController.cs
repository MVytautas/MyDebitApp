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
            return new RedirectResult();
        }

        public ActionResult Index()
        {

            return View();
        }

        public User readQuarry()
        {
            var user = new User("Bob", 20);
        }

    }
}
