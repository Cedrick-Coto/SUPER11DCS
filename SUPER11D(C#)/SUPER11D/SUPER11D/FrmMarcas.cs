using BL;
using ET;
using System.Diagnostics;
using System.Drawing.Text;

namespace SUPER11D
{
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }
        #region Mis variables globales
        int EstadoGuarda = 0;
        int IdMarcas = 0;

        #endregion




        #region Mis Metodos
        //Crea un formato, disposicion de como se van a ver los datos, que se van a  imprimir en el data view
        private void FormatoMA()
        {
            DgvPrincipal.Columns[0].Width = 100;
            DgvPrincipal.Columns[0].HeaderText = "ID ";
            DgvPrincipal.Columns[1].Width = 100;
            DgvPrincipal.Columns[1].HeaderText = "Marcas";
        }
        private void SeleccionaItem()
        {
            //Validar que el campo no este vacio
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["IdMarcas"].Value)))
            {
                MessageBox.Show("No se pudo seleccionar el registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Asignar los valores a las variables globales
                this.IdMarcas = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["IdMarcas"].Value);
                txtDescripMA.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["DescripcionCa"].Value);
            }

        }
        #endregion

        #region Listado de Marcas
        private void ListadoMA(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = BL_Marca.ListadoMA(cTexto);
                this.FormatoMA();
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

        #region Cargar el combo de Marcass
        private void Marcas_Load(object sender, EventArgs e)
        {
            this.ListadoMA("%");

        }
        #endregion

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;
            this.EstadoBotonesProcesos(true);
            this.EstadoBotonesPrincipales(false);
            //Limpiar los controles
            txtDescripMA.Text = "";
            txtDescripMA.ReadOnly = false;
            //Poner el cursor en el control de texto
            Mantenimiento.SelectedIndex = 1;
            txtDescripMA.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripMA.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripcion para la Marcas", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EstadoGuarda = 0;
                this.EstadoBotonesPrincipales(true);
                this.EstadoBotonesProcesos(false);
                txtDescripMA.Text = "";
                Mantenimiento.SelectedIndex = 0;
                this.IdMarcas = 0;
            }
            else
            {
                ET_Marca ca = new ET_Marca();
                string Rpta = "";
                ca.IdMarcas = this.IdMarcas;
                ca.cDescripcion_ca = this.txtDescripMA.Text.Trim();
                Rpta = BL_Marca.GuardarMA(EstadoGuarda, ca);
                if (Rpta.Equals("OK"))
                {
                    this.ListadoMA("%");
                    MessageBox.Show("Los datos se guardaron correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.EstadoBotonesProcesos(false);
                    this.EstadoBotonesPrincipales(true);
                    txtDescripMA.Text = "";
                    Mantenimiento.SelectedIndex = 0;
                    this.IdMarcas = 0;
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
            this.IdMarcas = 0;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 2;
            this.EstadoBotonesProcesos(true);
            this.EstadoBotonesPrincipales(false);
            this.SeleccionaItem();
            txtDescripMA.ReadOnly = false;
            Mantenimiento.SelectedIndex = 1;
            txtDescripMA.Focus();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["IdMarcas"].Value)))
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
                    this.IdMarcas = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["IdMarcas"].Value);
                    string Rpta = "";
                    Rpta = BL_Marca.EliminarMA(this.IdMarcas);
                    if (Rpta.Equals("OK"))
                    {
                        this.ListadoMA("%");
                        MessageBox.Show("Los datos se eliminaron correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.IdMarcas = 0;
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

