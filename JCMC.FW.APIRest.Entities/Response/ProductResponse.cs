using JCMC.FW.APIRest.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMC.FW.APIRest.Entities.Response
{
    public class ProductResponse
    {
        public List<Product> Products { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }

        public ProductResponse BuildReponse(Product products, bool success, string errorMsg = "")
        {
            return new ProductResponse
            {
                Products = new List<Product>() { products },
                Success = success,
                ErrorMessage = errorMsg
            };
        }
    }
    public class Error
    {
        public string Message { get; set; }
    }
}
