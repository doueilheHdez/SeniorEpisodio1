using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Data;
using System.Text;

namespace WebApplication1.Capa.Negocio
{
    public class CalculoNegocio
    {
        public string Buscar(long numero)
        {
            JObject JoResponse = new JObject();

            try
            {
                Capa.Datos.Procedimientos procedimientos = new Capa.Datos.Procedimientos();

                DataTable dtInfomacion = procedimientos.GetEmpleados(numero);

                if (dtInfomacion.Rows.Count == 0)
                {
                    JoResponse.Add(new JProperty("MjeAlerta", "Número de empleado no existe"));
                    JoResponse.Add(new JProperty("Existe", false));
                }
                else
                {
                    JoResponse.Add(new JProperty("Existe", true));
                    JoResponse.Add(Listado(dtInfomacion, "Empleado"));
                }

            }
            catch (Exception ex)
            {
                JoResponse = new JObject();
                JoResponse.Add(new JProperty("Error", true));
                JoResponse.Add(new JProperty("Catch", ex.Message));
            }

            return JoResponse.ToString();
        }

        public string CalcularMes(long numero, int anio, int mes)
        {
            JObject JoResponse = new JObject();

            try
            {
                Capa.Datos.Procedimientos procedimientos = new Capa.Datos.Procedimientos();

                DateTime sFechaIni = Convert.ToDateTime(anio + "-" + mes + "-01");
                DateTime sFechaFin = sFechaIni.AddMonths(1);
                DataTable dtInfomacion = procedimientos.GetCalcularSuelto(numero, sFechaIni, sFechaFin);

                if (dtInfomacion.Rows.Count == 0)
                {
                    JoResponse.Add(new JProperty("MjeAlerta", "Número de empleado no existe"));
                    JoResponse.Add(new JProperty("Existe", false));
                }
                else
                {
                    JoResponse.Add(new JProperty("Existe", true));
                    JoResponse.Add(Listado(dtInfomacion, "Calculo"));
                }

            }
            catch (Exception ex)
            {
                JoResponse = new JObject();
                JoResponse.Add(new JProperty("Error", true));
                JoResponse.Add(new JProperty("Catch", ex.Message));
            }

            return JoResponse.ToString();
        }

        public static JProperty Listado(DataTable dtResult, string Nombre)
        {
            JArray JaResponse = new JArray();

            foreach (DataRow dResult in dtResult.Rows)
            {
                JObject JoDetalle = new JObject();
                for (int jx = 0; jx <= dtResult.Columns.Count - 1; jx++)
                    if (dResult[dtResult.Columns[jx].ColumnName] != DBNull.Value)
                        JoDetalle.Add(new JProperty(dtResult.Columns[jx].ColumnName, dResult[dtResult.Columns[jx].ColumnName]));
                    else
                        JoDetalle.Add(new JProperty(dtResult.Columns[jx].ColumnName, ObtenerTipo(dtResult.Columns[jx].DataType.Name)));

                JaResponse.Add(JoDetalle);
            }

            return new JProperty(Nombre, JaResponse);
        }
        public static object ObtenerTipo(string StrTipo)
        {
            switch (StrTipo)
            {
                case "Int32":
                    return 0;
                case "String":
                    return "";
                case "Decimal":
                    return 0;
                case "Boolean":
                    return null;
                default:
                    return "";
            }
        }
    }
}