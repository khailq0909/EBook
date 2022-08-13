using EBook.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EBook.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Order.ToList());
        }
    }
}
