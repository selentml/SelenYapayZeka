using Microsoft.AspNetCore.Mvc;
using SelenYapayZekaGit.Classes.String;

namespace SelenYapayZekaGit.Controllers
{
    public class UrunController : Controller
    {
        // GET
        public IActionResult Ekle()
        {
            ViewBag.Title = "Ürün Ekle".AsTitle();
            return View();
        }
    }
}