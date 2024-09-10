using itvidpradotnetcoreadvanced.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Security.Claims;
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

        public ActionResult Dashboard()
        {
            return View();
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
        public async Task<IActionResult> Login(string username, string password)
        {
            LoginContext db = new LoginContext();

            var users = _db.UserLogins.Any(u => u.UserName == username && u.Password == password);

           
            if (users)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username)
            };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true 
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Dashboard");
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View();
        }

       
    }

}
