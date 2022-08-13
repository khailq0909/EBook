using EBook.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EBook.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext context;

        public AuthorController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Author.ToList());
        }
    }
}
