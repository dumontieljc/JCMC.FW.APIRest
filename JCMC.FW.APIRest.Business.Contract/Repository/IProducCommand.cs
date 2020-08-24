using JCMC.FW.APIRest.Entities.Models;

namespace JCMC.FW.APIRest.Business.Contract.Repository
{
    public interface IProducCommand
    {
        Product Create(Product product);
        Product Update(Product product);
        Product Delete(Product product);        
    }
}
