using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CapitalTec.SpectrumWeb.Entities;
using CapitalTec.SpectrumWeb.Services;

namespace CapitalTec.SpectrumWeb.WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        UsuarioSistemaService objUsuarioSistemaService;

        public ValuesController()
        {
            objUsuarioSistemaService = new UsuarioSistemaService();
        }

        // GET api/values
        public object Get()
        {
            return objUsuarioSistemaService.getUsuarioSistema();

        }

        // GET api/values/5
        public object Get(String id)
        {
            UsuarioSistema objUsuarioSistema = new UsuarioSistema();

            objUsuarioSistema.CodRol = id;


            return objUsuarioSistemaService.getUsuarioSistema_byID(objUsuarioSistema); 
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
