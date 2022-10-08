using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApplication1.Capa.Datos
{
    public class Procedimientos
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter da;

        public DataTable GetEmpleados(long Numero)
        {
            DataTable dtInformacion = new DataTable();
            try
            {
                conn = new SqlConnection(Conexion.ConnectionString);
                command = new SqlCommand("sp_GetEmpleados", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 60;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@Numero", SqlDbType.BigInt)).Value = Numero;
                da = new SqlDataAdapter(command);
                da.Fill(dtInformacion);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                da = null;
                command = null;
                conn = null;
            }
            return dtInformacion;
        }
        public DataTable GetCalcularSuelto(long Numero, DateTime fechaInicio, DateTime fechaFinal)
        {
            DataTable dtInformacion = new DataTable();
            try
            {
                conn = new SqlConnection(Conexion.ConnectionString);
                command = new SqlCommand("sp_GetEmpleados", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 60;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@Numero", SqlDbType.BigInt)).Value = Numero;
                command.Parameters.Add(new SqlParameter("@FechaInicio", SqlDbType.Date)).Value = fechaInicio;
                command.Parameters.Add(new SqlParameter("@FechaFinal", SqlDbType.Date)).Value = fechaFinal;
                da = new SqlDataAdapter(command);
                da.Fill(dtInformacion);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                da = null;
                command = null;
                conn = null;
            }
            return dtInformacion;
        }

    }
}