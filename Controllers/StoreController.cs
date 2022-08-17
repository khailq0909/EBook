using EBook.Data;
using Microsoft.AspNetCore.Authorization;
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
            return View(context.Book.OrderByDescending(b => b.Id).ToList());
        }
        public IActionResult Ascending()
        {
            var books = context.Book.OrderBy(b => b.Price).ToList();
            return View("Index", books);
        }

        public IActionResult Decending()
        {
            var books = context.Book.OrderByDescending(b => b.Price).ToList();
            return View("Index", books);
        }
        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var book = context.Book.Where(b => b.Name.Contains(keyword)).ToList();
            return View("Index", book);
        }
        [Authorize(Roles ="Customer")]
        public IActionResult OrderHistory()
        {
            var user = User.Identity.Name;
            var order = context.Order.Include(b => b.Book).Where(o => o.UserEmail == user).ToList();
            return View("OrderHistory", order);
        }
        public IActionResult Delete(int id)
        {
            var order = context.Order.Find(id);
            var bookid = order.BookId;
            var book = context.Book.Find(bookid);
            
            order.Book.Quantity += order.Quantity;
            context.Order.Remove(order);
            context.Book.Update(book);
            //lưu thay đổi vào DB
            context.SaveChanges();
            var message = "Delete successs";
            TempData["message"] = message; //redircet phải dùng tempdata ms gửi dữ liệu được
            return RedirectToAction("Index");

        }

    }
}
