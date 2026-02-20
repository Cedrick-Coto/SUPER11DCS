using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    public class Conexion
    {
        //Atributos

        private string _Base;
        private string _Server;
        private bool _seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this._Base = "SUPER11D";
            this._Server = "DESKTOP-B8F8KCS";
            this._seguridad = true;
        }
        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server =" + this._Server + ";Database=" + this._Base + ";Integrated Security=" + this._seguridad;
                if (_seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security=SSPI";
                }
                else
                {
                    // Aquí iría la conexión si fuese un server de BD
                }
            } catch (Exception ex)
            {
                cadena = null;
                throw ex;

            }
            return cadena;
        }
        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con= new Conexion();
            }
            return Con;
        }
    }
}