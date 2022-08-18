using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NLayerMyApp.Core.Entities;
using NLayerMyApp.Repository.Configuration;

namespace NLayerMyApp.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
        //mydebdfgdgfgd
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-9HMKFF5;Initial Catalog=NlayerMyApp;User ID=sa;Password=Berkant123*;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id = 1,
                Colour = "Kırmızı",
                Height = 100,
                Width = 200,
                ProductId = 1

            }, new ProductFeature()
                {
                    Id = 2,
                    Colour = "Mavi",
                    Height = 200,
                    Width = 300,
                    ProductId = 2

                },
                new ProductFeature()
                {
                    Id = 3,
                    Colour = "AMavi",
                    Height = 200,
                    Width = 300,
                    ProductId = 2

                }
                );

            base.OnModelCreating(modelBuilder); 


        }

     
    }
}
