using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
--******************************************************                                                       
-- Proyecto:      Nomina
-- Responsable:   Daniel Oueilhe  
-- Fecha:         2020-10-08
-- Descripcion:   Clase de empleado
-- ID:                                                                               
--******************************************************  
*/
namespace Nomina.Capa.Negocio
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
