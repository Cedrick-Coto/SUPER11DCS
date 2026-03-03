namespace ET
{
    public class ET_Marca
    {
        private int _IdMarca;
        private string _cDescripcion_ma;
        private bool _Estado;

        public int IdMarca { get => _IdMarca; set => _IdMarca = value; }
        public string cDescripcion_ma { get => _cDescripcion_ma; set => _cDescripcion_ma = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}
