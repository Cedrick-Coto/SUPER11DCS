using System.Data;
using DAL;

namespace BL;

public class BL_Productos
{
    public static DataTable ListadoPR(string ctexto)
    {
        DAL_Productos Datos = new DAL_Productos();
            return Datos.ListadoPR(ctexto);
    }

    public static DataTable ListadoCAPR(string ctexto)
    {
        DAL_Productos Datos = new DAL_Productos();
        return Datos.ListadoCAPR(ctexto);
    }

    public static DataTable ListadoUMPR(string ctexto)
    {
        DAL_Productos Datos = new DAL_Productos();
        return Datos.ListadoUMPR(ctexto);
    }
    public static DataTable ListadoMAPR(string ctexto)
    {
        DAL_Productos Datos = new DAL_Productos();
        return Datos.ListadoMAPR(ctexto);
    }
    public static DataTable Ver_Stock_Actual_Prod_xBodegas(int  cIdProducto)
    {
        DAL_Productos Datos = new DAL_Productos();
        return Datos.Ver_Stock_Actual_Prod_xBodegas(cIdProducto);
    }
}