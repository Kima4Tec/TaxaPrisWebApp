namespace TaxaPrisWebApp.Model
{
    public class TaxaPriceData
    {
        public int Id { get; set; }
        public string VognType { get; set; }
        public string AntalPassagerer { get; set; }
        public string Tid { get; set; }
        public string Tidspunkt { get; set; }
        public Dictionary<string, string> Koersel { get; set; }
        public Dictionary<string, string> Tillaeg { get; set; }
    }
}
