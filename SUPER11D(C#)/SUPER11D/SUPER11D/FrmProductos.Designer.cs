namespace SUPER11D
{
    partial class FrmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TbpPrincipal = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            TxtBuscar = new TextBox();
            label1 = new Label();
            DgvPrincipal = new DataGridView();
            tabPage2 = new TabPage();
            Txt_pu_venta = new TextBox();
            TxtMaximo = new TextBox();
            TxtMinimo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            Pnl_Stock_Bodega = new GroupBox();
            DgvBodega = new DataGridView();
            TxtCategorias = new TextBox();
            label5 = new Label();
            BtnLupa3 = new Button();
            TxtMedidas = new TextBox();
            label4 = new Label();
            BtnLupa2 = new Button();
            textMarca = new TextBox();
            label3 = new Label();
            btnRegresar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            BtnLupa1 = new Button();
            txtDescripPr = new TextBox();
            label2 = new Label();
            btnNuevo = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnReporte = new Button();
            btnSalir = new Button();
            Pnl_Unid_med = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            textBox5 = new TextBox();
            label10 = new Label();
            DgvMedidas = new DataGridView();
            Pnl_Categorias = new GroupBox();
            btnRetorna3 = new Button();
            btnBuscar3 = new Button();
            textBox4 = new TextBox();
            label9 = new Label();
            DgvCategorias = new DataGridView();
            Pnl_Marca = new GroupBox();
            btnRetorna1 = new Button();
            btnBuscar1 = new Button();
            txtMarcas = new TextBox();
            label11 = new Label();
            DgvMarcas = new DataGridView();
            TbpPrincipal.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPrincipal).BeginInit();
            tabPage2.SuspendLayout();
            Pnl_Stock_Bodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBodega).BeginInit();
            Pnl_Unid_med.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMedidas).BeginInit();
            Pnl_Categorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).BeginInit();
            Pnl_Marca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMarcas).BeginInit();
            SuspendLayout();
            // 
            // TbpPrincipal
            // 
            TbpPrincipal.Controls.Add(tabPage1);
            TbpPrincipal.Controls.Add(tabPage2);
            TbpPrincipal.Location = new Point(12, 12);
            TbpPrincipal.Name = "TbpPrincipal";
            TbpPrincipal.SelectedIndex = 0;
            TbpPrincipal.Size = new Size(1078, 305);
            TbpPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(TxtBuscar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(DgvPrincipal);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1070, 277);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(329, 16);
            button3.Name = "button3";
            button3.Size = new Size(77, 30);
            button3.TabIndex = 7;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(79, 21);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(224, 23);
            TxtBuscar.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 5;
            label1.Text = "Buscar :";
            // 
            // DgvPrincipal
            // 
            DgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPrincipal.Location = new Point(20, 62);
            DgvPrincipal.Name = "DgvPrincipal";
            DgvPrincipal.Size = new Size(1027, 198);
            DgvPrincipal.TabIndex = 4;
            DgvPrincipal.DoubleClick += DgvPrincipal_DoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Txt_pu_venta);
            tabPage2.Controls.Add(TxtMaximo);
            tabPage2.Controls.Add(TxtMinimo);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(Pnl_Stock_Bodega);
            tabPage2.Controls.Add(TxtCategorias);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(BtnLupa3);
            tabPage2.Controls.Add(TxtMedidas);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(BtnLupa2);
            tabPage2.Controls.Add(textMarca);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnRegresar);
            tabPage2.Controls.Add(btnGuardar);
            tabPage2.Controls.Add(btnCancelar);
            tabPage2.Controls.Add(BtnLupa1);
            tabPage2.Controls.Add(txtDescripPr);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1070, 277);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mantenimiento";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Txt_pu_venta
            // 
            Txt_pu_venta.Location = new Point(282, 165);
            Txt_pu_venta.Name = "Txt_pu_venta";
            Txt_pu_venta.Size = new Size(90, 23);
            Txt_pu_venta.TabIndex = 27;
            // 
            // TxtMaximo
            // 
            TxtMaximo.Location = new Point(154, 165);
            TxtMaximo.Name = "TxtMaximo";
            TxtMaximo.Size = new Size(76, 23);
            TxtMaximo.TabIndex = 26;
            // 
            // TxtMinimo
            // 
            TxtMinimo.Location = new Point(27, 165);
            TxtMinimo.Name = "TxtMinimo";
            TxtMinimo.Size = new Size(71, 23);
            TxtMinimo.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(282, 147);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 24;
            label8.Text = "Precio Ventas(*)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(154, 147);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 23;
            label7.Text = "stock Max.(*)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 147);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 22;
            label6.Text = "stock Min.(*)";
            // 
            // Pnl_Stock_Bodega
            // 
            Pnl_Stock_Bodega.Controls.Add(DgvBodega);
            Pnl_Stock_Bodega.ForeColor = SystemColors.ActiveCaptionText;
            Pnl_Stock_Bodega.Location = new Point(627, 25);
            Pnl_Stock_Bodega.Name = "Pnl_Stock_Bodega";
            Pnl_Stock_Bodega.Size = new Size(403, 214);
            Pnl_Stock_Bodega.TabIndex = 21;
            Pnl_Stock_Bodega.TabStop = false;
            Pnl_Stock_Bodega.Text = "Estado de stock en bodega";
            // 
            // DgvBodega
            // 
            DgvBodega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBodega.Location = new Point(23, 27);
            DgvBodega.Name = "DgvBodega";
            DgvBodega.Size = new Size(362, 167);
            DgvBodega.TabIndex = 0;
            // 
            // TxtCategorias
            // 
            TxtCategorias.Location = new Point(101, 107);
            TxtCategorias.Name = "TxtCategorias";
            TxtCategorias.Size = new Size(224, 23);
            TxtCategorias.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 110);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 19;
            label5.Text = "Categoria(*)";
            // 
            // BtnLupa3
            // 
            BtnLupa3.BackColor = Color.DodgerBlue;
            BtnLupa3.ForeColor = SystemColors.ButtonFace;
            BtnLupa3.Location = new Point(331, 107);
            BtnLupa3.Name = "BtnLupa3";
            BtnLupa3.Size = new Size(50, 28);
            BtnLupa3.TabIndex = 18;
            BtnLupa3.Text = ":::";
            BtnLupa3.UseVisualStyleBackColor = false;
            BtnLupa3.Click += BtnLupa3_Click;
            // 
            // TxtMedidas
            // 
            TxtMedidas.Location = new Point(101, 78);
            TxtMedidas.Name = "TxtMedidas";
            TxtMedidas.Size = new Size(224, 23);
            TxtMedidas.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 81);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 16;
            label4.Text = "Medida(*)";
            // 
            // BtnLupa2
            // 
            BtnLupa2.BackColor = Color.DodgerBlue;
            BtnLupa2.ForeColor = SystemColors.ButtonFace;
            BtnLupa2.Location = new Point(331, 78);
            BtnLupa2.Name = "BtnLupa2";
            BtnLupa2.Size = new Size(50, 28);
            BtnLupa2.TabIndex = 15;
            BtnLupa2.Text = ":::";
            BtnLupa2.UseVisualStyleBackColor = false;
            BtnLupa2.Click += BtnLupa2_Click;
            // 
            // textMarca
            // 
            textMarca.Location = new Point(101, 49);
            textMarca.Name = "textMarca";
            textMarca.Size = new Size(224, 23);
            textMarca.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 52);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 13;
            label3.Text = "Marca(*)";
            label3.Click += label3_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.DodgerBlue;
            btnRegresar.ForeColor = SystemColors.ButtonFace;
            btnRegresar.Location = new Point(282, 227);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(99, 32);
            btnRegresar.TabIndex = 12;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(154, 227);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 32);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DodgerBlue;
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(27, 227);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 32);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnLupa1
            // 
            BtnLupa1.BackColor = Color.DodgerBlue;
            BtnLupa1.ForeColor = SystemColors.ButtonFace;
            BtnLupa1.Location = new Point(331, 49);
            BtnLupa1.Name = "BtnLupa1";
            BtnLupa1.Size = new Size(50, 28);
            BtnLupa1.TabIndex = 10;
            BtnLupa1.Text = ":::";
            BtnLupa1.UseVisualStyleBackColor = false;
            BtnLupa1.Click += BtnLupa1_Click;
            // 
            // txtDescripPr
            // 
            txtDescripPr.Location = new Point(101, 20);
            txtDescripPr.Name = "txtDescripPr";
            txtDescripPr.Size = new Size(307, 23);
            txtDescripPr.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 23);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 8;
            label2.Text = "Productos(*)";
            label2.Click += label2_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.DodgerBlue;
            btnNuevo.ForeColor = SystemColors.ButtonFace;
            btnNuevo.Location = new Point(97, 343);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(77, 30);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DodgerBlue;
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(218, 343);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(77, 30);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DodgerBlue;
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(347, 343);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(77, 30);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.DodgerBlue;
            btnReporte.ForeColor = SystemColors.ButtonFace;
            btnReporte.Location = new Point(469, 343);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(77, 30);
            btnReporte.TabIndex = 7;
            btnReporte.Text = "Reporte";
            btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DodgerBlue;
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(586, 343);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(77, 30);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Pnl_Unid_med
            // 
            Pnl_Unid_med.Controls.Add(button1);
            Pnl_Unid_med.Controls.Add(button2);
            Pnl_Unid_med.Controls.Add(textBox5);
            Pnl_Unid_med.Controls.Add(label10);
            Pnl_Unid_med.Controls.Add(DgvMedidas);
            Pnl_Unid_med.ForeColor = SystemColors.ControlText;
            Pnl_Unid_med.Location = new Point(543, 392);
            Pnl_Unid_med.Name = "Pnl_Unid_med";
            Pnl_Unid_med.Size = new Size(503, 244);
            Pnl_Unid_med.TabIndex = 32;
            Pnl_Unid_med.TabStop = false;
            Pnl_Unid_med.Text = "Estado de Unid. Med.";
            Pnl_Unid_med.Visible = false;
            DgvMedidas.MouseDoubleClick += DgvMedidas_MouseDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(387, 15);
            button1.Name = "button1";
            button1.Size = new Size(50, 28);
            button1.TabIndex = 29;
            button1.Text = ":::";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(331, 15);
            button2.Name = "button2";
            button2.Size = new Size(50, 28);
            button2.TabIndex = 28;
            button2.Text = ":::";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(80, 19);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 23);
            textBox5.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 19);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 28;
            label10.Text = "Buscar(*)";
            // 
            // DgvMedidas
            // 
            DgvMedidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMedidas.Location = new Point(74, 62);
            DgvMedidas.Name = "DgvMedidas";
            DgvMedidas.Size = new Size(362, 167);
            DgvMedidas.TabIndex = 1;
            // 
            // Pnl_Categorias
            // 
            Pnl_Categorias.Controls.Add(btnRetorna3);
            Pnl_Categorias.Controls.Add(btnBuscar3);
            Pnl_Categorias.Controls.Add(textBox4);
            Pnl_Categorias.Controls.Add(label9);
            Pnl_Categorias.Controls.Add(DgvCategorias);
            Pnl_Categorias.ForeColor = SystemColors.ControlDark;
            Pnl_Categorias.Location = new Point(19, 392);
            Pnl_Categorias.Name = "Pnl_Categorias";
            Pnl_Categorias.Size = new Size(503, 244);
            Pnl_Categorias.TabIndex = 31;
            Pnl_Categorias.TabStop = false;
            Pnl_Categorias.Text = "Estado de categorias";
            Pnl_Categorias.Visible = false;
            // 
            // btnRetorna3
            // 
            btnRetorna3.BackColor = Color.DodgerBlue;
            btnRetorna3.ForeColor = SystemColors.ButtonFace;
            btnRetorna3.Location = new Point(387, 15);
            btnRetorna3.Name = "btnRetorna3";
            btnRetorna3.Size = new Size(50, 28);
            btnRetorna3.TabIndex = 29;
            btnRetorna3.Text = ":::";
            btnRetorna3.UseVisualStyleBackColor = false;
            // 
            // btnBuscar3
            // 
            btnBuscar3.BackColor = Color.DodgerBlue;
            btnBuscar3.ForeColor = SystemColors.ButtonFace;
            btnBuscar3.Location = new Point(331, 15);
            btnBuscar3.Name = "btnBuscar3";
            btnBuscar3.Size = new Size(50, 28);
            btnBuscar3.TabIndex = 28;
            btnBuscar3.Text = ":::";
            btnBuscar3.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(80, 19);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 23);
            textBox4.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 19);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 28;
            label9.Text = "Buscar(*)";
            // 
            // DgvCategorias
            // 
            DgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategorias.Location = new Point(74, 62);
            DgvCategorias.Name = "DgvCategorias";
            DgvCategorias.Size = new Size(362, 167);
            DgvCategorias.TabIndex = 1;
            DgvCategorias.MouseDoubleClick += DgvCategorias_MouseDoubleClick;
            // 
            // Pnl_Marca
            // 
            Pnl_Marca.Controls.Add(btnRetorna1);
            Pnl_Marca.Controls.Add(btnBuscar1);
            Pnl_Marca.Controls.Add(txtMarcas);
            Pnl_Marca.Controls.Add(label11);
            Pnl_Marca.Controls.Add(DgvMarcas);
            Pnl_Marca.ForeColor = SystemColors.ControlText;
            Pnl_Marca.Location = new Point(1065, 392);
            Pnl_Marca.Name = "Pnl_Marca";
            Pnl_Marca.Size = new Size(503, 244);
            Pnl_Marca.TabIndex = 33;
            Pnl_Marca.TabStop = false;
            Pnl_Marca.Text = "Estado de Marcas";
            Pnl_Marca.Visible = false;
            // 
            // btnRetorna1
            // 
            btnRetorna1.BackColor = Color.DodgerBlue;
            btnRetorna1.ForeColor = SystemColors.ButtonFace;
            btnRetorna1.Location = new Point(387, 15);
            btnRetorna1.Name = "btnRetorna1";
            btnRetorna1.Size = new Size(50, 28);
            btnRetorna1.TabIndex = 29;
            btnRetorna1.Text = ":::";
            btnRetorna1.UseVisualStyleBackColor = false;
            btnRetorna1.Click += btnRetorna1_Click;
            // 
            // btnBuscar1
            // 
            btnBuscar1.BackColor = Color.DodgerBlue;
            btnBuscar1.ForeColor = SystemColors.ButtonFace;
            btnBuscar1.Location = new Point(331, 15);
            btnBuscar1.Name = "btnBuscar1";
            btnBuscar1.Size = new Size(50, 28);
            btnBuscar1.TabIndex = 28;
            btnBuscar1.Text = ":::";
            btnBuscar1.UseVisualStyleBackColor = false;
            btnBuscar1.Click += btnBuscar1_Click;
            // 
            // txtMarcas
            // 
            txtMarcas.Location = new Point(80, 19);
            txtMarcas.Name = "txtMarcas";
            txtMarcas.Size = new Size(245, 23);
            txtMarcas.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 19);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 28;
            label11.Text = "Buscar(*)";
            // 
            // DgvMarcas
            // 
            DgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMarcas.Location = new Point(74, 62);
            DgvMarcas.Name = "DgvMarcas";
            DgvMarcas.Size = new Size(362, 167);
            DgvMarcas.TabIndex = 1;
            DgvMarcas.MouseDoubleClick += DgvMarcas_MouseDoubleClick;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1573, 648);
            Controls.Add(Pnl_Marca);
            Controls.Add(Pnl_Unid_med);
            Controls.Add(Pnl_Categorias);
            Controls.Add(btnSalir);
            Controls.Add(btnReporte);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnNuevo);
            Controls.Add(TbpPrincipal);
            Name = "FrmProductos";
            Text = "PRODUCTOS";
            Load += FrmProductos_Load;
            TbpPrincipal.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPrincipal).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            Pnl_Stock_Bodega.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvBodega).EndInit();
            Pnl_Unid_med.ResumeLayout(false);
            Pnl_Unid_med.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMedidas).EndInit();
            Pnl_Categorias.ResumeLayout(false);
            Pnl_Categorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).EndInit();
            Pnl_Marca.ResumeLayout(false);
            Pnl_Marca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMarcas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TbpPrincipal;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnNuevo;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnReporte;
        private Button btnSalir;
        private Button button3;
        private TextBox TxtBuscar;
        private Label label1;
        private DataGridView DgvPrincipal;
        private TextBox txtDescripPr;
        private Label label2;
        private Button btnCancelar;
        private System.Windows.Forms.Button BtnLupa1;
        private Button btnGuardar;
        private Button btnRegresar;
        private TextBox textMarca;
        private Label label3;
        private TextBox TxtCategorias;
        private Label label5;
        private Button BtnLupa3;
        private TextBox TxtMedidas;
        private Label label4;
        private System.Windows.Forms.Button BtnLupa2;
        private GroupBox Pnl_Stock_Bodega;
        private TextBox Txt_pu_venta;
        private TextBox TxtMaximo;
        private TextBox TxtMinimo;
        private Label label8;
        private Label label7;
        private Label label6;
        private DataGridView DgvBodega;
        private GroupBox Pnl_Unid_med;
        private Button button1;
        private Button button2;
        private TextBox textBox5;
        private Label label10;
        private DataGridView DgvMedidas;
        private GroupBox Pnl_Categorias;
        private Button btnRetorna3;
        private Button btnBuscar3;
        private TextBox textBox4;
        private Label label9;
        private System.Windows.Forms.DataGridView DgvCategorias;
        private GroupBox Pnl_Marca;
        private Button btnRetorna1;
        private Button btnBuscar1;
        private TextBox txtMarcas;
        private Label label11;
        private DataGridView DgvMarcas;
    }
}
