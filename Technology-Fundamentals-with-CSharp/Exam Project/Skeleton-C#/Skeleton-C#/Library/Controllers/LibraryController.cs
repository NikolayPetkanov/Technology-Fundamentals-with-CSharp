namespace Library.Controllers
{
    using System.Linq;
    using Library.Models;
    using Library.Data;
    using Microsoft.AspNetCore.Mvc;

    public class LibraryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var db = new LibraryDbContext())
            {
                var allBooks = db.Books.ToList();
                return View(allBooks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (string.IsNullOrEmpty(book.Title) || string.IsNullOrEmpty(book.Author))
            {
                return RedirectToAction("Index");
            }

            using (var db = new LibraryDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new LibraryDbContext())
            {
                Book currentBook = db.Books.FirstOrDefault(b => b.Id == id);

                if (currentBook == null)
                {
                    return RedirectToAction("Index");
                }

                return View(currentBook);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                using (var db = new LibraryDbContext())
                {
                    Book currentBook = db.Books.FirstOrDefault(b => b.Id == book.Id);
                    currentBook.Title = book.Title;
                    currentBook.Author = book.Author;
                    currentBook.Price = book.Price;
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new LibraryDbContext())
            {
                Book currentBook = db.Books.FirstOrDefault(b => b.Id == id);

                if (currentBook == null)
                {
                    return RedirectToAction("Index");
                }

                return View(currentBook);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {

            using (var db = new LibraryDbContext())
            {
                Book currentBook = db.Books.FirstOrDefault(b => b.Id == book.Id);

                if (currentBook == null)
                {
                    return RedirectToAction("Index");
                }

                db.Books.Remove(currentBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}