using BL;
using ET;
using System.Diagnostics;
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
        private void SeleccionaItem()
        {
            //Validar que el campo no este vacio
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["IdCategoria"].Value)))
            {
                MessageBox.Show("No se pudo seleccionar el registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Asignar los valores a las variables globales
                this.IdCategoria = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["IdCategoria"].Value);
                txtDescripPr.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["cDescripcion_ca"].Value);
            }

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
        #region Metodos miscelaneos
        private void EstadoBotonesPrincipales(bool lEstado)
        {
            this.BtnNuevo.Enabled = lEstado;
            this.BtnActualizar.Enabled = lEstado;
            this.BtnReporte.Enabled = lEstado;
            this.BtnEliminar.Enabled = lEstado;
            this.BtnSalir.Enabled = lEstado;
        }
        private void EstadoBotonesProcesos(bool lEstado)
        {
            this.BtnGuardar.Visible = lEstado;
            this.BtnCancelar.Visible = lEstado;
            this.BtnRegresar.Visible = lEstado;
        }
        #endregion

        #region Cargar el combo de categorias
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ListadoCA("%");

        }
        #endregion

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;
            this.EstadoBotonesProcesos(true);
            this.EstadoBotonesPrincipales(false);
            //Limpiar los controles
            txtDescripPr.Text = "";
            txtDescripPr.ReadOnly = false;
            //Poner el cursor en el control de texto
            Mantenimiento.SelectedIndex = 1;
            txtDescripPr.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripPr.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripcion para la categoria", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EstadoGuarda = 0;
                this.EstadoBotonesPrincipales(true);
                this.EstadoBotonesProcesos(false);
                txtDescripPr.Text = "";
                Mantenimiento.SelectedIndex = 0;
                this.IdCategoria = 0;
            }
            else
            {
                ET_Categoria ca = new ET_Categoria();
                string Rpta = "";
                ca.IdCategoria = this.IdCategoria;
                ca.cDescripcion_ca = this.txtDescripPr.Text.Trim();
                Rpta = BL_Categoria.GuardarCA(EstadoGuarda, ca);
                if (Rpta.Equals("OK"))
                {
                    this.ListadoCA("%");
                    MessageBox.Show("Los datos se guardaron correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.EstadoBotonesProcesos(false);
                    this.EstadoBotonesPrincipales(true);
                    txtDescripPr.Text = "";
                    Mantenimiento.SelectedIndex = 0;
                    this.IdCategoria = 0;
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.EstadoBotonesProcesos(false);
            this.EstadoBotonesPrincipales(true);
            Mantenimiento.SelectedIndex = 0;
            this.IdCategoria = 0;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 2;
            this.EstadoBotonesProcesos(true);
            this.EstadoBotonesPrincipales(false);
            this.SeleccionaItem();
            txtDescripPr.ReadOnly = false;
            Mantenimiento.SelectedIndex = 1;
            txtDescripPr.Focus();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["IdCategoria"].Value)))
            {
                MessageBox.Show("No se pudo seleccionar el registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar el registro seleccionado?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.No)
                {
                    return;
                }
                else
                {
                    this.IdCategoria = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["IdCategoria"].Value);
                    string Rpta = "";
                    Rpta = BL_Categoria.EliminarCA(this.IdCategoria);
                    if (Rpta.Equals("OK"))
                    {
                        this.ListadoCA("%");
                        MessageBox.Show("Los datos se eliminaron correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.IdCategoria = 0;
                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

