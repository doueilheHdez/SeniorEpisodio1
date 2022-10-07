using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Nomina.Capa.Datos
{
    internal class Procedimientos
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter da;
        public DataSet getCarpetas()
        {
            string MSJReturn = String.Empty;
            DataSet dt = new DataSet();
            try
            {
                conn = new SqlConnection(connectionString);
                command = new SqlCommand("sp_ListaDocumentosxDia", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 600;
                command.Parameters.Clear();
                da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                string _msj = DateTime.Now + "--> Error getCarpeta " + ex.Message;
                logs lg = new logs();
                lg.Escribir(_msj);
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
            return dt;
        }

        public bool setRegistro(int anio, int mes, int folioWM, int complemento, string archivo, string tipo,
           long filesize, string hash, int paginas, string tipoDocumentoId, int nextsec, string CarpetaAzure, int Existe)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            try
            {
                command.CommandText = "sp_GMM_UploadFile_Azure";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@anio", SqlDbType.Int)).Value = anio;
                command.Parameters.Add(new SqlParameter("@mes", SqlDbType.Int)).Value = mes;
                command.Parameters.Add(new SqlParameter("@folioWM", SqlDbType.Int)).Value = folioWM;
                command.Parameters.Add(new SqlParameter("@complemento", SqlDbType.Int)).Value = complemento;
                command.Parameters.Add(new SqlParameter("@archivo", SqlDbType.NVarChar)).Value = archivo;
                command.Parameters.Add(new SqlParameter("@tipo", SqlDbType.NVarChar)).Value = tipo;
                command.Parameters.Add(new SqlParameter("@filesize", SqlDbType.BigInt)).Value = filesize;
                command.Parameters.Add(new SqlParameter("@hash", SqlDbType.NVarChar)).Value = hash;
                command.Parameters.Add(new SqlParameter("@paginas", SqlDbType.Int)).Value = paginas;
                command.Parameters.Add(new SqlParameter("@tipoDocumentoId", SqlDbType.NVarChar)).Value = tipoDocumentoId;
                command.Parameters.Add(new SqlParameter("@nextsec", SqlDbType.Int)).Value = nextsec;
                command.Parameters.Add(new SqlParameter("@CarpetaAzure", SqlDbType.NVarChar)).Value = CarpetaAzure;
                command.Parameters.Add(new SqlParameter("@Existe", SqlDbType.Int)).Value = Existe;
                command.CommandTimeout = 120;
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                string _msj = DateTime.Now + "--> Error InsertRegistro(): " + Ex.Message;
                logs lg = new logs();
                lg.Escribir(_msj);

                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                command = null;
                conn = null;
            }
            return true;
        }
    }
}
