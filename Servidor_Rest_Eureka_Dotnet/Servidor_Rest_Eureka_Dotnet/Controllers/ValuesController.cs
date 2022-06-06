using Servidor_Rest_Eureka_Dotnet.ec.edu.monster.modelo;
using Servidor_Rest_Eureka_Dotnet.ec.edu.monster.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servidor_Rest_Eureka_Dotnet.Controllers
{
    public class ValuesController : ApiController
    {

        private CuentaService service = new CuentaService();
        // GET api/values     
        public IEnumerable<ec.edu.monster.db.Cuenta> Get()
        {
            return this.service.Get();
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
