using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Models.About;
using PurpleBuzz.Models.Contact;

namespace PurpleBuzz.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var ContactInfos = _context.ContactInfos.ToList();
            var ContactInfosList = new List<ContactInfoVM>();
            foreach (var Contact in ContactInfos)
            {
                var ContactInfoVM = new ContactInfoVM
                {
                    Title = Contact.Title,
                    Person = Contact.Person,
                    PhotoUrl = Contact.PhotoUrl,
                    PhoneNumber = Contact.PhoneNumber,
                };
                ContactInfosList.Add(ContactInfoVM);
            }
            var model = new ContactIndexVM
            {
                ContactInfos = ContactInfosList
            };
            return View(model);
        }


    }
}
