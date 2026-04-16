using ET;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Categoria
    {
        public DataTable ListadoCA(string ctexto)
        {
            SqlDataReader Resultado; //Guarda en Bruto
            DataTable Tabla = new DataTable(); //Tabla de Datos
            SqlConnection SqlCon = new SqlConnection(); //Instancia a la Conexion a la BD
            try
            {
                //Establecer la conexion con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion;
                SqlCommand comando = new SqlCommand("USP_Listado_ca", SqlCon);
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

        public string GuardarCA(int nOpcion, ET_Categoria ca)
        {
            SqlConnection sqlConnection = new SqlConnection();
            string Rpta = "";
            try
            {
                sqlConnection = Conexion.GetInstancia().CrearConexion;
                SqlCommand sqlCommand = new SqlCommand("USP_Guardar_ca", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parametros para el procedimiento almacenado
                sqlCommand.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                sqlCommand.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = ca.IdCategoria;
                sqlCommand.Parameters.Add("@cDescripcion_ca", SqlDbType.VarChar).Value = ca.cDescripcion_ca;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.Bit).Value = ca.Estado;
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
        public string EliminarCA(int IdCategoria)
        {
            SqlConnection sqlConnection = new SqlConnection();
            string Rpta = "";
            try
            {
                //Realizar la conexion con la BD creando una instancia a la clase Conexion (pregunta de examen)
                sqlConnection = Conexion.GetInstancia().CrearConexion;
                SqlCommand sqlCommand = new SqlCommand("USP_Eliminar_ca", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parametro para el procedimiento almacenado
                sqlCommand.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = IdCategoria;
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
}
