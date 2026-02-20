namespace ET
{
    public class ET_Categoria
    {
        private int _IdCategoria;
        private string _DescripcionCat;
        private bool _Estado;

        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        public string DescripcionCat { get => _DescripcionCat; set => _DescripcionCat = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}
