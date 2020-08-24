using JCMC.FW.APIRest.Business.Contract.Repository;
using System.Collections.Generic;
using System.Linq;
using JCMC.FW.APIRest.Data.Products;
using JCMC.FW.APIRest.Entities.Models;

namespace JCMC.FW.APIRest.Data.Repository
{
    public class ProductQuery : IProductoQuery
    {
        private ProductCollection dbContext;
        public ProductQuery(ProductCollection dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> getAllProduct()
        {
            return dbContext.Products.ToList();
        }

        public Product getProduct(int id)
        {
            return dbContext.Products.Where(x=>x.Id == id).SingleOrDefault();
        }

        public Product getProductByCode(string code)
        {
            return dbContext.Products.Where(x => x.Code == code).SingleOrDefault();
        }

    }
}
