using JCMC.FW.APIRest.Entities.Models;
using System.Collections.Generic;

namespace JCMC.FW.APIRest.Data.Products
{
    public class ProductCollection
    {
        public ProductCollection()
        {
            Products = new List<Product> {
                new Product { Id=1, Code="0001", Name = "Product 0001", Description = "Producto for Men", Price=500.99, Exitence = 100 },
                new Product { Id=2, Code="0002", Name = "Product 0002", Description = "Producto for Men", Price=400.99, Exitence = 100 },
                new Product { Id=3, Code="0003", Name = "Product 0003", Description = "Producto for Men", Price=300.99, Exitence = 100 },
                new Product { Id=4, Code="0004", Name = "Product 0004", Description = "Producto for Men", Price=200.99, Exitence = 100 },
                new Product { Id=5, Code="0005", Name = "Product 0005", Description = "Producto for Men", Price=100.99, Exitence = 100 }

            };

        }

        public List<Product> Products { get; set; }
    }
}
