namespace SUPER11D
{
    partial class FrmMarcas
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
            Mantenimiento = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            button3 = new System.Windows.Forms.Button();
            TxtBuscar = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            DgvPrincipal = new System.Windows.Forms.DataGridView();
            tabPage2 = new System.Windows.Forms.TabPage();
            BtnRegresar = new System.Windows.Forms.Button();
            BtnGuardar = new System.Windows.Forms.Button();
            BtnCancelar = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            txtDescripPr = new System.Windows.Forms.TextBox();
            Marcas = new System.Windows.Forms.Label();
            BtnActualizar = new System.Windows.Forms.Button();
            BtnNuevo = new System.Windows.Forms.Button();
            BtnReporte = new System.Windows.Forms.Button();
            BtnSalir = new System.Windows.Forms.Button();
            BtnEliminar = new System.Windows.Forms.Button();
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
            Mantenimiento.Location = new System.Drawing.Point(12, 12);
            Mantenimiento.Name = "Mantenimiento";
            Mantenimiento.SelectedIndex = 0;
            Mantenimiento.Size = new System.Drawing.Size(839, 287);
            Mantenimiento.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(TxtBuscar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(DgvPrincipal);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(831, 259);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.DodgerBlue;
            button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            button3.Location = new System.Drawing.Point(273, 6);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new System.Drawing.Point(80, 6);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new System.Drawing.Size(187, 23);
            TxtBuscar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(32, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar";
            // 
            // DgvPrincipal
            // 
            DgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPrincipal.Location = new System.Drawing.Point(16, 44);
            DgvPrincipal.Name = "DgvPrincipal";
            DgvPrincipal.Size = new System.Drawing.Size(797, 198);
            DgvPrincipal.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnRegresar);
            tabPage2.Controls.Add(BtnGuardar);
            tabPage2.Controls.Add(BtnCancelar);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(txtDescripPr);
            tabPage2.Controls.Add(Marcas);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(831, 259);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mantenimiento";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackColor = System.Drawing.Color.DodgerBlue;
            BtnRegresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            BtnRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            BtnRegresar.Location = new System.Drawing.Point(168, 211);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new System.Drawing.Size(75, 23);
            BtnRegresar.TabIndex = 8;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = false;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLight;
            BtnGuardar.Location = new System.Drawing.Point(87, 211);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new System.Drawing.Size(75, 23);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            BtnCancelar.Location = new System.Drawing.Point(6, 211);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new System.Drawing.Size(75, 23);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.Color.DodgerBlue;
            button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button6.ForeColor = System.Drawing.SystemColors.ControlLight;
            button6.Location = new System.Drawing.Point(307, 6);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(75, 23);
            button6.TabIndex = 3;
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = false;
            // 
            // txtDescripPr
            // 
            txtDescripPr.Location = new System.Drawing.Point(114, 6);
            txtDescripPr.Name = "txtDescripPr";
            txtDescripPr.Size = new System.Drawing.Size(187, 23);
            txtDescripPr.TabIndex = 5;
            // 
            // Marcas
            // 
            Marcas.AutoSize = true;
            Marcas.Location = new System.Drawing.Point(32, 6);
            Marcas.Name = "Marcas";
            Marcas.Size = new System.Drawing.Size(58, 15);
            Marcas.TabIndex = 4;
            Marcas.Text = "Marcas(*)";
            // 
            // BtnActualizar
            // 
            BtnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            BtnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            BtnActualizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            BtnActualizar.Location = new System.Drawing.Point(177, 339);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new System.Drawing.Size(75, 23);
            BtnActualizar.TabIndex = 3;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = System.Drawing.Color.DodgerBlue;
            BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            BtnNuevo.ForeColor = System.Drawing.SystemColors.ControlLight;
            BtnNuevo.Location = new System.Drawing.Point(96, 339);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new System.Drawing.Size(75, 23);
            BtnNuevo.TabIndex = 4;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnReporte
            // 
            BtnReporte.BackColor = System.Drawing.Color.DodgerBlue;
            BtnReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            BtnReporte.ForeColor = System.Drawing.SystemColors.ControlLight;
            BtnReporte.Location = new System.Drawing.Point(339, 339);
            BtnReporte.Name = "BtnReporte";
            BtnReporte.Size = new System.Drawing.Size(75, 23);
            BtnReporte.TabIndex = 6;
            BtnReporte.Text = "Reporte";
            BtnReporte.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLight;
            BtnSalir.Location = new System.Drawing.Point(420, 339);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new System.Drawing.Size(75, 23);
            BtnSalir.TabIndex = 7;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            BtnEliminar.Location = new System.Drawing.Point(258, 339);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new System.Drawing.Size(75, 23);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FrmMarcas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(894, 400);
            Controls.Add(BtnSalir);
            Controls.Add(BtnReporte);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnNuevo);
            Controls.Add(Mantenimiento);
            Text = "MARCAS";
            Load += FrmMarcas_Load;
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
        private System.Windows.Forms.DataGridView DgvPrincipal;
        private Button button6;
        private TextBox txtDescripPr;
        private Label Marcas;
        private Button BtnReporte;
        private Button BtnSalir;
        private Button BtnRegresar;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Button BtnEliminar;
    }
}
