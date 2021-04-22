using Microsoft.AspNetCore.Mvc;
using Negociantes.Data;
using Negociantes.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Web;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Negociantes.ViewModels;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Negociantes.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Contact record)
        {
            var Name = User.FindFirstValue(ClaimTypes.Email);

            var item = new Contact()
            {
                Text = record.Text,
                Email = Name,
                DateTime = System.DateTime.Now,
            };

            _context.Contacts.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
