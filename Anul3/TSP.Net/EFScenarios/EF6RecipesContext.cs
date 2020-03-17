﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFScenarios
{
    class EF6RecipesContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public EF6RecipesContext()
            : base("name=EF6RecipesContext")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Map(m =>
                {
                    m.Properties(p => new { p.SKU, p.Description, p.Price });
                    m.ToTable("Product", "BazaDeDate");
                })
                .Map(m =>
                {
                    m.Properties(p => new { p.SKU, p.ImageURL });
                    m.ToTable("ProductWebInfo", "BazaDeDate");
                });
        }
    }
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SKU { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageURL { get; set; }
    }
}
