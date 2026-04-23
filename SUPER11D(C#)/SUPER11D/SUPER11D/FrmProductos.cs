// Referencia a la capa de Lógica de Negocio
using BL;
// Referencia a la capa de Entidades
using ET;

namespace SUPER11D
{
    /// <summary>
    /// Formulario para gestionar las categorías del sistema.
    /// Permite listar, crear, actualizar y eliminar categorías.
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
        // 0 = Sin acción
        // 1 = Insertar nueva categoría
        // 2 = Actualizar categoría existente
        int EstadoGuarda = 0;

        // Almacena el ID de la categoría seleccionada para edición
        // 0 = Nueva categoría
        // >0 = Categoría existente
        int IdCategoria = 0;

        #endregion

        #region Mis Métodos

        /// <summary>
        /// Configura el formato de las columnas del DataGridView.
        /// Define el ancho y los encabezados de las columnas que se mostrarán.
        /// </summary>
        private void FormatoCA()
        {
            // Verifica que existan al menos 2 columnas antes de formatear
            if (DgvPrincipal.Columns.Count >= 2)
            {
                // Columna 0: ID de la categoría
                DgvPrincipal.Columns[0].Width = 100;
                DgvPrincipal.Columns[0].HeaderText = "ID Categoria";

                // Columna 1: Descripción de la categoría
                DgvPrincipal.Columns[1].Width = 100;
                DgvPrincipal.Columns[1].HeaderText = "Categoria";
            }
        }

        /// Carga y muestra el listado de categorías en el DataGridView.
        /// Ejecuta una consulta a la base de datos a través de las capas BL y DAL.
        /// <param name="ctexto">Texto de búsqueda para filtrar categorías. 
        /// Usar "%" para mostrar todas las categorías.</param>
        private void ListadoCA(string ctexto)
        {
            try
            {
                // Llama a la capa de negocio para obtener los datos
                // y los asigna como origen de datos del DataGridView
                DgvPrincipal.DataSource = BL_Categoria.ListadoCA(ctexto);

                // Aplica el formato a las columnas del DataGridView
                this.FormatoCA();
            }
            catch (Exception ex)
            {
                // Captura cualquier error y lo muestra al usuario
                // con detalles para facilitar la depuración
                MessageBox.Show($"Error al cargar datos: {ex.Message}\n\nStackTrace: {ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// Controla el estado (habilitado/deshabilitado) de los botones principales del formulario.
        /// <param name="LEstado">true = habilita los botones, false = deshabilita los botones</param>
        private void EstadoBotonesPrincipales(bool LEstado)
        {
            // Habilita o deshabilita los botones de acciones principales
            this.btnNuevo.Enabled = LEstado;
            this.btnActualizar.Enabled = LEstado;
            this.btnEliminar.Enabled = LEstado;
            this.btnReporte.Enabled = LEstado;
            this.btnSalir.Enabled = LEstado;
        }


        /// Controla la visibilidad de los botones de procesos (Guardar, Cancelar, Regresar).

        /// name="LEstado">true = muestra los botones, false = oculta los botones
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
                Cells["DescripcionCa"].Value);
            }
        }
        #region Eventos del Formulario


        /// Evento que se ejecuta cuando el formulario se carga por primera vez.
        /// Inicializa el estado del formulario y carga los datos iniciales.

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            // Carga todas las categorías (% = comodín para traer todos los registros)
            this.ListadoCA("%");

            // Habilita los botones principales (Nuevo, Actualizar, Eliminar, etc.)
            this.EstadoBotonesPrincipales(true);

            // Oculta los botones de procesos (Guardar, Cancelar, Regresar)
            this.EstadoBotonesProcesos(false);

            // Bloquea el campo de texto para evitar ediciones no autorizadas
            txtDescripPr.ReadOnly = true;
        }


        /// Evento del botón Nuevo.
        /// Prepara el formulario para ingresar una nueva categoría.
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Establece el estado a 1 (Insertar nueva categoría)
            EstadoGuarda = 1;

            // Deshabilita los botones principales para evitar conflictos
            this.EstadoBotonesPrincipales(false);

            // Muestra los botones de proceso (Guardar, Cancelar, Regresar)
            this.EstadoBotonesProcesos(true);

            // Limpia el campo de texto
            txtDescripPr.Text = "";

            // Habilita el campo de texto para permitir la escritura
            txtDescripPr.ReadOnly = false;

            // Cambia a la pestaña de Mantenimiento (índice 1)
            TbpPrincipal.SelectedIndex = 1;

            // Coloca el cursor en el campo de texto para que el usuario pueda escribir inmediatamente
            txtDescripPr.Focus();
        }

        /// Evento del botón Guardar.
        /// Valida y guarda la categoría (nueva o actualizada) en la base de datos.

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Valida que el campo de descripción no esté vacío
            if (txtDescripPr.Text == String.Empty)
            {
                // Muestra un mensaje de advertencia si no se ingresó descripción
                MessageBox.Show("Debe ingresar una descripción para el producto",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Crea una instancia de la entidad Categoría
                ET_Categoria eT_Categoria = new ET_Categoria();

                // Variable para almacenar la respuesta del proceso de guardado
                string Rpta = "";

                // Asigna el ID de la categoría (0 para nueva, >0 para actualizar)
                eT_Categoria.IdCategoria = IdCategoria;

                // Asigna la descripción ingresada, eliminando espacios al inicio y final
                eT_Categoria.DescripcionCat = txtDescripPr.Text.Trim();

                // Llama al método de la capa de negocio para guardar la categoría
                // EstadoGuarda indica si es inserción (1) o actualización (2)
                Rpta = BL_Categoria.GuardarCA(EstadoGuarda, eT_Categoria);

                // Verifica si el guardado fue exitoso
                if (Rpta == "OK")
                {
                    // Recarga el listado de categorías para mostrar los cambios
                    this.ListadoCA("%");

                    // Muestra mensaje de confirmación al usuario
                    MessageBox.Show("Los datos se guardaron correctamente",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Restablece el estado de guardado a 0 (sin acción)
                    EstadoGuarda = 0;

                    // Habilita los botones principales nuevamente
                    this.EstadoBotonesPrincipales(true);

                    // Oculta los botones de procesos
                    this.EstadoBotonesProcesos(false);

                    // Limpia el campo de texto
                    txtDescripPr.Text = "";

                    // Bloquea el campo de texto
                    txtDescripPr.ReadOnly = true;

                    // Regresa a la pestaña de Listado (índice 0)
                    TbpPrincipal.SelectedIndex = 0;

                    // Reinicia el ID de categoría a 0
                    this.IdCategoria = 0;
                }
                else
                {
                    // Si hubo un error, muestra el mensaje de error recibido
                    MessageBox.Show($"Error al guardar los datos: {Rpta}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.SeleccionaItem();
            txtDescripPr.ReadOnly = false;
            TbpPrincipal.SelectedIndex = 1;
            txtDescripPr.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ListadoCA(TxtBuscar.Text.Trim());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.
                  Cells["IdCategoria"].Value)))//valida si el campo id categoria de la fila seleccionada esta vacia 
            {

                MessageBox.Show("No se pudo seleccionar el registro ", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Esta seguro de eliminar el registro seleccionado?",
                    "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {

                    string Rpta = "";


                    this.IdCategoria = Convert.ToInt32(DgvPrincipal.CurrentRow.
                    Cells["IdCategoria"].Value);

                    Rpta = BL_Categoria.ElminarCA(this.IdCategoria);

                    if (Rpta.Equals("OK"))
                    {
                        ListadoCA("%");
                        this.IdCategoria = 0;
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
    }
}
