using EBook.Data;
using EBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
        [Authorize()]
        public IActionResult Index() 
        { 
            var order = context.Order.OrderByDescending(b => b.Id).Include(o => o.Book).ToList();
            return View(order); 
        }
        [Authorize()]
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
            book.Quantity -= quantity;
            context.Order.Add(order);
            context.Book.Update(book);
            context.SaveChanges();
            TempData["Success"] = "Order Success";
            return RedirectToAction("Index", "Store");

        }
        public IActionResult Search(string keyword)
        {
            var book = context.Order.Where(r => r.UserEmail.Contains(keyword)).ToList();
            return View("Index", book);
        }
        [Authorize(Roles ="Admin, StoreOwner")]
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
