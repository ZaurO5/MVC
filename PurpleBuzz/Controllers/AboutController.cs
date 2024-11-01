using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Models.About;

namespace PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var teamMembers = _context.TeamMembers.ToList();
            var aboutCards = _context.AboutCards.ToList();

            var teamMembersList = teamMembers.Select(teamMember => new TeamMemberVM
            {
                Name = teamMember.Name,
                Surname = teamMember.Surname,
                PhotoPath = teamMember.PhotoPath,
                Position = teamMember.Position,
            }).ToList();

            var aboutCardsList = aboutCards.Select(aboutCard => new AboutCardVM
            {
                Title = aboutCard.Title,
                Subtitle = aboutCard.Subtitle,
                IconClass = aboutCard.IconClass,

            }).ToList();

            var model = new AboutIndexVM
            {
                TeamMembers = teamMembersList,
                AboutCards = aboutCardsList
            };

            return View(model);
        }
    }
}
