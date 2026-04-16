using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_Ventas
    {
        private int _Codigo_sp;
        private int _Codigo_tde;
        private string _Nrodocumento_sp;
        private int _Codigo_cl;
        private string _Nrodocumento_cl;
        private string _Razon_Social_cl;
        private DateTime _fecha_sp;
        private string _observacion;
        private decimal _subTotal;
        private decimal _iva;
        private decimal _total_importe;

        public int Codigo_sp { get => _Codigo_sp; set => _Codigo_sp = value; }
        public int Codigo_tde { get => _Codigo_tde; set => _Codigo_tde = value; }
        public string Nrodocumento_sp { get => _Nrodocumento_sp; set => _Nrodocumento_sp = value; }
        public int Codigo_cl { get => _Codigo_cl; set => _Codigo_cl = value; }
        public string Nrodocumento_cl { get => _Nrodocumento_cl; set => _Nrodocumento_cl = value; }
        public string Razon_Social_cl { get => _Razon_Social_cl; set => _Razon_Social_cl = value; }
        public DateTime Fecha_sp { get => _fecha_sp; set => _fecha_sp = value; }
        public string Observacion { get => _observacion; set => _observacion = value; }
        public decimal SubTotal { get => _subTotal; set => _subTotal = value; }
        public decimal Iva { get => _iva; set => _iva = value; }
        public decimal Total_importe { get => _total_importe; set => _total_importe = value; }
    }
}
