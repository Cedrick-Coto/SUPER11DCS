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
            SqlConnection SqlCon= new SqlConnection(); //Instancia a la Conexion a la BD
            try {
                //Establecer la conexion con la BD
                SqlCon=Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("sp_ListadoCA", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                //Parametro de busqueda
                comando.Parameters.Add("@ctexto", SqlDbType.VarChar).Value = ctexto;
                //Abrir la conexion
                SqlCon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex) {
                throw ex;
            } finally {
                //Si la conexion esta abierta, cerrarla
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
