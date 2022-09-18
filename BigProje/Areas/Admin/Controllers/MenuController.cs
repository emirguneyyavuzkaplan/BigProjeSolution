using BigProje.DAL.Contexts;
using BigProje.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BigProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "admin")]
    public class MenuController : Controller
    {
        private readonly SqlDbContext context;

        public MenuController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Menuler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Menu menu = new();
            return View(menu);
        }

        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            if (ModelState.IsValid)
            {

                context.Menuler.Add(menu);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(menu);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Menu menu = context.Menuler.Find(id);
            return View(menu);
        }

        [HttpPost]
        public IActionResult Update(Menu menu)
        {
            context.Update(menu);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var menu = context.Menuler.Find(id);
            return View(menu);
        }

        [HttpPost]
        public IActionResult Delete(Menu menu)
        {


            context.Remove(menu);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
