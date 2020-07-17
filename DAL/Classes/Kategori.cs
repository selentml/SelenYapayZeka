﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SelenYapayZekaGit.DAL.Classes
{
    public class Kategori
    {
        [Key] public int KategoriId { get; set; }
        public string Isim { get; set; }

        public string ResimUrl { get; set; }


        public List<Urun> Urun { get; set; }
        
    }
}