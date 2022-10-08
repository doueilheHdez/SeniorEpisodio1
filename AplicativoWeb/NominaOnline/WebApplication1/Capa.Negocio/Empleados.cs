using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Capa.Negocio
{
    public class Empleados
    {
        public long Numero { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public string Tipo { get; set; }
        public string Movimiento { get; set; }

        public Empleados(long numero, string nombre, string rol, string tipo, string movimiento)
        {
            this.Numero = numero;
            this.Nombre = nombre;
            this.Rol = rol;
            this.Tipo = tipo;
            this.Movimiento = movimiento;
        }
    }
}