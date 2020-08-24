using JCMC.FW.APIRest.Business.Contract.Repository;
using JCMC.FW.APIRest.Data.Products;
using JCMC.FW.APIRest.Entities.Models;
using System;
using System.Data;
using System.Linq;

namespace JCMC.FW.APIRest.Data.Repository
{
    public class ProductCommand : IProducCommand
    {
        private ProductCollection dbContext;
        public ProductCommand(ProductCollection dbContext)
        {
            this.dbContext = dbContext;
        }
        public Product Create(Product tipo)
        {
            try
            {
                dbContext.Products.Add(tipo);
                return tipo;
            }
            catch
            {
                return tipo;
            }
        }

        public Product Delete(Product tipo)
        {
            try
            {
                dbContext.Products.Remove(tipo);                
                return tipo;
            }
            catch
            {
                return null;
            }
        }        

        public Product Update(Product tipo)
        {
            try
            {
                dbContext.Products
                    .Where(x => x.Id == tipo.Id)
                    .ToList()
                    .ForEach(itm => 
                    { 
                        itm.Name = tipo.Name;
                        itm.Description = tipo.Description;
                        itm.Price = tipo.Price;
                        itm.Exitence = tipo.Exitence;                        
                    }
                    );
                return tipo;
            }
            catch 
            {
                return null;
            }
        }
    }
}
