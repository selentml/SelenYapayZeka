using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelenYapayZekaGit.DAL;
using SelenYapayZekaGit.DAL.Classes;

namespace SelenYapayZekaGit.Controllers
{
    public class SelenTest : Controller
    {
        private SelenDB _instance;
        // GET

        public SelenTest(SelenDB selendb)
        {
            _instance = selendb;

        }
        public IActionResult Index()
        {
            return View();
        }

        public string Test()
        {
            var kategoriList = new List<Kategori>()
            {
                new Kategori(){Isim =  "Ahşap Oyuncaklar"},
                new Kategori() {Isim = "Bebek Oyuncaklar"},
                new Kategori(){Isim =   "Figur Oyuncaklar"},
                new Kategori(){Isim = "Hobi Oyuncaklar"},
                new Kategori(){Isim = "Oyuncak Silahlar"},
                new Kategori(){Isim = "Peluş Oyuncaklar"}
            };
            _instance.Kategori.AddRange(kategoriList);
            _instance.SaveChanges();
            return "Başarılı";
            
            
        }
    }
}