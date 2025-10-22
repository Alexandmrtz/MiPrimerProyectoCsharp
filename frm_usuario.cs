using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestionDocentes
{
    public class frm_usuario : Form
    {
        private Conexion_base_datos conexion;
        private BindingSource bs = new BindingSource();

        // Controles
        private TextBox txtUsuario, txtClave, txtConfClave, txtNombre, txtDireccion, txtTelefono;
        private Button btnAgregar, btnModificar, btnEliminar, btnGuardar, btnCancelar;
        private Button btnPrimero, btnAnterior, btnSiguiente, btnUltimo;

        private Panel panelCentral;
        private TableLayoutPanel gridCampos;
        private FlowLayoutPanel panelBotonesAccion;
        private FlowLayoutPanel panelNavegacion;

        public frm_usuario(Conexion_base_datos con)
        {
            conexion = con;
            InitializeComponent();
            InicializarBinding();
        }

        private void InitializeComponent()
        {
    
            this.Text = "Registro de Usuarios - frm_usuario";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(620, 560);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.BackColor = Color.WhiteSmoke;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            
            panelCentral = new Panel()
            {
                Width = 780,
                Height = 520,
                BackColor = Color.Transparent
            };
            this.Controls.Add(panelCentral);

        
            gridCampos = new TableLayoutPanel()
            {
                ColumnCount = 2,
                RowCount = 6,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(8),
            };
            gridCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F)); // etiquetas
            gridCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));  // controles

            var lblU = new Label() { Text = "Usuario:", Anchor = AnchorStyles.Right, AutoSize = true };
            txtUsuario = new TextBox() { Anchor = AnchorStyles.Left | AnchorStyles.Right, Width = 300, Font = new Font("Segoe UI", 10) };

            var lblC = new Label() { Text = "Clave:", Anchor = AnchorStyles.Right, AutoSize = true };
            txtClave = new TextBox() { Anchor = AnchorStyles.Left | AnchorStyles.Right, Width = 300, Font = new Font("Segoe UI", 10), UseSystemPasswordChar = true };

            var lblCC = new Label() { Text = "Confirmar clave:", Anchor = AnchorStyles.Right, AutoSize = true };
            txtConfClave = new TextBox() { Anchor = AnchorStyles.Left | AnchorStyles.Right, Width = 300, Font = new Font("Segoe UI", 10), UseSystemPasswordChar = true };

            var lblN = new Label() { Text = "Nombre:", Anchor = AnchorStyles.Right, AutoSize = true };
            txtNombre = new TextBox() { Anchor = AnchorStyles.Left | AnchorStyles.Right, Width = 300, Font = new Font("Segoe UI", 10) };

            var lblD = new Label() { Text = "Dirección:", Anchor = AnchorStyles.Right, AutoSize = true };
            txtDireccion = new TextBox() { Anchor = AnchorStyles.Left | AnchorStyles.Right, Width = 300, Font = new Font("Segoe UI", 10) };

            var lblT = new Label() { Text = "Teléfono:", Anchor = AnchorStyles.Right, AutoSize = true };
            txtTelefono = new TextBox() { Anchor = AnchorStyles.Left, Width = 140, Font = new Font("Segoe UI", 10) };

            // Añadir filas al grid (fila por fila)
            gridCampos.Controls.Add(lblU, 0, 0);
            gridCampos.Controls.Add(txtUsuario, 1, 0);
            gridCampos.Controls.Add(lblC, 0, 1);
            gridCampos.Controls.Add(txtClave, 1, 1);
            gridCampos.Controls.Add(lblCC, 0, 2);
            gridCampos.Controls.Add(txtConfClave, 1, 2);
            gridCampos.Controls.Add(lblN, 0, 3);
            gridCampos.Controls.Add(txtNombre, 1, 3);
            gridCampos.Controls.Add(lblD, 0, 4);
            gridCampos.Controls.Add(txtDireccion, 1, 4);
            gridCampos.Controls.Add(lblT, 0, 5);
            gridCampos.Controls.Add(txtTelefono, 1, 5);

            // Espaciado limpio: fijar alturas de fila
            for (int i = 0; i < gridCampos.RowCount; i++)
                gridCampos.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Panel de botones de acción (Agregar, Modificar, Eliminar, Guardar, Cancelar)
            panelBotonesAccion = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                WrapContents = false,
                Padding = new Padding(0),
                Margin = new Padding(0)
            };

            btnAgregar = CrearBotonAccion("Agregar");
            btnModificar = CrearBotonAccion("Modificar");
            btnEliminar = CrearBotonAccion("Eliminar");
            btnGuardar = CrearBotonAccion("Guardar");
            btnCancelar = CrearBotonAccion("Cancelar");

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            panelBotonesAccion.Controls.AddRange(new Control[] { btnAgregar, btnModificar, btnEliminar, btnGuardar, btnCancelar });

            // Panel de navegación (|<  <  >  >|)
            panelNavegacion = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                WrapContents = false
            };
            btnPrimero = CrearBotonNavegacion("|<");
            btnAnterior = CrearBotonNavegacion("<");
            btnSiguiente = CrearBotonNavegacion(">");
            btnUltimo = CrearBotonNavegacion(">|");

            panelNavegacion.Controls.AddRange(new Control[] { btnPrimero, btnAnterior, btnSiguiente, btnUltimo });

            // Eventos básicos
            btnAgregar.Click += BtnAgregar_Click;
            btnModificar.Click += BtnModificar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;

            btnPrimero.Click += (s, e) => MovePosition(0);
            btnAnterior.Click += (s, e) => MovePosition(bs.Position - 1);
            btnSiguiente.Click += (s, e) => MovePosition(bs.Position + 1);
            btnUltimo.Click += (s, e) => MovePosition(bs.Count - 1);

            // Layout final: stack vertical dentro del panel central
            var stack = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                WrapContents = false,
                Width = panelCentral.Width,
                Padding = new Padding(8)
            };

            // Título minimalista centrado
            var lblTitulo = new Label()
            {
                Text = "Registro de Usuarios",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 30, 30),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0, 0, 0, 8)
            };
            lblTitulo.Left = (stack.Width - lblTitulo.Width) / 2;

            // Centrar el grid en el stack
            var contGrid = new Panel() { AutoSize = true };
            contGrid.Controls.Add(gridCampos);
            gridCampos.Location = new Point((contGrid.Width - gridCampos.PreferredSize.Width) / 2, 0);

            // Añadir controles al stack
            stack.Controls.Add(lblTitulo);
            stack.Controls.Add(contGrid);
            stack.Controls.Add(panelBotonesAccion);
            stack.Controls.Add(panelNavegacion);

            // Agregar stack al panel central
            panelCentral.Controls.Add(stack);

            // Posicionamiento dinámico al cargar y redimensionar
            this.Load += (s, e) => Reposicionar();
            this.Resize += (s, e) => Reposicionar();
        }

        private Button CrearBotonAccion(string texto)
        {
            return new Button()
            {
                Text = texto,
                Width = 90,
                Height = 30,
                BackColor = Color.White,
                FlatStyle = FlatStyle.System,
                Margin = new Padding(6, 8, 6, 8)
            };
        }

        private Button CrearBotonNavegacion(string texto)
        {
            return new Button()
            {
                Text = texto,
                Width = 44,
                Height = 28,
                BackColor = Color.White,
                FlatStyle = FlatStyle.System,
                Margin = new Padding(6, 6, 6, 6)
            };
        }

        private void Reposicionar()
        {
            // Centrar panelCentral en el formulario
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
            panelCentral.Top = (this.ClientSize.Height - panelCentral.Height) / 2;

            // Recalcular posiciones internas si hace falta (alinear grid)
            foreach (Control c in panelCentral.Controls)
            {
                // Si es FlowLayoutPanel (stack), centrar su contenido horizontalmente
                if (c is FlowLayoutPanel stack)
                {
                    stack.Left = (panelCentral.Width - stack.PreferredSize.Width) / 2;
                }
            }
        }

        private void InicializarBinding()
        {
            conexion.crearDs();
            bs.DataSource = conexion.ds.Tables["usuarios"];
            // Bindings
            txtUsuario.DataBindings.Add("Text", bs, "usuario", true, DataSourceUpdateMode.OnPropertyChanged);
            txtClave.DataBindings.Add("Text", bs, "clave", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNombre.DataBindings.Add("Text", bs, "nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDireccion.DataBindings.Add("Text", bs, "direccion", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefono.DataBindings.Add("Text", bs, "telefono", true, DataSourceUpdateMode.OnPropertyChanged);

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void MovePosition(int pos)
        {
            if (pos < 0) pos = 0;
            if (pos >= bs.Count) pos = bs.Count - 1;
            bs.Position = pos;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (bs.Current != null && MessageBox.Show("¿Eliminar registro actual?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bs.RemoveCurrent();
                conexion.mantenimiento_usuarios();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;
            string conf = txtConfClave.Text;

            if (usuario.Length < 6 || usuario.Length > 16)
            {
                MessageBox.Show("El campo 'usuario' debe tener entre 6 y 16 caracteres.", "Validación");
                return;
            }

            if (clave != conf)
            {
                MessageBox.Show("La clave y su confirmación no coinciden.", "Validación");
                return;
            }

            if (!conexion.claveValida(clave))
            {
                MessageBox.Show("La clave debe contener letras y números.", "Validación");
                return;
            }

            bs.EndEdit();
            conexion.mantenimiento_usuarios();
            MessageBox.Show("Guardado correctamente (simulado).", "Información");
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
