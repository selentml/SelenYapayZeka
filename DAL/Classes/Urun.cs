using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SelenYapayZekaGit.DAL.Classes
{
    public class Urun
    {
        [Key] public int UrunId { get; set; }

        public string Isim { get; set; }
        public virtual Kategori Kategori { get; set; }

        public string ResimUrl { get; set; }
        public int IncelemeAdet { get; set; }
        public List<UrunEtkiket> UrunEtiket { get; set; }
        
        
    }
}