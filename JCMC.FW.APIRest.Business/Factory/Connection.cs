using JCMC.FW.APIRest.Data.Products;

namespace JCMC.FW.APIRest.Business.Factory
{
    internal static class Connection
    {
        
        private static ProductCollection productCollection;
        public static ProductCollection GetInstace()
        {
            if (productCollection == null)
            {
                productCollection = new ProductCollection();
            }
            return productCollection;
        }
    }
}
