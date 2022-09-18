using Microsoft.AspNetCore.Mvc;

namespace BigProje.Controllers
{
    public class YemekCesitleriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
