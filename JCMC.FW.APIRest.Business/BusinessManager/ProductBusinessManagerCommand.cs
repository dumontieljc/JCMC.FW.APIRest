using JCMC.FW.APIRest.Business.BusinessManager.Contracts;
using JCMC.FW.APIRest.Business.Contract.Repository;
using JCMC.FW.APIRest.Entities.Models;
using JCMC.FW.APIRest.Entities.Response;
using System.Collections.Generic;
using System.Linq;

namespace JCMC.FW.APIRest.Business.BusinessManager
{
    internal class ProductBusinessManagerCommand : IProductBusinessManagerCommand
    {
        private readonly IProductoQuery query;
        private readonly IProducCommand command;
        public ProductBusinessManagerCommand(IProductoQuery query, IProducCommand command)
        {
            this.query = query;
            this.command = command;
        }
        public ProductResponse Create(Product product)
        {
            var response = new ProductResponse();
            if (product == null || product.Id > uint.MinValue)
            {
                return response.BuildReponse(product, false, "Error en asignación de datos");
            }

            var nextId = query.getAllProduct().Max(x => x.Id + 1);
            product.Id = nextId;

            var validateExists = query.getProductByCode(product.Code);
            if (validateExists != null)
            {
                return response.BuildReponse(product, false, "Ya existe el código ingresado"); 
            }

            var result = command.Create(product);
            if (result.Id == uint.MinValue)
            {
                return response.BuildReponse(result, false, "Error al insertar");
            }

            return response.BuildReponse(result, true); 

        }

        public ProductResponse Delete(int id)
        {
            var response = new ProductResponse();
            if (id == uint.MinValue)
            {
                return response.BuildReponse(null, false, "No se asignó valor al ID");
            }

            var product= query.getProduct(id);
            if (product== null)
            {
                return response.BuildReponse(product, false, "No existe el dato que se desea eliminar"); ;
            }

            var result = command.Delete(product);
            if (result == null)
            {
                return response.BuildReponse(result, false, "Error al modificar");
            }

            return response.BuildReponse(result, true);
        }        

        public ProductResponse Update(Product product)
        {
            var response = new ProductResponse();
            if (product== null || product.Id == uint.MinValue)
            {
                return response.BuildReponse(product, false, "No se asignó valor al ID");
            }

            var validateExists = query.getProduct(product.Id);
            if (validateExists == null)
            {
                return response.BuildReponse(product, false, "No existe el dato que se desea modificar"); ;
            }

            var validateExistsCode = query.getProductByCode(product.Code);
            if (validateExistsCode != null && validateExistsCode.Id != product.Id)
            {
                return response.BuildReponse(product, false, "Ya existe el código ingresado"); ;
            }

            var result = command.Update(product);
            if (result == null)
            {
                return response.BuildReponse(result, false, "Error al modificar");
            }

            return response.BuildReponse(result, true);
        }
    }
}
