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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            btnRegresar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            this.BtnLupa1 = new Button();
            txtDescripPr = new TextBox();
            label2 = new Label();
            btnNuevo = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnReporte = new Button();
            btnSalir = new Button();
            textMarca = new TextBox();
            label3 = new Label();
            textMedida = new TextBox();
            label4 = new Label();
            BtnLupa2 = new Button();
            textCategorias = new TextBox();
            label5 = new Label();
            BtnLupa3 = new Button();
            TbpPrincipal.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPrincipal).BeginInit();
            tabPage2.SuspendLayout();
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
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textCategorias);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(BtnLupa3);
            tabPage2.Controls.Add(textMedida);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(BtnLupa2);
            tabPage2.Controls.Add(textMarca);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnRegresar);
            tabPage2.Controls.Add(btnGuardar);
            tabPage2.Controls.Add(btnCancelar);
            tabPage2.Controls.Add(this.BtnLupa1);
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
            this.BtnLupa1.BackColor = Color.DodgerBlue;
            this.BtnLupa1.ForeColor = SystemColors.ButtonFace;
            this.BtnLupa1.Location = new Point(331, 49);
            this.BtnLupa1.Name = "BtnLupa1";
            this.BtnLupa1.Size = new Size(50, 28);
            this.BtnLupa1.TabIndex = 10;
            this.BtnLupa1.Text = ":::";
            this.BtnLupa1.UseVisualStyleBackColor = false;
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
            // textMedida
            // 
            textMedida.Location = new Point(101, 78);
            textMedida.Name = "textMedida";
            textMedida.Size = new Size(224, 23);
            textMedida.TabIndex = 17;
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
            // 
            // textCategorias
            // 
            textCategorias.Location = new Point(101, 107);
            textCategorias.Name = "textCategorias";
            textCategorias.Size = new Size(224, 23);
            textCategorias.TabIndex = 20;
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
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 568);
            Controls.Add(btnSalir);
            Controls.Add(btnReporte);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnNuevo);
            Controls.Add(TbpPrincipal);
            Name = "FrmProductos";
            Text = "PRODUCTOS";
            Load += FrmCategorias_Load;
            TbpPrincipal.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPrincipal).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private Button button6;
        private TextBox txtDescripPr;
        private Label label2;
        private Button btnCancelar;
        private Button BtnLupa1;
        private Button btnGuardar;
        private Button btnRegresar;
        private TextBox textMarca;
        private Label label3;
        private TextBox textCategorias;
        private Label label5;
        private Button BtnLupa3;
        private TextBox textMedida;
        private Label label4;
        private Button BtnLupa2;
    }
}
