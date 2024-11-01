using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Models.Contact;
using PurpleBuzz.Models.Home;

namespace PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Works = _context.Works.ToList();
            var WorksList = new List<WorkVM>();
            foreach (var work in Works)
            {
                var WorkVM = new WorkVM
                {
                    Title = work.Title,
                    PhotoPath = work.PhotoPath,
                    Description = work.Description,
                };
                WorksList.Add(WorkVM);
            }
            var model = new HomeIndexVM
            {
                Works = WorksList
            };
            return View(model);
        }

    }
}
