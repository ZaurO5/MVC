using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Models.Contact;
using PurpleBuzz.Models.Home;
using System.Collections.Generic;
using System.Linq;

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
            var contacts = _context.Contacts.ToList();

            var contactsList = new List<ContactVM>();
            foreach (var contact in contacts)
            {
                var contactVM = new ContactVM
                {
                    Role = contact.Role,
                    Name = contact.Name,
                    Phone = contact.Phone,
                    IconClass = contact.IconClass,
                };
                contactsList.Add(contactVM);
            }

            var model = new ContactIndexVM
            {
                Contacts = contactsList
            };

            return View(model);
        }
    }
}
