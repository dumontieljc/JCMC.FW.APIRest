using JCMC.FW.APIRest.Entities.Models;
using System.Collections.Generic;

namespace JCMC.FW.APIRest.Business.Contract.Repository
{
    public interface IProductoQuery
    {
        IEnumerable<Product> getAllProduct();
        Product getProduct(int id);
        Product getProductByCode(string code);
    }
}
