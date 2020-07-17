using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelenYapayZekaGit.Classes.String;
using SelenYapayZekaGit.DAL;

namespace SelenYapayZekaGit.Controllers
{
    public class AnasayfaController : Controller
    {
        private SelenDB _instance;

        public AnasayfaController(SelenDB _in)
        {
            _instance = _in;
        }
        // GET
        public IActionResult Index()
        {
            ViewBag.Title = "Anasayfa".AsTitle();
            ViewBag.KategoriList = _instance.Kategori.ToList();
            ViewBag.UrunList = _instance.Urun.OrderByDescending(a => a.IncelemeAdet).Take(10).ToList();
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