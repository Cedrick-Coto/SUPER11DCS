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
    }
}