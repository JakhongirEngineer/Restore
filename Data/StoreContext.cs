using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Product> Products {get; set;}

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Product>().HasData(
                new Product{Brand = "brand1", Description = "description1", Name="name1", Price=10, PriceUrl="url1", QuantityInStock = 5, Type = "type1", Id = 1},
                new Product{Brand = "brand2", Description = "description2", Name="name2", Price=12, PriceUrl="url2", QuantityInStock = 2, Type = "type2", Id = 2},
                new Product{Brand = "brand3", Description = "description3", Name="name3", Price=13, PriceUrl="url3", QuantityInStock = 3, Type = "type3", Id = 3},
                new Product{Brand = "brand4", Description = "description4", Name="name4", Price=14, PriceUrl="url4", QuantityInStock = 4, Type = "type4", Id = 4},
                new Product{Brand = "brand5", Description = "description5", Name="name5", Price=15, PriceUrl="url5", QuantityInStock = 5, Type = "type5", Id = 5},
                new Product{Brand = "brand6", Description = "description6", Name="name6", Price=16, PriceUrl="url6", QuantityInStock = 6, Type = "type6", Id = 6},
                new Product{Brand = "brand7", Description = "description7", Name="name7", Price=17, PriceUrl="url7", QuantityInStock = 7, Type = "type7", Id = 7},
                new Product{Brand = "brand8", Description = "description8", Name="name8", Price=18, PriceUrl="url8", QuantityInStock = 8, Type = "type8", Id = 8},
                new Product{Brand = "brand9", Description = "description9", Name="name9", Price=19, PriceUrl="url9", QuantityInStock = 9, Type = "type9", Id = 9}
            );
        }
        
    }
}