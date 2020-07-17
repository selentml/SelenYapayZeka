using System.ComponentModel.DataAnnotations;

namespace SelenYapayZekaGit.DAL.Classes
{
    public class Kategori
    {
        [Key] public int Id { get; set; }
        public string Isim { get; set; }
        
    }
}