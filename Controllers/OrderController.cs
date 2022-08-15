using EBook.Data;
using EBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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
            var order = context.Order.Include(o => o.Book).ToList();
            return View(order); 
        }
        public IActionResult MakeOrder(int id, int quantity)
        {
            var order = new Order();
            var book = context.Book.Find(id);
            order.Book = book;
            order.BookId = id;
            order.Quantity = quantity;
            order.TotalPrice = order.Book.Price * quantity;
            order.OrderDate = DateTime.Now;
            order.UserEmail = User.Identity.Name;
            context.Order.Add(order);
            book.Quantity -= quantity;
            context.Book.Update(book);
            context.SaveChanges();
            TempData["Success"] = "Order Success";
            return RedirectToAction("Store", "Book");

        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = context.Order.Find(id);
            context.Order.Remove(order);
            //lưu thay đổi vào DB
            context.SaveChanges();
            var message = "Delete successs";
            TempData["message"] = message; //redircet phải dùng tempdata ms gửi dữ liệu được
            return RedirectToAction("Index");

        }
    }
}
