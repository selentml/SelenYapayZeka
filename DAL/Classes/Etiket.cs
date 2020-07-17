using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SelenYapayZekaGit.DAL.Classes
{
    public class Etiket
    {
        [Key] public int EtiketId { get; set; }
        public string Isim { get; set; }

        public List<UrunEtkiket> UrunEtiket { get; set; }
    }
}