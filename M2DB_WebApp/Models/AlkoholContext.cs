using Microsoft.EntityFrameworkCore;

namespace M2DB_WebApp.Models
{
    public class AlkoholContext : DbContext
    {
        public AlkoholContext() { }

        public AlkoholContext(DbContextOptions<AlkoholContext> options) : base(options) { }

        public virtual DbSet<Alkohol> Alkohols { get; set; }
        public virtual DbSet<Gyarto> Gyartos { get; set; }
        public virtual DbSet<Kategoria> Kategorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySQL("SERVER = localhost; Port=3306; DATABASE = kocsma; USER=root; PASSWORD = ; SSL MODE=none");

    }
}
