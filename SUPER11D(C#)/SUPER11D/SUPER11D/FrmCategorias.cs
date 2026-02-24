using BL;
using System.Drawing.Text;

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

        #region Listado de Categorias
        private void ListadoCA(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = BL_Categoria.ListadoCA(cTexto);
                this.FormatoCA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw ex;
            }

        }
        #endregion
        #region Cargar el combo de categorias
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ListadoCA("%");

        }
        #endregion
    }
}

