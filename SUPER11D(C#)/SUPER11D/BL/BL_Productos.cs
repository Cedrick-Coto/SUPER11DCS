using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BL
{
    public class BL_Productos
    {
        public static DataTable ListadoPR(string ctexto)
        {
            //Instancia de la DAL para retornar el cTexto
            DAL_Productos Datos = new DAL_Productos();
            return Datos.ListadoPR(ctexto);
        }
        public static string GuardarPR(int nOpcion, ET_Productos pr)
        {
            DAL_Productos Datos = new DAL_Productos();
            return Datos.GuardarPR(nOpcion, pr);
        }

        public static string EliminarPR(int IdProducto)
        {
            DAL_Productos Datos = new DAL_Productos();
            return Datos.EliminarPR(IdProducto);
        }

        public static DataTable ListadoMAPR(string ctexto)
        {
            //Instancia de la DAL para retornar el cTexto
            DAL_Productos Datos = new DAL_Productos();
            return Datos.ListadoMAPR(ctexto);
        }

        public static DataTable ListadoUMPR(string ctexto)
        {
            //Instancia de la DAL para retornar el cTexto
            DAL_Productos Datos = new DAL_Productos();
            return Datos.ListadoUMPR(ctexto);

        }

        public static DataTable ListadoCAPR(string ctexto)
        {
            //Instancia de la DAL para retornar el cTexto
            DAL_Productos Datos = new DAL_Productos();
            return Datos.ListadoCAPR(ctexto);

        }
        public static DataTable Ver_Stock_Actual_Prod_xBodegas(int cIdProducto)
        {
            //Instancia de la DAL para retornar el cTexto
            DAL_Productos Datos = new DAL_Productos();
            return Datos.Ver_Stock_Actual_Prod_xBodegas(cIdProducto);

        }
    }
}
