using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SelenYapayZekaGit.DAL;

namespace SelenYapayZekaGit.Controllers
{
    public class KategoriController  : Controller
    {
        private SelenDB _instance;
        public KategoriController(SelenDB inn)
        {
            _instance = inn;
        }
        [Route("kategori/{id?}")]
        public ActionResult Liste(int? id)
        {
            if (id == null) return RedirectToAction("Index", "Anasayfa");
            if (!_instance.Kategori.Any(a => a.KategoriId == id)) return RedirectToAction("Index", "Anasayfa");
            ViewBag.UrunList = _instance.Kategori.Include(a => a.Urun).First(a => a.KategoriId == id).Urun.ToList();
            ViewBag.KategoriList = _instance.Kategori.ToList();
            ViewBag.Kategori = _instance.Kategori.Include(a => a.Urun).First(a => a.KategoriId == id);
            ViewBag.EtiketList = _instance.Etkiket.ToList();
            
            return View();

        }

        [Route("urunEkle")]
        public ActionResult Ekle()
        {
            ViewBag.KategoriList = _instance.Kategori.ToList();
            return View();
        }
    }
}