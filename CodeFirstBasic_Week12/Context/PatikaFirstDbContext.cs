using CodeFirstBasic_Week12.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic_Week12.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SQL Server veritabanına bağlanmak için connection string veriyoruz.
            optionsBuilder.UseSqlServer("server=DESKTOP-U6UHBUC; database=PatikaCodeFirstDb1; Trusted_Connection=true; TrustServerCertificate=true");


            base.OnConfiguring(optionsBuilder);
        }


        //MovieEntity --> "Movies" adında bir tablo oluşturur/veritabanında bu tabloyu kullanır.
        //GameEntity --> "Games" adında bir tablo oluşturur/veritabanında bu tabloyu kullanır.
        public DbSet<GameEntity> Games { get; set; }
        public DbSet<MovieEntity> Movies { get; set; }


    }
}
