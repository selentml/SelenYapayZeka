using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SelenYapayZekaGit.Classes;
using SelenYapayZekaGit.DAL;
using SelenYapayZekaGit.DAL.Classes;

namespace SelenYapayZekaGit.Controllers
{
    public class SelenApi : Controller
    {

        private SelenDB _db;

        public SelenApi(SelenDB db)
        {
            _db = db;
        }
        
        [HttpPost]
      
        public JsonResult UrunEkle(string urunIsim, string resimUrl, int kategori, string etiket)
        {
        
            if (string.IsNullOrEmpty(urunIsim))
            {
                return Json(new {_durum = false,_mesaj = "Ürün ismi boş bırakılamaz."});
            }

            if (string.IsNullOrEmpty(resimUrl))
            {
                return Json(new {_durum = false,_mesaj = "Resim url boş bırakılamaz."});
            }

            if (kategori == -1)
            {
                return Json(new {_durum = false,_mesaj = "Kategori seçmediniz."});
            }

            etiket = etiket.ToLower();
            var etiketList = etiket.Split(',');
            List<Etiket> etiketler = new List<Etiket>();
            var urun = new Urun();
            urun.Isim = urunIsim;
            urun.ResimUrl = resimUrl;
            urun.Kategori = _db.Kategori.First(a => a.KategoriId == kategori);
            _db.Urun.Add(urun);
            _db.SaveChanges();
            foreach (var et in etiketList)
            {
                var eklenecekEtiket = new Etiket(){Isim = et};
                if (_db.Etkiket.Any(a => a.Isim == eklenecekEtiket.Isim))
                {
                    eklenecekEtiket = _db.Etkiket.First(a => a.Isim == eklenecekEtiket.Isim);
                }
                else
                {
                    _db.Etkiket.Add(eklenecekEtiket);
                }
                _db.UrunEtiket.Add(new UrunEtkiket() {Urun = urun, Etiket = eklenecekEtiket});

            }

            _db.SaveChanges();
            return Json(new {_durum = true,_mesaj = "Ürün ekleme başalarılı."});

        }
    }
}