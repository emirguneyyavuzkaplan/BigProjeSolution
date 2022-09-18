using BigProje.DAL.Contexts;
using BigProje.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BigProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "admin")]
    public class KategoriController : Controller
    {
        private readonly SqlDbContext context;

        public KategoriController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Kategoriler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Kategori kategori = new();
            return View(kategori);
        }

        [HttpPost]
        public IActionResult Create(Kategori kategori)
        {
            if (!ModelState.IsValid)
            {

                context.Kategoriler.Add(kategori);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(kategori);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Kategori kategori = context.Kategoriler.Find(id);
            return View(kategori);
        }

        [HttpPost]
        public IActionResult Update(Kategori kategori)
        {
            context.Update(kategori);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var kategori = context.Kategoriler.Find(id);
            return View(kategori);
        }

        [HttpPost]
        public IActionResult Delete(Kategori kategori)
        {


            context.Remove(kategori);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
