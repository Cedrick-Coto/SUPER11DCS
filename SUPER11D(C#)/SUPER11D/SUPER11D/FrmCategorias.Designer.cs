namespace SUPER11D
{
    partial class Form1
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
            Mantenimiento = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            TxtBuscar = new TextBox();
            label1 = new Label();
            DgvPrincipal = new DataGridView();
            tabPage2 = new TabPage();
            BtnRegresar = new Button();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            button6 = new Button();
            txtDescripPr = new TextBox();
            Categorias = new Label();
            BtnActualizar = new Button();
            BtnNuevo = new Button();
            BtnReporte = new Button();
            BtnSalir = new Button();
            BtnEliminar = new Button();
            Mantenimiento.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPrincipal).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Mantenimiento
            // 
            Mantenimiento.Controls.Add(tabPage1);
            Mantenimiento.Controls.Add(tabPage2);
            Mantenimiento.Location = new Point(12, 12);
            Mantenimiento.Name = "Mantenimiento";
            Mantenimiento.SelectedIndex = 0;
            Mantenimiento.Size = new Size(839, 287);
            Mantenimiento.TabIndex = 0;
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
            tabPage1.Size = new Size(831, 259);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(273, 6);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(80, 6);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(187, 23);
            TxtBuscar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar";
            // 
            // DgvPrincipal
            // 
            DgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPrincipal.Location = new Point(16, 44);
            DgvPrincipal.Name = "DgvPrincipal";
            DgvPrincipal.Size = new Size(797, 198);
            DgvPrincipal.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnRegresar);
            tabPage2.Controls.Add(BtnGuardar);
            tabPage2.Controls.Add(BtnCancelar);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(txtDescripPr);
            tabPage2.Controls.Add(Categorias);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(831, 259);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mantenimiento";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackColor = Color.DodgerBlue;
            BtnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegresar.ForeColor = SystemColors.ControlLight;
            BtnRegresar.Location = new Point(168, 211);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(75, 23);
            BtnRegresar.TabIndex = 8;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.DodgerBlue;
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = SystemColors.ControlLight;
            BtnGuardar.Location = new Point(87, 211);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.DodgerBlue;
            BtnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = SystemColors.ControlLight;
            BtnCancelar.Location = new Point(6, 211);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.DodgerBlue;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLight;
            button6.Location = new Point(307, 6);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 3;
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = false;
            // 
            // txtDescripPr
            // 
            txtDescripPr.Location = new Point(114, 6);
            txtDescripPr.Name = "txtDescripPr";
            txtDescripPr.Size = new Size(187, 23);
            txtDescripPr.TabIndex = 5;
            // 
            // Categorias
            // 
            Categorias.AutoSize = true;
            Categorias.Location = new Point(32, 6);
            Categorias.Name = "Categorias";
            Categorias.Size = new Size(76, 15);
            Categorias.TabIndex = 4;
            Categorias.Text = "Categorias(*)";
            // 
            // BtnActualizar
            // 
            BtnActualizar.BackColor = Color.DodgerBlue;
            BtnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnActualizar.ForeColor = SystemColors.ControlLight;
            BtnActualizar.Location = new Point(177, 339);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(75, 23);
            BtnActualizar.TabIndex = 3;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.DodgerBlue;
            BtnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevo.ForeColor = SystemColors.ControlLight;
            BtnNuevo.Location = new Point(96, 339);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(75, 23);
            BtnNuevo.TabIndex = 4;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnReporte
            // 
            BtnReporte.BackColor = Color.DodgerBlue;
            BtnReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReporte.ForeColor = SystemColors.ControlLight;
            BtnReporte.Location = new Point(339, 339);
            BtnReporte.Name = "BtnReporte";
            BtnReporte.Size = new Size(75, 23);
            BtnReporte.TabIndex = 6;
            BtnReporte.Text = "Reporte";
            BtnReporte.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.DodgerBlue;
            BtnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.ControlLight;
            BtnSalir.Location = new Point(420, 339);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 23);
            BtnSalir.TabIndex = 7;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.DodgerBlue;
            BtnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.ForeColor = SystemColors.ControlLight;
            BtnEliminar.Location = new Point(258, 339);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 400);
            Controls.Add(BtnSalir);
            Controls.Add(BtnReporte);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnNuevo);
            Controls.Add(Mantenimiento);
            Name = "Form1";
            Text = "CATEGORIAS";
            Load += Form1_Load;
            Mantenimiento.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPrincipal).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Mantenimiento;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BtnActualizar;
        private Button BtnNuevo;
        private Button button3;
        private TextBox TxtBuscar;
        private Label label1;
        private DataGridView DgvPrincipal;
        private Button button6;
        private TextBox txtDescripPr;
        private Label Categorias;
        private Button BtnReporte;
        private Button BtnSalir;
        private Button BtnRegresar;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Button BtnEliminar;
    }
}
