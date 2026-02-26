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
            public static string GuardarCA(int n0ption, ET.ET_Categoria ca)
            {
                DAL_Categoria Datos = new DAL_Categoria();
                return Datos.GuardarCA(n0ption, ca);
        }
    }
}