using JCMC.FW.APIRest.Business.BusinessManager;
using JCMC.FW.APIRest.Business.BusinessManager.Contracts;
using JCMC.FW.APIRest.Business.Contract.Repository;
using JCMC.FW.APIRest.Data.Products;
using JCMC.FW.APIRest.Data.Repository;

namespace JCMC.FW.APIRest.Business.Factory
{
    public class ProductHandlerFactory
    {        
        private readonly ProductCollection dbSingleton;
        public ProductHandlerFactory()
        {     
            dbSingleton = Connection.GetInstace();
        }
        
        public IProductBusinessManagerQuery createQuery()
        {            
            IProductoQuery productQueryData = new ProductQuery(dbSingleton);
            IProductBusinessManagerQuery productQuery = new ProductBusinessManagerQuery(productQueryData);
            return productQuery;

        }
        public IProductBusinessManagerCommand createCommand()
        {
            IProducCommand productCommandData = new ProductCommand(dbSingleton);
            IProductoQuery productQueryData = new ProductQuery(dbSingleton);
            IProductBusinessManagerCommand productCommand = new ProductBusinessManagerCommand(productQueryData, productCommandData);
            return productCommand;

        }
    }
}
