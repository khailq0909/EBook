using EBook.Data;
using EBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EBook.Controllers
{
    public class StoreOwnerController : Controller
    {
        private readonly ApplicationDbContext context;

        public StoreOwnerController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.RequestCT.ToList());
        }
        [HttpGet]
        [Authorize(Roles = "StoreOwner")]
        public IActionResult RequestCT()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "StoreOwner")]
        public IActionResult RequestCT(RequestCT rq)

        {
            if (ModelState.IsValid)
            {
                context.Add(rq);
                context.SaveChanges();
                var message = "Add successs";
                ViewData["message"] = message;
                return RedirectToAction("Index");
            }
            else
            {
                return View(rq);
            }

        }
    }
}
