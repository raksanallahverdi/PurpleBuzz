using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Models.About;

namespace PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context) {
            _context=context;
        }
        public IActionResult Index()
        {
            var teamMembers=_context.TeamMembers.ToList();
            var teamMembersList=new List<TeamMemberVM>();

            foreach (var teamMember in teamMembers) { 
            var teamMemberVM=new TeamMemberVM
            {
                Name = teamMember.Name,
                Surname=teamMember.Surname,
                PhotoPath=teamMember.PhotoPath,
                Position=teamMember.Position,
            };
                teamMembersList.Add(teamMemberVM);
            }
            var OurVisions = _context.Visions.ToList();
            var OurVisionsList = new List<OurVisionVM>();

            foreach (var vision in OurVisions)
            {
                var OurVisionVM = new OurVisionVM
                {
                    Title = vision.Title,
                    Description = vision.Description,
                    PhotoPath = vision.PhotoPath,
                };
                OurVisionsList.Add(OurVisionVM);
            }




            var model = new AboutIndexVM
            {
                TeamMembers = teamMembersList,
                OurVisions = OurVisionsList
            };
            return View(model);
        }




    }
}
