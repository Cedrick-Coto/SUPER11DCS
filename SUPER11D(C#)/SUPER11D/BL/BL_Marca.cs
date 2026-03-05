using DAL;
using System.Data;

namespace BL
{
    public class BL_Marca
    {
        public static DataTable ListadoMA(string ctexto)
        {
            DAL_Marca Datos = new DAL_Marca();
            return Datos.ListadoMA(ctexto);
        }
        public static string GuardarMA(int nOption, ET.ET_Marca ca)
        {
            DAL_Marca Datos = new DAL_Marca();
            return Datos.GuardarMA(nOption, ca);
        }
        public static string EliminarMA(int IdMarca)
        {
            DAL_Marca Datos = new DAL_Marca();
            return Datos.EliminarMA(IdMarca);
        }
    }
}
