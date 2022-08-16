using EBook.Data;
using EBook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace EBook.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly ApplicationDbContext context;

        public OrderDetailController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var session = JsonConvert.DeserializeObject<Order>(HttpContext.Session.GetString("SessionOrder"));
            return View(session);
        }
        public IActionResult Add() {
            var session = JsonConvert.DeserializeObject<Order>(HttpContext.Session.GetString("SessionOrder"));
            context.Order.Add(session);
            context.SaveChanges();
            return RedirectToAction("Index", "Store");
        }
    }
}
