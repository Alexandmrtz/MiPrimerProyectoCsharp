namespace miPrimerProyectoCsharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbDatosDocente = new System.Windows.Forms.GroupBox();
            this.txtTelefonoDocente = new System.Windows.Forms.TextBox();
            this.txtDireccionDocente = new System.Windows.Forms.TextBox();
            this.txtAsignaturaDocente = new System.Windows.Forms.TextBox();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.txtCodigoDocente = new System.Windows.Forms.TextBox();
            this.idDocente = new System.Windows.Forms.Label();
            this.lblCodigoDocente = new System.Windows.Forms.Label();
            this.lblIdDocente = new System.Windows.Forms.Label();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.lblTelefonoDocente = new System.Windows.Forms.Label();
            this.lblAsignaturaDocente = new System.Windows.Forms.Label();
            this.lblDireccionDocente = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grbNavegacionDocente = new System.Windows.Forms.GroupBox();
            this.lblRegistroDocente = new System.Windows.Forms.Label();
            this.btnUltimoDocente = new System.Windows.Forms.Button();
            this.btnSiguienteDocente = new System.Windows.Forms.Button();
            this.btnAnteriorDocente = new System.Windows.Forms.Button();
            this.btnPreimeroDocente = new System.Windows.Forms.Button();
            this.grbEdiccionDocente = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.grbBusquedaDocente = new System.Windows.Forms.GroupBox();
            this.grdDocentes = new System.Windows.Forms.DataGridView();
            this.txtBuscarDocente = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosDocente.SuspendLayout();
            this.grbNavegacionDocente.SuspendLayout();
            this.grbEdiccionDocente.SuspendLayout();
            this.grbBusquedaDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosDocente
            // 
            this.grbDatosDocente.Controls.Add(this.txtTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.txtDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.txtAsignaturaDocente);
            this.grbDatosDocente.Controls.Add(this.txtNombreDocente);
            this.grbDatosDocente.Controls.Add(this.txtCodigoDocente);
            this.grbDatosDocente.Controls.Add(this.idDocente);
            this.grbDatosDocente.Controls.Add(this.lblCodigoDocente);
            this.grbDatosDocente.Controls.Add(this.lblIdDocente);
            this.grbDatosDocente.Controls.Add(this.lblNombreDocente);
            this.grbDatosDocente.Controls.Add(this.lblTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.lblAsignaturaDocente);
            this.grbDatosDocente.Controls.Add(this.lblDireccionDocente);
            this.grbDatosDocente.Location = new System.Drawing.Point(12, 12);
            this.grbDatosDocente.Name = "grbDatosDocente";
            this.grbDatosDocente.Size = new System.Drawing.Size(277, 236);
            this.grbDatosDocente.TabIndex = 0;
            this.grbDatosDocente.TabStop = false;
            this.grbDatosDocente.Text = "Datos";
            // 
            // txtTelefonoDocente
            // 
            this.txtTelefonoDocente.Location = new System.Drawing.Point(91, 197);
            this.txtTelefonoDocente.Name = "txtTelefonoDocente";
            this.txtTelefonoDocente.Size = new System.Drawing.Size(130, 24);
            this.txtTelefonoDocente.TabIndex = 12;
            // 
            // txtDireccionDocente
            // 
            this.txtDireccionDocente.Location = new System.Drawing.Point(91, 163);
            this.txtDireccionDocente.Name = "txtDireccionDocente";
            this.txtDireccionDocente.Size = new System.Drawing.Size(182, 24);
            this.txtDireccionDocente.TabIndex = 11;
            // 
            // txtAsignaturaDocente
            // 
            this.txtAsignaturaDocente.Location = new System.Drawing.Point(91, 131);
            this.txtAsignaturaDocente.Name = "txtAsignaturaDocente";
            this.txtAsignaturaDocente.Size = new System.Drawing.Size(117, 24);
            this.txtAsignaturaDocente.TabIndex = 10;
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(79, 101);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(165, 24);
            this.txtNombreDocente.TabIndex = 9;
            // 
            // txtCodigoDocente
            // 
            this.txtCodigoDocente.Location = new System.Drawing.Point(79, 67);
            this.txtCodigoDocente.Name = "txtCodigoDocente";
            this.txtCodigoDocente.Size = new System.Drawing.Size(100, 24);
            this.txtCodigoDocente.TabIndex = 8;
            // 
            // idDocente
            // 
            this.idDocente.AutoSize = true;
            this.idDocente.Location = new System.Drawing.Point(82, 36);
            this.idDocente.Name = "idDocente";
            this.idDocente.Size = new System.Drawing.Size(52, 18);
            this.idDocente.TabIndex = 7;
            this.idDocente.Text = "label7";
            // 
            // lblCodigoDocente
            // 
            this.lblCodigoDocente.AutoSize = true;
            this.lblCodigoDocente.Location = new System.Drawing.Point(6, 67);
            this.lblCodigoDocente.Name = "lblCodigoDocente";
            this.lblCodigoDocente.Size = new System.Drawing.Size(67, 18);
            this.lblCodigoDocente.TabIndex = 1;
            this.lblCodigoDocente.Text = "Código:";
            // 
            // lblIdDocente
            // 
            this.lblIdDocente.AutoSize = true;
            this.lblIdDocente.Location = new System.Drawing.Point(6, 36);
            this.lblIdDocente.Name = "lblIdDocente";
            this.lblIdDocente.Size = new System.Drawing.Size(29, 18);
            this.lblIdDocente.TabIndex = 6;
            this.lblIdDocente.Text = "ID:";
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Location = new System.Drawing.Point(0, 101);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(73, 18);
            this.lblNombreDocente.TabIndex = 2;
            this.lblNombreDocente.Text = "Nombre:";
            // 
            // lblTelefonoDocente
            // 
            this.lblTelefonoDocente.AutoSize = true;
            this.lblTelefonoDocente.Location = new System.Drawing.Point(6, 197);
            this.lblTelefonoDocente.Name = "lblTelefonoDocente";
            this.lblTelefonoDocente.Size = new System.Drawing.Size(79, 18);
            this.lblTelefonoDocente.TabIndex = 5;
            this.lblTelefonoDocente.Text = "Telefono:";
            // 
            // lblAsignaturaDocente
            // 
            this.lblAsignaturaDocente.AutoSize = true;
            this.lblAsignaturaDocente.Location = new System.Drawing.Point(0, 128);
            this.lblAsignaturaDocente.Name = "lblAsignaturaDocente";
            this.lblAsignaturaDocente.Size = new System.Drawing.Size(92, 18);
            this.lblAsignaturaDocente.TabIndex = 3;
            this.lblAsignaturaDocente.Text = "Asignatura:";
            // 
            // lblDireccionDocente
            // 
            this.lblDireccionDocente.AutoSize = true;
            this.lblDireccionDocente.Location = new System.Drawing.Point(0, 163);
            this.lblDireccionDocente.Name = "lblDireccionDocente";
            this.lblDireccionDocente.Size = new System.Drawing.Size(85, 18);
            this.lblDireccionDocente.TabIndex = 4;
            this.lblDireccionDocente.Text = "Dirección:";
            // 
            // grbNavegacionDocente
            // 
            this.grbNavegacionDocente.Controls.Add(this.lblRegistroDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnUltimoDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnSiguienteDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnAnteriorDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnPreimeroDocente);
            this.grbNavegacionDocente.Location = new System.Drawing.Point(12, 316);
            this.grbNavegacionDocente.Name = "grbNavegacionDocente";
            this.grbNavegacionDocente.Size = new System.Drawing.Size(390, 80);
            this.grbNavegacionDocente.TabIndex = 1;
            this.grbNavegacionDocente.TabStop = false;
            this.grbNavegacionDocente.Text = "Navegación";
            // 
            // lblRegistroDocente
            // 
            this.lblRegistroDocente.AutoSize = true;
            this.lblRegistroDocente.Location = new System.Drawing.Point(168, 47);
            this.lblRegistroDocente.Name = "lblRegistroDocente";
            this.lblRegistroDocente.Size = new System.Drawing.Size(53, 18);
            this.lblRegistroDocente.TabIndex = 4;
            this.lblRegistroDocente.Text = "x de n";
            // 
            // btnUltimoDocente
            // 
            this.btnUltimoDocente.Location = new System.Drawing.Point(304, 47);
            this.btnUltimoDocente.Name = "btnUltimoDocente";
            this.btnUltimoDocente.Size = new System.Drawing.Size(75, 23);
            this.btnUltimoDocente.TabIndex = 3;
            this.btnUltimoDocente.Text = ">|";
            this.btnUltimoDocente.UseVisualStyleBackColor = true;
            this.btnUltimoDocente.Click += new System.EventHandler(this.btnUltimoDocente_Click);
            // 
            // btnSiguienteDocente
            // 
            this.btnSiguienteDocente.Location = new System.Drawing.Point(227, 47);
            this.btnSiguienteDocente.Name = "btnSiguienteDocente";
            this.btnSiguienteDocente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteDocente.TabIndex = 2;
            this.btnSiguienteDocente.Text = ">";
            this.btnSiguienteDocente.UseVisualStyleBackColor = true;
            this.btnSiguienteDocente.Click += new System.EventHandler(this.btnSiguienteDocente_Click);
            // 
            // btnAnteriorDocente
            // 
            this.btnAnteriorDocente.Location = new System.Drawing.Point(87, 42);
            this.btnAnteriorDocente.Name = "btnAnteriorDocente";
            this.btnAnteriorDocente.Size = new System.Drawing.Size(75, 23);
            this.btnAnteriorDocente.TabIndex = 1;
            this.btnAnteriorDocente.Text = "<";
            this.btnAnteriorDocente.UseVisualStyleBackColor = true;
            this.btnAnteriorDocente.Click += new System.EventHandler(this.btnAnteriorDocente_Click);
            // 
            // btnPreimeroDocente
            // 
            this.btnPreimeroDocente.Location = new System.Drawing.Point(6, 42);
            this.btnPreimeroDocente.Name = "btnPreimeroDocente";
            this.btnPreimeroDocente.Size = new System.Drawing.Size(75, 23);
            this.btnPreimeroDocente.TabIndex = 0;
            this.btnPreimeroDocente.Text = "|<";
            this.btnPreimeroDocente.UseVisualStyleBackColor = true;
            this.btnPreimeroDocente.Click += new System.EventHandler(this.btnPreimeroDocente_Click);
            // 
            // grbEdiccionDocente
            // 
            this.grbEdiccionDocente.Controls.Add(this.btnEliminarDocente);
            this.grbEdiccionDocente.Controls.Add(this.btnModificarDocente);
            this.grbEdiccionDocente.Controls.Add(this.btnAgregarDocente);
            this.grbEdiccionDocente.Location = new System.Drawing.Point(408, 316);
            this.grbEdiccionDocente.Name = "grbEdiccionDocente";
            this.grbEdiccionDocente.Size = new System.Drawing.Size(275, 80);
            this.grbEdiccionDocente.TabIndex = 2;
            this.grbEdiccionDocente.TabStop = false;
            this.grbEdiccionDocente.Text = "Edición";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Location = new System.Drawing.Point(193, 42);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDocente.TabIndex = 2;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Location = new System.Drawing.Point(87, 42);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(100, 23);
            this.btnModificarDocente.TabIndex = 1;
            this.btnModificarDocente.Text = "Modificar";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            this.btnModificarDocente.Click += new System.EventHandler(this.btnModificarDocente_Click);
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Location = new System.Drawing.Point(6, 42);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDocente.TabIndex = 0;
            this.btnAgregarDocente.Text = "Nuevo";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click);
            // 
            // grbBusquedaDocente
            // 
            this.grbBusquedaDocente.Controls.Add(this.grdDocentes);
            this.grbBusquedaDocente.Controls.Add(this.txtBuscarDocente);
            this.grbBusquedaDocente.Location = new System.Drawing.Point(295, 17);
            this.grbBusquedaDocente.Name = "grbBusquedaDocente";
            this.grbBusquedaDocente.Size = new System.Drawing.Size(617, 231);
            this.grbBusquedaDocente.TabIndex = 3;
            this.grbBusquedaDocente.TabStop = false;
            this.grbBusquedaDocente.Text = "Busqueda Docente";
            // 
            // grdDocentes
            // 
            this.grdDocentes.AllowUserToAddRows = false;
            this.grdDocentes.AllowUserToDeleteRows = false;
            this.grdDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Nombre,
            this.Asignatura,
            this.Direccion,
            this.Telefono});
            this.grdDocentes.Location = new System.Drawing.Point(6, 55);
            this.grdDocentes.Name = "grdDocentes";
            this.grdDocentes.ReadOnly = true;
            this.grdDocentes.Size = new System.Drawing.Size(605, 150);
            this.grdDocentes.TabIndex = 10;
            // 
            // txtBuscarDocente
            // 
            this.txtBuscarDocente.Location = new System.Drawing.Point(6, 25);
            this.txtBuscarDocente.Name = "txtBuscarDocente";
            this.txtBuscarDocente.Size = new System.Drawing.Size(356, 24);
            this.txtBuscarDocente.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idDocente";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Asignatura
            // 
            this.Asignatura.DataPropertyName = "asignatura";
            this.Asignatura.HeaderText = "Asignatura";
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 418);
            this.Controls.Add(this.grbBusquedaDocente);
            this.Controls.Add(this.grbEdiccionDocente);
            this.Controls.Add(this.grbNavegacionDocente);
            this.Controls.Add(this.grbDatosDocente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "BasedeDatosMaestros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosDocente.ResumeLayout(false);
            this.grbDatosDocente.PerformLayout();
            this.grbNavegacionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.PerformLayout();
            this.grbEdiccionDocente.ResumeLayout(false);
            this.grbBusquedaDocente.ResumeLayout(false);
            this.grbBusquedaDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbDatosDocente;
        private System.Windows.Forms.Label lblCodigoDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.Label lblAsignaturaDocente;
        private System.Windows.Forms.Label lblDireccionDocente;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lblTelefonoDocente;
        private System.Windows.Forms.Label lblIdDocente;
        private System.Windows.Forms.Label idDocente;
        private System.Windows.Forms.TextBox txtTelefonoDocente;
        private System.Windows.Forms.TextBox txtDireccionDocente;
        private System.Windows.Forms.TextBox txtAsignaturaDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.TextBox txtCodigoDocente;
        private System.Windows.Forms.GroupBox grbNavegacionDocente;
        private System.Windows.Forms.Button btnUltimoDocente;
        private System.Windows.Forms.Button btnSiguienteDocente;
        private System.Windows.Forms.Button btnAnteriorDocente;
        private System.Windows.Forms.Button btnPreimeroDocente;
        private System.Windows.Forms.Label lblRegistroDocente;
        private System.Windows.Forms.GroupBox grbEdiccionDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.GroupBox grbBusquedaDocente;
        private System.Windows.Forms.DataGridView grdDocentes;
        private System.Windows.Forms.TextBox txtBuscarDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}

