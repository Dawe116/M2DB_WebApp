using M2DB_WebApp.Models;

namespace M2DB_WebApp.DTOs
{
    public class AlkoholDTO
    {
        public string? Nev { get; set; }
        public double AlkoholFox { get; set; }
        public double Urtartlokom { get; set; }
        public string? GyartoNev { get; set; }
        public string? GyartoCim { get; set; }
        public string? GyartoOrszag { get; set; }
        public int Ar { get; set; }
        public string? KategoriaNev { get; set; }
    }
}
