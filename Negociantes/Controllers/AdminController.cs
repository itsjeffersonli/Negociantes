using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Negociantes.Data;
using Negociantes.Models;

namespace Negociantes.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        // Admin Controllers
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Post()
        {
            var posts = _context.Posts.ToList();
            return View(posts);
        }
        public IActionResult Reply()
        {
            var replies = _context.Replies.ToList();
            return View(replies);
        }

        //Edits View

        public IActionResult EditPost()
        {
            return View();
        }
        public IActionResult EditReply()
        {
            return View();
        }

        // Edit Post
        [HttpPost]
        public IActionResult EditPost(int? id, Post record)
        {
            var post = _context.Posts.Where(i => i.PostId == id).SingleOrDefault();

            post.Subject = post.Subject;
            post.Text = record.Text;
            post.Name = post.Name;
            post.NameFull = post.NameFull;
            post.Messenger = post.Messenger;
            post.City = post.City;
            post.User = post.User;
            post.ImagePath = post.ImagePath;
            post.ImagePath2 = post.ImagePath2;

            _context.Posts.Update(post);
            _context.SaveChanges();

            return RedirectToAction("Post");
        }

        // Delete Post
        public IActionResult deletePost(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Post");
            }
            var post = _context.Posts.Where(i => i.PostId == id).SingleOrDefault();
            if (post == null)
            {
                return RedirectToAction("Post");
            }

            _context.Posts.Remove(post);
            _context.SaveChanges();

            return RedirectToAction("Post");
        }

        // Edit Post
        [HttpPost]
        public IActionResult EditReply(int? id, Reply record)
        {
            var reply = _context.Replies.Where(i => i.ReplyId == id).SingleOrDefault();

            reply.Text = record.Text;
            reply.Name = reply.Name;
            reply.NameFull = reply.NameFull;
            reply.Messenger = reply.Messenger;
            reply.City = reply.City;
            reply.User = reply.User;
            reply.Post = reply.Post;

            _context.Replies.Update(reply);
            _context.SaveChanges();

            return RedirectToAction("Reply");
        }

        // Delete Reply
        public IActionResult deleteReply(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Reply");
            }
            var reply = _context.Replies.Where(i => i.ReplyId == id).SingleOrDefault();
            if (reply == null)
            {
                return RedirectToAction("Reply");
            }

            _context.Replies.Remove(reply);
            _context.SaveChanges();

            return RedirectToAction("Reply");
        }
    }
}
