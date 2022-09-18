using BigProje.DAL.Contexts;
using BigProje.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BigProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "admin")]
    public class KargoController : Controller
    {
        private readonly SqlDbContext context;

        public KargoController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Kargolar.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Kargo kargo = new();
            return View(kargo);
        }

        [HttpPost]
        public IActionResult Create(Kargo kargo)
        {
            if (ModelState.IsValid)
            {

                context.Kargolar.Add(kargo);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(kargo);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Kargo kargo = context.Kargolar.Find(id);
            return View(kargo);
        }

        [HttpPost]
        public IActionResult Update(Kargo kargo)
        {
            context.Update(kargo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var kargo = context.Kargolar.Find(id);
            return View(kargo);
        }

        [HttpPost]
        public IActionResult Delete(Kargo kargo)
        {


            context.Remove(kargo);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
