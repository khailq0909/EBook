using EBook.Data;
using EBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EBook.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;

        public AdminController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(context.Category.OrderByDescending(b => b.Id).ToList());
        }
        public IActionResult Detail(int? id)
        {
            var cte = context.Category
                .Include(b => b.Book)
                .FirstOrDefault(x => x.Id == id);
            return View(cte);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            var cte = context.Category.Find(id);
            context.Category.Remove(cte);
            //lưu thay đổi vào DB
            context.SaveChanges();
            var message = "Delete successs";
            TempData["message"] = message; //redircet phải dùng tempdata ms gửi dữ liệu được
            return RedirectToAction("Index");

        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)

        {
            return View(context.Category.Find(id));
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
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

        public IActionResult Approval()
        {
            return View(context.RequestCT.OrderByDescending(b => b.Id).ToList());
        }
        public IActionResult Approved(int id)
        {
            var requestct = context.RequestCT.Find(id);
            var Category = new Category();
            Category.Name = requestct.Name;
            requestct.IsApproved = "Approved";
            context.Category.Update(Category);
            context.RequestCT.Update(requestct);
            context.SaveChanges();
            return RedirectToAction("Approval");
        }
        public IActionResult Reject(int id)
        {
            var requestct = context.RequestCT.Find(id);
            requestct.IsApproved = "Reject";
            context.RequestCT.Update(requestct);
            context.SaveChanges();
            return RedirectToAction("Approval");
        }

    }
}
