using EBook.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EBook.Controllers
{
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext context;

        public StoreController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Book.ToList());
        }
        public IActionResult Ascending()
        {
            var books = context.Book.OrderBy(b => b.Price).ToList();
            return View("Store", books);
        }

        public IActionResult Decending()
        {
            var books = context.Book.OrderByDescending(b => b.Price).ToList();
            return View("Store", books);
        }
        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var book = context.Book.Where(b => b.Name.Contains(keyword)).ToList();
            return View("Store", book);
        }
    }
}
