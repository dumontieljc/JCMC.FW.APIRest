using JCMC.FW.APIRest.Entities.Models;
using JCMC.FW.APIRest.Entities.Response;

namespace JCMC.FW.APIRest.Business.BusinessManager.Contracts
{
    public interface IProductBusinessManagerCommand
    {

        ProductResponse Create(Product tipo);
        ProductResponse Update(Product tipo);
        ProductResponse Delete(int id);

    }
}
