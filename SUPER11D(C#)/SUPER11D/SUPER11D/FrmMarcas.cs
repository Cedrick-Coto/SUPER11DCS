using BL;
using ET;
using System.Diagnostics;
using System.Drawing.Text;

namespace SUPER11D
{
    public partial class FrmMarcas : Form
    {
        public FrmMarcas()
        {
            InitializeComponent();
        }
        #region Mis variables globales
        int EstadoGuarda = 0;
        int IdMarca = 0;

        #endregion




        #region Mis Metodos
        //Crea un formato, disposicion de como se van a ver los datos, que se van a  imprimir en el data view
        private void FormatoCA()
        {
            DgvPrincipal.Columns[0].Width = 100;
            DgvPrincipal.Columns[0].HeaderText = "ID Marca";
            DgvPrincipal.Columns[1].Width = 100;
            DgvPrincipal.Columns[1].HeaderText = "Marca";
        }
        private void SeleccionaItem()
        {
            //Validar que el campo no este vacio
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["IdMarca"].Value)))
            {
                MessageBox.Show("No se pudo seleccionar el registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Asignar los valores a las variables globales
                this.IdMarca = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["IdMarca"].Value);
                txtDescripPr.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["DescripcionCa"].Value);
            }

        }
        #endregion

        #region Listado de Marcas
        private void ListadoMA(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = BL_Marca.ListadoMA(cTexto);
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

        #region Cargar el combo de marcas
        private void FrmMarcas_Load(object sender, EventArgs e)
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
                MessageBox.Show("Debe ingresar una descripcion para la marca", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EstadoGuarda = 0;
                this.EstadoBotonesPrincipales(true);
                this.EstadoBotonesProcesos(false);
                txtDescripPr.Text = "";
                Mantenimiento.SelectedIndex = 0;
                this.IdMarca = 0;
            }
            else
            {
                ET_Marca ma = new ET_Marca();
                string Rpta = "";
                ma.IdMarca = this.IdMarca;
                ma.cDescripcion_ma = this.txtDescripPr.Text.Trim();
                Rpta = BL_Marca.GuardarMA(EstadoGuarda, ma);
                if (Rpta.Equals("OK"))
                {
                    this.ListadoMA("%");
                    MessageBox.Show("Los datos se guardaron correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.EstadoBotonesProcesos(false);
                    this.EstadoBotonesPrincipales(true);
                    txtDescripPr.Text = "";
                    Mantenimiento.SelectedIndex = 0;
                    this.IdMarca = 0;
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
            this.IdMarca = 0;
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
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["IdMarca"].Value)))
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
                    this.IdMarca = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["IdMarca"].Value);
                    string Rpta = "";
                    Rpta = BL_Marca.EliminarMA(this.IdMarca);
                    if (Rpta.Equals("OK"))
                    {
                        this.ListadoMA("%");
                        MessageBox.Show("Los datos se eliminaron correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.IdMarca = 0;
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

