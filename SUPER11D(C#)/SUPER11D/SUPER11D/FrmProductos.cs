// Referencia a la capa de L�gica de Negocio
using BL;
// Referencia a la capa de Entidades
using ET;

namespace SUPER11D
{
    /// <summary>
    /// Formulario para gestionar las categor�as del sistema.
    /// Permite listar, crear, actualizar y eliminar categor�as.
    /// </summary>
    public partial class FrmProductos : Form
    {
        /// <summary>
        /// Constructor del formulario.
        /// Inicializa los componentes visuales del formulario.
        /// </summary>
        public FrmProductos()
        {
            InitializeComponent();
        }

        #region Mis variables globales

        // Variable que controla el estado de guardado:
        // 0 = Sin acci�n
        // 1 = Insertar nueva categor�a
        // 2 = Actualizar categor�a existente
        int EstadoGuarda = 0;

        // Almacena el ID de la categor�a seleccionada para edici�n
        // 0 = Nueva categor�a
        // >0 = Categor�a existente
        int IdProducto = 0;
        int IdMarca = 0;
        int IdCategoria = 0;
        int IdUniMed = 0;

        #endregion

        #region Mis Metodos


        private void FormatoPR()
        {
            DgvPrincipal.Columns[0].Width = 80;
            DgvPrincipal.Columns[0].HeaderText = "ID PRODUCTO";
            DgvPrincipal.Columns[1].Width = 240;
            DgvPrincipal.Columns[1].HeaderText = "Producto";
            DgvPrincipal.Columns[2].Width = 150;
            DgvPrincipal.Columns[2].HeaderText = "Marca";
            DgvPrincipal.Columns[3].Width = 80;
            DgvPrincipal.Columns[3].HeaderText = "Uni. Med";
            DgvPrincipal.Columns[4].Width = 100;
            DgvPrincipal.Columns[4].HeaderText = "Categoria";
            DgvPrincipal.Columns[5].Width = 80;
            DgvPrincipal.Columns[5].HeaderText = "Stock Min";
            DgvPrincipal.Columns[6].Width = 80;
            DgvPrincipal.Columns[6].HeaderText = "Stock MAX";
            DgvPrincipal.Columns[7].Visible = false;
            DgvPrincipal.Columns[8].Visible = false;
            DgvPrincipal.Columns[9].Visible = false;
            DgvPrincipal.Columns[10].Visible = false;
        }

        private void FormatomaPR()
        {
            DgvMarcas.Columns[0].Width = 215;
            DgvMarcas.Columns[0].HeaderText = "Marca";
            DgvMarcas.Columns[1].Visible = false;
        }
        private void FormatocaPR()
        {
            // Usamos DgvCategorias porque parece ser el que usas en los paneles flotantes
            if (DgvCategorias.Columns.Count > 0)
            {
                DgvCategorias.Columns[0].Width = 215;
                DgvCategorias.Columns[0].HeaderText = "Categoria";

                if (DgvCategorias.Columns.Count > 1)
                {
                    DgvCategorias.Columns[1].Visible = false;
                }
            }
        }

        private void FormatoStockActualPR()
        {
            if (DgvBodega.Columns.Count >= 3) // Validamos que existan al menos 3 columnas
            {
                DgvBodega.Columns[0].Width = 95;
                DgvBodega.Columns[0].HeaderText = "Bodega";

                DgvBodega.Columns[1].Width = 65; // Cambiado a índice 1
                DgvBodega.Columns[1].HeaderText = "Stock Actual";

                DgvBodega.Columns[2].Width = 65; // Cambiado a índice 2
                DgvBodega.Columns[2].HeaderText = "Costo Unidad";
            }
        }
        private void FormatoumPR()
        {
            if (DgvMedidas.Columns.Count > 0)
            {
                DgvMedidas.Columns[0].Width = 215;
                DgvMedidas.Columns[0].HeaderText = "Medida"; // Corregido: Decía "Marca"

                if (DgvMedidas.Columns.Count > 1)
                {
                    DgvMedidas.Columns[1].Visible = false;
                }
            }
        }

        private void ListadoPR(string ctexto)
        {
            try
            {
                try
                {
                    // Llama a la capa de negocio para obtener los datos
                    // y los asigna como origen de datos del DataGridView
                    DgvPrincipal.DataSource = BL_Productos.ListadoPR(ctexto);

                    // Aplica el formato a las columnas del DataGridView
                    this.FormatoPR();
                }
                catch (Exception ex)
                {
                    // Captura cualquier error y lo muestra al usuario
                    // con detalles para facilitar la depuraci�n
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n\nStackTrace: {ex.StackTrace}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        // Para Unidades de Medida
        private void ListadoUMPR(string ctexto)
        {
            DgvMedidas.DataSource = BL_Productos.ListadoUMPR(ctexto); // Usar DgvMedidas
            this.FormatoumPR();
        }
        private void ListadoCAPR(string ctexto)
        {
            try
            {
                // CORRECCIÓN: Asignar al DGV del panel de categorías, no al principal
                DgvCategorias.DataSource = BL_Productos.ListadoCAPR(ctexto);
                this.FormatocaPR();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error");
            }
        }
        private void ListadoMAPR(string ctexto)
        {
            DgvMarcas.DataSource = BL_Productos.ListadoMAPR(ctexto); // Usar DgvMarcas
            this.FormatomaPR();
        }
        private void ListadoStockActualPR(int cIdProducto)
        {
            try
            {
                try
                {
                    // Llama a la capa de negocio para obtener los datos
                    // y los asigna como origen de datos del DataGridView
                    DgvBodega.DataSource = BL_Productos.Ver_Stock_Actual_Prod_xBodegas(cIdProducto);

                    // Aplica el formato a las columnas del DataGridView
                    this.FormatoPR();
                }
                catch (Exception ex)
                {
                    // Captura cualquier error y lo muestra al usuario
                    // con detalles para facilitar la depuraci�n
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n\nStackTrace: {ex.StackTrace}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void EstadoBotonesPrincipales(bool LEstado)
        {
            // Habilita o deshabilita los botones de acciones principales
            this.btnNuevo.Enabled = LEstado;
            this.btnActualizar.Enabled = LEstado;
            this.btnEliminar.Enabled = LEstado;
            this.btnReporte.Enabled = LEstado;
            this.btnSalir.Enabled = LEstado;
        }


        private void EstadoBotonesProcesos(bool LEstado)
        {
            // Muestra u oculta los botones de procesos de mantenimiento
            this.btnCancelar.Visible = LEstado;
            this.btnGuardar.Visible = LEstado;
            this.btnRegresar.Visible = LEstado;
        }

        #endregion
        private void SeleccionaItem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.
                    Cells["IdProducto"].Value)))//valida si el campo id Producto de la fila seleccionada esta vacia 
            {

                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                this.IdProducto = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["IdProducto"].Value);
                txtDescripPr.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["DescripcionPr"].Value);
                this.IdMarca = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["IdMarca"].Value);
                txtMarcas.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["DescripcionMa"].Value);
                this.IdUniMed = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["IdUniMed"].Value);
                Txt_pu_venta.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["DescripcionUn"].Value);
                this.IdCategoria = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["IdCategoria"].Value);
                txtDescripPr.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["DescripcionCa"].Value);
            }
        }
        private void SeleccionaItemPR()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.
                Cells["IdProductos"].Value)))//valida si el campo id Producto de la fila seleccionada esta vacia 
            {

                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                this.IdCategoria = Convert.ToInt32(DgvPrincipal.CurrentRow.
                    Cells["IdProducto"].Value);
                txtDescripPr.Text = Convert.ToString(DgvPrincipal.CurrentRow.
                Cells["cDescripcion_pr"].Value);
            }
        }
        private void SeleccionaItemMAPR()
        {
            // 1. Validar que haya una fila seleccionada
            if (DgvPrincipal.CurrentRow == null) return;

            // 2. Validar que la celda no sea nula antes de convertir a String
            var cellValue = DgvPrincipal.CurrentRow.Cells["IdMarca"].Value;

            if (cellValue == null || string.IsNullOrEmpty(cellValue.ToString()))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.IdMarca = Convert.ToInt32(cellValue);
                // OJO: Verifica que el nombre de la columna en SQL sea exactamente "cDescripcion_ma_pr"
                txtMarcas.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["cDescripcion_ma_pr"].Value);
            }
        }
        private void SeleccionaItemCAPR()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.
                    Cells["IdCategoria"].Value)))//valida si el campo id Producto de la fila seleccionada esta vacia 
            {

                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                this.IdCategoria = Convert.ToInt32(DgvPrincipal.CurrentRow.
                    Cells["IdCategoria"].Value);
                TxtCategorias.Text = Convert.ToString(DgvPrincipal.CurrentRow.
                    Cells["cDescripcion_ca_pr"].Value);
            }
        }
        private void SeleccionaItemUMPR()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.
                    Cells["IdUniMed"].Value)))//valida si el campo id Producto de la fila seleccionada esta vacia 
            {

                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                this.IdCategoria = Convert.ToInt32(DgvPrincipal.CurrentRow.
                    Cells["IdUniMed"].Value);
                txtDescripPr.Text = Convert.ToString(DgvPrincipal.CurrentRow.
                    Cells["cDescripcion_um_pr"].Value);
            }
        }
        private void SeleccionaItemBOPR()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.
                    Cells["IdBodega"].Value)))//valida si el campo id Producto de la fila seleccionada esta vacia 
            {

                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                this.IdCategoria = Convert.ToInt32(DgvPrincipal.CurrentRow.
                    Cells["IdBodega"].Value);
                txtDescripPr.Text = Convert.ToString(DgvPrincipal.CurrentRow.
                    Cells["cIdProducto"].Value);
            }
        }
        #region Eventos del Formulario




        private void FrmProductos_Load(object sender, EventArgs e)
        {
            // Carga todas las categor�as (% = comod�n para traer todos los registros)
            this.ListadoPR("%");
            this.ListadoCAPR("%");
            this.ListadoMAPR("%");
            this.ListadoUMPR("%");
            this.ListadoStockActualPR(0);

            // Habilita los botones principales (Nuevo, Actualizar, Eliminar, etc.)
            this.EstadoBotonesPrincipales(true);

            // Oculta los botones de procesos (Guardar, Cancelar, Regresar)
            this.EstadoBotonesProcesos(false);

            // Bloquea el campo de texto para evitar ediciones no autorizadas
            txtDescripPr.ReadOnly = true;
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;
            this.EstadoBotonesPrincipales(false);
            this.EstadoBotonesProcesos(true);
            txtDescripPr.ReadOnly = false;
            TbpPrincipal.SelectedIndex = 1;
            TxtMinimo.Text = "0";
            TxtMaximo.Text = "0";
            txtDescripPr.Focus();
            Pnl_Stock_Bodega.Visible = false;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripPr.Text == String.Empty || txtMarcas.Text == String.Empty || TxtMedidas.Text == String.Empty || TxtCategorias.Text == String.Empty || Txt_pu_venta.Text == String.Empty || TxtMaximo.Text==String.Empty || TxtMinimo.Text == String.Empty )
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ET_Productos eT_Productos = new ET_Productos();
                string Rpta = "";
                eT_Productos.IdProducto = this.IdProducto;
                eT_Productos.DescripcionPr = txtDescripPr.Text.Trim();
                eT_Productos.IdMarca = this.IdMarca;
                eT_Productos.IdUnidMed = this.IdUniMed;
                eT_Productos.IdCategoria = this.IdCategoria;
                eT_Productos.StockMin = Convert.ToDecimal(TxtMinimo.Text);
                eT_Productos.StockMax = Convert.ToDecimal(TxtMaximo.Text);
                eT_Productos.Pu_venta= Convert.ToDecimal(Txt_pu_venta.Text);
                Rpta = BL_Productos.GuardarPR(EstadoGuarda, eT_Productos);
                if (Rpta == "OK")
                {
                    this.ListadoPR("%");
                    MessageBox.Show("Los datos se han registrado", "Aviso del sistema",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EstadoGuarda = 0;
                    this.EstadoBotonesPrincipales(true);
                    this.EstadoBotonesProcesos(false);
                    txtDescripPr.Text = "";
                    TxtMaximo.Text = "0";
                    TxtMinimo.Text = "0";
                    Txt_pu_venta.Text = "0";
                    txtDescripPr.ReadOnly = true;
                    TxtMaximo.ReadOnly = true;
                    TxtMinimo.ReadOnly = true;
                    Txt_pu_venta.ReadOnly = true;
                    TbpPrincipal.SelectedIndex = 0;
                    this.IdMarca = 0;
                    this.Pnl_Stock_Bodega.Visible = false;
                }
            }
        }

        #endregion

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.EstadoBotonesPrincipales(true);
            this.EstadoBotonesProcesos(false);
            TbpPrincipal.SelectedIndex = 0;
            this.IdCategoria = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 2;
            this.EstadoBotonesPrincipales(false);
            this.EstadoBotonesProcesos(true);
            this.SeleccionaItemPR();
            txtDescripPr.ReadOnly = false;
            TbpPrincipal.SelectedIndex = 1;
            TxtMaximo.ReadOnly = false;
            TxtMinimo.ReadOnly = false;
            Txt_pu_venta.ReadOnly = false;
            this.IdMarca = 0;
            txtDescripPr.Focus();
            Pnl_Stock_Bodega.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ListadoPR(TxtBuscar.Text.Trim());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.
                  Cells["IdProducto"].Value)))
            {

                MessageBox.Show("No se pudo seleccionar el registro ", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("�Esta seguro de eliminar el registro seleccionado?",
                    "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {

                    string Rpta = "";


                    this.IdProducto = Convert.ToInt32(DgvPrincipal.CurrentRow.
                    Cells["IdProducto"].Value);

                    Rpta = BL_Productos.EliminarPR(this.IdProducto);

                    if (Rpta.Equals("OK"))
                    {
                        this.ListadoPR("%");
                        this.IdProducto = 0;
                        MessageBox.Show("Resgistro eliminado", "Aviso del sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del sistema",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);// muestra el error del sistema (codigo)
                    }

                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnLupa1_Click(object sender, EventArgs e)
        {
            this.Pnl_Marca.Location = BtnLupa1.Location;
            this.Pnl_Marca.Visible = true;
        }

        private void BtnLupa2_Click(object sender, EventArgs e)
        {
            this.Pnl_Unid_med.Location = BtnLupa2.Location;
            this.Pnl_Unid_med.Visible = true;
        }

        private void BtnLupa3_Click(object sender, EventArgs e)
        {
            this.Pnl_Categorias.Location = BtnLupa3.Location;
            this.Pnl_Categorias.Visible = true;
        }

        private void DgvCategorias_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.SeleccionaItemCAPR();
            Pnl_Categorias.Visible = false;
        }

        private void DgvMarcas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.SeleccionaItemMAPR();
            Pnl_Marca.Visible = false;
        }
        private void DgvPrincipal_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionaItem();
            this.EstadoBotonesProcesos(false);
            TbpPrincipal.SelectedIndex = 1;
            this.ListadoStockActualPR(this.IdProducto);
            this.Pnl_Stock_Bodega.Visible = true;
        }
    }
}
