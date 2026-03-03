using DAL;
using System.Data;

namespace BL
{
    public class BL_Categoria
    {
        public static DataTable ListadoCA(string ctexto)
        {
            DAL_Categoria Datos = new DAL_Categoria();
            return Datos.ListadoCA(ctexto);
        }
        public static string GuardarCA(int nOption, ET.ET_Categoria ca)
        {
            DAL_Categoria Datos = new DAL_Categoria();
            return Datos.GuardarCA(nOption, ca);
        }
        public static string EliminarCA(int IdMarca)
        {
            DAL_Categoria Datos = new DAL_Categoria();
            return Datos.EliminarCA(IdMarca);
        }
    }
}
