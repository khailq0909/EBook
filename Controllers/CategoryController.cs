using EBook.Data;
using EBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return View(context.Category.ToList());
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cte = context.Category
                .Include(b => b.Book)
                .FirstOrDefault(x => x.Id == id);
            return View(cte);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cte = context.Category.Find(id);
            context.Category.Remove(cte);
            //lưu thay đổi vào DB
            context.SaveChanges();
            var message = "Delete successs";
            TempData["message"] = message; //redircet phải dùng tempdata ms gửi dữ liệu được
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category cte)

        {
            if (ModelState.IsValid)
            {
                context.Add(cte);
                context.SaveChanges();
                var message = "Add successs";
                ViewData["message"] = message;
                return RedirectToAction("Index");
            }
            else
            {
                return View(cte);
            }

        }

        [HttpGet]
        public IActionResult Edit(int id)

        {
            return View(context.Category.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Category cte)

        {
            if (ModelState.IsValid)
            {
                context.Update(cte);
                context.SaveChanges();
                var message = "Edit successs";
                ViewData["message"] = message;
                return RedirectToAction("Index");
            }
            else
            {
                return View(cte);
            }

        }
    }
}
