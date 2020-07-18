namespace SelenYapayZekaGit.Classes
{
    public class JsonReturner
    {
        public bool _durum;
        public string _mesaj;

        public JsonReturner(bool durum,string mesaj)
        {
            _durum = durum;
            _mesaj = mesaj;
        }

        public static JsonReturner Basarili(string mesaj)
        {
            return new JsonReturner(true, mesaj);
        }

        public static JsonReturner Basarisiz(string mesaj)
        {
            return new JsonReturner(false,mesaj);
        }
    }
}