using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoClub.Models;

namespace VideoClub.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public bool login(string username, string password)
        {
            using (var db = new VideoClubEntities())
            {
                var user = db.Employees.FirstOrDefault(e => e.User == username);

                if (user != null)
                {
                    return (user.Password == password);
                }

            }

            return false;
        }
    }
}