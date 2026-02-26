namespace ET
{
    public class ET_Categoria
    {
        private int _IdCategoria;
        private string _cDescripcion_ca;
        private bool _Estado;

        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        public string cDescripcion_ca { get => _cDescripcion_ca; set => _cDescripcion_ca = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}
