using Servidor_Rest_Eureka_Dotnet.ec.edu.monster.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servidor_Rest_Eureka_Dotnet.ec.edu.monster.service
{
    public class CuentaService
    {
        public IEnumerable<db.Cuenta> Get()
        {
            IEnumerable<db.Cuenta> lista;
            using (db.EUREKABANKEntities db = new db.EUREKABANKEntities())
            {
                lista = db.Cuenta.ToList();

            }
            return lista;
        }
    }
}