using Microsoft.AspNetCore.Mvc;

namespace itvidpradotnetcoreadvanced.Controllers.CSharpControllers
{
    public class RestaurantController : Controller
    {
       public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

    }
}
