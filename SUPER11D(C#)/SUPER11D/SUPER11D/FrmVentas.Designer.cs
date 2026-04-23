namespace GUI
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            Pnl_Cliente = new GroupBox();
            Btn_Retornar2 = new Button();
            Btn_Buscar2 = new Button();
            Txt_Buscar2 = new TextBox();
            label11 = new Label();
            DgvCliente = new DataGridView();
            btnSalir = new Button();
            btnReporte = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnNuevo = new Button();
            button3 = new Button();
            TxtBuscar = new TextBox();
            DgvPrincipal = new DataGridView();
            tabPage1 = new TabPage();
            label1 = new Label();
            TbpPrincipal = new TabControl();
            tabPage2 = new TabPage();
            Txt_razon_social_cli = new TextBox();
            Txt_total_importe = new TextBox();
            label9 = new Label();
            Txt_iva = new TextBox();
            label8 = new Label();
            Txt_subtotal = new TextBox();
            label7 = new Label();
            label6 = new Label();
            Txt_nroducmento_cl = new TextBox();
            BtnLupa1 = new Button();
            label5 = new Label();
            Txt_observaciones_sp = new RichTextBox();
            Dgv_Detalle = new DataGridView();
            Btn_Quitar = new Button();
            Btn_Agregar = new Button();
            label4 = new Label();
            Txt_nrodocumento_sp = new TextBox();
            label2 = new Label();
            DtpFechaVenta = new DateTimePicker();
            Txt_descripcion_tde = new TextBox();
            label3 = new Label();
            btnRegresar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            BtnLupa2 = new Button();
            Pnl_Listado_tde = new GroupBox();
            btnRetornar1 = new Button();
            btnBuscar1 = new Button();
            label10 = new Label();
            Dgv_tipo_tde = new DataGridView();
            Pnl_Listado_pr = new GroupBox();
            Btn_Retorna3 = new Button();
            Btn_Buscar3 = new Button();
            Txt_Buscar3 = new TextBox();
            label12 = new Label();
            Dgv_Productos = new DataGridView();
            Pnl_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvPrincipal).BeginInit();
            tabPage1.SuspendLayout();
            TbpPrincipal.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Detalle).BeginInit();
            Pnl_Listado_tde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_tipo_tde).BeginInit();
            Pnl_Listado_pr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Productos).BeginInit();
            SuspendLayout();
            //
            // Pnl_Cliente
            //
            Pnl_Cliente.Controls.Add(Btn_Retornar2);
            Pnl_Cliente.Controls.Add(Btn_Buscar2);
            Pnl_Cliente.Controls.Add(Txt_Buscar2);
            Pnl_Cliente.Controls.Add(label11);
            Pnl_Cliente.Controls.Add(DgvCliente);
            Pnl_Cliente.ForeColor = SystemColors.ControlText;
            Pnl_Cliente.Location = new Point(46, 519);
            Pnl_Cliente.Name = "Pnl_Cliente";
            Pnl_Cliente.Size = new Size(491, 244);
            Pnl_Cliente.TabIndex = 40;
            Pnl_Cliente.TabStop = false;
            Pnl_Cliente.Text = "Listado de clientes";
            Pnl_Cliente.Visible = false;
            //
            // Btn_Retornar2
            //
            Btn_Retornar2.BackColor = Color.DodgerBlue;
            Btn_Retornar2.ForeColor = SystemColors.ButtonFace;
            Btn_Retornar2.Location = new Point(387, 15);
            Btn_Retornar2.Name = "Btn_Retornar2";
            Btn_Retornar2.Size = new Size(50, 28);
            Btn_Retornar2.TabIndex = 29;
            Btn_Retornar2.Text = ":::";
            Btn_Retornar2.UseVisualStyleBackColor = false;
            //
            // Btn_Buscar2
            //
            Btn_Buscar2.BackColor = Color.DodgerBlue;
            Btn_Buscar2.ForeColor = SystemColors.ButtonFace;
            Btn_Buscar2.Location = new Point(331, 15);
            Btn_Buscar2.Name = "Btn_Buscar2";
            Btn_Buscar2.Size = new Size(50, 28);
            Btn_Buscar2.TabIndex = 28;
            Btn_Buscar2.Text = ":::";
            Btn_Buscar2.UseVisualStyleBackColor = false;
            //
            // Txt_Buscar2
            //
            Txt_Buscar2.Location = new Point(80, 19);
            Txt_Buscar2.Name = "Txt_Buscar2";
            Txt_Buscar2.Size = new Size(245, 23);
            Txt_Buscar2.TabIndex = 28;
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
            // DgvCliente
            //
            DgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCliente.Location = new Point(74, 62);
            DgvCliente.Name = "DgvCliente";
            DgvCliente.Size = new Size(362, 167);
            DgvCliente.TabIndex = 1;
            //
            // btnSalir
            //
            btnSalir.BackColor = Color.DodgerBlue;
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(522, 483);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(77, 30);
            btnSalir.TabIndex = 39;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            //
            // btnReporte
            //
            btnReporte.BackColor = Color.DodgerBlue;
            btnReporte.ForeColor = SystemColors.ButtonFace;
            btnReporte.Location = new Point(405, 483);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(77, 30);
            btnReporte.TabIndex = 38;
            btnReporte.Text = "Reporte";
            btnReporte.UseVisualStyleBackColor = false;
            //
            // btnEliminar
            //
            btnEliminar.BackColor = Color.DodgerBlue;
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(283, 483);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(77, 30);
            btnEliminar.TabIndex = 37;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            //
            // btnActualizar
            //
            btnActualizar.BackColor = Color.DodgerBlue;
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(154, 483);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(77, 30);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            //
            // btnNuevo
            //
            btnNuevo.BackColor = Color.DodgerBlue;
            btnNuevo.ForeColor = SystemColors.ButtonFace;
            btnNuevo.Location = new Point(33, 483);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(77, 30);
            btnNuevo.TabIndex = 35;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
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
            //
            // TxtBuscar
            //
            TxtBuscar.Location = new Point(79, 21);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(224, 23);
            TxtBuscar.TabIndex = 6;
            //
            // DgvPrincipal
            //
            DgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPrincipal.Location = new Point(20, 62);
            DgvPrincipal.Name = "DgvPrincipal";
            DgvPrincipal.Size = new Size(1027, 198);
            DgvPrincipal.TabIndex = 4;
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
            tabPage1.Size = new Size(1111, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consultas";
            tabPage1.UseVisualStyleBackColor = true;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(28, 27);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 5;
            label1.Text = "Buscar :";
            //
            // TbpPrincipal
            //
            TbpPrincipal.Controls.Add(tabPage2);
            TbpPrincipal.Controls.Add(tabPage1);
            TbpPrincipal.Location = new Point(33, -1);
            TbpPrincipal.Name = "TbpPrincipal";
            TbpPrincipal.SelectedIndex = 0;
            TbpPrincipal.Size = new Size(1119, 478);
            TbpPrincipal.TabIndex = 34;
            //
            // tabPage2
            //
            tabPage2.Controls.Add(Txt_razon_social_cli);
            tabPage2.Controls.Add(Txt_total_importe);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(Txt_iva);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(Txt_subtotal);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(Txt_nroducmento_cl);
            tabPage2.Controls.Add(BtnLupa1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(Txt_observaciones_sp);
            tabPage2.Controls.Add(Dgv_Detalle);
            tabPage2.Controls.Add(Btn_Quitar);
            tabPage2.Controls.Add(Btn_Agregar);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(Txt_nrodocumento_sp);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(DtpFechaVenta);
            tabPage2.Controls.Add(Txt_descripcion_tde);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnRegresar);
            tabPage2.Controls.Add(btnGuardar);
            tabPage2.Controls.Add(btnCancelar);
            tabPage2.Controls.Add(BtnLupa2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1111, 450);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ventas";
            tabPage2.UseVisualStyleBackColor = true;
            //
            // Txt_razon_social_cli
            //
            Txt_razon_social_cli.Location = new Point(770, 54);
            Txt_razon_social_cli.Name = "Txt_razon_social_cli";
            Txt_razon_social_cli.Size = new Size(224, 23);
            Txt_razon_social_cli.TabIndex = 39;
            //
            // Txt_total_importe
            //
            Txt_total_importe.Location = new Point(912, 413);
            Txt_total_importe.Name = "Txt_total_importe";
            Txt_total_importe.Size = new Size(90, 23);
            Txt_total_importe.TabIndex = 38;
            //
            // label9
            //
            label9.AutoSize = true;
            label9.Location = new Point(918, 395);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 37;
            label9.Text = "Total (*)";
            //
            // Txt_iva
            //
            Txt_iva.Location = new Point(816, 413);
            Txt_iva.Name = "Txt_iva";
            Txt_iva.Size = new Size(90, 23);
            Txt_iva.TabIndex = 36;
            //
            // label8
            //
            label8.AutoSize = true;
            label8.Location = new Point(822, 395);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 35;
            label8.Text = "I.V.A (*)";
            //
            // Txt_subtotal
            //
            Txt_subtotal.Location = new Point(720, 413);
            Txt_subtotal.Name = "Txt_subtotal";
            Txt_subtotal.Size = new Size(90, 23);
            Txt_subtotal.TabIndex = 34;
            //
            // label7
            //
            label7.AutoSize = true;
            label7.Location = new Point(726, 395);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 33;
            label7.Text = "Sub Total. (*)";
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Location = new Point(595, 87);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 32;
            label6.Text = "Observaciones (*)";
            //
            // Txt_nroducmento_cl
            //
            Txt_nroducmento_cl.Location = new Point(770, 22);
            Txt_nroducmento_cl.Name = "Txt_nroducmento_cl";
            Txt_nroducmento_cl.Size = new Size(224, 23);
            Txt_nroducmento_cl.TabIndex = 31;
            //
            // BtnLupa1
            //
            BtnLupa1.BackColor = Color.DodgerBlue;
            BtnLupa1.ForeColor = SystemColors.ButtonFace;
            BtnLupa1.Location = new Point(1000, 22);
            BtnLupa1.Name = "BtnLupa1";
            BtnLupa1.Size = new Size(50, 28);
            BtnLupa1.TabIndex = 30;
            BtnLupa1.Text = ":::";
            BtnLupa1.UseVisualStyleBackColor = false;
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Location = new Point(704, 25);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 29;
            label5.Text = "Cliente (*)";
            //
            // Txt_observaciones_sp
            //
            Txt_observaciones_sp.Location = new Point(704, 87);
            Txt_observaciones_sp.Name = "Txt_observaciones_sp";
            Txt_observaciones_sp.Size = new Size(362, 96);
            Txt_observaciones_sp.TabIndex = 28;
            Txt_observaciones_sp.Text = "";
            Txt_observaciones_sp.TextChanged += Txt_observaciones_sp_TextChanged;
            //
            // Dgv_Detalle
            //
            Dgv_Detalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Detalle.Location = new Point(9, 199);
            Dgv_Detalle.Name = "Dgv_Detalle";
            Dgv_Detalle.Size = new Size(1066, 167);
            Dgv_Detalle.TabIndex = 0;
            //
            // Btn_Quitar
            //
            Btn_Quitar.BackColor = Color.DodgerBlue;
            Btn_Quitar.ForeColor = SystemColors.ButtonFace;
            Btn_Quitar.Location = new Point(154, 119);
            Btn_Quitar.Name = "Btn_Quitar";
            Btn_Quitar.Size = new Size(95, 29);
            Btn_Quitar.TabIndex = 27;
            Btn_Quitar.Text = "Quitar";
            Btn_Quitar.UseVisualStyleBackColor = false;
            Btn_Quitar.Click += Btn_Quitar_Click;
            //
            // Btn_Agregar
            //
            Btn_Agregar.BackColor = Color.DodgerBlue;
            Btn_Agregar.ForeColor = SystemColors.ButtonFace;
            Btn_Agregar.Location = new Point(27, 119);
            Btn_Agregar.Name = "Btn_Agregar";
            Btn_Agregar.Size = new Size(95, 29);
            Btn_Agregar.TabIndex = 26;
            Btn_Agregar.Text = "Agregar";
            Btn_Agregar.UseVisualStyleBackColor = false;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(23, 90);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 25;
            label4.Text = "Fecha Doc(*)";
            //
            // Txt_nrodocumento_sp
            //
            Txt_nrodocumento_sp.Location = new Point(102, 54);
            Txt_nrodocumento_sp.Name = "Txt_nrodocumento_sp";
            Txt_nrodocumento_sp.Size = new Size(224, 23);
            Txt_nrodocumento_sp.TabIndex = 24;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(31, 60);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 23;
            label2.Text = "Nro. Doc(*)";
            //
            // DtpFechaVenta
            //
            DtpFechaVenta.Format = DateTimePickerFormat.Short;
            DtpFechaVenta.Location = new Point(104, 90);
            DtpFechaVenta.Name = "DtpFechaVenta";
            DtpFechaVenta.Size = new Size(200, 23);
            DtpFechaVenta.TabIndex = 22;
            //
            // Txt_descripcion_tde
            //
            Txt_descripcion_tde.Location = new Point(102, 25);
            Txt_descripcion_tde.Name = "Txt_descripcion_tde";
            Txt_descripcion_tde.Size = new Size(224, 23);
            Txt_descripcion_tde.TabIndex = 14;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(31, 31);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 13;
            label3.Text = "Tipo Doc(*)";
            //
            // btnRegresar
            //
            btnRegresar.BackColor = Color.DodgerBlue;
            btnRegresar.ForeColor = SystemColors.ButtonFace;
            btnRegresar.Location = new Point(302, 386);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(99, 32);
            btnRegresar.TabIndex = 12;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            //
            // btnGuardar
            //
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(174, 386);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 32);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            //
            // btnCancelar
            //
            btnCancelar.BackColor = Color.DodgerBlue;
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(47, 386);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 32);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            //
            // BtnLupa2
            //
            BtnLupa2.BackColor = Color.DodgerBlue;
            BtnLupa2.ForeColor = SystemColors.ButtonFace;
            BtnLupa2.Location = new Point(332, 25);
            BtnLupa2.Name = "BtnLupa2";
            BtnLupa2.Size = new Size(50, 28);
            BtnLupa2.TabIndex = 10;
            BtnLupa2.Text = ":::";
            BtnLupa2.UseVisualStyleBackColor = false;
            //
            // Pnl_Listado_tde
            //
            Pnl_Listado_tde.Controls.Add(btnRetornar1);
            Pnl_Listado_tde.Controls.Add(btnBuscar1);
            Pnl_Listado_tde.Controls.Add(label10);
            Pnl_Listado_tde.Controls.Add(Dgv_tipo_tde);
            Pnl_Listado_tde.ForeColor = SystemColors.ControlText;
            Pnl_Listado_tde.Location = new Point(632, 506);
            Pnl_Listado_tde.Name = "Pnl_Listado_tde";
            Pnl_Listado_tde.Size = new Size(491, 244);
            Pnl_Listado_tde.TabIndex = 41;
            Pnl_Listado_tde.TabStop = false;
            Pnl_Listado_tde.Text = "Listado tipo de documento";
            Pnl_Listado_tde.Visible = false;
            //
            // btnRetornar1
            //
            btnRetornar1.BackColor = Color.DodgerBlue;
            btnRetornar1.ForeColor = SystemColors.ButtonFace;
            btnRetornar1.Location = new Point(387, 15);
            btnRetornar1.Name = "btnRetornar1";
            btnRetornar1.Size = new Size(50, 28);
            btnRetornar1.TabIndex = 29;
            btnRetornar1.Text = ":::";
            btnRetornar1.UseVisualStyleBackColor = false;
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
            // Dgv_tipo_tde
            //
            Dgv_tipo_tde.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_tipo_tde.Location = new Point(74, 62);
            Dgv_tipo_tde.Name = "Dgv_tipo_tde";
            Dgv_tipo_tde.Size = new Size(362, 167);
            Dgv_tipo_tde.TabIndex = 1;
            //
            // Pnl_Listado_pr
            //
            Pnl_Listado_pr.Controls.Add(Btn_Retorna3);
            Pnl_Listado_pr.Controls.Add(Btn_Buscar3);
            Pnl_Listado_pr.Controls.Add(Txt_Buscar3);
            Pnl_Listado_pr.Controls.Add(label12);
            Pnl_Listado_pr.Controls.Add(Dgv_Productos);
            Pnl_Listado_pr.ForeColor = SystemColors.ControlText;
            Pnl_Listado_pr.Location = new Point(1175, 506);
            Pnl_Listado_pr.Name = "Pnl_Listado_pr";
            Pnl_Listado_pr.Size = new Size(943, 244);
            Pnl_Listado_pr.TabIndex = 42;
            Pnl_Listado_pr.TabStop = false;
            Pnl_Listado_pr.Text = "Listado de productos";
            Pnl_Listado_pr.Visible = false;
            //
            // Btn_Retorna3
            //
            Btn_Retorna3.BackColor = Color.DodgerBlue;
            Btn_Retorna3.ForeColor = SystemColors.ButtonFace;
            Btn_Retorna3.Location = new Point(387, 15);
            Btn_Retorna3.Name = "Btn_Retorna3";
            Btn_Retorna3.Size = new Size(50, 28);
            Btn_Retorna3.TabIndex = 29;
            Btn_Retorna3.Text = ":::";
            Btn_Retorna3.UseVisualStyleBackColor = false;
            //
            // Btn_Buscar3
            //
            Btn_Buscar3.BackColor = Color.DodgerBlue;
            Btn_Buscar3.ForeColor = SystemColors.ButtonFace;
            Btn_Buscar3.Location = new Point(331, 15);
            Btn_Buscar3.Name = "Btn_Buscar3";
            Btn_Buscar3.Size = new Size(50, 28);
            Btn_Buscar3.TabIndex = 28;
            Btn_Buscar3.Text = ":::";
            Btn_Buscar3.UseVisualStyleBackColor = false;
            //
            // Txt_Buscar3
            //
            Txt_Buscar3.Location = new Point(80, 19);
            Txt_Buscar3.Name = "Txt_Buscar3";
            Txt_Buscar3.Size = new Size(245, 23);
            Txt_Buscar3.TabIndex = 28;
            //
            // label12
            //
            label12.AutoSize = true;
            label12.Location = new Point(19, 19);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 28;
            label12.Text = "Buscar(*)";
            //
            // Dgv_Productos
            //
            Dgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Productos.Location = new Point(19, 62);
            Dgv_Productos.Name = "Dgv_Productos";
            Dgv_Productos.Size = new Size(901, 167);
            Dgv_Productos.TabIndex = 1;
            //
            // FrmVentas
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2204, 769);
            Controls.Add(Pnl_Listado_pr);
            Controls.Add(Pnl_Listado_tde);
            Controls.Add(Pnl_Cliente);
            Controls.Add(btnSalir);
            Controls.Add(btnReporte);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnNuevo);
            Controls.Add(TbpPrincipal);
            Name = "FrmVentas";
            Text = "FrmVentas";
            Pnl_Cliente.ResumeLayout(false);
            Pnl_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvPrincipal).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            TbpPrincipal.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Detalle).EndInit();
            Pnl_Listado_tde.ResumeLayout(false);
            Pnl_Listado_tde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_tipo_tde).EndInit();
            Pnl_Listado_pr.ResumeLayout(false);
            Pnl_Listado_pr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Productos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Pnl_Cliente;
        private Button Btn_Retornar2;
        private Button Btn_Buscar2;
        private TextBox Txt_Buscar2;
        private Label label11;
        private DataGridView DgvCliente;
        private Button btnSalir;
        private Button btnReporte;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnNuevo;
        private Button button3;
        private TextBox TxtBuscar;
        private DataGridView DgvPrincipal;
        private TabPage tabPage1;
        private Label label1;
        private TabControl TbpPrincipal;
        private TabPage tabPage2;
        private DataGridView Dgv_Detalle;
        private TextBox Txt_descripcion_tde;
        private Label label3;
        private Button btnRegresar;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button BtnLupa2;
        private Label label4;
        private TextBox Txt_nrodocumento_sp;
        private Label label2;
        private DateTimePicker DtpFechaVenta;
        private RichTextBox Txt_observaciones_sp;
        private Button Btn_Quitar;
        private Button Btn_Agregar;
        private Label label6;
        private TextBox Txt_nroducmento_cl;
        private Button BtnLupa1;
        private Label label5;
        private TextBox Txt_total_importe;
        private Label label9;
        private TextBox Txt_iva;
        private Label label8;
        private TextBox Txt_subtotal;
        private Label label7;
        private GroupBox Pnl_Listado_tde;

        public TextBox TxtBucar1 { get; private set; }

        private TextBox textBox6;
        private Label label10;
        private DataGridView Dgv_tipo_tde;
        private GroupBox Pnl_Listado_pr;
        private Button Btn_Retorna3;
        private Button Btn_Buscar3;
        private TextBox Txt_Buscar3;
        private Label label12;
        private DataGridView Dgv_Productos;
        private Button btnRetornar1;
        private Button btnBuscar1;
        private TextBox Txt_razon_social_cli;
    }
}
