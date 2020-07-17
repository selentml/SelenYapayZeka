namespace SelenYapayZekaGit.DAL.Classes
{
    public class UrunEtkiket
    {
        public int UrunId { get; set; }
        public Urun Urun { get; set; }

        public int EtkiketId { get; set; }
        public Etiket Etiket { get; set; }
    }
}