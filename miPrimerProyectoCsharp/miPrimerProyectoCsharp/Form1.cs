using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion objConexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";
        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objConexion.obtenerDatosDocente();
            objDt = objDs.Tables["docentes"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idDocente"] };

            grdDocentes.DataSource = objDt.DefaultView;
            mostrarDatos();

        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idDocente.Text = objDt.Rows[posicion]["idDocente"].ToString();
                txtCodigoDocente.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreDocente.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtAsignaturaDocente.Text = objDt.Rows[posicion]["asignatura"].ToString();
                txtDireccionDocente.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoDocente.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblRegistroDocente.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++; //Posicion = Posicion + 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoDocente_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPreimeroDocente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosDocente.Enabled = estado;
            grbNavegacionDocente.Enabled = !estado;
            btnEliminarDocente.Enabled = !estado;
        }

        private void limpiarControles()
        {
            idDocente.Text = "";
            txtCodigoDocente.Text = "";
            txtNombreDocente.Text = "";
            txtAsignaturaDocente.Text = "";
            txtDireccionDocente.Text = "";
            txtTelefonoDocente.Text = "";
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            if (btnAgregarDocente.Text == "Nuevo")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();

            }
            else //Guardar
            {
                String[] docentes =
                {
                    idDocente.Text, txtCodigoDocente.Text, txtNombreDocente.Text, txtAsignaturaDocente.Text, txtDireccionDocente.Text, txtTelefonoDocente.Text
                };

                String respuesta = objConexion.administrarDatosDocentes(docentes, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar docentes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarDocente.Text = "Nuevo";
                    btnModificarDocente.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            if (btnModificarDocente.Text == "Modificar")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";
            }
            else //Guardar
            {
                mostrarDatos();
                estadoControles(false);
                btnAgregarDocente.Text = "Nuevo";
                btnModificarDocente.Text = "Modificar";
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elIminar a " + txtNombreDocente.Text, "Eliminando docentes",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosDocentes(
                    new String[] { idDocente.Text, "", "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar docente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }
        private void txtBuscarDocente_TextChanged(object sender, EventArgs e)
        {
            filtrarDatos(txtBuscarDocente.Text);

            if (grdDocentes.Rows.Count > 0)
            {
                seleccionarDocente();
            }
        }
        private void filtrarDatos(String valor)
        {
            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '%" + valor + "%'";
            grdDocentes.DataSource = objDv;
        }

        private void seleccionarDocente()
        {
            posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdDocentes.CurrentRow.Cells["id"].Value));
            mostrarDatos();
        }
         private void grdDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocente();
        }
    }
}

      

    
