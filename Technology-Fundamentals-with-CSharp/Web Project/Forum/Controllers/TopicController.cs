using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.Controllers
{
    public class TopicController : Controller
    {
        private readonly ForumDbContext context;

        public TopicController(ForumDbContext context)
        {
            this.context = context;
        }

        //GET: Topic/Details/id
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Topic topic = context.Topics
                .Include(t => t.Author)
                .Include(t => t.Category)
                .Include(t => t.Comments)
                .ThenInclude(c => c.Author)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        //GET: Topic/Create
        [Authorize]
        public IActionResult Create()
        {
            var categoryNames = context.Categories
                .Select(c => c.Name)
                .ToList();

            ViewData["CategoryNames"] = categoryNames;

            return View();
        }

        //POST: Topic/Create
        [HttpPost]
        [Authorize]
        public IActionResult Create(string categoryName, Topic topic)
        {
            if (ModelState.IsValid)
            {
                //set CreatedDate and LastUpdatedDate
                topic.CreatedDate = DateTime.Now;
                topic.LastUpdatedDate = DateTime.Now;

                //get user id
                string authorId = context.Users
                    .Where(x => x.UserName == this.User.Identity.Name)
                    .First()
                    .Id;

                //set topic author id
                topic.AuthorId = authorId;

                if (!context.Categories.Any(c => c.Name == categoryName))
                {
                    return View(topic);
                }

                int categoryId = context.Categories
                    .FirstOrDefault(c => c.Name == categoryName)
                    .Id;

                topic.CategoryId = categoryId;

                //save topic
                context.Topics.Add(topic);
                context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        //GET: Topic/Delete/id
        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var topic = context.Topics
                .Include(x => x.Author)
                .FirstOrDefault(x => x.Id == id);

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        //POST: Topic/Delete/id
        [HttpPost]
        [Authorize]
        public IActionResult Delete(int id)
        {
            //get topic
            var topic = context.Topics
                .Include(x => x.Author)
                .FirstOrDefault(x => x.Id == id);

            //check if topic exists
            if (topic != null)
            {
                //delete topic
                context.Topics.Remove(topic);
                context.SaveChanges();
            }

            // redirect to Index
            return RedirectToAction("Index", "Home");
        }

        //GET: Topic/Edit/id
        [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            //get topic from DB
            var topic = context.Topics
                .Include(t => t.Author)
                .Include(t => t.Category)
                .Where(t => t.Id == id)
                .FirstOrDefault();

            //check if topic exists
            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (topic.IsAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            var categoryNames = context.Categories
                .Select(c => c.Name)
                .ToList();

            ViewData["CategoryNames"] = categoryNames;

            //pass the model to View
            return View(topic);
        }

        //POST: Topic/Edit/id
        [HttpPost]
        [Authorize]
        public IActionResult Edit(string categoryName, Topic topic)
        {
            if (ModelState.IsValid)
            {
                //get the topic from the DB
                var topicFromDb = context.Topics
                    .Include(x => x.Author)
                    .FirstOrDefault(x => x.Id == topic.Id);

                //check if the topic exists
                if (topicFromDb == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                //set new properties
                topicFromDb.Description = topic.Description;
                topicFromDb.Title = topic.Title;

                int categoryId = context.Categories
                    .FirstOrDefault(c => c.Name == categoryName)
                    .Id;

                topicFromDb.CategoryId = categoryId;

                topicFromDb.LastUpdatedDate = DateTime.Now;

                //save changes
                context.SaveChanges();

                //redirect to Index
                return RedirectToAction("Index", "Home");
            }

            //if model is invalid return the sam topic
            return View(topic);
        }
    }
}