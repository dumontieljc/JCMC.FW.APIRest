using JCMC.FW.APIRest.Business.BusinessManager.Contracts;
using JCMC.FW.APIRest.Business.Contract.Repository;
using JCMC.FW.APIRest.Entities.Models;
using System.Collections.Generic;

namespace JCMC.FW.APIRest.Business.BusinessManager
{
    internal class ProductBusinessManagerQuery : IProductBusinessManagerQuery
    {
        private readonly IProductoQuery query;
        public ProductBusinessManagerQuery(IProductoQuery query)
        {
            this.query = query;
        }

        public IEnumerable<Product> getAllProduct()
        {
            return query.getAllProduct();
        }

        public Product getProduct(int? id)
        {
            if (id == null || id == uint.MinValue)
            {
                return null;
            }
            return query.getProduct((int)id);
        }

        public Product getTipoProductoByCode(string code)
        {
            return query.getProductByCode(code);
        }
    }
}
