using System;
using System.Data;
using System.Windows.Forms;
using BL;
using ET;

namespace GUI
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        #region Campos
        int codigo_sp = 0;
        int Codigo_tde = 0;
        int Codigo_cl = 0;
        int EstadoGuarda = 0;
        int IdProducto = 0;

        DataTable TablaDetalle = new DataTable();
        #endregion

        #region Métodos de formato / listado / selección

        private void Formato_sp()
        {
            if (DgvPrincipal.Columns.Count < 7) return;

            DgvPrincipal.Columns[0].Width = 85;
            DgvPrincipal.Columns[0].HeaderText = "CODIGO_SP";
            DgvPrincipal.Columns[1].Width = 95;
            DgvPrincipal.Columns[1].HeaderText = "TIPO DOC";
            DgvPrincipal.Columns[2].Width = 110;
            DgvPrincipal.Columns[2].HeaderText = "NRO DOC";
            DgvPrincipal.Columns[3].Width = 80;
            DgvPrincipal.Columns[3].HeaderText = "FECHA DOC";
            DgvPrincipal.Columns[4].Width = 100;
            DgvPrincipal.Columns[4].HeaderText = "NRO. DOC.CLI";
            DgvPrincipal.Columns[5].Width = 80;
            DgvPrincipal.Columns[5].HeaderText = "CLIENTE";
            DgvPrincipal.Columns[6].Width = 80;
            DgvPrincipal.Columns[6].HeaderText = "TOTAL IMPORTE";

            // Ocultar columnas extras si existen
            for (int i = 7; i < DgvPrincipal.Columns.Count; i++)
            {
                DgvPrincipal.Columns[i].Visible = false;
            }
        }

        private void Listado_sp(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = BL_Ventas.Listado_sp(cTexto);
                this.Formato_sp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void SeleccionaItemMaPR()
        {
            if (DgvPrincipal.CurrentRow == null) return;

            var cell = DgvPrincipal.CurrentRow.Cells["codigo_sp"];
            if (cell == null || string.IsNullOrEmpty(Convert.ToString(cell.Value)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                this.codigo_sp = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["codigo_sp"].Value);
                this.Codigo_tde = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["codigo_tde"].Value);
                this.Codigo_cl = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["codigo_cl"].Value);

                Txt_descripcion_tde.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion_tde"].Value);
                Txt_nrodocumento_sp.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion_sp"].Value);
                DtpFechaVenta.Value = Convert.ToDateTime(DgvPrincipal.CurrentRow.Cells["fecha_sp"].Value);
                Txt_razon_social_cli.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Razon_social_cl"].Value);
                Txt_observaciones_sp.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["observacion_sp"].Value);
                Txt_subtotal.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["subtotal"].Value);
                Txt_iva.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Iva"].Value);
                Txt_total_importe.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["total_importe"].Value);

                // Cargar detalle
                Dgv_Detalle.DataSource = BL_Ventas.Listado_Detalle_sp(this.codigo_sp);
                this.Formato_detalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar: " + ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato_detalle()
        {
            if (Dgv_Detalle.Columns.Count < 6) return;

            Dgv_Detalle.Columns[0].Width = 250;
            Dgv_Detalle.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Detalle.Columns[1].Width = 150;
            Dgv_Detalle.Columns[1].HeaderText = "MARCA";
            Dgv_Detalle.Columns[2].Width = 90;
            Dgv_Detalle.Columns[2].HeaderText = "U. MEDIDA";
            Dgv_Detalle.Columns[3].Width = 90;
            Dgv_Detalle.Columns[3].HeaderText = "CANTIDAD";
            Dgv_Detalle.Columns[4].Width = 90;
            Dgv_Detalle.Columns[4].HeaderText = "PRECIO";
            Dgv_Detalle.Columns[5].Width = 90;
            Dgv_Detalle.Columns[5].HeaderText = "TOTAL";

            // Marcar columnas como lectura por defecto
            for (int i = 0; i <= 5 && i < Dgv_Detalle.Columns.Count; i++)
            {
                Dgv_Detalle.Columns[i].ReadOnly = true;
            }

            // Ocultar columnas extras si existen
            for (int i = 6; i < Dgv_Detalle.Columns.Count; i++)
            {
                Dgv_Detalle.Columns[i].Visible = false;
            }
        }

        private void EstadoBotonesPrincipales(bool LEstado)
        {
            this.btnNuevo.Enabled = LEstado;
            this.btnActualizar.Enabled = LEstado;
            this.btnEliminar.Enabled = LEstado;
            this.btnReporte.Enabled = LEstado;
            this.btnSalir.Enabled = LEstado;
        }

        private void EstadoBotonesProcesos(bool LEstado)
        {
            this.btnCancelar.Visible = LEstado;
            this.btnGuardar.Visible = LEstado;
            this.btnRegresar.Visible = LEstado;
            this.Btn_Agregar.Visible = LEstado;
            this.Btn_Quitar.Visible = LEstado;
            this.BtnLupa1.Visible = LEstado;
            this.BtnLupa2.Visible = LEstado;
        }

        private void Crear_tablaDetalle()
        {
            this.TablaDetalle = new DataTable("TablaDetalle");
            this.TablaDetalle.Columns.Add("descripcion_pr", typeof(string));
            this.TablaDetalle.Columns.Add("descripcion_ma", typeof(string));
            this.TablaDetalle.Columns.Add("descripcion_um", typeof(string));
            this.TablaDetalle.Columns.Add("cantidad", typeof(decimal));
            this.TablaDetalle.Columns.Add("pu_venta", typeof(decimal));
            this.TablaDetalle.Columns.Add("total", typeof(decimal));
            this.TablaDetalle.Columns.Add("codigo_pr", typeof(int));
            this.TablaDetalle.AcceptChanges();

            Dgv_Detalle.DataSource = this.TablaDetalle;
            this.Formato_detalle();
        }

        private void Agregar_item(
            string xDescripcionPr,
            string xDescripcionMa,
            string xDescripcionuN,
            decimal xCantidad,
            decimal xPu_venta,
            decimal xTotal,
            int nIdProducto)
        {
            DataRow xFila = TablaDetalle.NewRow();

            xFila["descripcion_pr"] = xDescripcionPr;
            xFila["descripcion_ma"] = xDescripcionMa;
            xFila["descripcion_um"] = xDescripcionuN;
            xFila["cantidad"] = xCantidad;
            xFila["pu_venta"] = xPu_venta;
            xFila["total"] = xTotal;
            xFila["codigo_pr"] = nIdProducto;

            this.TablaDetalle.Rows.Add(xFila);
            TablaDetalle.AcceptChanges();
        }

        private void Selecciona_pr()
        {
            // Implementar selección directa si se necesita (por ejemplo doble click en Dgv_Productos)
            // Actualmente la lógica de agregar producto se ejecuta desde Txt_observaciones_sp_TextChanged en el original,
            // pero eso es poco intuitivo. Si prefieres que el doble clic de Dgv_Productos agregue el producto,
            // mueve la lógica de agregación aquí y llama a este método desde Dgv_Productos_DoubleClick.
        }

        #endregion

        #region Clientes / Productos / Tipo Documento

        private void Formato_pr()
        {
            if (Dgv_Productos.Columns.Count < 6) return;

            Dgv_Productos.Columns[0].Width = 180;
            Dgv_Productos.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Productos.Columns[1].Width = 100;
            Dgv_Productos.Columns[1].HeaderText = "MARCA";
            Dgv_Productos.Columns[2].Width = 70;
            Dgv_Productos.Columns[2].HeaderText = "U. MEDIDA";
            Dgv_Productos.Columns[3].Width = 110;
            Dgv_Productos.Columns[3].HeaderText = "CATEGORIA";
            Dgv_Productos.Columns[4].Width = 60;
            Dgv_Productos.Columns[4].HeaderText = "STOCK ACTUAL";
            Dgv_Productos.Columns[5].Width = 60;
            Dgv_Productos.Columns[5].HeaderText = "PRECIO";

            for (int i = 6; i < Dgv_Productos.Columns.Count; i++)
                Dgv_Productos.Columns[i].Visible = false;
        }

        private void Listado_pr(string cTexto)
        {
            try
            {
                Dgv_Productos.DataSource = BL_Ventas.Listado_pr_sp(cTexto);
                this.Formato_pr();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato_cl()
        {
            if (DgvCliente.Columns.Count < 3) return;

            DgvCliente.Columns[0].Width = 180;
            DgvCliente.Columns[0].HeaderText = "CLIENTE";
            DgvCliente.Columns[1].Width = 100;
            DgvCliente.Columns[1].HeaderText = "TIPO DOC";
            DgvCliente.Columns[2].Width = 70;
            DgvCliente.Columns[2].HeaderText = "No. DOC";

            for (int i = 3; i < DgvCliente.Columns.Count; i++)
                DgvCliente.Columns[i].Visible = false;
        }

        private void Listado_cl(string cTexto)
        {
            try
            {
                DgvCliente.DataSource = BL_Ventas.Listado_cl_sp(cTexto);
                this.Formato_cl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void SeleccionaItem_cl()
        {
            if (DgvCliente.CurrentRow == null)
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cell = DgvCliente.CurrentRow.Cells["IdCliente"];
            if (cell == null || string.IsNullOrEmpty(Convert.ToString(cell.Value)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                this.Codigo_cl = Convert.ToInt32(DgvCliente.CurrentRow.Cells["IdCliente"].Value);
                Txt_nroducmento_cl.Text = Convert.ToString(DgvCliente.CurrentRow.Cells["NroDocumento"].Value);
                Txt_razon_social_cli.Text = Convert.ToString(DgvCliente.CurrentRow.Cells["RazonSocial"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar cliente: " + ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato_tde()
        {
            if (Dgv_tipo_tde.Columns.Count == 0) return;
            Dgv_tipo_tde.Columns[0].Width = 200;
            Dgv_tipo_tde.Columns[0].HeaderText = "TIPO DE DOCUMENTO";
            if (Dgv_tipo_tde.Columns.Count > 1)
                Dgv_tipo_tde.Columns[1].Visible = false;
        }

        private void Listado_tde(string cTexto)
        {
            try
            {
                Dgv_tipo_tde.DataSource = BL_Ventas.Listado_tde(cTexto);
                this.Formato_tde();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_tde()
        {
            if (Dgv_tipo_tde.CurrentRow == null)
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cell = Dgv_tipo_tde.CurrentRow.Cells["Codigo_tde"];
            if (cell == null || string.IsNullOrEmpty(Convert.ToString(cell.Value)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                this.Codigo_tde = Convert.ToInt32(Dgv_tipo_tde.CurrentRow.Cells["Codigo_tde"].Value);
                Txt_descripcion_tde.Text = Convert.ToString(Dgv_tipo_tde.CurrentRow.Cells["Descripcion_tde"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar tipo de documento: " + ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Utilitarios

        private void Estado_texto(bool LEstado)
        {
            Txt_nrodocumento_sp.ReadOnly = LEstado;
            Txt_observaciones_sp.ReadOnly = LEstado;
            DtpFechaVenta.Enabled = !LEstado ? true : false;
        }

        private void Limpia_texto()
        {
            Txt_nrodocumento_sp.Text = "";
            Txt_observaciones_sp.Text = "";
            Txt_subtotal.Text = "";
            Txt_iva.Text = "";
            Txt_total_importe.Text = "";
            this.Crear_tablaDetalle();
        }

        private void Calcular_totales()
        {
            decimal nSubtotal = 0;
            decimal nIva = 0;
            decimal nTotal = 0;

            if (TablaDetalle == null || TablaDetalle.Rows.Count == 0)
            {
                Txt_subtotal.Text = "0.00";
                Txt_iva.Text = "0.00";
                Txt_total_importe.Text = "0.00";
                return;
            }

            TablaDetalle.AcceptChanges();
            foreach (DataRow FilaTemp in TablaDetalle.Rows)
            {
                nTotal += Convert.ToDecimal(FilaTemp["total"]);
            }

            nTotal = decimal.Round(nTotal, 2);
            nSubtotal = nTotal / (1 + Convert.ToDecimal("0.13"));
            nIva = (nTotal - nSubtotal);

            Txt_subtotal.Text = decimal.Round(nSubtotal, 2).ToString("#0.00");
            Txt_iva.Text = decimal.Round(nIva, 2).ToString("#0.00");
            Txt_total_importe.Text = decimal.Round(nTotal, 2).ToString("#0.00");
        }

        #endregion

        #region Eventos del formulario / controles

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            this.Listado_sp("%");
            this.Listado_tde("%");
            this.Listado_cl("%");
            this.Listado_pr("%");
            this.Crear_tablaDetalle();
            this.EstadoBotonesProcesos(false);
            this.EstadoBotonesPrincipales(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;
            this.EstadoBotonesPrincipales(false);
            this.EstadoBotonesProcesos(true);
            this.Limpia_texto();

            // permitir edición de cantidad en detalle
            if (Dgv_Detalle.Columns.Count > 3)
                Dgv_Detalle.Columns[3].ReadOnly = false;

            this.Estado_texto(false);
            TbpPrincipal.SelectedIndex = 0;
            Txt_nrodocumento_sp.Focus();
        }

        private void BtnLupa2_Click(object sender, EventArgs e)
        {
            // Mostrar listado tipos documento
            this.Pnl_Listado_tde.Location = BtnLupa2.Location;
            this.Pnl_Listado_tde.Visible = true;
        }

        private void Dgv_tipo_tde_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_tde();
            Pnl_Listado_tde.Visible = false;
        }

        private void BtnLupa1_Click(object sender, EventArgs e)
        {
            // Mostrar listado clientes
            this.Pnl_Cliente.Location = BtnLupa1.Location;
            Pnl_Cliente.Visible = true;
        }

        private void DgvCliente_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionaItem_cl();
            Pnl_Cliente.Visible = false;
        }

        private void Dgv_Productos_DoubleClick(object sender, EventArgs e)
        {
            // Si se quiere, se puede agregar el producto al detalle al doble clic
            if (Dgv_Productos.CurrentRow == null) return;

            try
            {
                // Obtener datos con nombres esperados; si no existen, evitar excepción
                int idProd = 0;
                decimal cantidad = 1;
                decimal pu_venta = 0;
                string descPr = "";
                string descMa = "";
                string descUn = "";

                if (Dgv_Productos.Columns["IdProducto"] != null && Dgv_Productos.CurrentRow.Cells["IdProducto"].Value != null)
                    idProd = Convert.ToInt32(Dgv_Productos.CurrentRow.Cells["IdProducto"].Value);
                else if (Dgv_Productos.CurrentRow.Cells.Count > 0)
                    idProd = Convert.ToInt32(Dgv_Productos.CurrentRow.Cells[0].Value);

                if (Dgv_Productos.Columns["StockAnual"] != null && Dgv_Productos.CurrentRow.Cells["StockAnual"].Value != null)
                    cantidad = Convert.ToDecimal(Dgv_Productos.CurrentRow.Cells["StockAnual"].Value);
                if (Dgv_Productos.Columns["Pu_venta"] != null && Dgv_Productos.CurrentRow.Cells["Pu_venta"].Value != null)
                    pu_venta = Convert.ToDecimal(Dgv_Productos.CurrentRow.Cells["Pu_venta"].Value);
                if (Dgv_Productos.Columns["DescripcionPR"] != null && Dgv_Productos.CurrentRow.Cells["DescripcionPR"].Value != null)
                    descPr = Convert.ToString(Dgv_Productos.CurrentRow.Cells["DescripcionPR"].Value);
                if (Dgv_Productos.Columns["DescripcionMa"] != null && Dgv_Productos.CurrentRow.Cells["DescripcionMa"].Value != null)
                    descMa = Convert.ToString(Dgv_Productos.CurrentRow.Cells["DescripcionMa"].Value);
                if (Dgv_Productos.Columns["DescripcionUn"] != null && Dgv_Productos.CurrentRow.Cells["DescripcionUn"].Value != null)
                    descUn = Convert.ToString(Dgv_Productos.CurrentRow.Cells["DescripcionUn"].Value);

                decimal total = decimal.Round(cantidad * pu_venta, 2);

                // Evitar duplicados
                bool Agregar = true;
                foreach (DataRow Filatemp in TablaDetalle.Rows)
                {
                    if (Convert.ToInt32(Filatemp["codigo_pr"]) == idProd)
                    {
                        Agregar = false;
                        MessageBox.Show("El producto ya se encuentra agregado", "Aviso del sistema");
                        break;
                    }
                }

                if (Agregar)
                {
                    this.Agregar_item(descPr, descMa, descUn, cantidad, pu_venta, total, idProd);
                    this.Calcular_totales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Pnl_Listado_pr.Visible = false;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            this.Pnl_Listado_pr.Visible = true;
            this.Pnl_Listado_pr.Location = BtnLupa2.Location;
            Txt_Buscar3.Focus();
        }

        private void Dgv_Detalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.EstadoGuarda == 1 && TablaDetalle != null && e.RowIndex >= 0 && e.RowIndex < TablaDetalle.Rows.Count)
            {
                DataRow yFila = TablaDetalle.Rows[e.RowIndex];
                decimal yCantidad = Convert.ToDecimal(yFila["cantidad"]);
                decimal yPuVenta = Convert.ToDecimal(yFila["pu_venta"]);
                yFila["total"] = decimal.Round(yCantidad * yPuVenta, 2);
                this.Calcular_totales();
            }
        }

        private void Btn_Quitar_Click(object sender, EventArgs e)
        {
            if (Dgv_Detalle.Rows.Count > 0 && Dgv_Detalle.CurrentRow != null)
            {
                try
                {
                    int idx = Dgv_Detalle.CurrentRow.Index;
                    Dgv_Detalle.Rows.RemoveAt(idx);
                    TablaDetalle.AcceptChanges();
                    this.Calcular_totales();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo quitar el elemento: " + ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_observaciones_sp_TextChanged(object sender, EventArgs e)
        {
            // Nota: en el diseñador este evento está conectado; aquí lo dejamos seguro para que no provoque errores.
            // No realizaremos acciones inesperadas al escribir en el textbox, solo validaciones mínimas.
            // Si se requiere agregar productos desde otro control, mover la lógica a Dgv_Productos_DoubleClick o un botón.
            // Por ahora, simplemente nohacer nada para evitar comportamiento inesperado.
        }

        #endregion
    }
}
