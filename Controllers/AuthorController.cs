using EBook.Data;
using EBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return View(context.Author.OrderByDescending(b => b.Id).ToList());
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var author = context.Author
                .Include(m => m.Book)
                .FirstOrDefault(x => x.Id == id); //book object
            return View(author);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var author = context.Author.Find(id);
            context.Author.Remove(author);
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
        public IActionResult Add(Author Author)
        {
            context.Add(Author);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(context.Author.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Author author)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //update dữ liệu vào DB
                context.Update(author);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Edit author successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(author);
        }

    }
}
