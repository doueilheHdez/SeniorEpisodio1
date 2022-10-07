using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Capa.Negocio
{
    public class Empleados
    {
        public string Numero { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public string Tipo { get; set; }
        public string Movimiento { get; set; }

        public Empleados(string numero, string nombre, string rol, string tipo, string movimiento)
        {
            this.Numero = numero;
            this.Nombre = nombre;
            this.Rol = rol;
            this.Tipo = tipo;
            this.Movimiento = movimiento;
        }
    }
}
