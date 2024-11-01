using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzz.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
