using EBook.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EBook.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext context;

        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Book.ToList());
        }
    }
}
