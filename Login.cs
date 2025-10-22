using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionDocentes
{
    public class Login : Form
    {
        private TextBox txtUsuario, txtClave;
        private Button btnEntrar;
        private Label lblTitulo, lblU, lblC, lblStatus;
        private Conexion_base_datos conexion;
        private Panel panelCentral;
        private TableLayoutPanel camposLayout;

        public Login()
        {
            conexion = new Conexion_base_datos();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Form
            this.Text = "Login - Sistema de Gestión Docentes";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(850, 720);
            this.BackColor = Color.FromArgb(240, 244, 249);
            this.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Panel central (tamaño fijo, se centra dinámicamente)
            panelCentral = new Panel()
            {
                Width = 520,
                Height = 360,
                BackColor = Color.Transparent
            };
            this.Controls.Add(panelCentral);

            // Título (se posiciona después, en Load)
            lblTitulo = new Label()
            {
                Text = "INICIO DE SESIÓN",
                Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(0, 51, 102),
                AutoSize = true
            };
            panelCentral.Controls.Add(lblTitulo);

            // Layout para campos (2 columnas: etiqueta / control)
            camposLayout = new TableLayoutPanel()
            {
                ColumnCount = 2,
                RowCount = 3,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                Margin = new Padding(0),
                Padding = new Padding(0)
            };
            camposLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            camposLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));

            // Labels y TextBoxes
            lblU = new Label() { Text = "Usuario:", Anchor = AnchorStyles.Right, AutoSize = true };
            txtUsuario = new TextBox() { Width = 280, Anchor = AnchorStyles.Left, Font = new Font("Segoe UI", 12) };

            lblC = new Label() { Text = "Clave:", Anchor = AnchorStyles.Right, AutoSize = true };
            txtClave = new TextBox() { Width = 280, Anchor = AnchorStyles.Left, Font = new Font("Segoe UI", 12), UseSystemPasswordChar = true };

            // Añadir filas (dejamos la primera fila vacía para separar del título)
            camposLayout.Controls.Add(lblU, 0, 1);
            camposLayout.Controls.Add(txtUsuario, 1, 1);
            camposLayout.Controls.Add(lblC, 0, 2);
            camposLayout.Controls.Add(txtClave, 1, 2);

            panelCentral.Controls.Add(camposLayout);

            // Botón Entrar
            btnEntrar = new Button()
            {
                Width = 180,
                Height = 48,
                Text = "Entrar",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(0, 102, 204),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.Click += BtnEntrar_Click;
            panelCentral.Controls.Add(btnEntrar);

            // Label de estado
            lblStatus = new Label()
            {
                Width = panelCentral.Width - 40,
                Height = 30,
                ForeColor = Color.Red,
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false
            };
            panelCentral.Controls.Add(lblStatus);

            // Posicionamiento dinámico al cargar y al redimensionar
            this.Load += LayoutControls;
            this.Resize += LayoutControls;
        }

        private void LayoutControls(object sender, EventArgs e)
        {
            // Centrar panelCentral dentro del form
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
            panelCentral.Top = (this.ClientSize.Height - panelCentral.Height) / 2;

            // Posicionar el título arriba, centrado dentro del panel
            lblTitulo.Left = (panelCentral.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 10;

            // Posicionar el layout de campos debajo del título
            camposLayout.Left = (panelCentral.Width - camposLayout.PreferredSize.Width) / 2;
            camposLayout.Top = lblTitulo.Bottom + 20;

            // Botón centrado debajo de los campos
            btnEntrar.Left = (panelCentral.Width - btnEntrar.Width) / 2;
            btnEntrar.Top = camposLayout.Bottom + 20;

            // lblStatus debajo del botón
            lblStatus.Left = (panelCentral.Width - lblStatus.Width) / 2;
            lblStatus.Top = btnEntrar.Bottom + 16;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string nombre;
            lblStatus.Text = ""; // limpiar estado antes de validar
            if (conexion.validarUsuario(txtUsuario.Text.Trim(), txtClave.Text, out nombre))
            {
                MessageBox.Show($"Bienvenido {nombre}", "Acceso concedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var frm = new frm_usuario(conexion);
                this.Hide();
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
            }
            else
            {
                lblStatus.Text = "Usuario o clave incorrectos.";
            }
        }
    }
}
