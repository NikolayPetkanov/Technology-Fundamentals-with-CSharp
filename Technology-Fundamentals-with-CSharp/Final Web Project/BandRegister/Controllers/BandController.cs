using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var db = new BandDbContext())
            {
                var allBands = db.Bands.ToList();
                return View(allBands);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            if (string.IsNullOrEmpty(band.Name) || string.IsNullOrEmpty(band.Members) ||
                string.IsNullOrEmpty(band.Genre) || band.Honorarium <= 0)
            {
                return RedirectToAction("Index");
            }

            using (var db = new BandDbContext())
            {
                db.Bands.Add(band);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BandDbContext())
            {
                var band = db.Bands.FirstOrDefault(b => b.Id == id);

                if (band != null)
                {
                    return View(band);
                }

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BandDbContext())
                {
                    var currentBand = db.Bands.FirstOrDefault(b => b.Id == band.Id);

                    if (currentBand != null)
                    {
                        currentBand.Name = band.Name;
                        currentBand.Members = band.Members;
                        currentBand.Honorarium = band.Honorarium;
                        currentBand.Genre = band.Genre;
                    }
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BandDbContext())
            {
                var band = db.Bands.FirstOrDefault(b => b.Id == id);

                if (band != null)
                {
                    return View(band);
                }

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            using (var db = new BandDbContext())
            {
                var currentBand = db.Bands.FirstOrDefault(b => b.Id == band.Id);

                if (currentBand != null)
                {
                    db.Bands.Remove(currentBand);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}