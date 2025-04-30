using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralamaVeSatisOtomasyonu.Models;
using Microsoft.EntityFrameworkCore;

namespace AracKiralamaVeSatisOtomasyonu.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Arac> Arac { get; set; }
        public DbSet<Kiralama> Kiralama { get; set; }
        public DbSet<Satis> Satis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BURAKSENOL\\SQLEXPRESS;Database=AracKiralamaVeSatisOtomasyonuDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { KategoriId = 1, KategoriAdi = "Sedan" },
                new Kategori { KategoriId = 2, KategoriAdi = "SUV" },
                new Kategori { KategoriId = 3, KategoriAdi = "Hatchback" },
                new Kategori { KategoriId = 4, KategoriAdi = "Minivan" }
                );
        }
    }
}
