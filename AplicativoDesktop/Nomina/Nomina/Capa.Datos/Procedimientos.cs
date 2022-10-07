using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;

namespace Nomina.Capa.Datos
{
    internal class Procedimientos
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

        public bool SetEmpleados(long Numero, string Nombre, string Rol, string Tipo, string Movimiento)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.ConnectionString);
                SqlCommand command = new SqlCommand();

                command.CommandText = "sp_SetEmpleados";
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 60;
                command.Connection = conn;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@Numero", SqlDbType.BigInt)).Value = Numero;
                command.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = Nombre;
                command.Parameters.Add(new SqlParameter("@Rol", SqlDbType.NVarChar)).Value = Rol;
                command.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.NVarChar)).Value = Tipo;
                command.Parameters.Add(new SqlParameter("@Movimento", SqlDbType.NVarChar)).Value = Movimiento;

                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                return false;
            }
            finally
            {
                command = null;
                conn = null;
            }
            return true;
        }

        public bool SetCapturaMovimiento(long Numero, DateTime Fecha, int CantidadEntrega, bool CubrioTurno, 
            String CubrioTurnoTipo, String CubrioTurnoRol)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.ConnectionString);
                SqlCommand command = new SqlCommand();

                command.CommandText = "sp_SetCapturaMovimiento";
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 60;
                command.Connection = conn;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@Numero", SqlDbType.BigInt)).Value = Numero;
                command.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.Date)).Value = Fecha;
                command.Parameters.Add(new SqlParameter("@CantidadEntrega", SqlDbType.Int)).Value = CantidadEntrega;
                command.Parameters.Add(new SqlParameter("@CubrioTurno", SqlDbType.Int)).Value = CubrioTurno;
                command.Parameters.Add(new SqlParameter("@CubrioTurnoRol", SqlDbType.NVarChar)).Value = CubrioTurnoRol;
                command.Parameters.Add(new SqlParameter("@CubrioTurnoTipo", SqlDbType.NVarChar)).Value = CubrioTurnoTipo;

                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                return false;
            }
            finally
            {
                command = null;
                conn = null;
            }
            return true;
        }

        public DataTable ValidaFechaMovimiento(long Numero, DateTime Fecha)
        {
            DataTable dtInformacion = new DataTable();
            try
            {
                conn = new SqlConnection(Conexion.ConnectionString);
                command = new SqlCommand("sp_ValidaFechaMovimiento", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 60;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@Numero", SqlDbType.BigInt)).Value = Numero;
                command.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.Date)).Value = Fecha;
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
