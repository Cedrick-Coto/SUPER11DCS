using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BL
{
    public class BL_Ventas
    {
        public static DataTable Listado_sp(string ctexto)
        {
            //Instancia de la DAL para retornar el cTexto
            DAL_Ventas Datos = new DAL_Ventas();
            return Datos.Listado_sp(ctexto);
        }
        public static string Guardar_sp(ET_Ventas oSp, DataTable dTabla)
        {
            DAL_Ventas Datos = new DAL_Ventas();
            return Datos.Guardar_sp(oSp, dTabla);
        }

        public static string Eliminar_sp(int Codigo_sp)
        {
            DAL_Ventas Datos = new DAL_Ventas();
            return Datos.Elimina_sp(Codigo_sp);
        }

        public static DataTable Listado_cl_sp(string ctexto)
        {
            //Instancia de la DAL para retornar el cTexto
            DAL_Ventas Datos = new DAL_Ventas();
            return Datos.Listado_cl_sp(ctexto);
        }

        public static DataTable Listado_tde(string ctexto)
        {
            //Instancia de la DAL para retornar el cTexto
            DAL_Ventas Datos = new DAL_Ventas();
            return Datos.Listado_tde(ctexto);

        }

        public static DataTable Listado_pr_sp(string ctexto)
        {
            //Instancia de la DAL para retornar el cTexto
            DAL_Ventas Datos = new DAL_Ventas();
            return Datos.Listado_pr_sp(ctexto);

        }
        public static DataTable Listado_Detalle_sp(int nCodigo_sp)
        {
            //Instancia de la DAL para retornar el cTexto
            DAL_Ventas Datos = new DAL_Ventas();
            return Datos.Listado_Detalle_sp(nCodigo_sp);

        }
    }
}
