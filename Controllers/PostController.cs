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
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;

        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Posts
                .Include(x => x.Replies)
                .ToList();
            return View(list);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Post record, IFormFile ImagePath, IFormFile ImagePath2)
        {
            var Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Name = User.FindFirstValue(ClaimTypes.Name);
            var user = _context.Users.Where(u => u.Id == Id).SingleOrDefault();
            var NameFull = user.Name;
            var City = user.City;
            var Messenger = user.Messenger;
            var Avatar = user.AvatarPath;

            var item = new Post()
            {
                Subject = record.Subject,
                Text = record.Text,
                DateTime = System.DateTime.Now,
                UserId = Id,
                Name = Name,
                Category = record.Category,
                NameFull = NameFull,
                City = City,
                Messenger = Messenger,
            };

            if (ImagePath != null)
            {
                if (ImagePath.Length > 0)
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot/img/products", ImagePath.FileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        ImagePath.CopyTo(stream);
                    }
                    item.ImagePath = ImagePath.FileName;
                }
            }

            if (!string.IsNullOrEmpty(Avatar))
            {
                item.ImagePath2 = Avatar;
            }
            else
            {
                item.ImagePath2 = "noprofilepic.png";
            }

            _context.Posts.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var post = _context.Posts.Where(p => p.PostId == id).SingleOrDefault();
            if (post == null)
            {
                return RedirectToAction("Index");
            }

            _context.Posts.Remove(post);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize]
        [HttpPost]
        public IActionResult PostReply(ReplyVM obj)
        {
            var Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Name = User.FindFirstValue(ClaimTypes.Name);
            var user = _context.Users.Where(u => u.Id == Id).SingleOrDefault();
            var NameFull = user.Name;

            Reply record = new Reply();
            {
                record.Text = obj.Reply;
                record.DateTime = System.DateTime.Now;
                record.UserId = Id;
                record.PostId = obj.FID;
                record.Name = Name;
                record.NameFull = NameFull;
                record.Messenger = user.Messenger;
                record.City = user.City;
            }

            _context.Replies.Add(record);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
