using JCMC.FW.APIRest.Business.Factory;
using JCMC.FW.APIRest.Entities;
using JCMC.FW.APIRest.Entities.Models;
using JCMC.FW.APIRest.Entities.Response;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Services.Description;

namespace JCMC.FW.APIRest.Controllers
{
    [Route("api/[controller]")]
    public class TipoProductoController : ApiController
    {
        // GET: api/TipoProducto
        [HttpGet]
        [Route("get")]
        public IHttpActionResult Get()
        {
            try
            {
                var handler = new ProductHandlerFactory().createQuery();
                var result = handler.getAllProduct();
                return Ok(result.ToList());
            }
            catch 
            {
                return null;
            }


        }

        [HttpGet]
        [Route("get/{id}")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var handler = new ProductHandlerFactory().createQuery();
                var result = handler.getProduct(id);
                return Ok(result);
            }
            catch 
            {
                return null;
            }


        }

        [HttpPost]
        [Route("post")]
        public virtual IHttpActionResult Post([FromBody] Product request)
        {
            try
            {
                var handler = new ProductHandlerFactory().createCommand();
                var result = handler.Create(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Json(new { ErrorMessage = ex.Message });
            }

        }

        [HttpPut]
        [Route("put")]
        public virtual IHttpActionResult Put([FromBody] Product request)
        {
            try
            {
                var handler = new ProductHandlerFactory().createCommand();
                var result = handler.Update(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Json(new { ErrorMessage = ex.Message });
            }

        }

        [HttpDelete]
        [Route("delete/{id}")]
        public virtual IHttpActionResult Delete(int id)
        {
            try
            {
                var handler = new ProductHandlerFactory().createCommand();
                var result = handler.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Json(new { ErrorMessage = ex.Message });
            }

        }
    }
}
