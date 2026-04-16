using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
        #region Mis variables globales
        int codigo_sp = 0;
        int Codigo_tde;
        int Codigo_cl = 0;
        int EstadoGuarda = 0;
        int IdProducto = 0;

        DataTable TablaDetalle = new DataTable();
        #endregion

        #region Mis Metodos


        private void Formato_sp()
        {
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
            DgvPrincipal.Columns[7].Visible = false;
            DgvPrincipal.Columns[8].Visible = false;
            DgvPrincipal.Columns[9].Visible = false;
            DgvPrincipal.Columns[10].Visible = false;
            DgvPrincipal.Columns[11].Visible = false;

        }
        private void Formato_detalle()
        {
            Dgv_Detalle.Columns[0].Width = 250;
            Dgv_Detalle.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Detalle.Columns[1].Width = 150;
            Dgv_Detalle.Columns[1].HeaderText = "MARCA";
            Dgv_Detalle.Columns[2].Width = 90;
            Dgv_Detalle.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_Detalle.Columns[3].Width = 90;
            Dgv_Detalle.Columns[3].HeaderText = "CANTIDAD";
            Dgv_Detalle.Columns[4].Width = 90;
            Dgv_Detalle.Columns[4].HeaderText = "PRECIO";
            Dgv_Detalle.Columns[5].Width = 90;
            Dgv_Detalle.Columns[5].HeaderText = "TOTAL";
            Dgv_Detalle.Columns[6].Visible = false;
            Dgv_Detalle.Columns[0].ReadOnly = true;
            Dgv_Detalle.Columns[1].ReadOnly = true;
            Dgv_Detalle.Columns[2].ReadOnly = true;
            Dgv_Detalle.Columns[3].ReadOnly = true;
            Dgv_Detalle.Columns[4].ReadOnly = true;
            Dgv_Detalle.Columns[5].ReadOnly = true;
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
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.
                Cells["codigo_sp"].Value)))//valida si el campo id Producto de la fila seleccionada esta vacia
            {

                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                this.codigo_sp = Convert.ToInt32(DgvPrincipal.CurrentRow.
                        Cells["codigo_sp"].Value);
                this.Codigo_tde = Convert.ToInt32(DgvPrincipal.CurrentRow.
                Cells["codigo_tde"].Value);
                this.Codigo_cl = Convert.ToInt32(DgvPrincipal.CurrentRow.
                Cells["codigo_cl"].Value);
                Txt_descripcion_tde.Text = DgvPrincipal.CurrentRow.Cells["Descripcion_tde"].Value.ToString();
                Txt_nrodocumento_sp.Text = DgvPrincipal.CurrentRow.Cells["Descripcion_sp"].Value.ToString();
                DtpFechaVenta.Value = Convert.ToDateTime(DgvPrincipal.CurrentRow.Cells["fecha_sp"].Value);
                Txt_razon_social_cli.Text = DgvPrincipal.CurrentRow.Cells["Razon_social_cl"].Value.ToString();
                Txt_observaciones_sp.Text = DgvPrincipal.CurrentRow.Cells["observacion_sp"].Value.ToString();
            }
        }
        private void Crear_TablaDetalle()
        {
            this.TablaDetalle = new DataTable("TablaDetalle");
            this.TablaDetalle.Columns.Add("descripcion_pr", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("descripcion_ma", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("descripcion_um", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("cantidad", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("pu_venta", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("total", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("codigo_pr", System.Type.GetType("System.Int32"));
            this.TablaDetalle.AcceptChanges();
            Dgv_Detalle.DataSource = this.TablaDetalle;
            this.Formato_detalle();
        }
        private void Agregar_item(string xDescripcionPr, string xDescripcionMa, string xDescipcionuN, decimal xCantidad, decimal xPu_venta, decimal xTotal, int nIdProducto)
        {
            DataRow xFila = TablaDetalle.NewRow();
            xFila["descripcion_pr"] = xDescripcionPr;
            xFila["descripcion_ma"] = xDescripcionMa;
            xFila["descripcion_um"] = xDescipcionuN;
            xFila["cantidad"] = xCantidad;
            xFila["pu_venta"] = xPu_venta;
            xFila["total"] = xTotal;
            xFila["codigo_pr"] = nIdProducto;
            this.TablaDetalle.Rows.Add(xFila);
            TablaDetalle.AcceptChanges();
        }
        private void Selecciona_pr()
        {
            if (string.IsNullOrEmpty(Convert: ToString(Dgv_Productos.CurrentRow.Cells["IdProducto"].Value)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string xDescripcion_pr;
                string xDescripcion_ma;
                string xDescripcion_um;
                decimal xCantidad;
                decimal xPu_venta;
                decimal xTotal;
                this.IdProducto = Convert.ToInt32(Dgv_Productos.CurrentRow.Cells["IdProducto"].Value);
                bool Agregar = true;
                foreach (DataRow FilaTemp in TablaDetalle.Rows)
                {
                    if (Convert.ToInt32(FilaTemp["codigo_pr"] == IdProducto))
                    {
                        Agregar = false;
                        MessageBox.Show("El producto ya se encuentra agregado", "Aviso del sistema");
                    }
                }
                if (Agregar == true)
                {
                    xDescripcion_pr = Convert.ToString(Dgv_Productos.CurrentRow.Cells["DescripcionPR"].Value);
                    xDescripcion_ma = Convert.ToString(Dgv_Productos.CurrentRow.Cells["DescripcionMa"].Value);
                    xDescripcion_um = Convert.ToString(Dgv_Productos.CurrentRow.Cells["DescripcionUn"].Value);
                    xCantidad = Convert.ToDecimal(Dgv_Productos.CurrentRow.Cells["StockAnual"].Value);
                    xPu_venta = Convert.ToDecimal(Dgv_Productos.CurrentRow.Cells["Pu_venta"].Value);
                    xTotal = decimal.Round(xCantidad * xPu_venta, 2);
                    this.Agregar_item(xDescripcion_pr, xDescripcion_ma, xDescripcion_um, xCantidad, xPu_venta, xTotal, IdProducto);
                }
            }
        }
        private void Formato_pr()
        {
            Dgv_Productos.Columns[0].Width = 250;
            Dgv_Productos.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Productos.Columns[1].Width = 150;
            Dgv_Productos.Columns[1].HeaderText = "MARCA";
            Dgv_Productos.Columns[2].Width = 90;
            Dgv_Productos.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_Productos.Columns[3].Width = 90;
            Dgv_Productos.Columns[3].HeaderText = "CANTIDAD";
            Dgv_Productos.Columns[4].Width = 90;
            Dgv_Productos.Columns[4].HeaderText = "PRECIO";
            Dgv_Productos.Columns[5].Width = 90;
            Dgv_Productos.Columns[5].HeaderText = "TOTAL";
            Dgv_Productos.Columns[6].Visible = false;
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
        #endregion

        #region Action del sistema



        private void Txt_observaciones_sp_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
