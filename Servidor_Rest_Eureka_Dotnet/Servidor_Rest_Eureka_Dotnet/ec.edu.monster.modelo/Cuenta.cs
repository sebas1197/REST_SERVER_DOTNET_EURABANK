using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servidor_Rest_Eureka_Dotnet.ec.edu.monster.modelo
{
    public class Cuenta
    {
        private String codigoCuenta;
        private String codigoCliente;
        private String saldo;
        private String fechaCreacion;
        private String estado;

        public Cuenta()
        {
        }

        public String getCodigoCuenta()
        {
            return codigoCuenta;
        }

        public void setCodigoCuenta(String codigoCuenta)
        {
            this.codigoCuenta = codigoCuenta;
        }

        public String getCodigoCliente()
        {
            return codigoCliente;
        }

        public void setCodigoCliente(String codigoCliente)
        {
            this.codigoCliente = codigoCliente;
        }

        public String getSaldo()
        {
            return saldo;
        }

        public void setSaldo(String saldo)
        {
            this.saldo = saldo;
        }

        public String getFechaCreacion()
        {
            return fechaCreacion;
        }

        public void setFechaCreacion(String fechaCreacion)
        {
            this.fechaCreacion = fechaCreacion;
        }

        public String getEstado()
        {
            return estado;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }


    }
}