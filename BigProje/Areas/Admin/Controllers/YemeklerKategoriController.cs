using BigProje.DAL.Contexts;
using BigProje.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BigProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "admin")]
    public class YemeklerKategoriController : Controller
    {
        private readonly SqlDbContext context;

        public YemeklerKategoriController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.YemeklerKategori.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            YemeklerKategori filmlerkategori = new();
            return View(filmlerkategori);
        }

        [HttpPost]
        public IActionResult Create(YemeklerKategori yemeklerkategori)
        {
            if (ModelState.IsValid)
            {

                context.YemeklerKategori.Add(yemeklerkategori);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(yemeklerkategori);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            YemeklerKategori yemeklerkategori = context.YemeklerKategori.Find(id);
            return View(yemeklerkategori);
        }

        [HttpPost]
        public IActionResult Update(YemeklerKategori yemeklerkategori)
        {
            context.Update(yemeklerkategori);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var yemeklerkategori = context.YemeklerKategori.Find(id);
            return View(yemeklerkategori);
        }

        [HttpPost]
        public IActionResult Delete(YemeklerKategori yemeklerkategori)
        {


            context.Remove(yemeklerkategori);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
