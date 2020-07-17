using Microsoft.AspNetCore.Mvc;
using SelenYapayZekaGit.Classes.String;

namespace SelenYapayZekaGit.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            ViewBag.Title = "Test".AsTitle();
            return View();
        }

        public string UrunEkle()
        {
            return "Başarılı";
        }
    

        public IActionResult OgrenciBilgi()
        {
            ViewBag.Title = "Öğrenci Bilgi".AsTitle();
            return View();
        }
        
    }
}