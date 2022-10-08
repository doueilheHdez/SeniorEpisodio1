using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using WebApplication1.Capa.Datos;

namespace WebApplication1.Capa.Negocio
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
    }
}