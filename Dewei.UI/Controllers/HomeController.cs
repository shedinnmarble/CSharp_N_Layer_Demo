using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dewei.IBLL;
using Dewei.Model;

namespace Dewei.UI.Controllers
{
    public class HomeController : Controller
    {
        public IUserService UserService { get; set; }
        public ActionResult Index()
        {
            List<User> users = UserService.GetEntities(u => u.id > 0).ToList();
            ViewBag.Model = users;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}