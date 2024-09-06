using itvidpradotnetcoreadvanced.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using static UglyToad.PdfPig.Core.PdfSubpath;

namespace itvidpradotnetcoreadvanced.Controllers.CSharpControllers
{
    public class UserController : Controller
    {
        private readonly LoginContext _db; 
        public UserController(LoginContext db)
        {
            _db = db; 
        }

        public ActionResult MainPage()
        {
            return View();
        }
            
       [HttpGet]
        
        public ActionResult Signup()
        {

        
            return View();
        }
 
        [HttpPost]
        public ActionResult Signup( User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();

            int a = _db.SaveChanges();
            if (a == 0)
            {
                return RedirectToAction("ManageUserName");
            }

            return View(user);

        }

        [HttpGet]

        public ActionResult ManageUserName()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ManageUserName(UserLogin login)
        {
            _db.UserLogins.Add(login);
            
            int a = _db.SaveChanges();

            if (a > 0)
            {
                return RedirectToAction("Login");
            }
            return View();

        }
        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLogin loginUser)
        {

            var users = _db.UserLogins
            .Where(u => u.UserName == loginUser.UserName && u.Password == loginUser.Password);

            if (users.Any())
            {
                var user = users.First();


                return RedirectToAction("MainPage");
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return View();
            }
            //var user = this._db.UserLogins.SingleOrDefault(u => u.UserName == loginUser.UserName && u.Password == loginUser.Password);

            //if (user != null)
            //{
            //    ModelState.AddModelError("", "valid username or password.");
            //    return View();
            //}
            //else
            //{
            //    ModelState.AddModelError("", "Invalid username or password.");
            //    return View();
            //}
            return View();
        }

        



    }

}
