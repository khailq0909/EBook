using EBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EBook.Data;

using System.Linq;

namespace EBook.Controllers
{
    public class BookController : Controller

    {
        //khai báo DbCOntext để kết nối database
        private readonly ApplicationDbContext context;
        public BookController(ApplicationDbContext DbContext)
        {
            context = DbContext;
        }

        //View all book
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            //set book mới được hienr thị trên đầu danh sách

            var books = context.Book.OrderByDescending(b => b.Id).ToList();
            return View(books);
        }
        //view book by id
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = context.Book
                .Include(c => c.Category)
                .Include(b => b.BookAuthor)
                .ThenInclude(m => m.Author)
                .FirstOrDefault(x => x.Id == id); //book object
            return View(book);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = context.Book.Find(id);
            context.Book.Remove(book);
            //lưu thay đổi vào DB
            context.SaveChanges();
            var message = "Delete successs";
            TempData["message"] = message; //redircet phải dùng tempdata ms gửi dữ liệu được
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Add()
        {
            //day danh sach category vaof 
            ViewBag.Category = context.Category.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(Book book)

        {
            if (ModelState.IsValid)
            {
                context.Add(book);
                context.SaveChanges();
                var message = "Add successs";
                ViewData["message"] = message;
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }

        }

        [HttpGet]
        public IActionResult Edit(int id)

        {
            ViewBag.Category = context.Category.ToList();
            return View(context.Book.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Book book)

        {
            if (ModelState.IsValid)
            {
                context.Update(book);
                context.SaveChanges();
                var message = "Edit successs";
                ViewData["message"] = message;
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }

        }


    }
}
