using BigProje.DAL.Contexts;
using BigProje.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BigProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "admin")]
    public class YemeklerController : Controller
    {
        private readonly SqlDbContext context;

        public YemeklerController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Yemekler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Yemekler yemekler = new();
            return View(yemekler);
        }

        [HttpPost]
        public IActionResult Create(Yemekler yemekler)
        {
            if (ModelState.IsValid)
            {

                context.Yemekler.Add(yemekler);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(yemekler);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Yemekler yemekler = context.Yemekler.Find(id);
            return View(yemekler);
        }

        [HttpPost]
        public IActionResult Update(Yemekler yemekler)
        {
            context.Update(yemekler);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var yemekler = context.Yemekler.Find(id);
            return View(yemekler);
        }

        [HttpPost]
        public IActionResult Delete(Yemekler yemekler)
        {


            context.Remove(yemekler);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
