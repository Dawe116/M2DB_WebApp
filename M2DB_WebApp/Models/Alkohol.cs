namespace M2DB_WebApp.Models
{
    public class Alkohol
    {
        public int Id { get; set; }
        public string? Nev { get; set; }
        public double AlkoholFox { get; set; }
        public double Urtartlokom { get; set; }
        public int GyartoId { get; set; }
        public int Ar { get; set; }
        public int KategoriaId { get; set; }

        public virtual Gyarto? Gyarto { get; set; }
        public virtual Kategoria? Kategoria { get; set; }

    }
}
