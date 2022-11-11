using Microsoft.AspNetCore.Mvc;

namespace TraverselCoreApplication.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
