namespace SUPER11D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Mis variables globales
        int EstadoGuarda = 0;
        int IdCategoria = 0;

        #endregion




        #region Mis Metodos
        //Crea un formato, disposicion de como se van a ver los datos, que se van a  imprimir en el data view
        private void FormatoCA()
        {
            DgvPrincipal.Columns[0].Width = 100;
            DgvPrincipal.Columns[0].HeaderText = "ID Categoria";
            DgvPrincipal.Columns[1].Width = 100;
            DgvPrincipal.Columns[1].HeaderText = "Categoria";
        }
        #endregion


    }
}

