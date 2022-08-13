using EBook.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EBook.Controllers
{

    public class BookController : Controller
    {
        private readonly ApplicationDbContext context;

        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Book.ToList());
        }
    }
}
