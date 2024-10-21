namespace M2DB_WebApp.Models
{
    public class Alkohol
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public double AlkoholFok { get; set; }
        public double Urtartalom { get; set; }
        public int GyartoId { get; set; }
        public int Ar { get; set; }
        public int KategoriaID { get; set; }

        public virtual Gyarto? Gyarto { get; set; }
        public virtual Kategoria? Kategoria { get; set; }
    }
}
