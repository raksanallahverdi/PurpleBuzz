using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Models.About;
using PurpleBuzz.Models.Pricing;

namespace PurpleBuzz.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var PricingCards = _context.PricingCards.ToList();

            var PricingCardList = new List<PricingCardVM>();
            foreach (var PricingCard in PricingCards)
            {
                var PricingCardVM = new PricingCardVM
                {
                    Title = PricingCard.Title,
                    Price =PricingCard.Price,
                    Features = PricingCard.Features
                  
                };
                PricingCardList.Add(PricingCardVM);
            }
            var model = new PricingIndexVM
            {
                PricingCards = PricingCardList
            };
            return View(model);
        }


    }
}
