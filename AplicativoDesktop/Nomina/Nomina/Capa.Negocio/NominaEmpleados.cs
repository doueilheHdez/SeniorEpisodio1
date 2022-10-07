using Nomina.Capa.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Capa.Negocio
{
    public class NominaEmpleados
    {
        public bool Buscar(long Numero, out Empleados empleados, out string msj)
        {
            msj = string.Empty;
            empleados = null;
            try
            {
                Empleados Emp = null;
                Procedimientos procedimientos = new Procedimientos();
                DataTable dtInformacion = procedimientos.GetEmpleados(Numero);

                if (dtInformacion.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    foreach (DataRow rows in dtInformacion.Rows)
                    {
                        Emp = new Empleados(long.Parse(rows["Numero"].ToString()),
                                             rows["Nombre"].ToString(),
                                             rows["Rol"].ToString(),
                                             rows["Tipo"].ToString(),
                                             String.Empty);
                    }
                }
                empleados = Emp;
            }
            catch (Exception Ex)
            {
                msj = "Se genero un error al buscar empleado";
                empleados = null;
                return false;
            }
            return true;
        }
        public bool GuardarEmpleado(Empleados empleados)
        {
            try
            {
                Procedimientos procedimientos = new Procedimientos();
                procedimientos.SetEmpleados(empleados.Numero, empleados.Nombre,
                    empleados.Rol, empleados.Tipo, empleados.Movimiento);
            }
            catch (Exception Ex)
            {
                return false;
            }
            return true;
        }
        public bool GuardarMovimiento(CapturaMovimiento capturaMovimiento, string msj)
        {
            msj = string.Empty;
            try
            {

                Procedimientos procedimientos = new Procedimientos();

                DataTable dtInformacion = procedimientos.ValidaFechaMovimiento(capturaMovimiento.Numero, Convert.ToDateTime( capturaMovimiento.Fecha));

                if (dtInformacion.Rows.Count > 0)
                {
                    msj = dtInformacion.Rows[0]["respuesta"].ToString();
                    return false;
                }
                procedimientos.SetCapturaMovimiento(capturaMovimiento.Numero, Convert.ToDateTime(capturaMovimiento.Fecha), capturaMovimiento.CantidadEntrega,
                    capturaMovimiento.CubrioTurno, capturaMovimiento.CubrioTurnoTipo, capturaMovimiento.CubrioTurnoRol);
            }
            catch (Exception Ex)
            {

                return false;
            }

            return true;
        }
    }
}
