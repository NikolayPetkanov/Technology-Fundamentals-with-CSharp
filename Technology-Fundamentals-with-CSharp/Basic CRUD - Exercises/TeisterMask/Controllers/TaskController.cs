using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TeisterMask.Data;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var db = new MeisterTaskDbContext())
            {
                var allTasks = db.Tasks.ToList();
                return View(allTasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Task task)
        {
            if (string.IsNullOrEmpty(task.Title) || string.IsNullOrEmpty(task.Status))
            {
                return RedirectToAction("Index");
            }

            using (var db = new MeisterTaskDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new MeisterTaskDbContext())
            {
                var currentTask = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (currentTask == null)
                {
                    return RedirectToAction("Index");
                }

                return View(currentTask);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                using (var db = new MeisterTaskDbContext())
                {
                    var currentTask = db.Tasks.FirstOrDefault(t => t.Id == task.Id);
                    currentTask.Title = task.Title;
                    currentTask.Status = task.Status;
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new MeisterTaskDbContext())
            {
                var currentTask = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (currentTask == null)
                {
                    return RedirectToAction("Index");
                }

                return View(currentTask);
            }
        }

        [HttpPost]
        public IActionResult Delete(Task task)
        {
            using (var db = new MeisterTaskDbContext())
            {
                var currentTask = db.Tasks.FirstOrDefault(t => t.Id == task.Id);

                if (currentTask != null)
                {
                    db.Tasks.Remove(currentTask);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
        }
    }
}