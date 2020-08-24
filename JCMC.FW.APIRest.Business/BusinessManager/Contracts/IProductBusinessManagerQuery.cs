using JCMC.FW.APIRest.Entities.Models;
using System.Collections.Generic;

namespace JCMC.FW.APIRest.Business.BusinessManager.Contracts
{
    public interface IProductBusinessManagerQuery
    {
        IEnumerable<Product> getAllProduct();
        Product getProduct(int? id);
        
    }
}
