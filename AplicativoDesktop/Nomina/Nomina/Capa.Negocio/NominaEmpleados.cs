using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Capa.Negocio
{
    public class NominaEmpleados
    {
        public bool Buscar(string Numero, out Empleados empleados)
        {
            try
            {

                Empleados Emp = new Empleados(Numero, "XN", "Cargador", "Interno", "");

                empleados = Emp;
            }
            catch (Exception Ex)
            {
                empleados = null;
                return false;
            }
            return true;
        }
        public bool GuardarEmpleado(Empleados empleados)
        {
            try
            {

            }
            catch (Exception Ex)
            {

                return false;
            }

            return true;
        }
        public bool GuardarMovimiento(CapturaMovimiento capturaMovimiento)
        {
            try
            {

            }
            catch (Exception Ex)
            {

                return false;
            }

            return true;
        }
    }
}
