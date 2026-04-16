using System;
using System.Collections.Generic;
using System.Text;
using ET;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_Ventas
    {
        public DataTable Listado_sp(string ctexto)
        {
            SqlDataReader Resultado; //Guarda en Bruto
            DataTable Tabla = new DataTable(); //Tabla de Datos
            SqlConnection SqlCon = new SqlConnection(); //Instancia a la Conexion a la BD
            try
            {
                //Establecer la conexion con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion;
                SqlCommand comando = new SqlCommand("USP_Listado_sp", SqlCon);
                //Tipo de comando a ejecutar (Procedimiento Almacenado)
                comando.CommandType = CommandType.StoredProcedure;
                //Parametro de busqueda para el procedimiento almacenado
                comando.Parameters.Add("@ctexto", SqlDbType.VarChar, 250).Value = (object)ctexto ?? DBNull.Value;
                //Abrir la conexion
                SqlCon.Open();
                Resultado = comando.ExecuteReader();
                // Cargar el resultado del comando en la tabla de datos
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Si la conexion esta abierta, cerrarla
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable Listado_Detalle_sp(int nCodigo_sp)
        {
            SqlDataReader Resultado; //Guarda en Bruto
            DataTable Tabla = new DataTable(); //Tabla de Datos
            SqlConnection SqlCon = new SqlConnection(); //Instancia a la Conexion a la BD
            try
            {
                //Establecer la conexion con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion;
                SqlCommand comando = new SqlCommand("USP_Listado_Detalle_sp", SqlCon);
                //Tipo de comando a ejecutar (Procedimiento Almacenado)
                comando.CommandType = CommandType.StoredProcedure;
                //Parametro de busqueda para el procedimiento almacenado
                comando.Parameters.Add("@nCodigo_sp", SqlDbType.Int).Value = (object)nCodigo_sp;
                //Abrir la conexion
                SqlCon.Open();
                Resultado = comando.ExecuteReader();
                // Cargar el resultado del comando en la tabla de datos
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Si la conexion esta abierta, cerrarla
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Listado_cl_sp(string ctexto)
        {
            SqlDataReader Resultado; //Guarda en Bruto
            DataTable Tabla = new DataTable(); //Tabla de Datos
            SqlConnection SqlCon = new SqlConnection(); //Instancia a la Conexion a la BD
            try
            {
                //Establecer la conexion con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion;
                SqlCommand comando = new SqlCommand("USP_Listado_cl_sp", SqlCon);
                //Tipo de comando a ejecutar (Procedimiento Almacenado)
                comando.CommandType = CommandType.StoredProcedure;
                //Abrir la conexion
                SqlCon.Open();
                Resultado = comando.ExecuteReader();
                // Cargar el resultado del comando en la tabla de datos
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Si la conexion esta abierta, cerrarla
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Listado_pr_sp(string ctexto)
        {
            SqlDataReader Resultado; //Guarda en Bruto
            DataTable Tabla = new DataTable(); //Tabla de Datos
            SqlConnection SqlCon = new SqlConnection(); //Instancia a la Conexion a la BD
            try
            {
                //Establecer la conexion con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion;
                SqlCommand comando = new SqlCommand("USP_Listado_pr_sp", SqlCon);
                //Tipo de comando a ejecutar (Procedimiento Almacenado)
                comando.CommandType = CommandType.StoredProcedure;
                //Parametro de busqueda para el procedimiento almacenado
                comando.Parameters.Add("@ctexto", SqlDbType.VarChar, 250).Value = (object)ctexto ?? DBNull.Value;
                //Abrir la conexion
                SqlCon.Open();
                Resultado = comando.ExecuteReader();
                // Cargar el resultado del comando en la tabla de datos
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Si la conexion esta abierta, cerrarla
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable Listado_tde(string ctexto)
        {
            SqlDataReader Resultado; //Guarda en Bruto
            DataTable Tabla = new DataTable(); //Tabla de Datos
            SqlConnection SqlCon = new SqlConnection(); //Instancia a la Conexion a la BD
            try
            {
                //Establecer la conexion con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion;
                SqlCommand comando = new SqlCommand("USP_Listado_tde", SqlCon);
                //Tipo de comando a ejecutar (Procedimiento Almacenado)
                comando.CommandType = CommandType.StoredProcedure;
                //Parametro de busqueda para el procedimiento almacenado
                comando.Parameters.Add("@ctexto", SqlDbType.VarChar, 250).Value = (object)ctexto ?? DBNull.Value;
                //Abrir la conexion
                SqlCon.Open();
                Resultado = comando.ExecuteReader();
                // Cargar el resultado del comando en la tabla de datos
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Si la conexion esta abierta, cerrarla
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public string Guardar_sp(ET_Ventas oSp, DataTable dTabla)
        {
            SqlConnection sqlConnection = new SqlConnection();
            string Rpta = "";
            try
            {
                sqlConnection = Conexion.GetInstancia().CrearConexion;
                SqlCommand sqlCommand = new SqlCommand("USP_Guardar_sp", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parametros para el procedimiento almacenado
                sqlCommand.Parameters.Add("@nCodigo_tde", SqlDbType.Int).Value = oSp.Codigo_tde;

                sqlCommand.Parameters.Add("@cNroDocumento_sp", SqlDbType.VarChar).Value = oSp.Nrodocumento_sp;
                sqlCommand.Parameters.Add("@nCodigo_cl", SqlDbType.Int).Value = oSp.Codigo_cl;
                sqlCommand.Parameters.Add("@cNroDocumento_cl", SqlDbType.VarChar).Value = oSp.Nrodocumento_cl;
                sqlCommand.Parameters.Add("@cRazon_social_cl", SqlDbType.VarChar).Value = oSp.Razon_Social_cl;
                sqlCommand.Parameters.Add("@fFecha_sp", SqlDbType.Date).Value = oSp.Fecha_sp;
                sqlCommand.Parameters.Add("@cObservacion_sp", SqlDbType.VarChar).Value = oSp.Observacion;
                sqlCommand.Parameters.Add("@nSubTotal", SqlDbType.Decimal).Value = oSp.SubTotal;
                sqlCommand.Parameters.Add("@Iva", SqlDbType.Decimal).Value = oSp.Iva;
                sqlCommand.Parameters.Add("@nTotal_importe", SqlDbType.Decimal).Value = oSp.Total_importe;
                sqlCommand.Parameters.Add("@tDetalle", SqlDbType.Structured).Value = dTabla;
                sqlConnection.Open();

                Rpta = sqlCommand.ExecuteNonQuery() > 0 ? "OK" : "No se pudo guardar el registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
            return Rpta;
        }
        public string Elimina_sp(int Codigo_sp)
        {
            SqlConnection sqlConnection = new SqlConnection();
            string Rpta = "";
            try
            {
                //Realizar la conexion con la BD creando una instancia a la clase Conexion (pregunta de examen)
                sqlConnection = Conexion.GetInstancia().CrearConexion;
                SqlCommand sqlCommand = new SqlCommand("USP_Eliminar_sp", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parametro para el procedimiento almacenado
                sqlCommand.Parameters.Add("@Codigo_sp", SqlDbType.Int).Value = Codigo_sp;
                sqlConnection.Open();
                Rpta = sqlCommand.ExecuteNonQuery() > 0 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return Rpta;
        }
    }

}
