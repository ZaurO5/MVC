using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
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
            var cards = _context.Cards.ToList();

            var cardsList = new List<CardVM>();
            foreach (var card in cards)
            {
                var cardVM = new CardVM
                {
                    Title = card.Title,
                    Subtitle = card.Subtitle,
                    PhotoPath = card.PhotoPath,
                };

                cardsList.Add(cardVM);
            }

            var model = new HomeIndexVM
            {
                Cards = cardsList
            };
            return View(model);
        }
    }
}
