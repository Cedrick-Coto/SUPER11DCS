namespace DAL;
using ET;
using System;
using System.Data;
using System.Data.SqlClient;
public class DAL_Productos
{
        public DataTable ListadoPR(string ctexto)
        {
            SqlDataReader Resultado; //Guarda en Bruto
            DataTable Tabla = new DataTable(); //Tabla de Datos
            SqlConnection SqlCon = new SqlConnection(); //Instancia a la Conexion a la BD
            try
            {
                //Establecer la conexion con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion;
                SqlCommand comando = new SqlCommand("USP_Listado_pr", SqlCon);
                //Tipo de comando a ejecutar (Procedimiento Almacenado)
                comando.CommandType = CommandType.StoredProcedure;
                //Parametro de busqueda para el procedimiento almacenado
                comando.Parameters.Add("@ctexto", SqlDbType.VarChar).Value = ctexto;
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

        public DataTable ListadoMAPR(string ctexto)
        {
            SqlDataReader Resultado; //Guarda en Bruto
            DataTable Tabla = new DataTable(); //Tabla de Datos
            SqlConnection SqlCon = new SqlConnection(); //Instancia a la Conexion a la BD
            try
            {
                //Establecer la conexion con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion;
                SqlCommand comando = new SqlCommand("USP_Listado_ma_pr", SqlCon);
                //Tipo de comando a ejecutar (Procedimiento Almacenado)
                comando.CommandType = CommandType.StoredProcedure;
                //Parametro de busqueda para el procedimiento almacenado
                comando.Parameters.Add("@ctexto", SqlDbType.VarChar).Value = ctexto;
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
        public DataTable ListadoUMPR(string ctexto)
        {
            SqlDataReader Resultado; //Guarda en Bruto
            DataTable Tabla = new DataTable(); //Tabla de Datos
            SqlConnection SqlCon = new SqlConnection(); //Instancia a la Conexion a la BD
            try
            {
                //Establecer la conexion con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion;
                SqlCommand comando = new SqlCommand("USP_Listado_um_pr", SqlCon);
                //Tipo de comando a ejecutar (Procedimiento Almacenado)
                comando.CommandType = CommandType.StoredProcedure;
                //Parametro de busqueda para el procedimiento almacenado
                comando.Parameters.Add("@ctexto", SqlDbType.VarChar).Value = ctexto;
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
        public DataTable ListadoCAPR(string ctexto)
        {
            SqlDataReader Resultado; //Guarda en Bruto
            DataTable Tabla = new DataTable(); //Tabla de Datos
            SqlConnection SqlCon = new SqlConnection(); //Instancia a la Conexion a la BD
            try
            {
                //Establecer la conexion con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion;
                SqlCommand comando = new SqlCommand("USP_Listado_ca_pr", SqlCon);
                //Tipo de comando a ejecutar (Procedimiento Almacenado)
                comando.CommandType = CommandType.StoredProcedure;
                //Parametro de busqueda para el procedimiento almacenado
                comando.Parameters.Add("@ctexto", SqlDbType.VarChar).Value = ctexto;
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
        public DataTable Ver_Stock_Actual_Prod_xBodegas(int  cIdProducto)
        {
            SqlDataReader Resultado; //Guarda en Bruto
            DataTable Tabla = new DataTable(); //Tabla de Datos
            SqlConnection SqlCon = new SqlConnection(); //Instancia a la Conexion a la BD
            try
            {
                //Establecer la conexion con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion;
                SqlCommand comando = new SqlCommand("USP_Ver_Stock_Actual_Prod_xBodegas", SqlCon);
                //Tipo de comando a ejecutar (Procedimiento Almacenado)
                comando.CommandType = CommandType.StoredProcedure;
                //Parametro de busqueda para el procedimiento almacenado
                comando.Parameters.Add("@nIdProducto", SqlDbType.VarChar).Value = cIdProducto;
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
        public string GuardarPR(int nOpcion, ET_Productos pr)
        {
            SqlConnection sqlConnection = new SqlConnection();
            string Rpta = "";
            try
            {
                sqlConnection = Conexion.GetInstancia().CrearConexion;
                SqlCommand sqlCommand = new SqlCommand("USP_Guardar_pr", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parametros para el procedimiento almacenado
                sqlCommand.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;

                sqlCommand.Parameters.Add("@IdProducto", SqlDbType.Int).Value = pr.IdProducto;
                sqlCommand.Parameters.Add("@cDescripcion_pr", SqlDbType.VarChar).Value = pr.DescripcionPr;
                sqlCommand.Parameters.Add("@IdMarca", SqlDbType.Int).Value = pr.IdMarca;
                sqlCommand.Parameters.Add("@IdUnidMed", SqlDbType.Int).Value = pr.IdUnidMed;
                sqlCommand.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = pr.IdCategoria;
                sqlCommand.Parameters.Add("@StockMin", SqlDbType.Decimal).Value = pr.StockMin;
                sqlCommand.Parameters.Add("@StockMax", SqlDbType.Decimal).Value = pr.StockMax;
                sqlCommand.Parameters.Add("@Pu_venta", SqlDbType.Decimal).Value = pr.Pu_venta;
            sqlConnection.Open();

                Rpta = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo guardar el registro";

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

        public string EliminarPR(int IdProducto)
        {
            SqlConnection sqlConnection = new SqlConnection();
            string Rpta = "";
            try
            {
                //Realizar la conexion con la BD creando una instancia a la clase Conexion (pregunta de examen)
                sqlConnection = Conexion.GetInstancia().CrearConexion;
                SqlCommand sqlCommand = new SqlCommand("USP_Eliminar_pr", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parametro para el procedimiento almacenado
                sqlCommand.Parameters.Add("@IdProducto", SqlDbType.Int).Value = IdProducto;
                sqlConnection.Open();
                Rpta = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
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